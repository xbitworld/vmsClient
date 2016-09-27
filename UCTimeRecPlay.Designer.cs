namespace VmsClientDemo
{
    partial class UCTimeRecPlay
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
            this.lblCamName = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartPlay = new System.Windows.Forms.Button();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.btnStopPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCamName
            // 
            this.lblCamName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCamName.Location = new System.Drawing.Point(18, 18);
            this.lblCamName.Name = "lblCamName";
            this.lblCamName.Size = new System.Drawing.Size(192, 23);
            this.lblCamName.TabIndex = 8;
            this.lblCamName.Text = "视频通道";
            this.lblCamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(342, 19);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(166, 21);
            this.dtpTime.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "事后查报警记录时播放报警前后10秒: 根据报警记录的时间点，向前10秒开始播放，播放20秒就停止";
            // 
            // btnStartPlay
            // 
            this.btnStartPlay.Location = new System.Drawing.Point(523, 18);
            this.btnStartPlay.Name = "btnStartPlay";
            this.btnStartPlay.Size = new System.Drawing.Size(93, 23);
            this.btnStartPlay.TabIndex = 11;
            this.btnStartPlay.Text = "播放录像";
            this.btnStartPlay.UseVisualStyleBackColor = true;
            this.btnStartPlay.Click += new System.EventHandler(this.btnStartPlay_Click);
            // 
            // panelVideo
            // 
            this.panelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVideo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelVideo.Location = new System.Drawing.Point(3, 79);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(822, 541);
            this.panelVideo.TabIndex = 12;
            // 
            // btnStopPlay
            // 
            this.btnStopPlay.Location = new System.Drawing.Point(632, 18);
            this.btnStopPlay.Name = "btnStopPlay";
            this.btnStopPlay.Size = new System.Drawing.Size(93, 23);
            this.btnStopPlay.TabIndex = 11;
            this.btnStopPlay.Text = "停止播放";
            this.btnStopPlay.UseVisualStyleBackColor = true;
            this.btnStopPlay.Click += new System.EventHandler(this.btnStopPlay_Click);
            // 
            // UCTimeRecPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.btnStopPlay);
            this.Controls.Add(this.btnStartPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblCamName);
            this.Name = "UCTimeRecPlay";
            this.Size = new System.Drawing.Size(830, 631);
            this.Load += new System.EventHandler(this.UCTimeRecPlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCamName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartPlay;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Button btnStopPlay;
    }
}
