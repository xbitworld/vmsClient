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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.PICsList = new System.Windows.Forms.ImageList(this.components);
            this.listViewPICs = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::VmsClientDemo.Properties.Resources._1454046538594;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, -2);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(619, 587);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Confirm
            // 
            this.Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm.Location = new System.Drawing.Point(733, 539);
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
            this.AmountTextbox.Location = new System.Drawing.Point(651, 543);
            this.AmountTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(68, 21);
            this.AmountTextbox.TabIndex = 3;
            this.AmountTextbox.Text = "0";
            this.AmountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PICsList
            // 
            this.PICsList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.PICsList.ImageSize = new System.Drawing.Size(160, 120);
            this.PICsList.TransparentColor = System.Drawing.Color.Empty;
            // 
            // listViewPICs
            // 
            this.listViewPICs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPICs.CheckBoxes = true;
            this.listViewPICs.Location = new System.Drawing.Point(623, 2);
            this.listViewPICs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewPICs.MultiSelect = false;
            this.listViewPICs.Name = "listViewPICs";
            this.listViewPICs.Size = new System.Drawing.Size(223, 519);
            this.listViewPICs.TabIndex = 4;
            this.listViewPICs.UseCompatibleStateImageBehavior = false;
            this.listViewPICs.SelectedIndexChanged += new System.EventHandler(this.listViewPICs_SelectedIndexChanged);
            // 
            // UCPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewPICs);
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCPreview";
            this.Size = new System.Drawing.Size(847, 585);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.ImageList PICsList;
        private System.Windows.Forms.ListView listViewPICs;
    }
}
