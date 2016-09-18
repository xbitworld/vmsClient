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
    public partial class UCRec : UserControl
    {

        private string _nvrRecFileName = "";

        private int _nvrId = -1;

        private bool _threadFlag = false;

        private int _HV_FRAME_HEAD_Len = 0;

        private global::Nvr.GenericStream.StreamPlayer _mediaPlayer = null;//播放器

        private int _readframeNum = 10; //每次读多少个Frame

        private bool _seeking = false;//seeking

        private DateTime _lastTime = DateTime.MinValue;

        private bool _pause = false;//暂停

        private DateTime _seekTime = DateTime.MinValue;//转到的时间点

        private DateTime _startTime = DateTime.MinValue;

        private DateTime _stopTime = DateTime.MinValue;

        private IntPtr _videoHandle = IntPtr.Zero;

        private bool _seekBar_MouseDown = false;

        private string _localFileName = "";


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

        private Nvr.VideoLib.ObjectModel.VideoRecordItem _selRecItem = null;

        public UCRec()
        {
            InitializeComponent();
            dtpTime1.Value = DateTime.Now.AddHours(-2);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            btnQuery.Enabled = false;
            DateTime day = this.dtpDay.Value;
            this.lstRecords.Items.Clear();
            DateTime beinDt=new DateTime(dtpDay.Value.Year,dtpDay.Value.Month,dtpDay.Value.Day,dtpTime1.Value.Hour,dtpTime1.Value.Minute,dtpTime1.Value.Second);
            DateTime endDt=new DateTime(dtpDay.Value.Year,dtpDay.Value.Month,dtpDay.Value.Day,dtpTime2.Value.Hour,dtpTime2.Value.Minute,dtpTime2.Value.Second);
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
                {
                    var rmtNvr = Spnet.Core.Service.RemoteObjectFactory.CreateNvrHost();
                    try
                    {
                        //var list = rmtNvr.GetNvrRecordFileListByDateTime(_modelCam.ID, day);
                        var list = rmtNvr.GetNvrRecordFileListByDateTimeSeg(_modelCam.ID, beinDt, endDt);
                        foreach (var model in list)
                        {
                            Nvr.VideoLib.ObjectModel.VideoRecordItem vrItem = new Nvr.VideoLib.ObjectModel.VideoRecordItem(model, Nvr.Common.AvOperType.OpenRecFileByNvr);
                            model.Ext = "Nvr";//表示来源

                            var ts = model.EndTime - model.StartTime;
                            if (vrItem.RecordFile.CameraId != _modelCam.ID)
                            {
                                vrItem.RecordFile.CameraId = _modelCam.ID;
                            }
                            vrItem.RecordFile.SpnetCameraId = _modelCam.ID;
                            this.Invoke(new System.Threading.ThreadStart(delegate()
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = System.IO.Path.GetFileName(model.FileName);
                                item.SubItems.Add(model.StartTime.ToShortTimeString() + "---" + model.EndTime.ToShortTimeString());
                                item.Tag = vrItem;
                                this.lstRecords.Items.Add(item);
                            }));
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
                    this.Invoke(new System.Threading.ThreadStart(delegate()
                          {
                              btnQuery.Enabled = true;
                          }));
                }));
        }

        private void lstRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstRecords.SelectedItems.Count <= 0) return;

            _selRecItem = this.lstRecords.SelectedItems[0].Tag as Nvr.VideoLib.ObjectModel.VideoRecordItem;
            this.lblSelRec.Text = _selRecItem.RecordFile.FileName;

        }

        private void btnPlayRec_Click(object sender, EventArgs e)
        {
            if (_selRecItem == null) return;

            if (btnPlayRec.Text == "播放录像")
            {
                _videoHandle = this.panelVideo.Handle;
                this._seekBar_video_playback.Minimum = 0;
                var ts=_selRecItem.RecordFile.EndTime-_selRecItem.RecordFile.StartTime;
                this._seekBar_video_playback.Maximum =(int)ts.TotalSeconds;
                Play(_modelCam.NvrId, _selRecItem.RecordFile.FileName, _selRecItem.RecordFile.StartTime, _selRecItem.RecordFile.EndTime);
                btnPlayRec.Text = "停止播放";
            }
            else
            {
                Stop();
                btnPlayRec.Text = "播放录像";
            }
        }

        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="nvrId"></param>
        /// <param name="filename"></param>
        /// <param name="startTime"></param>
        /// <param name="stopTime"></param>
        public void Play(int nvrId, string filename, DateTime startTime, DateTime stopTime)
        {
            _nvrId = nvrId;
            _nvrRecFileName = filename;
            _startTime = startTime;
            _stopTime = stopTime;
            _threadFlag = true;
            _readframeNum = 10;
            var ts = _stopTime - _startTime;
            _seekBar_video_playback.Minimum = 0;
            _seekBar_video_playback.Maximum = (int)ts.TotalSeconds;
            new System.Threading.Thread(new System.Threading.ThreadStart(ProcThread)).Start();
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="localFilename"></param>
        public void OpenFile(string localFilename)
        {
            if (_mediaPlayer == null)
            {
                _mediaPlayer = new global::Nvr.GenericStream.StreamPlayer(_videoHandle);
            }
            _localFileName = "";
            _mediaPlayer.OpenFile(localFilename);
        }


        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            _threadFlag = false;
            if (_localFileName != "")
            {
                _mediaPlayer.Close();
                _mediaPlayer = null;
                this.Invoke(new System.Threading.ThreadStart(delegate
                {
                    this.panelVideo.Invalidate();
                }));
            }
        }


        private void ProcThread()
        {
            _HV_FRAME_HEAD_Len = Marshal.SizeOf(typeof(AvHeader));
            var ts = _stopTime - _startTime;
            int pos = 0;
            var rmtNvr = Spnet.Core.Service.RemoteObjectFactory.CreateNvrHost();
            while (_threadFlag)
            {
                if (_seeking && _seekTime != DateTime.MinValue)
                {
                    pos = (int)rmtNvr.GetDownloadFilePosByDateTime(_nvrId, _nvrRecFileName, _seekTime);
                    _seekTime = DateTime.MinValue;
                    _seeking = false;
                }

                List<byte[]> frmateList = rmtNvr.GetDownloaFileBlockBytesByPos(_nvrId, _nvrRecFileName, pos, _readframeNum);
                if (frmateList == null || frmateList.Count == 0) //表示当前文件取完了转到下一个文件
                {
                    pos = 0;
                    break;
                }
                if (_threadFlag)
                {
                    ParseStream(frmateList, out _lastTime);

                    foreach (var itemBytes in frmateList)
                    {
                        pos += itemBytes.Length;
                    }

                    ts = _lastTime - _startTime;
                    if (!_seeking && !_seekBar_MouseDown)
                    {
                        this.Invoke(new System.Threading.ThreadStart(delegate
                        {
                            if (ts.TotalSeconds > _seekBar_video_playback.Minimum && ts.TotalSeconds < _seekBar_video_playback.Maximum)
                            {
                                _seekBar_video_playback.Value = (int)ts.TotalSeconds;
                            }
                            this.lblPlayTime.Text = _lastTime.ToString();
                        }));
                    }
                }
                else
                {
                    break;
                }
            }
            if (_mediaPlayer != null)
            {
                _mediaPlayer.Close();
                _mediaPlayer = null;
            }
            this.Invoke(new System.Threading.ThreadStart(delegate
            {
                this.panelVideo.Invalidate();
            }));
        }

        private void ParseStream(List<byte[]> frmateList, out DateTime lastTime)
        {
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


        private void _seekBar_video_playback_MouseUp(object sender, MouseEventArgs e)
        {
            _seeking = true;
            _seekTime = _startTime.AddSeconds(_seekBar_video_playback.Value);
            _seekBar_MouseDown = false;
        }

        private void _seekBar_video_playback_MouseDown(object sender, MouseEventArgs e)
        {
            _seekBar_MouseDown = true;
        }
      

        private void btnFast_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;
            _mediaPlayer.NextFrame();
            _mediaPlayer.NormalPlay();
            _mediaPlayer.Fast();
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;
            _mediaPlayer.NextFrame();
            _mediaPlayer.NormalPlay();
            _mediaPlayer.Slow();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;
            _mediaPlayer.NextFrame();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;
            _mediaPlayer.Pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer == null) return;
            _mediaPlayer.NextFrame();
            _mediaPlayer.NormalPlay();
        }

        private void _seekBar_video_playback_ValueChanged(object sender, EventArgs e)
        {
            var dt = _startTime.AddSeconds(_seekBar_video_playback.Value);
            this.lblPlayTime.Text = dt.ToString();
        }

        private void CapturePIC(object sender, EventArgs e)
        {
            if (_mediaPlayer != null)
            {
                string filePath = Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                bool flag = _mediaPlayer.CaputrePic(filePath);
                if (flag)
                {
                    MessageBox.Show(this, "保存在" + filePath);
                }
            }
        }

        public string getPlayTimeStr()
        {
            return this.lblPlayTime.Text;
        }

        public bool SaveRecPicToPath(out string picPath)
        {
            if (_mediaPlayer != null)
            {
                string filePath = Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                picPath = filePath;
                bool flag = _mediaPlayer.CaputrePic(filePath);
                return flag;
            }
            else
            {
                picPath = "";
                return false;
            }
        }

        private void PlayRec(object sender, EventArgs e)
        {
            if (_selRecItem == null) return;

            if (btnPlayRec.Text == "停止播放")
            {
                Stop();
            }
            _videoHandle = this.panelVideo.Handle;
            this._seekBar_video_playback.Minimum = 0;
            var ts=_selRecItem.RecordFile.EndTime-_selRecItem.RecordFile.StartTime;
            this._seekBar_video_playback.Maximum =(int)ts.TotalSeconds;
            Play(_modelCam.NvrId, _selRecItem.RecordFile.FileName, _selRecItem.RecordFile.StartTime, _selRecItem.RecordFile.EndTime);
            btnPlayRec.Text = "停止播放";
        }
    }
}
