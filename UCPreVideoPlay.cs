using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nvr.Driver.GenericStream;

namespace VmsClientDemo
{
    public partial class UCPreVideoPlay : UserControl
    {
        private Spnet.Data.Model.Camera _modelCam = null;

        private int _HV_FRAME_HEAD_Len = 0;

        private bool _threadFlag = false;

        private bool _pause = false;

        private Nvr.GenericStream.StreamPlayer _player = null;

        private IntPtr _videoHandle = IntPtr.Zero;

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


        private List<byte[]> _preVideoSortedList;//获取的预录像媒体数据
        

        public UCPreVideoPlay()
        {
            InitializeComponent();
            _videoHandle = this.panel1.Handle;
        }
    


        private void btnPlayPreVideo_Click(object sender, EventArgs e)
        {
            if (btnPlayPreVideo.Text == "播放预录视频")
            {
                this.btnRePlay.Enabled = false;

                StartPlay();
                btnPlayPreVideo.Text = "停止播放";
            }
            else
            {
                StopPlay();
                btnPlayPreVideo.Text = "播放预录视频";
                this.panel1.Invalidate();
            }
        }


        ///// <summary>
        ///// 输入播放
        ///// </summary>
        ///// <param name="blockBytes"></param>
        //private void ParseStream(List<byte[]> frmateList, out DateTime lastTime)
        //{
           
            
        //    DateTime dt = DateTime.MinValue;
        //    foreach (var bytes in frmateList)
        //    {
        //        byte[] headBytes = new byte[_HV_FRAME_HEAD_Len];
        //        Array.Copy(bytes, headBytes, _HV_FRAME_HEAD_Len);
        //        var headerSturct = (AvHeader)global::Nvr.Common.Helpers.SturctHelper.BytesToStuct(headBytes, typeof(AvHeader));

        //        byte[] dataBytes = new byte[headerSturct.DataLen];
        //        Array.Copy(bytes, _HV_FRAME_HEAD_Len, dataBytes, 0, headerSturct.DataLen);
        //        AvPacket avPacket = new AvPacket();
        //        avPacket.Header = headerSturct;
        //        avPacket.Data = dataBytes;
        //        dt = global::Nvr.Common.Helpers.TimerHelper.ConvertIntToDateTime(headerSturct.SrvTime);
        //        InputAvPacket(avPacket);//解码显示
        //        WriteGavFile(avPacket);//写到文件
        //    }
        //    lastTime = dt;
        //}

        /// <summary>
        /// 写到文件
        /// </summary>
        /// <param name="avPacket"></param>
        private void WriteGavFile(AvPacket avPacket)
        {

        }

        /// <summary>
        /// 输入解码显示
        /// </summary>
        /// <param name="avPacket"></param>
        private void InputAvPacket(AvPacket avPacket)
        {
            while (_pause)
            {
                System.Threading.Thread.Sleep(20);
            }
            if (_player == null)
            {
                if (avPacket.Header.StreamOwner == GenericStreamOwner.HIKStream && avPacket.Header.DataType == GenericStreamType.Para)
                {
                    _player = new global::Nvr.GenericStream.StreamPlayer(_videoHandle);
                    _player.OpenStream(avPacket.Header.StreamOwner, global::Nvr.GenericStream.PlayMode.GavFileStream, avPacket.Data);
                }
                else
                {
                    _player = new global::Nvr.GenericStream.StreamPlayer(_videoHandle);
                     _player.OpenStream(avPacket.Header.StreamOwner, global::Nvr.GenericStream.PlayMode.GavFileStream, avPacket.Data);
                }
            }
            else
            {
                if (_threadFlag)
                {
                    _player.InputAvPacket(avPacket);
                }
            }
        }

        private void StartPlay()
        {
            if (_HV_FRAME_HEAD_Len == 0)
                _HV_FRAME_HEAD_Len = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AvHeader));

