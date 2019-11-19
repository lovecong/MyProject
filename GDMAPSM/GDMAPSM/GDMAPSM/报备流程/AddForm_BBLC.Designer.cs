namespace GDMAPSM.报备流程
{
    partial class AddForm_BBLC
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZT = new System.Windows.Forms.ComboBox();
            this.BZ = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Etime = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Stime = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.JBR = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainer1.Size = new System.Drawing.Size(440, 320);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ZT);
            this.panel1.Controls.Add(this.BZ);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.Etime);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.Stime);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.JBR);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 268);
            this.panel1.TabIndex = 3;
            // 
            // ZT
            // 
            this.ZT.FormattingEnabled = true;
            this.ZT.Items.AddRange(new object[] {
            "登记",
            "办理",
            "完成"});
            this.ZT.Location = new System.Drawing.Point(282, 35);
            this.ZT.Name = "ZT";
            this.ZT.Size = new System.Drawing.Size(137, 22);
            this.ZT.TabIndex = 14;
            // 
            // BZ
            // 
            this.BZ.Location = new System.Drawing.Point(12, 135);
            this.BZ.Multiline = true;
            this.BZ.Name = "BZ";
            this.BZ.Size = new System.Drawing.Size(412, 130);
            this.BZ.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "备注：";
            // 
            // Etime
            // 
            this.Etime.Location = new System.Drawing.Point(284, 84);
            this.Etime.Name = "Etime";
            this.Etime.Size = new System.Drawing.Size(137, 22);
            this.Etime.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(220, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "办结时间：";
            // 
            // Stime
            // 
            this.Stime.Location = new System.Drawing.Point(73, 84);
            this.Stime.Name = "Stime";
            this.Stime.Size = new System.Drawing.Size(137, 22);
            this.Stime.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "办理时间：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(228, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "状态：";
            // 
            // JBR
            // 
            this.JBR.Location = new System.Drawing.Point(73, 34);
            this.JBR.Name = "JBR";
            this.JBR.Size = new System.Drawing.Size(135, 22);
            this.JBR.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "经办人：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(346, 16);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "下一步";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // AddForm_BBLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddForm_BBLC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加报备流程";
            this.Load += new System.EventHandler(this.AddForm_BBLC_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ZT;
        private System.Windows.Forms.TextBox BZ;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker Etime;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker Stime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox JBR;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}