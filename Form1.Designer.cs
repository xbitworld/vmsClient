namespace VmsClientDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lstCamList = new System.Windows.Forms.ListView();
            this.TabImageList = new System.Windows.Forms.ImageList(this.components);
            this.VideoPlayTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.shortCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CamADD = new System.Windows.Forms.TextBox();
            this.DevGroup = new System.Windows.Forms.GroupBox();
            this.AngleShowBox = new System.Windows.Forms.TextBox();
            this.DelRuleBT = new System.Windows.Forms.Button();
            this.AddRuleBT = new System.Windows.Forms.Button();
            this.AddrID = new System.Windows.Forms.TextBox();
            this.ruleCOMB = new System.Windows.Forms.ComboBox();
            this.RoadNOCMB = new System.Windows.Forms.ComboBox();
            this.DirCOMB = new System.Windows.Forms.ComboBox();
            this.IntervalTimeBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.SavePICPath = new System.Windows.Forms.TextBox();
            this.ChoisePICs = new System.Windows.Forms.Button();
            this.SelectDIR = new System.Windows.Forms.Button();
            this.CAPConfirmBT = new System.Windows.Forms.Button();
            this.AutoCapBT = new System.Windows.Forms.Button();
            this.CaptureBT = new System.Windows.Forms.Button();
            this.CamID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.VideoPlayTab.SuspendLayout();
            this.LoginGroup.SuspendLayout();
            this.DevGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "中心管理服务器：";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(168, 28);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(140, 28);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "192.168.1.4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(168, 69);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 28);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8899";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(168, 110);
            this.txtUid.Margin = new System.Windows.Forms.Padding(4);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(140, 28);
            this.txtUid.TabIndex = 1;
            this.txtUid.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(168, 150);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(140, 28);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "admin";
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "密码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(314, 146);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lstCamList
            // 
            this.lstCamList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCamList.GridLines = true;
            this.lstCamList.Location = new System.Drawing.Point(18, 573);
            this.lstCamList.Margin = new System.Windows.Forms.Padding(4);
            this.lstCamList.Name = "lstCamList";
            this.lstCamList.Size = new System.Drawing.Size(426, 288);
            this.lstCamList.SmallImageList = this.TabImageList;
            this.lstCamList.TabIndex = 4;
            this.lstCamList.UseCompatibleStateImageBehavior = false;
            this.lstCamList.View = System.Windows.Forms.View.List;
            this.lstCamList.SelectedIndexChanged += new System.EventHandler(this.lstCamList_SelectedIndexChanged);
            this.lstCamList.DoubleClick += new System.EventHandler(this.DBClickCamera);
            // 
            // TabImageList
            // 
            this.TabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabImageList.ImageStream")));
            this.TabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TabImageList.Images.SetKeyName(0, "CamIcon.png");
            this.TabImageList.Images.SetKeyName(1, "video166.png");
            this.TabImageList.Images.SetKeyName(2, "clapper2.png");
            this.TabImageList.Images.SetKeyName(3, "time_clock.png");
            this.TabImageList.Images.SetKeyName(4, "pictures1.png");
            this.TabImageList.Images.SetKeyName(5, "database16.png");
            this.TabImageList.Images.SetKeyName(6, "CamIcon-OffLine.png");
            this.TabImageList.Images.SetKeyName(7, "CamIcon-Online.png");
            // 
            // VideoPlayTab
            // 
            this.VideoPlayTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoPlayTab.Controls.Add(this.tabPage1);
            this.VideoPlayTab.Controls.Add(this.tabPage2);
            this.VideoPlayTab.Controls.Add(this.tabPage3);
            this.VideoPlayTab.Controls.Add(this.tabPage4);
            this.VideoPlayTab.Controls.Add(this.tabPage5);
            this.VideoPlayTab.Controls.Add(this.tabPage6);
            this.VideoPlayTab.HotTrack = true;
            this.VideoPlayTab.ImageList = this.TabImageList;
            this.VideoPlayTab.Location = new System.Drawing.Point(456, 15);
            this.VideoPlayTab.Margin = new System.Windows.Forms.Padding(4);
            this.VideoPlayTab.Name = "VideoPlayTab";
            this.VideoPlayTab.SelectedIndex = 0;
            this.VideoPlayTab.Size = new System.Drawing.Size(1138, 848);
            this.VideoPlayTab.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1130, 813);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "实时视频";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1130, 813);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "录像回放";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1130, 813);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "预录像播放";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "time_clock.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1130, 813);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "按时间回放录像";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ImageIndex = 4;
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1130, 813);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "图片预览";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.ImageIndex = 5;
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1130, 813);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "数据库编辑";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // LoginGroup
            // 
            this.LoginGroup.Controls.Add(this.shortCheck);
            this.LoginGroup.Controls.Add(this.btnLogin);
            this.LoginGroup.Controls.Add(this.txtPwd);
            this.LoginGroup.Controls.Add(this.txtUid);
            this.LoginGroup.Controls.Add(this.txtPort);
            this.LoginGroup.Controls.Add(this.txtServer);
            this.LoginGroup.Controls.Add(this.label2);
            this.LoginGroup.Controls.Add(this.label1);
            this.LoginGroup.Controls.Add(this.label4);
            this.LoginGroup.Controls.Add(this.label3);
            this.LoginGroup.Location = new System.Drawing.Point(18, 15);
            this.LoginGroup.Margin = new System.Windows.Forms.Padding(4);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Padding = new System.Windows.Forms.Padding(4);
            this.LoginGroup.Size = new System.Drawing.Size(429, 210);
            this.LoginGroup.TabIndex = 10;
            this.LoginGroup.TabStop = false;
            this.LoginGroup.Text = "登录信息";
            // 
            // shortCheck
            // 
            this.shortCheck.AutoSize = true;
            this.shortCheck.Checked = true;
            this.shortCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shortCheck.Location = new System.Drawing.Point(327, 30);
            this.shortCheck.Name = "shortCheck";
            this.shortCheck.Size = new System.Drawing.Size(88, 22);
            this.shortCheck.TabIndex = 24;
            this.shortCheck.Text = "快捷键";
            this.shortCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "地点：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "方向：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "设备号：";
            // 
            // CamADD
            // 
            this.CamADD.Location = new System.Drawing.Point(74, 70);
            this.CamADD.Margin = new System.Windows.Forms.Padding(4);
            this.CamADD.Name = "CamADD";
            this.CamADD.Size = new System.Drawing.Size(205, 28);
            this.CamADD.TabIndex = 12;
            this.CamADD.Text = "一环路科华路口磨子桥";
            // 
            // DevGroup
            // 
            this.DevGroup.Controls.Add(this.AngleShowBox);
            this.DevGroup.Controls.Add(this.DelRuleBT);
            this.DevGroup.Controls.Add(this.AddRuleBT);
            this.DevGroup.Controls.Add(this.AddrID);
            this.DevGroup.Controls.Add(this.ruleCOMB);
            this.DevGroup.Controls.Add(this.RoadNOCMB);
            this.DevGroup.Controls.Add(this.DirCOMB);
            this.DevGroup.Controls.Add(this.IntervalTimeBox);
            this.DevGroup.Controls.Add(this.colorBox);
            this.DevGroup.Controls.Add(this.SavePICPath);
            this.DevGroup.Controls.Add(this.ChoisePICs);
            this.DevGroup.Controls.Add(this.SelectDIR);
            this.DevGroup.Controls.Add(this.CAPConfirmBT);
            this.DevGroup.Controls.Add(this.AutoCapBT);
            this.DevGroup.Controls.Add(this.CaptureBT);
            this.DevGroup.Controls.Add(this.CamID);
            this.DevGroup.Controls.Add(this.CamADD);
            this.DevGroup.Controls.Add(this.label9);
            this.DevGroup.Controls.Add(this.label10);
            this.DevGroup.Controls.Add(this.label7);
            this.DevGroup.Controls.Add(this.label6);
            this.DevGroup.Controls.Add(this.label12);
            this.DevGroup.Controls.Add(this.label8);
            this.DevGroup.Controls.Add(this.label5);
            this.DevGroup.Controls.Add(this.label11);
            this.DevGroup.Controls.Add(this.label13);
            this.DevGroup.Location = new System.Drawing.Point(18, 240);
            this.DevGroup.Margin = new System.Windows.Forms.Padding(4);
            this.DevGroup.Name = "DevGroup";
            this.DevGroup.Padding = new System.Windows.Forms.Padding(4);
            this.DevGroup.Size = new System.Drawing.Size(428, 324);
            this.DevGroup.TabIndex = 13;
            this.DevGroup.TabStop = false;
            this.DevGroup.Text = "截图信息";
            // 
            // AngleShowBox
            // 
            this.AngleShowBox.Location = new System.Drawing.Point(210, 111);
            this.AngleShowBox.Name = "AngleShowBox";
            this.AngleShowBox.ReadOnly = true;
            this.AngleShowBox.Size = new System.Drawing.Size(68, 28);
            this.AngleShowBox.TabIndex = 24;
            // 
            // DelRuleBT
            // 
            this.DelRuleBT.Location = new System.Drawing.Point(384, 150);
            this.DelRuleBT.Margin = new System.Windows.Forms.Padding(4);
            this.DelRuleBT.Name = "DelRuleBT";
            this.DelRuleBT.Size = new System.Drawing.Size(33, 33);
            this.DelRuleBT.TabIndex = 23;
            this.DelRuleBT.Text = "-";
            this.DelRuleBT.UseVisualStyleBackColor = true;
            this.DelRuleBT.Click += new System.EventHandler(this.DelRuleBT_Click);
            // 
            // AddRuleBT
            // 
            this.AddRuleBT.Location = new System.Drawing.Point(351, 150);
            this.AddRuleBT.Margin = new System.Windows.Forms.Padding(4);
            this.AddRuleBT.Name = "AddRuleBT";
            this.AddRuleBT.Size = new System.Drawing.Size(33, 33);
            this.AddRuleBT.TabIndex = 23;
            this.AddRuleBT.Text = "+";
            this.AddRuleBT.UseVisualStyleBackColor = true;
            this.AddRuleBT.Click += new System.EventHandler(this.AddRuleBT_Click);
            // 
            // AddrID
            // 
            this.AddrID.Location = new System.Drawing.Point(285, 70);
            this.AddrID.Margin = new System.Windows.Forms.Padding(4);
            this.AddrID.Name = "AddrID";
            this.AddrID.Size = new System.Drawing.Size(130, 28);
            this.AddrID.TabIndex = 22;
            this.AddrID.Text = "100001000100";
            // 
            // ruleCOMB
            // 
            this.ruleCOMB.FormattingEnabled = true;
            this.ruleCOMB.Location = new System.Drawing.Point(74, 152);
            this.ruleCOMB.Margin = new System.Windows.Forms.Padding(4);
            this.ruleCOMB.Name = "ruleCOMB";
            this.ruleCOMB.Size = new System.Drawing.Size(266, 26);
            this.ruleCOMB.TabIndex = 21;
            this.ruleCOMB.Text = "跨越白实线";
            // 
            // RoadNOCMB
            // 
            this.RoadNOCMB.FormattingEnabled = true;
            this.RoadNOCMB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.RoadNOCMB.Location = new System.Drawing.Point(356, 112);
            this.RoadNOCMB.Margin = new System.Windows.Forms.Padding(4);
            this.RoadNOCMB.Name = "RoadNOCMB";
            this.RoadNOCMB.Size = new System.Drawing.Size(62, 26);
            this.RoadNOCMB.TabIndex = 20;
            this.RoadNOCMB.Text = "1";
            this.RoadNOCMB.SelectedIndexChanged += new System.EventHandler(this.ChangeDIR);
            // 
            // DirCOMB
            // 
            this.DirCOMB.FormattingEnabled = true;
            this.DirCOMB.Location = new System.Drawing.Point(74, 111);
            this.DirCOMB.Margin = new System.Windows.Forms.Padding(4);
            this.DirCOMB.Name = "DirCOMB";
            this.DirCOMB.Size = new System.Drawing.Size(79, 26);
            this.DirCOMB.TabIndex = 20;
            this.DirCOMB.Text = "西南";
            this.DirCOMB.SelectedIndexChanged += new System.EventHandler(this.ChangeDIR);
            // 
            // IntervalTimeBox
            // 
            this.IntervalTimeBox.Location = new System.Drawing.Point(372, 284);
            this.IntervalTimeBox.Margin = new System.Windows.Forms.Padding(4);
            this.IntervalTimeBox.Name = "IntervalTimeBox";
            this.IntervalTimeBox.Size = new System.Drawing.Size(43, 28);
            this.IntervalTimeBox.TabIndex = 4;
            this.IntervalTimeBox.Text = "800";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.colorBox.Location = new System.Drawing.Point(381, 30);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(36, 32);
            this.colorBox.TabIndex = 19;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.setColor);
            // 
            // SavePICPath
            // 
            this.SavePICPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePICPath.Location = new System.Drawing.Point(74, 190);
            this.SavePICPath.Margin = new System.Windows.Forms.Padding(4);
            this.SavePICPath.Name = "SavePICPath";
            this.SavePICPath.Size = new System.Drawing.Size(266, 28);
            this.SavePICPath.TabIndex = 15;
            this.SavePICPath.Text = "C:\\抓取图片";
            // 
            // ChoisePICs
            // 
            this.ChoisePICs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoisePICs.Location = new System.Drawing.Point(144, 238);
            this.ChoisePICs.Margin = new System.Windows.Forms.Padding(4);
            this.ChoisePICs.Name = "ChoisePICs";
            this.ChoisePICs.Size = new System.Drawing.Size(134, 34);
            this.ChoisePICs.TabIndex = 14;
            this.ChoisePICs.Text = "选图";
            this.ChoisePICs.UseVisualStyleBackColor = true;
            this.ChoisePICs.Click += new System.EventHandler(this.ChoisePIC);
            // 
            // SelectDIR
            // 
            this.SelectDIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDIR.Location = new System.Drawing.Point(351, 190);
            this.SelectDIR.Margin = new System.Windows.Forms.Padding(4);
            this.SelectDIR.Name = "SelectDIR";
            this.SelectDIR.Size = new System.Drawing.Size(66, 32);
            this.SelectDIR.TabIndex = 16;
            this.SelectDIR.Text = "...";
            this.SelectDIR.UseVisualStyleBackColor = true;
            this.SelectDIR.Click += new System.EventHandler(this.SelectDIR_Click);
            // 
            // CAPConfirmBT
            // 
            this.CAPConfirmBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CAPConfirmBT.Location = new System.Drawing.Point(144, 280);
            this.CAPConfirmBT.Margin = new System.Windows.Forms.Padding(4);
            this.CAPConfirmBT.Name = "CAPConfirmBT";
            this.CAPConfirmBT.Size = new System.Drawing.Size(134, 34);
            this.CAPConfirmBT.TabIndex = 14;
            this.CAPConfirmBT.Text = "选图确认";
            this.CAPConfirmBT.UseVisualStyleBackColor = true;
            this.CAPConfirmBT.EnabledChanged += new System.EventHandler(this.WaitProgress);
            this.CAPConfirmBT.Click += new System.EventHandler(this.ConfirmCAP);
            // 
            // AutoCapBT
            // 
            this.AutoCapBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoCapBT.Location = new System.Drawing.Point(284, 237);
            this.AutoCapBT.Margin = new System.Windows.Forms.Padding(4);
            this.AutoCapBT.Name = "AutoCapBT";
            this.AutoCapBT.Size = new System.Drawing.Size(134, 34);
            this.AutoCapBT.TabIndex = 14;
            this.AutoCapBT.Text = "截图(自动)";
            this.AutoCapBT.UseVisualStyleBackColor = true;
            this.AutoCapBT.Click += new System.EventHandler(this.AutoCapPics);
            // 
            // CaptureBT
            // 
            this.CaptureBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureBT.Location = new System.Drawing.Point(9, 238);
            this.CaptureBT.Margin = new System.Windows.Forms.Padding(4);
            this.CaptureBT.Name = "CaptureBT";
            this.CaptureBT.Size = new System.Drawing.Size(132, 76);
            this.CaptureBT.TabIndex = 14;
            this.CaptureBT.Text = "截图(手动)";
            this.CaptureBT.UseVisualStyleBackColor = true;
            this.CaptureBT.Click += new System.EventHandler(this.CapturePIC);
            // 
            // CamID
            // 
            this.CamID.Location = new System.Drawing.Point(74, 30);
            this.CamID.Margin = new System.Windows.Forms.Padding(4);
            this.CamID.Name = "CamID";
            this.CamID.Size = new System.Drawing.Size(205, 28);
            this.CamID.TabIndex = 14;
            this.CamID.Text = "512113889150570369";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "车道：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "路径：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "违章名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "水印颜色：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "间隔(ms)：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(160, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "角度：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 866);
            this.Controls.Add(this.LoginGroup);
            this.Controls.Add(this.VideoPlayTab);
            this.Controls.Add(this.lstCamList);
            this.Controls.Add(this.DevGroup);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "HVMS客户端 Ver 3.9.6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.VideoPlayTab.ResumeLayout(false);
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.DevGroup.ResumeLayout(false);
            this.DevGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListView lstCamList;
        private System.Windows.Forms.TabControl VideoPlayTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList TabImageList;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CamADD;
        private System.Windows.Forms.GroupBox DevGroup;
        private System.Windows.Forms.TextBox CamID;
        private System.Windows.Forms.Button CaptureBT;
        private System.Windows.Forms.TextBox SavePICPath;
        private System.Windows.Forms.Button SelectDIR;
        private System.Windows.Forms.Button ChoisePICs;
        private System.Windows.Forms.Button AutoCapBT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button CAPConfirmBT;
        private System.Windows.Forms.TextBox IntervalTimeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ruleCOMB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox RoadNOCMB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddrID;
        private System.Windows.Forms.Button AddRuleBT;
        private System.Windows.Forms.Button DelRuleBT;
        public System.Windows.Forms.ComboBox DirCOMB;
        private System.Windows.Forms.CheckBox shortCheck;
        private System.Windows.Forms.TextBox AngleShowBox;
        private System.Windows.Forms.Label label13;
    }
}

