namespace VmsClientDemo
{
    partial class UCPreVideoPlay
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
            this.btnPlayPreVideo = new System.Windows.Forms.Button();
            this.lblCamName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRePlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayPreVideo
            // 
            this.btnPlayPreVideo.Location = new System.Drawing.Point(276, 18);
            this.btnPlayPreVideo.Name = "btnPlayPreVideo";
            this.btnPlayPreVideo.Size = new System.Drawing.Size(147, 23);
            this.btnPlayPreVideo.TabIndex = 0;
            this.btnPlayPreVideo.Text = "播放预录视频";
            this.btnPlayPreVideo.UseVisualStyleBackColor = true;
            this.btnPlayPreVideo.Click += new System.EventHandler(this.btnPlayPreVideo_Click);
            // 
            // lblCamName
            // 
            this.lblCamName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCamName.Location = new System.Drawing.Point(21, 21);
            this.lblCamName.Name = "lblCamName";
            this.lblCamName.Size = new System.Drawing.Size(192, 23);
            this.lblCamName.TabIndex = 1;
            this.lblCamName.Text = "视频通道";
            this.lblCamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(20, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 513);
            this.panel1.TabIndex = 2;
            // 
            // btnRePlay
            // 
            this.btnRePlay.Location = new System.Drawing.Point(451, 18);
            this.btnRePlay.Name = "btnRePlay";
            this.btnRePlay.Size = new System.Drawing.Size(147, 23);
            this.btnRePlay.TabIndex = 0;
            this.btnRePlay.Text = "重播放";
            this.btnRePlay.UseVisualStyleBackColor = true;
            this.btnRePlay.Click += new System.EventHandler(this.btnRePlay_Click);
            // 
            // UCPreVideoPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCamName);
            this.Controls.Add(this.btnRePlay);
            this.Controls.Add(this.btnPlayPreVideo);
            this.Name = "UCPreVideoPlay";
            this.Size = new System.Drawing.Size(752, 590);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayPreVideo;
        private System.Windows.Forms.Label lblCamName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRePlay;
    }
}
