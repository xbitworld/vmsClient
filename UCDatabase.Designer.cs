namespace VmsClientDemo
{
    partial class UCDatabase
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.modRoad = new System.Windows.Forms.Button();
            this.roadCOMB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roadCode = new System.Windows.Forms.TextBox();
            this.roadName = new System.Windows.Forms.TextBox();
            this.addRoad = new System.Windows.Forms.Button();
            this.delRoad = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.secName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secCOMB = new System.Windows.Forms.ComboBox();
            this.delSection = new System.Windows.Forms.Button();
            this.addSection = new System.Windows.Forms.Button();
            this.modSection = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.posCode = new System.Windows.Forms.TextBox();
            this.posName = new System.Windows.Forms.TextBox();
            this.posCOMB = new System.Windows.Forms.ComboBox();
            this.delPos = new System.Windows.Forms.Button();
            this.addPos = new System.Windows.Forms.Button();
            this.modPos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CAMCodeBox = new System.Windows.Forms.TextBox();
            this.CamNameBox = new System.Windows.Forms.Label();
            this.ADDCamera = new System.Windows.Forms.Button();
            this.ModifyCAM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.posCodeBox = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.方向信息 = new System.Windows.Forms.GroupBox();
            this.dirCMB = new System.Windows.Forms.ComboBox();
            this.prePosCMB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.devDirCMB = new System.Windows.Forms.ComboBox();
            this.DelDirBT = new System.Windows.Forms.Button();
            this.AddDirBT = new System.Windows.Forms.Button();
            this.AngelBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.方向信息.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(72, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "摄像机名称：";
            // 
            // modRoad
            // 
            this.modRoad.Location = new System.Drawing.Point(222, 171);
            this.modRoad.Name = "modRoad";
            this.modRoad.Size = new System.Drawing.Size(68, 30);
            this.modRoad.TabIndex = 6;
            this.modRoad.Text = "改";
            this.modRoad.UseVisualStyleBackColor = true;
            this.modRoad.Click += new System.EventHandler(this.modRoad_Click);
            // 
            // roadCOMB
            // 
            this.roadCOMB.FormattingEnabled = true;
            this.roadCOMB.Location = new System.Drawing.Point(9, 44);
            this.roadCOMB.Name = "roadCOMB";
            this.roadCOMB.Size = new System.Drawing.Size(278, 26);
            this.roadCOMB.TabIndex = 7;
            this.roadCOMB.SelectedIndexChanged += new System.EventHandler(this.roadCOMB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.roadCode);
            this.groupBox1.Controls.Add(this.roadName);
            this.groupBox1.Controls.Add(this.roadCOMB);
            this.groupBox1.Controls.Add(this.addRoad);
            this.groupBox1.Controls.Add(this.delRoad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.modRoad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 314);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "道路名称";
            // 
            // roadCode
            // 
            this.roadCode.Location = new System.Drawing.Point(96, 124);
            this.roadCode.Name = "roadCode";
            this.roadCode.Size = new System.Drawing.Size(192, 28);
            this.roadCode.TabIndex = 9;
            // 
            // roadName
            // 
            this.roadName.Location = new System.Drawing.Point(96, 86);
            this.roadName.Name = "roadName";
            this.roadName.Size = new System.Drawing.Size(192, 28);
            this.roadName.TabIndex = 9;
            // 
            // addRoad
            // 
            this.addRoad.Location = new System.Drawing.Point(22, 171);
            this.addRoad.Name = "addRoad";
            this.addRoad.Size = new System.Drawing.Size(68, 30);
            this.addRoad.TabIndex = 6;
            this.addRoad.Text = "+";
            this.addRoad.UseVisualStyleBackColor = true;
            this.addRoad.Click += new System.EventHandler(this.addRoad_Click);
            // 
            // delRoad
            // 
            this.delRoad.Location = new System.Drawing.Point(96, 171);
            this.delRoad.Name = "delRoad";
            this.delRoad.Size = new System.Drawing.Size(68, 30);
            this.delRoad.TabIndex = 6;
            this.delRoad.Text = "-";
            this.delRoad.UseVisualStyleBackColor = true;
            this.delRoad.Click += new System.EventHandler(this.delRoad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "道路编码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "道路名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.secCode);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.secName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.secCOMB);
            this.groupBox2.Controls.Add(this.delSection);
            this.groupBox2.Controls.Add(this.addSection);
            this.groupBox2.Controls.Add(this.modSection);
            this.groupBox2.Location = new System.Drawing.Point(358, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 314);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "路段名称";
            // 
            // secCode
            // 
            this.secCode.Location = new System.Drawing.Point(93, 124);
            this.secCode.Name = "secCode";
            this.secCode.Size = new System.Drawing.Size(188, 28);
            this.secCode.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "路段编码：";
            // 
            // secName
            // 
            this.secName.Location = new System.Drawing.Point(92, 86);
            this.secName.Name = "secName";
            this.secName.Size = new System.Drawing.Size(188, 28);
            this.secName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "路段名称：";
            // 
            // secCOMB
            // 
            this.secCOMB.FormattingEnabled = true;
            this.secCOMB.Location = new System.Drawing.Point(9, 44);
            this.secCOMB.Name = "secCOMB";
            this.secCOMB.Size = new System.Drawing.Size(272, 26);
            this.secCOMB.TabIndex = 7;
            this.secCOMB.SelectedIndexChanged += new System.EventHandler(this.secCOMB_SelectedIndexChanged);
            // 
            // delSection
            // 
            this.delSection.Location = new System.Drawing.Point(92, 171);
            this.delSection.Name = "delSection";
            this.delSection.Size = new System.Drawing.Size(68, 30);
            this.delSection.TabIndex = 6;
            this.delSection.Text = "-";
            this.delSection.UseVisualStyleBackColor = true;
            this.delSection.Click += new System.EventHandler(this.delSection_Click);
            // 
            // addSection
            // 
            this.addSection.Location = new System.Drawing.Point(18, 171);
            this.addSection.Name = "addSection";
            this.addSection.Size = new System.Drawing.Size(68, 30);
            this.addSection.TabIndex = 6;
            this.addSection.Text = "+";
            this.addSection.UseVisualStyleBackColor = true;
            this.addSection.Click += new System.EventHandler(this.addSection_Click);
            // 
            // modSection
            // 
            this.modSection.Location = new System.Drawing.Point(214, 171);
            this.modSection.Name = "modSection";
            this.modSection.Size = new System.Drawing.Size(68, 30);
            this.modSection.TabIndex = 6;
            this.modSection.Text = "改";
            this.modSection.UseVisualStyleBackColor = true;
            this.modSection.Click += new System.EventHandler(this.modSection_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.posCode);
            this.groupBox3.Controls.Add(this.posName);
            this.groupBox3.Controls.Add(this.posCOMB);
            this.groupBox3.Controls.Add(this.delPos);
            this.groupBox3.Controls.Add(this.addPos);
            this.groupBox3.Controls.Add(this.modPos);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(690, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 314);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "路口名称";
            // 
            // posCode
            // 
            this.posCode.Location = new System.Drawing.Point(94, 124);
            this.posCode.Name = "posCode";
            this.posCode.Size = new System.Drawing.Size(196, 28);
            this.posCode.TabIndex = 9;
            // 
            // posName
            // 
            this.posName.Location = new System.Drawing.Point(94, 86);
            this.posName.Name = "posName";
            this.posName.Size = new System.Drawing.Size(196, 28);
            this.posName.TabIndex = 9;
            // 
            // posCOMB
            // 
            this.posCOMB.FormattingEnabled = true;
            this.posCOMB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.posCOMB.Location = new System.Drawing.Point(9, 44);
            this.posCOMB.Name = "posCOMB";
            this.posCOMB.Size = new System.Drawing.Size(282, 26);
            this.posCOMB.TabIndex = 7;
            this.posCOMB.SelectedIndexChanged += new System.EventHandler(this.posCOMB_SelectedIndexChanged);
            // 
            // delPos
            // 
            this.delPos.Location = new System.Drawing.Point(94, 171);
            this.delPos.Name = "delPos";
            this.delPos.Size = new System.Drawing.Size(68, 30);
            this.delPos.TabIndex = 6;
            this.delPos.Text = "-";
            this.delPos.UseVisualStyleBackColor = true;
            this.delPos.Click += new System.EventHandler(this.delPos_Click);
            // 
            // addPos
            // 
            this.addPos.Location = new System.Drawing.Point(22, 171);
            this.addPos.Name = "addPos";
            this.addPos.Size = new System.Drawing.Size(68, 30);
            this.addPos.TabIndex = 6;
            this.addPos.Text = "+";
            this.addPos.UseVisualStyleBackColor = true;
            this.addPos.Click += new System.EventHandler(this.addPos_Click);
            // 
            // modPos
            // 
            this.modPos.Location = new System.Drawing.Point(225, 171);
            this.modPos.Name = "modPos";
            this.modPos.Size = new System.Drawing.Size(68, 30);
            this.modPos.TabIndex = 6;
            this.modPos.Text = "改";
            this.modPos.UseVisualStyleBackColor = true;
            this.modPos.Click += new System.EventHandler(this.modPos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "路口信息：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "路口编码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(72, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "摄像机编码：";
            // 
            // CAMCodeBox
            // 
            this.CAMCodeBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CAMCodeBox.Location = new System.Drawing.Point(258, 88);
            this.CAMCodeBox.Name = "CAMCodeBox";
            this.CAMCodeBox.Size = new System.Drawing.Size(512, 39);
            this.CAMCodeBox.TabIndex = 9;
            // 
            // CamNameBox
            // 
            this.CamNameBox.AutoSize = true;
            this.CamNameBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CamNameBox.Location = new System.Drawing.Point(254, 39);
            this.CamNameBox.Name = "CamNameBox";
            this.CamNameBox.Size = new System.Drawing.Size(432, 28);
            this.CamNameBox.TabIndex = 4;
            this.CamNameBox.Text = "摄像机名称摄像机名称摄像机名称";
            // 
            // ADDCamera
            // 
            this.ADDCamera.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADDCamera.Location = new System.Drawing.Point(558, 147);
            this.ADDCamera.Name = "ADDCamera";
            this.ADDCamera.Size = new System.Drawing.Size(99, 39);
            this.ADDCamera.TabIndex = 10;
            this.ADDCamera.Text = "+";
            this.ADDCamera.UseVisualStyleBackColor = true;
            this.ADDCamera.Click += new System.EventHandler(this.ADDCamera_Click);
            // 
            // ModifyCAM
            // 
            this.ModifyCAM.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ModifyCAM.Location = new System.Drawing.Point(672, 146);
            this.ModifyCAM.Name = "ModifyCAM";
            this.ModifyCAM.Size = new System.Drawing.Size(99, 39);
            this.ModifyCAM.TabIndex = 10;
            this.ModifyCAM.Text = "改";
            this.ModifyCAM.UseVisualStyleBackColor = true;
            this.ModifyCAM.Click += new System.EventHandler(this.ModifyCAM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(72, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "路口点编码：";
            // 
            // posCodeBox
            // 
            this.posCodeBox.AutoSize = true;
            this.posCodeBox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.posCodeBox.Location = new System.Drawing.Point(254, 152);
            this.posCodeBox.Name = "posCodeBox";
            this.posCodeBox.Size = new System.Drawing.Size(180, 28);
            this.posCodeBox.TabIndex = 4;
            this.posCodeBox.Text = "100001000100";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(40, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1008, 374);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "关联信息";
            // 
            // 方向信息
            // 
            this.方向信息.Controls.Add(this.AngelBox);
            this.方向信息.Controls.Add(this.dirCMB);
            this.方向信息.Controls.Add(this.prePosCMB);
            this.方向信息.Controls.Add(this.label12);
            this.方向信息.Controls.Add(this.label11);
            this.方向信息.Controls.Add(this.label7);
            this.方向信息.Controls.Add(this.devDirCMB);
            this.方向信息.Controls.Add(this.DelDirBT);
            this.方向信息.Controls.Add(this.AddDirBT);
            this.方向信息.Location = new System.Drawing.Point(797, 16);
            this.方向信息.Name = "方向信息";
            this.方向信息.Size = new System.Drawing.Size(251, 226);
            this.方向信息.TabIndex = 12;
            this.方向信息.TabStop = false;
            this.方向信息.Text = "摄像机方向";
            // 
            // dirCMB
            // 
            this.dirCMB.FormattingEnabled = true;
            this.dirCMB.Items.AddRange(new object[] {
            "南",
            "西南",
            "西",
            "西北",
            "北",
            "东北",
            "东",
            "东南"});
            this.dirCMB.Location = new System.Drawing.Point(94, 138);
            this.dirCMB.Name = "dirCMB";
            this.dirCMB.Size = new System.Drawing.Size(69, 26);
            this.dirCMB.TabIndex = 4;
            // 
            // prePosCMB
            // 
            this.prePosCMB.FormattingEnabled = true;
            this.prePosCMB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.prePosCMB.Location = new System.Drawing.Point(6, 138);
            this.prePosCMB.Name = "prePosCMB";
            this.prePosCMB.Size = new System.Drawing.Size(75, 26);
            this.prePosCMB.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "方向";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "位置";
            // 
            // devDirCMB
            // 
            this.devDirCMB.FormattingEnabled = true;
            this.devDirCMB.Location = new System.Drawing.Point(20, 47);
            this.devDirCMB.Name = "devDirCMB";
            this.devDirCMB.Size = new System.Drawing.Size(216, 26);
            this.devDirCMB.TabIndex = 2;
            // 
            // DelDirBT
            // 
            this.DelDirBT.Location = new System.Drawing.Point(158, 182);
            this.DelDirBT.Name = "DelDirBT";
            this.DelDirBT.Size = new System.Drawing.Size(87, 30);
            this.DelDirBT.TabIndex = 1;
            this.DelDirBT.Text = "-";
            this.DelDirBT.UseVisualStyleBackColor = true;
            this.DelDirBT.Click += new System.EventHandler(this.DelDirBT_Click);
            // 
            // AddDirBT
            // 
            this.AddDirBT.Location = new System.Drawing.Point(6, 182);
            this.AddDirBT.Name = "AddDirBT";
            this.AddDirBT.Size = new System.Drawing.Size(89, 30);
            this.AddDirBT.TabIndex = 1;
            this.AddDirBT.Text = "+";
            this.AddDirBT.UseVisualStyleBackColor = true;
            this.AddDirBT.Click += new System.EventHandler(this.AddDirBT_Click);
            // 
            // AngelBox
            // 
            this.AngelBox.Location = new System.Drawing.Point(176, 138);
            this.AngelBox.Name = "AngelBox";
            this.AngelBox.Size = new System.Drawing.Size(69, 28);
            this.AngelBox.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "角度";
            // 
            // UCDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.方向信息);
            this.Controls.Add(this.ModifyCAM);
            this.Controls.Add(this.ADDCamera);
            this.Controls.Add(this.CAMCodeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.posCodeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CamNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDatabase";
            this.Size = new System.Drawing.Size(1092, 668);
            this.MouseEnter += new System.EventHandler(this.UCDatabase_MouseEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.方向信息.ResumeLayout(false);
            this.方向信息.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modRoad;
        private System.Windows.Forms.ComboBox roadCOMB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addRoad;
        private System.Windows.Forms.Button delRoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox secCOMB;
        private System.Windows.Forms.Button delSection;
        private System.Windows.Forms.Button addSection;
        private System.Windows.Forms.Button modSection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox posCOMB;
        private System.Windows.Forms.Button modPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delPos;
        private System.Windows.Forms.Button addPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CAMCodeBox;
        private System.Windows.Forms.Label CamNameBox;
        private System.Windows.Forms.Button ADDCamera;
        private System.Windows.Forms.Button ModifyCAM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label posCodeBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox roadCode;
        private System.Windows.Forms.TextBox roadName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox secCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox secName;
        private System.Windows.Forms.TextBox posCode;
        private System.Windows.Forms.TextBox posName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox 方向信息;
        private System.Windows.Forms.ComboBox dirCMB;
        private System.Windows.Forms.ComboBox prePosCMB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox devDirCMB;
        private System.Windows.Forms.Button DelDirBT;
        private System.Windows.Forms.Button AddDirBT;
        private System.Windows.Forms.TextBox AngelBox;
        private System.Windows.Forms.Label label12;
    }
}
