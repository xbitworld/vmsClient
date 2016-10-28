using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmsClientDemo
{
    public partial class UCRealVideo : UserControl
    {
        public UCRealVideo()
        {
            InitializeComponent();
        }

        private Spnet.Data.Model.Camera _modelCam = null;

        /// <summary>
        /// 读取摄像机实体
        /// </summary>
        public Spnet.Data.Model.Camera ModelCam
        {
            get { return _modelCam;}
            set { 
                _modelCam = value;
                this.label1.Text = _modelCam.Name;
            }
        }

        /// <summary>
        /// 通讯流对象
        /// </summary>
        Nvr.VideoLib.Sockets.TsStreamClient _stream = null;

        /// <summary>
        /// 播放器
        /// </summary>
        Nvr.GenericStream.StreamPlayer _player = null;

        private IntPtr _videoHandle;

        private void UCRealVideo_Load(object sender, EventArgs e)
        {
            _videoHandle = this.panel1.Handle;
            this.comboBox1.SelectedIndex = 0;
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            if (_modelCam == null) return;

            if (this.btnPlayVideo.Text == "播放视频")
            {
                btnPlayVideo.Text = "关闭视频";
                PlayVideo();
            }
            else
            {
                this.btnPlayVideo.Text = "播放视频";
                StopVideo();
            }
        }

        public void StopVideo()
        {
            if (_stream != null)
            {
                _stream.OnGenricAvStreamData -= _stream_OnGenricAvStreamData;
                _stream.Close();
                _stream = null;
            }

            if (_player != null)
            {
                _player.Close();
                _player = null;
            }
            this.panel1.Invalidate();
        }

        private void PlayVideo()
        {
            int streamType=this.comboBox1.SelectedIndex; //0主码流 1子码流
            Spnet.Core.Service.Camera rmtCam=Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
            var videoInfo= rmtCam.GetVideoInfo(_modelCam.ID);
            if (videoInfo==null ) return ;
            _stream = new Nvr.VideoLib.Sockets.TsStreamClient(ServiceGlobal.ServerAddr, 6699, videoInfo.NvrServerIp, videoInfo.NvrStreamPort, videoInfo.NvrUid, videoInfo.NvrPwd, _modelCam.NvrCameraId, streamType);
            _stream.OnGenricAvStreamData += _stream_OnGenricAvStreamData;
            _stream.Open();
        }

        void _stream_OnGenricAvStreamData(object sender, Nvr.VideoLib.GenericAvStreamDataEventArgs e)
        {
           // System.Console.WriteLine("收到:" + e.StreamHeader.DataLen);

            if (_player == null)
            {
                if (e.NeedParaOpenStream)
                {
                    if (e.StreamHeader.DataType == Nvr.Driver.GenericStream.GenericStreamType.Para)
                    {
                        _player = new Nvr.GenericStream.StreamPlayer(_videoHandle);
                        _player.OpenStream(e.StreamHeader.StreamOwner, Nvr.GenericStream.PlayMode.GavLiveStream, e.Data);
                    }
                }
                else
                {
                    _player = new Nvr.GenericStream.StreamPlayer(_videoHandle);
                    _player.OpenStream(e.StreamHeader.StreamOwner, Nvr.GenericStream.PlayMode.GavLiveStream, e.Data);
                }
            }
            else
            {
                _player.InputAvPacket(new Nvr.Driver.GenericStream.AvPacket() { Data = e.Data, Header = e.StreamHeader });
            }
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
                {
                    Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                    try
                    {
                        rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Up, Nvr.Common.PTZOperType.Start, Nvr.Common.PTZSpeed.Speed4, "");
                    }
                    catch { }
                    finally
                    {
                        rmtCam = null;
                    }
                }));
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Up, Nvr.Common.PTZOperType.Stop, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Down, Nvr.Common.PTZOperType.Start, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Down, Nvr.Common.PTZOperType.Stop, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Left, Nvr.Common.PTZOperType.Start, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Left, Nvr.Common.PTZOperType.Stop, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Right, Nvr.Common.PTZOperType.Start, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Right, Nvr.Common.PTZOperType.Stop, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnZoom1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Zoom1, Nvr.Common.PTZOperType.Start, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnZoom1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Zoom1, Nvr.Common.PTZOperType.Stop, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }


        private void btnZoom2_MouseDown(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Zoom2, Nvr.Common.PTZOperType.Start, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnZoom2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_stream == null) return;
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.PtzControl(_modelCam.ID, "admin", 0, Nvr.Common.PTZCommand.Zoom2, Nvr.Common.PTZOperType.Stop, Nvr.Common.PTZSpeed.Speed4, "");
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnSetPreset_Click(object sender, EventArgs e)
        {
            if (_stream == null) return;

            int preset = (int)this.nudPresetNo.Value;

            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.SetupPtzPreset(_modelCam.ID, "admin", 0, preset);
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        string[] dirText = { "南向", "西南", "西向", "西北", "北向", "东北", "东向", "东南" };
        private void btnCallPreset_Click(object sender, EventArgs e)
        {
            int preset = (int)this.nudPresetNo.Value;
            //Form1 xForm = (Form1)this.ParentForm;
            ////xForm.DirCOMB.SelectedIndex = preset;
            //xForm.DirCOMB.Text = dirText[preset];
            if (_stream == null) return;

            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
            {
                Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                try
                {
                    rmtCam.CallPtzPreset(_modelCam.ID, "admin", 0, preset);
                }
                catch { }
                finally
                {
                    rmtCam = null;
                }
            }));
        }

        private void btnCapturePic_Click(object sender, EventArgs e)
        {
            if (_player != null)
            {
               string filePath =Environment.CurrentDirectory+"\\"+DateTime.Now.ToString("yyyyMMddHHmmssfff")+".jpg";
               bool flag=  _player.CaputrePic(filePath);
               if (flag)
               {
                   MessageBox.Show(this, "保存在" + filePath);
               }
            }
        }

        public bool SavePicToPath(out string picPath)
        {
            if (_player != null)
            {
                string filePath = Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg";
                picPath = filePath;
                bool flag = _player.CaputrePic(filePath);
                return flag;
            }
            else
            {
                picPath = "";
                return false;
            }
        }
    }
}
