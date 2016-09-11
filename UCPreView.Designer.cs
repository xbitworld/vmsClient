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
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.PICsList = new System.Windows.Forms.ImageList(this.components);
            this.listViewPICs = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxALL = new System.Windows.Forms.CheckBox();
            this.BlockPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.BlockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::VmsClientDemo.Properties.Resources._1454046538594;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(928, 880);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            this.pictureBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseWheel);
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextbox.Location = new System.Drawing.Point(242, 2);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(100, 28);
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
            this.listViewPICs.Location = new System.Drawing.Point(9, 39);
            this.listViewPICs.MultiSelect = false;
            this.listViewPICs.Name = "listViewPICs";
            this.listViewPICs.Size = new System.Drawing.Size(332, 835);
            this.listViewPICs.TabIndex = 4;
            this.listViewPICs.UseCompatibleStateImageBehavior = false;
            this.listViewPICs.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewPICs_ItemChecked);
            this.listViewPICs.SelectedIndexChanged += new System.EventHandler(this.listViewPICs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择总数：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxALL
            // 
            this.checkBoxALL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxALL.AutoSize = true;
            this.checkBoxALL.Location = new System.Drawing.Point(41, 8);
            this.checkBoxALL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxALL.Name = "checkBoxALL";
            this.checkBoxALL.Size = new System.Drawing.Size(70, 22);
            this.checkBoxALL.TabIndex = 6;
            this.checkBoxALL.Text = "全选";
            this.checkBoxALL.UseVisualStyleBackColor = true;
            this.checkBoxALL.CheckedChanged += new System.EventHandler(this.checkBoxALL_CheckedChanged);
            // 
            // BlockPanel
            // 
            this.BlockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockPanel.BackColor = System.Drawing.SystemColors.Control;
            this.BlockPanel.Controls.Add(this.checkBoxALL);
            this.BlockPanel.Controls.Add(this.listViewPICs);
            this.BlockPanel.Controls.Add(this.AmountTextbox);
            this.BlockPanel.Controls.Add(this.label1);
            this.BlockPanel.Location = new System.Drawing.Point(926, 0);
            this.BlockPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlockPanel.Name = "BlockPanel";
            this.BlockPanel.Size = new System.Drawing.Size(345, 878);
            this.BlockPanel.TabIndex = 7;
            // 
            // UCPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BlockPanel);
            this.Controls.Add(this.pictureBox);
            this.Name = "UCPreview";
            this.Size = new System.Drawing.Size(1270, 878);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.BlockPanel.ResumeLayout(false);
            this.BlockPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.ImageList PICsList;
        private System.Windows.Forms.ListView listViewPICs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxALL;
        private System.Windows.Forms.Panel BlockPanel;
    }
}
