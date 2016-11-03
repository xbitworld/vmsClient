namespace VmsClientDemo
{
    partial class UCRealVideo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPlayVideo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnZoom2 = new System.Windows.Forms.Button();
            this.btnZoom1 = new System.Windows.Forms.Button();
            this.nudPresetNo = new System.Windows.Forms.NumericUpDown();
            this.btnSetPreset = new System.Windows.Forms.Button();
            this.btnCallPreset = new System.Windows.Forms.Button();
            this.btnCapturePic = new System.Windows.Forms.Button();
            this.TimerLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPresetNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "视频通道";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "主码流",
            "子码流"});
            this.comboBox1.Location = new System.Drawing.Point(339, 28);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // btnPlayVideo
            // 
            this.btnPlayVideo.Location = new System.Drawing.Point(531, 27);
            this.btnPlayVideo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayVideo.Name = "btnPlayVideo";
            this.btnPlayVideo.Size = new System.Drawing.Size(112, 34);
            this.btnPlayVideo.TabIndex = 2;
            this.btnPlayVideo.Text = "播放视频";
            this.btnPlayVideo.UseVisualStyleBackColor = true;
            this.btnPlayVideo.Click += new System.EventHandler(this.btnPlayVideo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(6, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 723);
            this.panel1.TabIndex = 3;
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUp.Location = new System.Drawing.Point(28, 818);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 34);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "上";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            this.btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseUp);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDown.Location = new System.Drawing.Point(98, 818);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 34);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "下";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseDown);
            this.btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeft.Location = new System.Drawing.Point(166, 818);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 34);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRight.Location = new System.Drawing.Point(236, 818);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 34);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnZoom2
            // 
            this.btnZoom2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoom2.Location = new System.Drawing.Point(304, 818);
            this.btnZoom2.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoom2.Name = "btnZoom2";
            this.btnZoom2.Size = new System.Drawing.Size(60, 34);
            this.btnZoom2.TabIndex = 4;
            this.btnZoom2.Text = "拉近";
            this.btnZoom2.UseVisualStyleBackColor = true;
            this.btnZoom2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoom1_MouseDown);
            this.btnZoom2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoom1_MouseUp);
            // 
            // btnZoom1
            // 
            this.btnZoom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoom1.Location = new System.Drawing.Point(374, 818);
            this.btnZoom1.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoom1.Name = "btnZoom1";
            this.btnZoom1.Size = new System.Drawing.Size(60, 34);
            this.btnZoom1.TabIndex = 4;
            this.btnZoom1.Text = "拉远";
            this.btnZoom1.UseVisualStyleBackColor = true;
            this.btnZoom1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoom2_MouseDown);
            this.btnZoom1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoom2_MouseUp);
            // 
            // nudPresetNo
            // 
            this.nudPresetNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudPresetNo.Location = new System.Drawing.Point(590, 820);
            this.nudPresetNo.Margin = new System.Windows.Forms.Padding(4);
            this.nudPresetNo.Name = "nudPresetNo";
            this.nudPresetNo.Size = new System.Drawing.Size(80, 28);
            this.nudPresetNo.TabIndex = 5;
            // 
            // btnSetPreset
            // 
            this.btnSetPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetPreset.Location = new System.Drawing.Point(468, 818);
            this.btnSetPreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPreset.Name = "btnSetPreset";
            this.btnSetPreset.Size = new System.Drawing.Size(112, 34);
            this.btnSetPreset.TabIndex = 6;
            this.btnSetPreset.Text = "设置预置位";
            this.btnSetPreset.UseVisualStyleBackColor = true;
            this.btnSetPreset.Click += new System.EventHandler(this.btnSetPreset_Click);
            // 
            // btnCallPreset
            // 
            this.btnCallPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCallPreset.Location = new System.Drawing.Point(678, 818);
            this.btnCallPreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnCallPreset.Name = "btnCallPreset";
            this.btnCallPreset.Size = new System.Drawing.Size(112, 34);
            this.btnCallPreset.TabIndex = 6;
            this.btnCallPreset.Text = "调用预置位";
            this.btnCallPreset.UseVisualStyleBackColor = true;
            this.btnCallPreset.Click += new System.EventHandler(this.btnCallPreset_Click);
            // 
            // btnCapturePic
            // 
            this.btnCapturePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturePic.Location = new System.Drawing.Point(863, 820);
            this.btnCapturePic.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturePic.Name = "btnCapturePic";
            this.btnCapturePic.Size = new System.Drawing.Size(112, 34);
            this.btnCapturePic.TabIndex = 7;
            this.btnCapturePic.Text = "抓图";
            this.btnCapturePic.UseVisualStyleBackColor = true;
            this.btnCapturePic.Visible = false;
            this.btnCapturePic.Click += new System.EventHandler(this.btnCapturePic_Click);
            // 
            // TimerLable
            // 
            this.TimerLable.AutoSize = true;
            this.TimerLable.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerLable.ForeColor = System.Drawing.Color.Brown;
            this.TimerLable.Location = new System.Drawing.Point(933, 17);
            this.TimerLable.Name = "TimerLable";
            this.TimerLable.Size = new System.Drawing.Size(42, 44);
            this.TimerLable.TabIndex = 8;
            this.TimerLable.Text = "0";
            // 
            // UCRealVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimerLable);
            this.Controls.Add(this.btnCapturePic);
            this.Controls.Add(this.btnCallPreset);
            this.Controls.Add(this.btnSetPreset);
            this.Controls.Add(this.nudPresetNo);
            this.Controls.Add(this.btnZoom1);
            this.Controls.Add(this.btnZoom2);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlayVideo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCRealVideo";
            this.Size = new System.Drawing.Size(1030, 872);
            this.Load += new System.EventHandler(this.UCRealVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPresetNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPlayVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPresetNo;
        private System.Windows.Forms.Button btnCallPreset;
        private System.Windows.Forms.Button btnCapturePic;
        public System.Windows.Forms.Button btnSetPreset;
        private System.Windows.Forms.Label TimerLable;
        public System.Windows.Forms.Button btnUp;
        public System.Windows.Forms.Button btnDown;
        public System.Windows.Forms.Button btnLeft;
        public System.Windows.Forms.Button btnRight;
        public System.Windows.Forms.Button btnZoom2;
        public System.Windows.Forms.Button btnZoom1;
    }
}
