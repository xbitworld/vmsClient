namespace VmsClientDemo
{
    partial class UCPreview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPreview));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.PICsList = new System.Windows.Forms.ImageList(this.components);
            this.listViewPICs = new System.Windows.Forms.ListView();
            this.ListColumnHeader_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::VmsClientDemo.Properties.Resources._1454046538594;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Confirm
            // 
            this.Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm.Location = new System.Drawing.Point(742, 539);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(66, 26);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "确定";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextbox.Location = new System.Drawing.Point(647, 542);
            this.AmountTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(68, 21);
            this.AmountTextbox.TabIndex = 3;
            this.AmountTextbox.Text = "0";
            this.AmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PICsList
            // 
            this.PICsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PICsList.ImageStream")));
            this.PICsList.TransparentColor = System.Drawing.Color.Empty;
            this.PICsList.Images.SetKeyName(0, "1454046538594.jpg");
            this.PICsList.Images.SetKeyName(1, "1454046538594.jpg");
            this.PICsList.Images.SetKeyName(2, "1454046538594.jpg");
            // 
            // listViewPICs
            // 
            this.listViewPICs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPICs.BackColor = System.Drawing.SystemColors.Control;
            this.listViewPICs.CheckBoxes = true;
            this.listViewPICs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListColumnHeader_1});
            this.listViewPICs.FullRowSelect = true;
            listViewItem1.StateImageIndex = 0;
            this.listViewPICs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewPICs.LargeImageList = this.PICsList;
            this.listViewPICs.Location = new System.Drawing.Point(618, 2);
            this.listViewPICs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewPICs.Name = "listViewPICs";
            this.listViewPICs.OwnerDraw = true;
            this.listViewPICs.Size = new System.Drawing.Size(228, 517);
            this.listViewPICs.SmallImageList = this.PICsList;
            this.listViewPICs.TabIndex = 0;
            this.listViewPICs.UseCompatibleStateImageBehavior = false;
            this.listViewPICs.View = System.Windows.Forms.View.List;
            // 
            // ListColumnHeader_1
            // 
            this.ListColumnHeader_1.Text = "截图列表";
            this.ListColumnHeader_1.Width = 350;
            // 
            // UCPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewPICs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCPreview";
            this.Size = new System.Drawing.Size(847, 585);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.ImageList PICsList;
        private System.Windows.Forms.ListView listViewPICs;
        private System.Windows.Forms.ColumnHeader ListColumnHeader_1;
    }
}