            _threadFlag = true;
            new System.Threading.Thread(new System.Threading.ThreadStart(delegate
                {
                    Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                    try
                    {
                        _preVideoSortedList = rmtCam.GetPreBufferLastVideoList(_modelCam.ID);
                        foreach (byte[] bytes in _preVideoSortedList)
                        {
                            if (_threadFlag == false) break;
                            byte[] headBytes = new byte[_HV_FRAME_HEAD_Len];
                            Array.Copy(bytes, headBytes, _HV_FRAME_HEAD_Len);
                            var headerSturct = (AvHeader)global::Nvr.Common.Helpers.SturctHelper.BytesToStuct(headBytes, typeof(AvHeader));

                            byte[] dataBytes = new byte[headerSturct.DataLen];
                            Array.Copy(bytes, _HV_FRAME_HEAD_Len, dataBytes, 0, headerSturct.DataLen);
                            AvPacket avPacket = new AvPacket();
                            avPacket.Header = headerSturct;
                            avPacket.Data = dataBytes;
                            DateTime dt = global::Nvr.Common.Helpers.TimerHelper.ConvertIntToDateTime(headerSturct.SrvTime);//取得时间
                            InputAvPacket(avPacket);//解码显示
                            WriteGavFile(avPacket);//写到文件
                           // System.Threading.Thread.Sleep(50);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                        //出错了
                    }
                    finally
                    {
                        rmtCam = null;
                    }
                    this.BeginInvoke(new System.Threading.ThreadStart(delegate
                        {
                            btnRePlay.Enabled = true;
                            StopPlay();
                            btnPlayPreVideo.Text = "播放预录视频";
                            this.panel1.Invalidate();
                        }));
                })).Start();
        }

        /// <summary>
        /// 停止播放
        /// </summary>
        private  void StopPlay()
        {
            _pause = false;
            _threadFlag = false;

            if (_player != null)
            {
                _player.Close();
                _player = null;
            }
        }

        private void btnRePlay_Click(object sender, EventArgs e)
        {
            if (_preVideoSortedList == null || _preVideoSortedList.Count == 0)
            {
                MessageBox.Show(this, "保存");
                return;
            }
            this.btnRePlay.Enabled = false;
            btnPlayPreVideo.Text = "停止播放";
            _threadFlag = true;
            if (_HV_FRAME_HEAD_Len == 0)
                _HV_FRAME_HEAD_Len = System.Runtime.InteropServices.Marshal.SizeOf(typeof(AvHeader));

            new System.Threading.Thread(new System.Threading.ThreadStart(delegate
              {
                  foreach (byte[] bytes in _preVideoSortedList)
                  {
                      if (_threadFlag == false) break;
                      byte[] headBytes = new byte[_HV_FRAME_HEAD_Len];
                      Array.Copy(bytes, headBytes, _HV_FRAME_HEAD_Len);
                      var headerSturct = (AvHeader)global::Nvr.Common.Helpers.SturctHelper.BytesToStuct(headBytes, typeof(AvHeader));

                      byte[] dataBytes = new byte[headerSturct.DataLen];
                      Array.Copy(bytes, _HV_FRAME_HEAD_Len, dataBytes, 0, headerSturct.DataLen);
                      AvPacket avPacket = new AvPacket();
                      avPacket.Header = headerSturct;
                      avPacket.Data = dataBytes;
                      DateTime dt = global::Nvr.Common.Helpers.TimerHelper.ConvertIntToDateTime(headerSturct.SrvTime);//取得时间
                      InputAvPacket(avPacket);//解码显示
                      WriteGavFile(avPacket);//写到文件
                      System.Threading.Thread.Sleep(40);
                  }
                  this.BeginInvoke(new System.Threading.ThreadStart(delegate
                  {
                      btnRePlay.Enabled = true;
                      StopPlay();
                      btnPlayPreVideo.Text = "播放预录视频";
                      this.panel1.Invalidate();
                  }));
              })).Start();


        }
    }
}
