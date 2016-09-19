namespace VmsClientDemo
{
    partial class RulesUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirCOMB = new System.Windows.Forms.ComboBox();
            this.rulesCOMB = new System.Windows.Forms.ComboBox();
            this.AddDel = new System.Windows.Forms.Button();
            this.IDOK = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.DirCOMB);
            this.groupBox5.Controls.Add(this.rulesCOMB);
            this.groupBox5.Controls.Add(this.AddDel);
            this.groupBox5.Location = new System.Drawing.Point(33, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 154);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "违章信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "方向：";
            // 
            // DirCOMB
            // 
            this.DirCOMB.FormattingEnabled = true;
            this.DirCOMB.Location = new System.Drawing.Point(74, 44);
            this.DirCOMB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DirCOMB.Name = "DirCOMB";
            this.DirCOMB.Size = new System.Drawing.Size(79, 26);
            this.DirCOMB.TabIndex = 21;
            this.DirCOMB.Text = "西南";
            this.DirCOMB.SelectedIndexChanged += new System.EventHandler(this.DirCOMB_SelectedIndexChanged);
            // 
            // rulesCOMB
            // 
            this.rulesCOMB.FormattingEnabled = true;
            this.rulesCOMB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rulesCOMB.Location = new System.Drawing.Point(6, 90);
            this.rulesCOMB.Name = "rulesCOMB";
            this.rulesCOMB.Size = new System.Drawing.Size(362, 26);
            this.rulesCOMB.TabIndex = 7;
            this.rulesCOMB.SelectedIndexChanged += new System.EventHandler(this.rulesCOMB_SelectedIndexChanged);
            // 
            // AddDel
            // 
            this.AddDel.Location = new System.Drawing.Point(303, 44);
            this.AddDel.Name = "AddDel";
            this.AddDel.Size = new System.Drawing.Size(68, 30);
            this.AddDel.TabIndex = 6;
            this.AddDel.Text = "+";
            this.AddDel.UseVisualStyleBackColor = true;
            this.AddDel.Click += new System.EventHandler(this.AddDel_Click);
            // 
            // IDOK
            // 
            this.IDOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.IDOK.Location = new System.Drawing.Point(306, 178);
            this.IDOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDOK.Name = "IDOK";
            this.IDOK.Size = new System.Drawing.Size(112, 34);
            this.IDOK.TabIndex = 10;
            this.IDOK.Text = "确认";
            this.IDOK.UseVisualStyleBackColor = true;
            this.IDOK.Click += new System.EventHandler(this.IDOK_Click);
            // 
            // RulesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 230);
            this.Controls.Add(this.IDOK);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RulesUI";
            this.Text = "违章信息维护";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox rulesCOMB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DirCOMB;
        private System.Windows.Forms.Button AddDel;
        private System.Windows.Forms.Button IDOK;
    }
}