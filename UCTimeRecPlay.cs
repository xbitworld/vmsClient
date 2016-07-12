using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nvr.Driver.GenericStream;
using System.Runtime.InteropServices;

namespace VmsClientDemo
{
    public partial class UCTimeRecPlay : UserControl
    {
        public UCTimeRecPlay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gav frame head
        /// </summary>
        private int _HV_FRAME_HEAD_Len = 0;
        private bool _pause = false;//暂停
        private global::Nvr.GenericStream.StreamPlayer _mediaPlayer = null;//播放器
        private IntPtr _videoHandle = IntPtr.Zero;//显示窗口
        private DateTime _lastTime = DateTime.MinValue;
        private Spnet.Data.Model.Camera _modelCam = null;


        /// <summary>
        /// 读取摄像机实体
        /// </summary>
        public Spnet.Data.Model.Camera ModelCam
        {
            get { return _modelCam; }
            set
            {
                _modelCam = value;
                this.lblCamName.Text = _modelCam.Name;
            }
        }

        private bool _threadFlag = false ;

        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            _videoHandle = this.panelVideo.Handle;
            btnStopPlay.Enabled =true;
            btnStartPlay.Enabled = false;
            //取时间点的前后30分钟的录像出来
            DateTime playTime = this.dtpTime.Value;
            DateTime beginTime = playTime.AddMinutes(-30);
            DateTime endTime = playTime.AddMinutes(30);

            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                var rmtNvr = Spnet.Core.Service.RemoteObjectFactory.CreateNvrHost();
                try
                {
                    var recList = rmtNvr.GetNvrRecordFileListByDateTimeSeg(_modelCam.ID, beginTime, endTime);
                    Nvr.Data.Model.RecordFile playRecModel = null;
                    foreach (var modelRec in recList)
                    {
                        //检查播放的时间是否在这个位置
                        if (playTime >= modelRec.StartTime && playTime <= modelRec.EndTime)
                        {
                            playRecModel = modelRec;
                            break;
                        }
                    }
                    if (playRecModel == null) //表示没有定位到时间，可能是录像时断电，造成该时间的录像文件没有结束时间,这时要找到最近的开始时间的录像，从这个录像里定位到指定的时间
                    {
                        int min_totalMinutes = 10000;

                        foreach (var modelRec in recList)
                        {
                            var ts = playTime - modelRec.StartTime;
                            if (ts.TotalMinutes < min_totalMinutes)
                            {
                                min_totalMinutes = (int)ts.TotalMinutes;
                                playRecModel = modelRec;
                            }
                        }
                    }
                    if (playRecModel == null) return;
                    //开始播放
                    _threadFlag = true;
                    int readframeNum = 25;
                    int pos = 0;
                    pos = (int)rmtNvr.GetDownloadFilePosByDateTime(_modelCam.NvrId, playRecModel.FullFileName, playTime);
                    while (_threadFlag)
                    {
                        List<byte[]> frmateList = rmtNvr.GetDownloaFileBlockBytesByPos(_modelCam.NvrId, playRecModel.FullFileName, pos, readframeNum);
                        if (frmateList == null || frmateList.Count == 0) //表示当前文件取完了转到下一个文件
                        {
                            pos = 0;
                            break;
                        }
                        ParseStream(frmateList, out _lastTime);
                        foreach (var itemBytes in frmateList)
                        {
                            pos += itemBytes.Length;
                        }
                    }
                }
                catch (Exception ex)
                {
                    //出错了，网络段开，或服务器内部方法调用异常
                }
                finally
                {
                    rmtNvr = null;
                }
                if (_mediaPlayer != null)
                {
                    _mediaPlayer.Close();
                    _mediaPlayer = null;
                }
                this.Invoke((Action)delegate
                {
                    btnStartPlay.Enabled = true;
                    btnStopPlay.Enabled = false;
                    this.panelVideo.Invalidate();
                });
            }));
        }

        private void ParseStream(List<byte[]> frmateList, out DateTime lastTime)
        {
            if (_HV_FRAME_HEAD_Len == 0) _HV_FRAME_HEAD_Len= Marshal.SizeOf(typeof(AvHeader));

            DateTime dt = DateTime.MinValue;
            foreach (var bytes in frmateList)
            {
                byte[] headBytes = new byte[_HV_FRAME_HEAD_Len];
                Array.Copy(bytes, headBytes, _HV_FRAME_HEAD_Len);
                var headerSturct = (AvHeader)global::Nvr.Common.Helpers.SturctHelper.BytesToStuct(headBytes, typeof(AvHeader));

                byte[] dataBytes = new byte[headerSturct.DataLen];
                Array.Copy(bytes, _HV_FRAME_HEAD_Len, dataBytes, 0, headerSturct.DataLen);
                AvPacket avPacket = new AvPacket();
                avPacket.Header = headerSturct;
                avPacket.Data = dataBytes;
                dt = global::Nvr.Common.Helpers.TimerHelper.ConvertIntToDateTime(headerSturct.SrvTime);
                InputAvPacket(avPacket);
            }
            lastTime = dt;
        }

        private bool InputAvPacket(AvPacket avPacket)
        {
            if (_threadFlag == false) return false;

            while (_pause)
            {
                System.Threading.Thread.Sleep(20);
            }

            if (_mediaPlayer == null)
            {
                _mediaPlayer = new global::Nvr.GenericStream.StreamPlayer(_videoHandle);
            }
            if (_mediaPlayer.get_IsPlaying() == false)
            {
                if (global::Nvr.GenericStream.StreamHelper.IsNeedOpenStreamByPara(avPacket.Header.StreamOwner))
                {
                    if (avPacket.Header.DataType == GenericStreamType.Para)
                    {
                        bool ok = _mediaPlayer.OpenStream(avPacket.Header.StreamOwner, global::Nvr.GenericStream.PlayMode.GavFileStream, avPacket.Data);
                    }
                }
                else
                {
                    _mediaPlayer.OpenStream(avPacket.Header.StreamOwner, global::Nvr.GenericStream.PlayMode.GavFileStream, null);
                }
            }
            else
            {
                bool ok = _mediaPlayer.InputAvPacket(avPacket);
                if (ok)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            if (_threadFlag==true )
            {
                _threadFlag = true;
                btnStopPlay.Enabled = false;
            }

        }

        private void UCTimeRecPlay_Load(object sender, EventArgs e)
        {
            this.dtpTime.Value=DateTime.Now.AddMinutes(-40);
        }
    }
}
