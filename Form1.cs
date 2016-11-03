using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace VmsClientDemo
{
    public partial class Form1 : Form
    {
        private string _serverIp = "127.0.0.1";

        private int _port = 8899;

        private UCRealVideo _real = new UCRealVideo();

        private UCRec _rec = new UCRec();

        private UCPreVideoPlay _prePlay = new UCPreVideoPlay();

        private UCTimeRecPlay _timeRecPlay = new UCTimeRecPlay();

        private UCPreview _PreviewPic = new UCPreview();

        public delegate int dbCallbackFun([In] string strSQL, ref DataRowCollection dra);
        static dbCallbackFun pDBCallFun = new dbCallbackFun(getData);

        private UCDatabase _Database = new UCDatabase(pDBCallFun);

        private Brush coverBrush = new SolidBrush(Color.FromArgb(96, Color.Black));

        private int iColor = 0;

        private bool bSupperUser = false;

        static System.Data.OleDb.OleDbConnection AccessConn = new System.Data.OleDb.OleDbConnection();

        WaitBox waitWin;

        private BackgroundWorker m_BackgroundWorker;// 申明后台对象

        private void InitDBConn(string DBFullpath)
        {
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            AccessConn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source= " +
                DBFullpath;
            try
            {
                AccessConn.Open();
                // Insert code to process data.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
        }

        public Form1()
        {
            InitializeComponent();
            loadXml();
            initBKW();
            //Find the mdb from current directory.
            FileInfo[] fileInfo = getFileFullPath(@"VMS.mdb", ".\\");
            if (fileInfo.Count() < 1)
            {
                fileInfo = getFileFullPath(@"VMS.mdb", "..\\");
            }
            if (fileInfo.Count() < 1)
            {
                fileInfo = getFileFullPath(@"VMS.mdb", "..\\..\\");
            }
            if (fileInfo.Count() > 0)
            {
                InitDBConn(fileInfo[0].FullName);
            }

            ////Find the mdb from current directory.
            //fileInfo = getFileFullPath(@"CamIcon.png", "..\\..\\");
            //if (fileInfo.Count() > 0)
            //{
            //    Image RImage = Image.FromFile(fileInfo[0].FullName);
            //    VideoPlayTab.ImageList.Images.Add(RImage);
            //    tabPage1.ImageIndex = 0;
            //}

            RoadNOCMB.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabPage1.Controls.Add(_real);
            _real.Dock = DockStyle.Fill;

            this.tabPage2.Controls.Add(_rec);
            _rec.Dock = DockStyle.Fill;

            this.tabPage3.Controls.Add(_prePlay);
            _prePlay.Dock = DockStyle.Fill;

            this.tabPage4.Controls.Add(_timeRecPlay);
            _timeRecPlay.Dock = DockStyle.Fill;

            this.tabPage5.Controls.Add(_PreviewPic);
            _PreviewPic.Dock = DockStyle.Fill;

            this.tabPage6.Controls.Add(_Database);
            _Database.Dock = DockStyle.Fill;

            _Database.Enabled = false;
            _real.btnSetPreset.Enabled = false;
        }

        private static int AccessRead(string strSQL, ref DataTableCollection dta)
        {
            DataSet myDataSet = new DataSet();

            try
            {
                OleDbCommand myAccessCommand = new OleDbCommand(strSQL, AccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myDataAdapter.Fill(myDataSet);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
                return 1;
            }

            // A dataset can contain multiple tables, so let's get them
            // all into an array:
            dta = myDataSet.Tables;
            return 0;
        }

        public static int getData(string strSQL, ref DataRowCollection dra)
        {
            //string strSQL = @"Select * from 最终视图 where 设备编码 = 1";

            DataTableCollection dta = null;
            AccessRead(strSQL, ref dta);

            if (dta == null)
            {
                return -1;
            }

            if (dta.Count == 0)
            {
                return 0;
            }

            //foreach (DataTable dt in dta)
            //{
            //    Console.WriteLine("Found data table {0}", dt.TableName);
            //}

            //DataColumnCollection drc = dta["最终视图"].Columns;
            //int i = 0;
            //foreach (DataColumn dc in drc)
            //{
            //    // Print the column subscript, then the column's name
            //    // and its data type:
            //    Console.WriteLine("Column name[{0}] is {1}, of type {2}", i++, dc.ColumnName, dc.DataType);
            //}

            dra = dta[0].Rows;
            //foreach (DataRow dr in dra)
            //{
            //    // Print the CategoryID as a subscript, then the CategoryName:
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            //}
            return dta[0].Rows.Count;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lstCamList.Items.Clear();
            _serverIp = this.txtServer.Text.Trim();
            _port = Convert.ToInt32(this.txtPort.Text.Trim());


            Spnet.Core.Service.RemoteObjectFactory.CoreIp = _serverIp;
            Spnet.Core.Service.RemoteObjectFactory.CorePort = _port;
            Spnet.Core.Service.RemoteObjectFactory.Uid = this.txtUid.Text.Trim();
            Spnet.Core.Service.RemoteObjectFactory.Pwd = this.txtPwd.Text.Trim();
            int userRoleID = 0;
            ServiceGlobal.ServerAddr = _serverIp;
            ServiceGlobal.Port = _port;

            if(this.txtUid.Text.Trim().Equals("admin"))
            {//Super user
                System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
                {
                    Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera(_serverIp, _port);
                    try
                    {
                        var camList = rmtCam.GetModelList("");
                        this.Invoke(new System.Threading.ThreadStart(delegate
                        {
                            foreach (var modelCam in camList)
                            {
                                ListViewItem item = new ListViewItem(modelCam.ID + "_" + modelCam.Name);
                                //string codex = modelCam.Code; //For test only

                                Spnet.Data.Model.SysModels.CameraState camSt = rmtCam.GetCameraStateById(modelCam.ID);

                                item.Tag = modelCam;
                                if (camSt.IsOnline)
                                {
                                    item.ImageIndex = 7;
                                }
                                else
                                {
                                    item.ImageIndex = 6;
                                }

                                lstCamList.Items.Add(item);
                            }

                            if ((camList.Count > 0) && (this.txtUid.Text.Trim().Equals("admin")))
                            {
                                bSupperUser = true;

                                _Database.Enabled = true;
                                _real.btnSetPreset.Enabled = true;
                            }
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new System.Threading.ThreadStart(delegate
                        {
                            MessageBox.Show(this, ex.Message);
                            //出错了一般是通讯失败或服务器内调用失败
                        }));
                    }
                    finally
                    {
                        rmtCam = null;
                    }
                }));
                return;
            }

            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
                {
                    //Spnet.Core.Service.Camera rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera(_serverIp, _port);
                    var rmtUser = Spnet.Core.Service.RemoteObjectFactory.CreateUser();
                    var rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera();
                    var rmt = Spnet.Core.Service.RemoteObjectFactory.CreateUserRoleObjectData();
                    var userModel = rmtUser.GetModelByUid(Spnet.Core.Service.RemoteObjectFactory.Uid);
                    if (userModel == null)
                    {
                        MessageBox.Show("User Model Error!");
                        return;
                    }

                    userRoleID = userModel.UserRoleId;

                    try
                    {
                        var tempList = rmt.GetModelListByUserRoleIdAndObjType(userRoleID, Spnet.Common.ObjectType.CameraGrp);
                        foreach (var temp in tempList)
                        {
                            int camGrpID = temp.ObjectId;

                            var camList = rmtCam.GetModelListByGroupId(camGrpID);
                            //var camList = rmtCam.GetModelList("");
                            this.Invoke(new System.Threading.ThreadStart(delegate
                                {
                                    foreach (var modelCam in camList)
                                    {
                                        ListViewItem item = new ListViewItem(modelCam.ID + "_" + modelCam.Name);
                                        //string codex = modelCam.Code; //For test only

                                        Spnet.Data.Model.SysModels.CameraState camSt = rmtCam.GetCameraStateById(modelCam.ID);

                                        item.Tag = modelCam;
                                        if (camSt.IsOnline)
                                        {
                                            item.ImageIndex = 7;
                                        }
                                        else
                                        {
                                            item.ImageIndex = 6;
                                        }

                                        lstCamList.Items.Add(item);
                                    }

                                    _Database.Enabled = false;
                                    _real.btnSetPreset.Enabled = false;
                                }));
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new System.Threading.ThreadStart(delegate
                        {
                            MessageBox.Show(this, ex.Message);
                            //出错了一般是通讯失败或服务器内调用失败
                        }));
                    }
                    finally
                    {
                        rmtCam = null;
                    }
                }));
        }

        //
        private void lstCamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iPosID = -1;
            string strPOSCode = "";
            string strCAMCode = "";

            CamADD.Tag = -1;   //Rest the AddrID

            DirCOMB.Items.Clear();
            CamADD.Text = "";
            CamID.Text = "";

            if (this.lstCamList.SelectedItems.Count==0) return ;
            Spnet.Data.Model.Camera modelCam=lstCamList.SelectedItems[0].Tag as  Spnet.Data.Model.Camera;

            if (modelCam != null)
            {
                _real.ModelCam = modelCam;
                _rec.ModelCam = modelCam;
                _prePlay.ModelCam = modelCam;
                _timeRecPlay.ModelCam = modelCam;

                CamADD.Text = modelCam.Name;    //Display Camera name in the Camera address textbox by dutao @ 2016-09-26
                _Database.fillDevDir(modelCam.Code);

                _Database.fillDatabaseUI(modelCam.Code, modelCam.Name);
                if(_Database.getPostitionID(ref iPosID, ref strCAMCode, ref strPOSCode) == 0)
                {
                    //Switch to Database table
                    CamID.Text = strCAMCode;
                    AddrID.Text = strPOSCode;

                    CamADD.Tag = iPosID;

                    fillRulesInfo(iPosID);
                }
                else
                {
                    this.VideoPlayTab.SelectedTab = this.tabPage6;
                }
            }
        }

        public int fillRulesInfo(int iPosID)
        {
            DirCOMB.Items.Clear();
            DirCOMB.Text = "";
            ruleCOMB.Items.Clear();
            ruleCOMB.Text = "";

            DataRowCollection drc = null;
            int iRows = getData(@"select distinct 方向描述 from 违章种类及方向 where 路口ID = " + iPosID.ToString(), ref drc);
            if (iRows > 0)
            {
                foreach (DataRow DR in drc)
                {
                    string dirStr = (string)(DR[0]);
                    int iPos = dirStr.IndexOf('\r');
                    string strTMP = null;
                    if (iPos >= 0)
                    {
                        strTMP = dirStr.Substring(0, iPos);
                    }
                    else
                    {
                        strTMP = dirStr;
                    }
                    DirCOMB.Items.Add(strTMP);
                }

                DirCOMB.SelectedIndex = 0;  //triger to fill the rules combbox
                return 0;
            }
            else
            {//Switch to database table to edit rules data
                return 1;
            }
        }

        private void ChangeDIR(object sender, EventArgs e)
        {
            setRulesBox();
        }

        private void setRulesBox()
        {
            if(CamADD.Tag == null)
            {
                return;
            }
            int iAddrCode = (int)(CamADD.Tag);
            if (iAddrCode == -1)
            {
                MessageBox.Show("地址信息错误，请检查！");
                return;
            }

            string strDir = DirCOMB.Items[DirCOMB.SelectedIndex].ToString();
            int iIndex = DirCOMB.SelectedIndex;
            ruleCOMB.Items.Clear();

            string strSQL = "select 方向描述, 违章描述 from 违章种类及方向 where 路口ID = " +
                iAddrCode.ToString();

            DataRowCollection drc = null;
            int iRows = getData(strSQL, ref drc);
            if (iRows > 0)
            {
                ruleCOMB.SelectedText = "";

                foreach (DataRow DR in drc)
                {
                    string dirStr = (string)(DR[0]);

                    int iPos = dirStr.IndexOf('\r');
                    string strTMP = null;
                    if (iPos >= 0)
                    {
                        strTMP = dirStr.Substring(0, iPos);
                    }
                    else
                    {
                        strTMP = dirStr;
                    }

                    if (strTMP == strDir)
                    {
                        ruleCOMB.Items.Add(DR[1]);
                    }
                }

                if (ruleCOMB.Items.Count > 0)
                {
                    ruleCOMB.SelectedIndex = 0;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _PreviewPic.resetList();
            //here will delete the template file
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(AccessConn.State != ConnectionState.Closed)
            {
                AccessConn.Close();
            }

            SaveXml();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void loadXml()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Application.StartupPath + "\\xmlConfig.xml");

                if (ds != null)
                {
                    DataTable dt = ds.Tables["Server"];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow xRow = dt.Rows[0];
                        txtServer.Text = dt.Rows[0]["IP"].ToString();
                        txtPort.Text = dt.Rows[0]["Port"].ToString();
                        txtUid.Text = dt.Rows[0]["User"].ToString();
                        txtPwd.Text = dt.Rows[0]["Pass"].ToString();
                    }

                    dt = ds.Tables["Capture"];
                    if (dt.Rows.Count > 0)
                    {
                        SavePICPath.Text = dt.Rows[0]["CapPath"].ToString();
                        iColor = Convert.ToInt32(dt.Rows[0]["txtColor"].ToString());
                        IntervalTimeBox.Text = dt.Rows[0]["IntervalTime"].ToString();
                        Color boxColor = Color.FromArgb(iColor);
                        coverBrush = new SolidBrush(boxColor);
                        colorBox.BackColor = boxColor;
                    }
                }
            }
            catch { }
        }

        private void SaveXml()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Application.StartupPath + "\\xmlConfig.xml");
                XmlNodeList root = xmlDoc.SelectSingleNode("Config").ChildNodes;

                XmlElement xe = (XmlElement)root[0];
                xe.SetAttribute("IP", txtServer.Text);
                xe.SetAttribute("Port", txtPort.Text);
                xe.SetAttribute("User", txtUid.Text);
                xe.SetAttribute("Pass", txtPwd.Text);

                xe = (XmlElement)root[1];
                xe.SetAttribute("CapPath", SavePICPath.Text);
                xe.SetAttribute("txtColor", iColor.ToString());
                xe.SetAttribute("IntervalTime", IntervalTimeBox.Text);

                xmlDoc.Save(Application.StartupPath + "\\xmlConfig.xml");
            }
            catch { };
        }

        private FileInfo[] getFileFullPath(string FileName, string StartPath)
        {
            try
            {
                if (FileName == null || StartPath == null)
                {
                    throw new DirectoryNotFoundException("获取文件路径时，文件名或路径名是空");
                }
            }
            catch
            {
                FileInfo[] FakeFileInfo = { new FileInfo("无法找到文件") };
                return FakeFileInfo;
            }

            DirectoryInfo di = new DirectoryInfo(StartPath);
            return di.GetFiles(FileName, SearchOption.AllDirectories);
        }

        private void DBClickCamera(object sender, EventArgs e)
        {
            this.VideoPlayTab.SelectedTab = this.tabPage1;

            if (this.lstCamList.SelectedItems.Count == 0) return;
            Spnet.Data.Model.Camera modelCam = lstCamList.SelectedItems[0].Tag as Spnet.Data.Model.Camera;
            if (modelCam != null)
            {
                _real.ModelCam = modelCam;
                _rec.ModelCam = modelCam;
                _prePlay.ModelCam = modelCam;
                _timeRecPlay.ModelCam = modelCam;

                int iX = 0;
                Control xBT = _real.GetNextControl(null, true);
                xBT = _real.GetNextControl(xBT, true);
                while (!xBT.Name.Equals("btnPlayVideo"))
                {
                    xBT = _real.GetNextControl(xBT, true);
                    iX++;
                }
                Button PlayBT = (Button)xBT;
                if (PlayBT.Text.Equals("关闭视频"))
                {
                    _real.StopVideo();
                    PlayBT.Text = "播放视频";
                    Thread.Sleep(1000);
                }
                PlayBT.PerformClick();
            }
        }

        string picsDir = @"./";
        int iFilesCounter = 0;      //Mark the file's name unique
        DateTime FirstFileTime = DateTime.Now;
        //保存的文件名格式：dev+datetime+"160002106400000000000"+nm+"A599N0_1345"
        private void CapturePIC(object sender, EventArgs e)
        {
            CaptureBT.Enabled = false;
            AutoCapBT.Enabled = false;
            m_BackgroundWorker.RunWorkerAsync(this);

            Button sendBT = (Button)sender;

            if (string.IsNullOrEmpty(SavePICPath.Text.Trim()))
            {
                MessageBox.Show("保存路径不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string strSavePath = SavePICPath.Text;

            if (VideoPlayTab.SelectedIndex != 0 && VideoPlayTab.SelectedIndex != 1)
            {//Not the vidio play table
                return;
            }

            if (string.IsNullOrEmpty(CamADD.Text.Trim()))
            {
                MessageBox.Show("地址不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StringBuilder sb = new StringBuilder(); //文字描述

            string strCamName = CamADD.Text.Substring(4);
            sb.Append(@"地点：" + strCamName + "  ");

            string strDIRm = DirCOMB.Text;
            if (strDIRm != null && strDIRm.Last() == '向')
            {
                strDIRm = strDIRm.Substring(0, 1);
            }
            sb.Append(@"方向：" + strDIRm + "\n");
            //

            string picPath = "";
            bool bCaptured = false;
            if (VideoPlayTab.SelectedIndex == 0)
            {
                FirstFileTime = DateTime.Now;
                sb.Append("抓拍时间：" + FirstFileTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                bCaptured = _real.SavePicToPath(out picPath);
            }
            else if (VideoPlayTab.SelectedIndex == 1)
            {
                //If the capture picture time are samed, user the OrderChar to tag it to avoid something wrong.
                string strTm = _rec.getPlayTimeStr();
                if (strTm == "")
                {
                    sb.Append("抓拍时间：");
                }
                else
                {
                    string xMS = (new Random()).Next(1000).ToString("000"); //模拟毫秒数
                    sb.Append("抓拍时间：" + Convert.ToDateTime(strTm).ToString("yyyy-MM-dd HH:mm:ss.") + xMS);
                    FirstFileTime = Convert.ToDateTime(strTm + "." + xMS);
                }
                bCaptured = _rec.SaveRecPicToPath(out picPath);
            }
            else
            {
                return;
            }

            sb.Append("\n" + @"设备编号：" + CamID.Text);

            if (!bCaptured)
            {
                MessageBox.Show("抓图失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(picPath))
            {
                MessageBox.Show("抓图失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (System.IO.File.Exists(picPath))//图片是否存在  
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(picPath));
                Image image = Image.FromStream(ms);
                Graphics g = Graphics.FromImage(image);

                //Draw the black board
                Brush blackBrush = new SolidBrush(Color.Black);
                g.DrawString(sb.ToString(), new Font("黑体", 24, FontStyle.Bold), blackBrush, new PointF(0, 10));
                g.DrawString(sb.ToString(), new Font("黑体", 24, FontStyle.Bold), blackBrush, new PointF(2, 10));
                g.DrawString(sb.ToString(), new Font("黑体", 24, FontStyle.Bold), blackBrush, new PointF(0, 12));
                g.DrawString(sb.ToString(), new Font("黑体", 24, FontStyle.Bold), blackBrush, new PointF(2, 12));

                g.DrawString(sb.ToString(), new Font("黑体", 24, FontStyle.Bold), coverBrush, new PointF(1, 11));

                System.IO.File.Delete(picPath); //删除原有图片

                strSavePath += @"//抓取日期_" + DateTime.Now.ToString("yyyyMMdd") + @"//" + CamADD.Text;

                picsDir = strSavePath;  //For the final save

                strSavePath += @"//Temp";
                picsDir = strSavePath;  //For the final save

                if (!Directory.Exists(strSavePath))
                {
                    try
                    {
                        Directory.CreateDirectory(strSavePath);
                    }
                    catch
                    {
                        MessageBox.Show("目录无法找到或建立，请检查后再试！");
                        return;
                    }
                }

                string finalFileName = "";

                finalFileName = CamID.Text.Trim();
                finalFileName += FirstFileTime.ToString("yyMMddHHmmss");
                finalFileName += RoadNOCMB.Text;
                finalFileName += AddrID.Text;
                finalFileName += "00000";
                finalFileName += "000";
                finalFileName += "nm";
                finalFileName += iFilesCounter.ToString("D2");

                finalFileName = strSavePath + @"//" + finalFileName + ".jpg";

                //Save Jpeg with quality variable
                ImageCodecInfo myImageCodecInfo;
                System.Drawing.Imaging.Encoder myEncoder;
                EncoderParameter myEncoderParameter;
                EncoderParameters myEncoderParameters;

                // Get an ImageCodecInfo object that represents the JPEG codec.
                myImageCodecInfo = GetEncoderInfo("image/jpeg");

                // Create an Encoder object based on the GUID

                // for the Quality parameter category.
                myEncoder = System.Drawing.Imaging.Encoder.Quality;

                // Create an EncoderParameters object.

                // An EncoderParameters object has an array of EncoderParameter

                // objects. In this case, there is only one

                // EncoderParameter object in the array.
                myEncoderParameters = new EncoderParameters(1);

                // Save the bitmap as a JPEG file with quality level 25.
                myEncoderParameter = new EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                //image.Save("Shapes025.jpg", myImageCodecInfo, myEncoderParameters);
                image.Save(finalFileName.ToUpper(), myImageCodecInfo, myEncoderParameters);
                //Save End.......

                //image.Save(finalFileName.ToUpper(), System.Drawing.Imaging.ImageFormat.Jpeg);

                //Thread.Sleep(1000);
                _PreviewPic.AddImg(finalFileName, iFilesCounter);
                iFilesCounter++;

                //if (VideoPlayTab.SelectedIndex == 0)
                //{
                //    int iInterval = Convert.ToInt32(IntervalTimeBox.Text);
                //    _real.TimerCount(iInterval);
                //}
            }
            else
            {
                MessageBox.Show("图片保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private ImageCodecInfo GetEncoderInfo(string v)
        {
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == v)
                    return codecs[i];
            return null;
        }

        private void SelectDIR_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = SavePICPath.Text;
            DialogResult result = fbd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                SavePICPath.Text = fbd.SelectedPath;
            }
        }

        private void setColor(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            DialogResult = colorD.ShowDialog();

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                coverBrush = new SolidBrush(colorD.Color);
                colorBox.BackColor = colorD.Color;
                iColor = colorD.Color.ToArgb();
            }
        }

        int iCurrentIndex = 0;
        private void ChoisePIC(object sender, EventArgs e)
        {
            iCurrentIndex = VideoPlayTab.SelectedIndex;

            VideoPlayTab.SelectedTab = tabPage5;

            _PreviewPic.showCurrentSelected(0);
        }

        private void ConfirmCAP(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            waitWin = new WaitBox();
            waitWin.Show(this);

            if (_PreviewPic.ConfirmSelected(ruleCOMB.Text))
            {//Clear the list for the capture operation of the next time
                iFilesCounter = 0;
                //MessageBox.Show("保存完毕");
            }

            VideoPlayTab.SelectedIndex = iCurrentIndex;

            waitWin.Close();
            Cursor.Current = Cursors.Default;
        }

        private void AutoCapPics(object sender, EventArgs e)
        {
            int iAmount = 3;
            int iInterval = Convert.ToInt16(IntervalTimeBox.Text);
            for (int iLoop = 0; iLoop < iAmount; iLoop++)
            {
                CaptureBT.PerformClick();
                Thread.Sleep(iInterval);
            }
        }

        private void AddRuleBT_Click(object sender, EventArgs e)
        {
            if (CamADD.Tag == null)
            {
                MessageBox.Show("设备信息错误，请检查！");
                return;
            }
            int iPosID = int.Parse(CamADD.Tag.ToString());
            if (iPosID == -1)
            {
                MessageBox.Show("设备地址信息错误，请检查！");
                return;
            }

            RulesUI rulesWin = new RulesUI(iPosID, true);
            rulesWin.Show(this);
        }

        private void DelRuleBT_Click(object sender, EventArgs e)
        {
            if (CamADD.Tag == null)
            {
                MessageBox.Show("设备信息错误，请检查！");
                return;
            }
            int iPosID = int.Parse(CamADD.Tag.ToString());
            if (iPosID == -1)
            {
                MessageBox.Show("设备地址信息错误，请检查！");
                return;
            }

            if(ruleCOMB.Items.Count < 1)
            {
                MessageBox.Show("数据已经为空，请返回");
                return;
            }

            RulesUI rulesWin = new RulesUI(iPosID, false);
            rulesWin.Show(this);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {//Adjust the size of tabcontrol to avoid some area be hide
            //VideoPlayTab.Width = this.Width - LoginGroup.Width - 5;
            //VideoPlayTab.Height = this.Height;
            //VideoPlayTab.Update();
            //VideoPlayTab.Refresh();
        }

        private void initBKW()
        {
            m_BackgroundWorker = new BackgroundWorker(); // 实例化后台对象
            m_BackgroundWorker.WorkerReportsProgress = true; // 设置可以通告进度
            m_BackgroundWorker.WorkerSupportsCancellation = true; // 设置可以取消
            m_BackgroundWorker.DoWork += new DoWorkEventHandler(DoWork);
            m_BackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(UpdateProgress);
            m_BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedWork);
//            m_BackgroundWorker.RunWorkerAsync(this);
        }

        private void WaitProgress(object sender, EventArgs e)
        {
            if(CAPConfirmBT.Enabled == false)
            {
            }
            else
            {
            }
        }

        void DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            int iMax = Convert.ToInt32(IntervalTimeBox.Text);
            int i = 0;
            while (i <= iMax)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                bw.ReportProgress(i);
                Thread.Sleep(100);
                i += 100;
            }
        }

        void UpdateProgress(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;
            _real.TimerShow(progress);
        }

        void CompletedWork(object sender, RunWorkerCompletedEventArgs e)
        {
            CaptureBT.Enabled = true;
            AutoCapBT.Enabled = true;
        }

        public void getDirFromPre(string devCode, int prePos)
        {
            string strSQL = "SELECT 方向编码表.方向描述 FROM 设备方向映射表 LEFT JOIN 方向编码表 ON 设备方向映射表.方向ID = 方向编码表.方向编码 WHERE 设备方向映射表.设备CODE = '" + devCode  + "' and 设备方向映射表.预置位ID = " + prePos.ToString();
            DataRowCollection drc = null;
            int iRow = getData(strSQL, ref drc);
            if (iRow > 0)
            {
                string strDIR = (string)drc[0][0];
                DirCOMB.Text = strDIR;
            }
        }
    }
}
