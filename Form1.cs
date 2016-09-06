﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Xml;
using System.Data.OleDb;

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

        private int iPicsAcocunt = 3;

        private Brush coverBrush = new SolidBrush(Color.FromArgb(96, Color.Black));

        private int iColor = 0;

        System.Data.OleDb.OleDbConnection AccessConn = new System.Data.OleDb.OleDbConnection();

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

        }

        private int AccessRead(string strSQL, ref DataTableCollection dta)
        {
            DataSet myDataSet = new DataSet();

            try
            {
                OleDbCommand myAccessCommand = new OleDbCommand(strSQL, AccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myDataAdapter.Fill(myDataSet, "最终视图");

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

        private int getData(string strSQL, ref DataRowCollection dra)
        {
            //string strSQL = @"Select * from 最终视图 where 设备编码 = 1";

            DataTableCollection dta = null;
            AccessRead(strSQL, ref dta);

            if (dta == null)
            {
                return 0;
            }

            foreach (DataTable dt in dta)
            {
                Console.WriteLine("Found data table {0}", dt.TableName);
            }

            DataColumnCollection drc = dta["最终视图"].Columns;
            int i = 0;
            foreach (DataColumn dc in drc)
            {
                // Print the column subscript, then the column's name
                // and its data type:
                Console.WriteLine("Column name[{0}] is {1}, of type {2}", i++, dc.ColumnName, dc.DataType);
            }

            dra = dta["最终视图"].Rows;
            //foreach (DataRow dr in dra)
            //{
            //    // Print the CategoryID as a subscript, then the CategoryName:
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            //}
            return dta["最终视图"].Rows.Count;
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
            ServiceGlobal.ServerAddr = _serverIp;
            ServiceGlobal.Port = _port;
                
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(delegate
                {
                    var rmtCam = Spnet.Core.Service.RemoteObjectFactory.CreateCamera(_serverIp, _port);
                    try
                    {
                        var camList = rmtCam.GetModelList("");
                        this.Invoke(new System.Threading.ThreadStart(delegate
                            {
                                foreach (var modelCam in camList)
                                {
                                    ListViewItem item = new ListViewItem(modelCam.ID + "_" + modelCam.Name);
                                    //string codex = modelCam.Code; //For test only
                                    item.Tag = modelCam;
                                    item.ImageIndex = 0;
                                    lstCamList.Items.Add(item);
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
        }

        private void lstCamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstCamList.SelectedItems.Count==0) return ;
            Spnet.Data.Model.Camera modelCam=lstCamList.SelectedItems[0].Tag as  Spnet.Data.Model.Camera;
            if (modelCam != null)
            {
                _real.ModelCam = modelCam;
                _rec.ModelCam = modelCam;
                _prePlay.ModelCam = modelCam;
                _timeRecPlay.ModelCam = modelCam;
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

                    dt = ds.Tables["CamInfo"];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow xRow = dt.Rows[0];
                        CamID.Text = dt.Rows[0]["Dev"].ToString();
                        CamADD.Text = dt.Rows[0]["Address"].ToString();
                        CamDIR.Text = dt.Rows[0]["Direct"].ToString();
                    }

                    dt = ds.Tables["VehInfo"];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow xRow = dt.Rows[0];
                        VehicleID.Text = dt.Rows[0]["vID"].ToString();
                        fileStr1.Text = dt.Rows[0]["fileStr1"].ToString();
                        fileStr2.Text = dt.Rows[0]["fileStr2"].ToString();
                    }

                    dt = ds.Tables["Capture"];
                    if (dt.Rows.Count > 0)
                    {
                        SavePICPath.Text = dt.Rows[0]["CapPath"].ToString();
                        iColor = Convert.ToInt32(dt.Rows[0]["txtColor"].ToString());
                        IntervalTimeBox.Text = dt.Rows[0]["IntervalTime"].ToString();
                        ProvinceBox.Text = dt.Rows[0]["ProvIndex"].ToString(); 
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
                xe.SetAttribute("Dev", CamID.Text);
                xe.SetAttribute("Address", CamADD.Text);
                xe.SetAttribute("Direct", CamDIR.Text);

                xe = (XmlElement)root[2];
                xe.SetAttribute("vID", VehicleID.Text);
                xe.SetAttribute("fileStr1", fileStr1.Text);
                xe.SetAttribute("fileStr2", fileStr2.Text);

                xe = (XmlElement)root[3];
                xe.SetAttribute("CapPath", SavePICPath.Text);
                xe.SetAttribute("txtColor", iColor.ToString());
                xe.SetAttribute("IntervalTime", IntervalTimeBox.Text);
                xe.SetAttribute("ProvIndex", ProvinceBox.Text);

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
        int iFilesCounter = 0;
        DateTime FirstFileTime = DateTime.Now;
        //保存的文件名格式：dev+datetime+"160002106400000000000"+nm+"A599N0_1345"
        private void CapturePIC(object sender, EventArgs e)
        {
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
            sb.Append(@"设备编号：" + CamID.Text + "  ");
            sb.Append(@"地点：" + CamADD.Text + "  ");
            sb.Append(@"方向：" + CamDIR.Text + "\n");
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
                    sb.Append("抓拍时间：" + Convert.ToDateTime(strTm).ToString("yyyy-MM-dd HH:mm:ss") + xMS);
                    FirstFileTime = Convert.ToDateTime(strTm + "." + xMS);
                }
                bCaptured = _rec.SaveRecPicToPath(out picPath);
            }
            else
            {
                return;
            }

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
                g.DrawString(sb.ToString(), new Font("黑体", 16, FontStyle.Bold), blackBrush, new PointF(0, 10));
                g.DrawString(sb.ToString(), new Font("黑体", 16, FontStyle.Bold), blackBrush, new PointF(2, 10));
                g.DrawString(sb.ToString(), new Font("黑体", 16, FontStyle.Bold), blackBrush, new PointF(0, 12));
                g.DrawString(sb.ToString(), new Font("黑体", 16, FontStyle.Bold), blackBrush, new PointF(2, 12));

                g.DrawString(sb.ToString(), new Font("黑体", 16, FontStyle.Bold), coverBrush, new PointF(1, 11));

                System.IO.File.Delete(picPath); //删除原有图片

                strSavePath += @"//抓取日期_" + DateTime.Now.ToString("yyyyMMdd") + @"//" + CamADD.Text;

                picsDir = strSavePath;  //For the final save

                strSavePath += @"//Temp";
                picsDir = strSavePath;  //For the final save

                if (!Directory.Exists(strSavePath))
                {
                    Directory.CreateDirectory(strSavePath);
                }

                string finalFileName = "";

                finalFileName = @"510122000000" + CamID.Text.Trim();
                finalFileName += FirstFileTime.ToString("yyMMddHHmmss");
                finalFileName += fileStr1.Text.ToString();
                finalFileName += "nm";
                finalFileName += iFilesCounter.ToString("D2");
                finalFileName += "_" + VehicleID.Text.ToString() + "_";
                finalFileName += fileStr2.Text.ToString();

                finalFileName = strSavePath + @"//" + finalFileName + ".jpg";
                image.Save(finalFileName.ToUpper());

                //Thread.Sleep(1000);
                _PreviewPic.AddImg(finalFileName, iFilesCounter);
                iFilesCounter++;
            }
            else
            {
                MessageBox.Show("图片保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            if (_PreviewPic.ConfirmSelected())
            {//Clear the list for the capture operation of the next time
                iFilesCounter = 0;
            }

            VideoPlayTab.SelectedIndex = iCurrentIndex;
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
    }
}
