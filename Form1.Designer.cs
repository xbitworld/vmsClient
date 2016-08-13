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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.VideoPlayTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CamADD = new System.Windows.Forms.TextBox();
            this.DevGroup = new System.Windows.Forms.GroupBox();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.fileStr2 = new System.Windows.Forms.TextBox();
            this.SavePICPath = new System.Windows.Forms.TextBox();
            this.SelectDIR = new System.Windows.Forms.Button();
            this.ChoisePICs = new System.Windows.Forms.Button();
            this.Cap2 = new System.Windows.Forms.Button();
            this.Cap1 = new System.Windows.Forms.Button();
            this.fileStr1 = new System.Windows.Forms.TextBox();
            this.VehicleID = new System.Windows.Forms.TextBox();
            this.CamID = new System.Windows.Forms.TextBox();
            this.CamDIR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.VideoPlayTab.SuspendLayout();
            this.LoginGroup.SuspendLayout();
            this.DevGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "中心管理服务器：";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(178, 28);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(174, 28);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "192.168.1.4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口：";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(178, 69);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 28);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8899";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(178, 110);
            this.txtUid.Margin = new System.Windows.Forms.Padding(4);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(100, 28);
            this.txtUid.TabIndex = 1;
            this.txtUid.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(178, 150);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 28);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.Text = "admin";
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "密码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(306, 147);
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
            this.lstCamList.Location = new System.Drawing.Point(18, 578);
            this.lstCamList.Margin = new System.Windows.Forms.Padding(4);
            this.lstCamList.Name = "lstCamList";
            this.lstCamList.Size = new System.Drawing.Size(427, 526);
            this.lstCamList.SmallImageList = this.imageList1;
            this.lstCamList.TabIndex = 4;
            this.lstCamList.UseCompatibleStateImageBehavior = false;
            this.lstCamList.View = System.Windows.Forms.View.List;
            this.lstCamList.SelectedIndexChanged += new System.EventHandler(this.lstCamList_SelectedIndexChanged);
            this.lstCamList.DoubleClick += new System.EventHandler(this.DBClickCamera);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "camera.png");
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
            this.VideoPlayTab.Location = new System.Drawing.Point(460, 36);
            this.VideoPlayTab.Margin = new System.Windows.Forms.Padding(4);
            this.VideoPlayTab.Name = "VideoPlayTab";
            this.VideoPlayTab.SelectedIndex = 0;
            this.VideoPlayTab.Size = new System.Drawing.Size(1234, 1070);
            this.VideoPlayTab.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1226, 1038);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "实时视频";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1226, 1038);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "录像回放";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1226, 1038);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "预录像播放";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1226, 1038);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "按时间回放录像";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1226, 1038);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "图片预览";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // LoginGroup
            // 
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "地点：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "方向：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "设备编号：";
            // 
            // CamADD
            // 
            this.CamADD.Location = new System.Drawing.Point(75, 27);
            this.CamADD.Margin = new System.Windows.Forms.Padding(4);
            this.CamADD.Name = "CamADD";
            this.CamADD.Size = new System.Drawing.Size(277, 28);
            this.CamADD.TabIndex = 12;
            // 
            // DevGroup
            // 
            this.DevGroup.Controls.Add(this.colorBox);
            this.DevGroup.Controls.Add(this.fileStr2);
            this.DevGroup.Controls.Add(this.SavePICPath);
            this.DevGroup.Controls.Add(this.SelectDIR);
            this.DevGroup.Controls.Add(this.ChoisePICs);
            this.DevGroup.Controls.Add(this.Cap2);
            this.DevGroup.Controls.Add(this.Cap1);
            this.DevGroup.Controls.Add(this.fileStr1);
            this.DevGroup.Controls.Add(this.VehicleID);
            this.DevGroup.Controls.Add(this.CamID);
            this.DevGroup.Controls.Add(this.CamDIR);
            this.DevGroup.Controls.Add(this.CamADD);
            this.DevGroup.Controls.Add(this.label8);
            this.DevGroup.Controls.Add(this.label10);
            this.DevGroup.Controls.Add(this.label9);
            this.DevGroup.Controls.Add(this.label5);
            this.DevGroup.Controls.Add(this.label7);
            this.DevGroup.Controls.Add(this.label6);
            this.DevGroup.Location = new System.Drawing.Point(18, 240);
            this.DevGroup.Margin = new System.Windows.Forms.Padding(4);
            this.DevGroup.Name = "DevGroup";
            this.DevGroup.Padding = new System.Windows.Forms.Padding(4);
            this.DevGroup.Size = new System.Drawing.Size(428, 328);
            this.DevGroup.TabIndex = 13;
            this.DevGroup.TabStop = false;
            this.DevGroup.Text = "截图信息";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.colorBox.Location = new System.Drawing.Point(363, 27);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(36, 32);
            this.colorBox.TabIndex = 19;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.setColor);
            // 
            // fileStr2
            // 
            this.fileStr2.Location = new System.Drawing.Point(290, 108);
            this.fileStr2.Margin = new System.Windows.Forms.Padding(4);
            this.fileStr2.Name = "fileStr2";
            this.fileStr2.Size = new System.Drawing.Size(108, 28);
            this.fileStr2.TabIndex = 18;
            this.fileStr2.Text = "1345";
            // 
            // SavePICPath
            // 
            this.SavePICPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePICPath.Location = new System.Drawing.Point(74, 288);
            this.SavePICPath.Margin = new System.Windows.Forms.Padding(4);
            this.SavePICPath.Name = "SavePICPath";
            this.SavePICPath.Size = new System.Drawing.Size(274, 28);
            this.SavePICPath.TabIndex = 15;
            this.SavePICPath.Text = "C:\\抓取图片";
            // 
            // SelectDIR
            // 
            this.SelectDIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectDIR.Location = new System.Drawing.Point(350, 286);
            this.SelectDIR.Margin = new System.Windows.Forms.Padding(4);
            this.SelectDIR.Name = "SelectDIR";
            this.SelectDIR.Size = new System.Drawing.Size(48, 34);
            this.SelectDIR.TabIndex = 16;
            this.SelectDIR.Text = "...";
            this.SelectDIR.UseVisualStyleBackColor = true;
            this.SelectDIR.Click += new System.EventHandler(this.SelectDIR_Click);
            // 
            // ChoisePICs
            // 
            this.ChoisePICs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoisePICs.Location = new System.Drawing.Point(74, 233);
            this.ChoisePICs.Margin = new System.Windows.Forms.Padding(4);
            this.ChoisePICs.Name = "ChoisePICs";
            this.ChoisePICs.Size = new System.Drawing.Size(322, 34);
            this.ChoisePICs.TabIndex = 14;
            this.ChoisePICs.Text = "选图";
            this.ChoisePICs.UseVisualStyleBackColor = true;
            this.ChoisePICs.Click += new System.EventHandler(this.ChoisePIC);
            // 
            // Cap2
            // 
            this.Cap2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cap2.Location = new System.Drawing.Point(262, 191);
            this.Cap2.Margin = new System.Windows.Forms.Padding(4);
            this.Cap2.Name = "Cap2";
            this.Cap2.Size = new System.Drawing.Size(134, 34);
            this.Cap2.TabIndex = 14;
            this.Cap2.Text = "截图(自动)";
            this.Cap2.UseVisualStyleBackColor = true;
            this.Cap2.Click += new System.EventHandler(this.CapturePIC);
            // 
            // Cap1
            // 
            this.Cap1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cap1.Location = new System.Drawing.Point(75, 191);
            this.Cap1.Margin = new System.Windows.Forms.Padding(4);
            this.Cap1.Name = "Cap1";
            this.Cap1.Size = new System.Drawing.Size(132, 34);
            this.Cap1.TabIndex = 14;
            this.Cap1.Text = "截图(手动)";
            this.Cap1.UseVisualStyleBackColor = true;
            this.Cap1.Click += new System.EventHandler(this.CapturePIC);
            // 
            // fileStr1
            // 
            this.fileStr1.Location = new System.Drawing.Point(75, 108);
            this.fileStr1.Margin = new System.Windows.Forms.Padding(4);
            this.fileStr1.Name = "fileStr1";
            this.fileStr1.Size = new System.Drawing.Size(204, 28);
            this.fileStr1.TabIndex = 15;
            this.fileStr1.Text = "160002106400000000000";
            // 
            // VehicleID
            // 
            this.VehicleID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VehicleID.Location = new System.Drawing.Point(75, 148);
            this.VehicleID.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Size = new System.Drawing.Size(157, 28);
            this.VehicleID.TabIndex = 15;
            this.VehicleID.Text = "A00001";
            // 
            // CamID
            // 
            this.CamID.Location = new System.Drawing.Point(262, 68);
            this.CamID.Margin = new System.Windows.Forms.Padding(4);
            this.CamID.Name = "CamID";
            this.CamID.Size = new System.Drawing.Size(134, 28);
            this.CamID.TabIndex = 14;
            // 
            // CamDIR
            // 
            this.CamDIR.Location = new System.Drawing.Point(75, 68);
            this.CamDIR.Margin = new System.Windows.Forms.Padding(4);
            this.CamDIR.Name = "CamDIR";
            this.CamDIR.Size = new System.Drawing.Size(88, 28);
            this.CamDIR.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 292);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "路径：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 153);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "车牌号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "文件名：";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 1124);
            this.Controls.Add(this.LoginGroup);
            this.Controls.Add(this.VideoPlayTab);
            this.Controls.Add(this.lstCamList);
            this.Controls.Add(this.DevGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "HVMS客户端 Ver 1.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CamADD;
        private System.Windows.Forms.GroupBox DevGroup;
        private System.Windows.Forms.TextBox CamID;
        private System.Windows.Forms.TextBox CamDIR;
        private System.Windows.Forms.Button Cap1;
        private System.Windows.Forms.TextBox SavePICPath;
        private System.Windows.Forms.Button SelectDIR;
        private System.Windows.Forms.Button ChoisePICs;
        private System.Windows.Forms.Button Cap2;
        private System.Windows.Forms.TextBox fileStr1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VehicleID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fileStr2;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

