namespace GDMAPSM.报备流程
{
    partial class AddModelForm
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
            this.LX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PCBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YPSN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton_addyp = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_ypClear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_DJSJ = new System.Windows.Forms.DateTimePicker();
            this.BZ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LX
            // 
            this.LX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LX.FormattingEnabled = true;
            this.LX.Items.AddRange(new object[] {
            "新增",
            "变更",
            "销毁"});
            this.LX.Location = new System.Drawing.Point(113, 21);
            this.LX.Name = "LX";
            this.LX.Size = new System.Drawing.Size(230, 22);
            this.LX.TabIndex = 0;
            this.LX.SelectedIndexChanged += new System.EventHandler(this.LX_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型";
            // 
            // PCBH
            // 
            this.PCBH.Location = new System.Drawing.Point(113, 63);
            this.PCBH.Name = "PCBH";
            this.PCBH.ReadOnly = true;
            this.PCBH.Size = new System.Drawing.Size(230, 22);
            this.PCBH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "计算机编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "硬盘序列号";
            // 
            // YPSN
            // 
            this.YPSN.Location = new System.Drawing.Point(113, 105);
            this.YPSN.Multiline = true;
            this.YPSN.Name = "YPSN";
            this.YPSN.ReadOnly = true;
            this.YPSN.Size = new System.Drawing.Size(230, 60);
            this.YPSN.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "部门";
            // 
            // simpleButton_addyp
            // 
            this.simpleButton_addyp.Location = new System.Drawing.Point(349, 105);
            this.simpleButton_addyp.Name = "simpleButton_addyp";
            this.simpleButton_addyp.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_addyp.TabIndex = 9;
            this.simpleButton_addyp.Text = "添加";
            // 
            // simpleButton_ypClear
            // 
            this.simpleButton_ypClear.Location = new System.Drawing.Point(349, 142);
            this.simpleButton_ypClear.Name = "simpleButton_ypClear";
            this.simpleButton_ypClear.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_ypClear.TabIndex = 10;
            this.simpleButton_ypClear.Text = "清空";
            this.simpleButton_ypClear.Click += new System.EventHandler(this.simpleButton_ypClear_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(353, 285);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "添加";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "时间";
            // 
            // dateTimePicker_DJSJ
            // 
            this.dateTimePicker_DJSJ.Location = new System.Drawing.Point(113, 193);
            this.dateTimePicker_DJSJ.Name = "dateTimePicker_DJSJ";
            this.dateTimePicker_DJSJ.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker_DJSJ.TabIndex = 13;
            // 
            // BZ
            // 
            this.BZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BZ.FormattingEnabled = true;
            this.BZ.Items.AddRange(new object[] {
            "数据部",
            "研发部",
            "制图部",
            "地图室",
            "技术质量科",
            "综合计划科"});
            this.BZ.Location = new System.Drawing.Point(113, 248);
            this.BZ.Name = "BZ";
            this.BZ.Size = new System.Drawing.Size(230, 22);
            this.BZ.TabIndex = 24;
            // 
            // AddModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.BZ);
            this.Controls.Add(this.dateTimePicker_DJSJ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton_ypClear);
            this.Controls.Add(this.simpleButton_addyp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.YPSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PCBH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LX);
            this.Name = "AddModelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.AddPCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PCBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YPSN;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton_addyp;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ypClear;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DJSJ;
        private System.Windows.Forms.ComboBox BZ;
    }
}