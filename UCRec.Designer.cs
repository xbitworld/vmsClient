namespace VmsClientDemo
{
    partial class UCRec
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
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListView();
            this.columnHeaderFiename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelVideo = new System.Windows.Forms.Panel();
            this._seekBar_video_playback = new System.Windows.Forms.TrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.dtpTime1 = new System.Windows.Forms.DateTimePicker();
            this.dtpTime2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCamName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.btnPlayRec = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSelRec = new System.Windows.Forms.Label();
            this.btnCapturePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._seekBar_video_playback)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(268, 19);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(127, 21);
            this.dtpDay.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(626, 18);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lstRecords
            // 
            this.lstRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFiename,
            this.columnHeaderDateTime,
            this.columnHeaderState});
            this.lstRecords.Location = new System.Drawing.Point(3, 44);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(852, 164);
            this.lstRecords.TabIndex = 3;
            this.lstRecords.UseCompatibleStateImageBehavior = false;
            this.lstRecords.View = System.Windows.Forms.View.Details;
            this.lstRecords.SelectedIndexChanged += new System.EventHandler(this.lstRecords_SelectedIndexChanged);
            this.lstRecords.DoubleClick += new System.EventHandler(this.PlayRec);
            // 
            // columnHeaderFiename
            // 
            this.columnHeaderFiename.Text = "录像文件";
            this.columnHeaderFiename.Width = 441;
            // 
            // columnHeaderDateTime
            // 
            this.columnHeaderDateTime.Text = "时间";
            this.columnHeaderDateTime.Width = 217;
            // 
            // columnHeaderState
            // 
            this.columnHeaderState.Text = "状态";
            this.columnHeaderState.Width = 156;
            // 
            // panelVideo
            // 
            this.panelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVideo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelVideo.Location = new System.Drawing.Point(4, 214);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(697, 416);
            this.panelVideo.TabIndex = 4;
            // 
            // _seekBar_video_playback
            // 
            this._seekBar_video_playback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._seekBar_video_playback.Location = new System.Drawing.Point(4, 637);
            this._seekBar_video_playback.Name = "_seekBar_video_playback";
            this._seekBar_video_playback.Size = new System.Drawing.Size(697, 45);
            this._seekBar_video_playback.TabIndex = 5;
            this._seekBar_video_playback.ValueChanged += new System.EventHandler(this._seekBar_video_playback_ValueChanged);
            this._seekBar_video_playback.MouseDown += new System.Windows.Forms.MouseEventHandler(this._seekBar_video_playback_MouseDown);
            this._seekBar_video_playback.MouseUp += new System.Windows.Forms.MouseEventHandler(this._seekBar_video_playback_MouseUp);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(30, 32);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "常速";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(30, 61);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(75, 23);
            this.btnFast.TabIndex = 6;
            this.btnFast.Text = "快进";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(30, 90);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(75, 23);
            this.btnSlow.TabIndex = 6;
            this.btnSlow.Text = "慢进";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(30, 119);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 23);
            this.btnStep.TabIndex = 6;
            this.btnStep.Text = "单步";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(30, 148);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // dtpTime1
            // 
            this.dtpTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime1.Location = new System.Drawing.Point(401, 19);
            this.dtpTime1.Name = "dtpTime1";
            this.dtpTime1.Size = new System.Drawing.Size(92, 21);
            this.dtpTime1.TabIndex = 1;
            // 
            // dtpTime2
            // 
            this.dtpTime2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime2.Location = new System.Drawing.Point(514, 19);
            this.dtpTime2.Name = "dtpTime2";
            this.dtpTime2.Size = new System.Drawing.Size(95, 21);
            this.dtpTime2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "-";
            // 
            // lblCamName
            // 
            this.lblCamName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCamName.Location = new System.Drawing.Point(18, 18);
            this.lblCamName.Name = "lblCamName";
            this.lblCamName.Size = new System.Drawing.Size(192, 23);
            this.lblCamName.TabIndex = 7;
            this.lblCamName.Text = "视频通道";
            this.lblCamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnFast);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Controls.Add(this.btnSlow);
            this.groupBox1.Controls.Add(this.btnStep);
            this.groupBox1.Location = new System.Drawing.Point(711, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlayTime.Location = new System.Drawing.Point(707, 637);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(144, 23);
            this.lblPlayTime.TabIndex = 9;
            this.lblPlayTime.Text = "label3";
            this.lblPlayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayRec
            // 
            this.btnPlayRec.Location = new System.Drawing.Point(30, 136);
            this.btnPlayRec.Name = "btnPlayRec";
            this.btnPlayRec.Size = new System.Drawing.Size(75, 27);
            this.btnPlayRec.TabIndex = 10;
            this.btnPlayRec.Text = "播放录像";
            this.btnPlayRec.UseVisualStyleBackColor = true;
            this.btnPlayRec.Click += new System.EventHandler(this.btnPlayRec_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSelRec);
            this.groupBox2.Controls.Add(this.btnPlayRec);
            this.groupBox2.Location = new System.Drawing.Point(711, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 169);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选中的录像";
            // 
            // lblSelRec
            // 
            this.lblSelRec.Location = new System.Drawing.Point(6, 27);
            this.lblSelRec.Name = "lblSelRec";
            this.lblSelRec.Size = new System.Drawing.Size(128, 106);
            this.lblSelRec.TabIndex = 11;
            this.lblSelRec.Text = "选中的录像";
            // 
            // btnCapturePic
            // 
            this.btnCapturePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapturePic.Location = new System.Drawing.Point(782, 18);
            this.btnCapturePic.Name = "btnCapturePic";
            this.btnCapturePic.Size = new System.Drawing.Size(75, 23);
            this.btnCapturePic.TabIndex = 12;
            this.btnCapturePic.Text = "抓图";
            this.btnCapturePic.UseVisualStyleBackColor = true;
            this.btnCapturePic.Visible = false;
            this.btnCapturePic.Click += new System.EventHandler(this.CapturePIC);
            // 
            // UCRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapturePic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPlayTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCamName);
            this.Controls.Add(this._seekBar_video_playback);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dtpTime2);
            this.Controls.Add(this.dtpTime1);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCRec";
            this.Size = new System.Drawing.Size(874, 689);
            ((System.ComponentModel.ISupportInitialize)(this._seekBar_video_playback)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ListView lstRecords;
        private System.Windows.Forms.ColumnHeader columnHeaderFiename;
        private System.Windows.Forms.ColumnHeader columnHeaderDateTime;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.TrackBar _seekBar_video_playback;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.DateTimePicker dtpTime1;
        private System.Windows.Forms.DateTimePicker dtpTime2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCamName;
        private System.Windows.Forms.ColumnHeader columnHeaderState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.Button btnPlayRec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSelRec;
        private System.Windows.Forms.Button btnCapturePic;
    }
}
