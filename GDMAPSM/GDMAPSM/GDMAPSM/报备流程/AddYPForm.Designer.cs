namespace GDMAPSM
{
    partial class AddYPForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GMSJ = new System.Windows.Forms.DateTimePicker();
            this.ZT = new System.Windows.Forms.TextBox();
            this.simpleButton_add = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SYQK = new System.Windows.Forms.ComboBox();
            this.BZ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BDJSJ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GMSJ);
            this.groupBox1.Controls.Add(this.ZT);
            this.groupBox1.Controls.Add(this.simpleButton_add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SYQK);
            this.groupBox1.Controls.Add(this.BZ);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.LX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BDJSJ);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 371);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // GMSJ
            // 
            this.GMSJ.Location = new System.Drawing.Point(419, 133);
            this.GMSJ.Name = "GMSJ";
            this.GMSJ.Size = new System.Drawing.Size(144, 22);
            this.GMSJ.TabIndex = 26;
            // 
            // ZT
            // 
            this.ZT.Location = new System.Drawing.Point(140, 92);
            this.ZT.Name = "ZT";
            this.ZT.ReadOnly = true;
            this.ZT.Size = new System.Drawing.Size(116, 22);
            this.ZT.TabIndex = 25;
            this.ZT.Text = "登记";
            // 
            // simpleButton_add
            // 
            this.simpleButton_add.Location = new System.Drawing.Point(476, 328);
            this.simpleButton_add.Name = "simpleButton_add";
            this.simpleButton_add.Size = new System.Drawing.Size(87, 27);
            this.simpleButton_add.TabIndex = 24;
            this.simpleButton_add.Text = "添加硬盘";
            this.simpleButton_add.Click += new System.EventHandler(this.simpleButton_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "报备状态:";
            // 
            // SYQK
            // 
            this.SYQK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SYQK.FormattingEnabled = true;
            this.SYQK.Items.AddRange(new object[] {
            "正常",
            "非正常"});
            this.SYQK.Location = new System.Drawing.Point(140, 133);
            this.SYQK.Name = "SYQK";
            this.SYQK.Size = new System.Drawing.Size(116, 22);
            this.SYQK.TabIndex = 21;
            // 
            // BZ
            // 
            this.BZ.Location = new System.Drawing.Point(24, 217);
            this.BZ.Multiline = true;
            this.BZ.Name = "BZ";
            this.BZ.Size = new System.Drawing.Size(538, 83);
            this.BZ.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 14);
            this.label15.TabIndex = 19;
            this.label15.Text = "备注:";
            // 
            // LX
            // 
            this.LX.Location = new System.Drawing.Point(419, 33);
            this.LX.Name = "LX";
            this.LX.ReadOnly = true;
            this.LX.Size = new System.Drawing.Size(144, 22);
            this.LX.TabIndex = 18;
            this.LX.Text = "硬盘";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "进入系统时间:";
            // 
            // BDJSJ
            // 
            this.BDJSJ.Location = new System.Drawing.Point(419, 84);
            this.BDJSJ.Name = "BDJSJ";
            this.BDJSJ.ReadOnly = true;
            this.BDJSJ.Size = new System.Drawing.Size(144, 22);
            this.BDJSJ.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "绑定计算机:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "使用状态:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型:";
            // 
            // SN
            // 
            this.SN.Location = new System.Drawing.Point(92, 35);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(185, 22);
            this.SN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "序列号:";
            // 
            // AddYPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 371);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddYPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增硬盘";
            this.Load += new System.EventHandler(this.AddYPForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SYQK;
        private System.Windows.Forms.TextBox BZ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BDJSJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZT;
        private System.Windows.Forms.DateTimePicker GMSJ;
    }
}