namespace GDMAPSM
{
    partial class YPDetailForm
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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.bajsj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ZT = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SYQK = new System.Windows.Forms.ComboBox();
            this.lblBZ = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.LX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GMSJ = new System.Windows.Forms.TextBox();
            this.BBSJ = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.bajsj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ZT);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SYQK);
            this.groupBox1.Controls.Add(this.lblBZ);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.LX);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.GMSJ);
            this.groupBox1.Controls.Add(this.BBSJ);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BDJSJ);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 436);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(425, 403);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(87, 27);
            this.simpleButton2.TabIndex = 28;
            this.simpleButton2.Text = "更正序列号";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // bajsj
            // 
            this.bajsj.Location = new System.Drawing.Point(446, 146);
            this.bajsj.Name = "bajsj";
            this.bajsj.ReadOnly = true;
            this.bajsj.Size = new System.Drawing.Size(116, 22);
            this.bajsj.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "备案计算机:";
            // 
            // ZT
            // 
            this.ZT.FormattingEnabled = true;
            this.ZT.Items.AddRange(new object[] {
            "已备案",
            "报备中",
            "登记",
            "销毁",
            "销毁登记",
            "销毁办理中"});
            this.ZT.Location = new System.Drawing.Point(446, 93);
            this.ZT.Name = "ZT";
            this.ZT.Size = new System.Drawing.Size(116, 22);
            this.ZT.TabIndex = 25;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(312, 403);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 27);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "更新信息";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "报备状态:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SYQK
            // 
            this.SYQK.FormattingEnabled = true;
            this.SYQK.Items.AddRange(new object[] {
            "正常",
            "非正常"});
            this.SYQK.Location = new System.Drawing.Point(140, 86);
            this.SYQK.Name = "SYQK";
            this.SYQK.Size = new System.Drawing.Size(116, 22);
            this.SYQK.TabIndex = 21;
            // 
            // lblBZ
            // 
            this.lblBZ.Location = new System.Drawing.Point(24, 296);
            this.lblBZ.Multiline = true;
            this.lblBZ.Name = "lblBZ";
            this.lblBZ.Size = new System.Drawing.Size(538, 83);
            this.lblBZ.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 14);
            this.label15.TabIndex = 19;
            this.label15.Text = "备注:";
            // 
            // LX
            // 
            this.LX.Location = new System.Drawing.Point(447, 35);
            this.LX.Name = "LX";
            this.LX.Size = new System.Drawing.Size(116, 22);
            this.LX.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 14);
            this.label13.TabIndex = 15;
            this.label13.Text = "报备时间:";
            // 
            // GMSJ
            // 
            this.GMSJ.Location = new System.Drawing.Point(447, 210);
            this.GMSJ.Name = "GMSJ";
            this.GMSJ.Size = new System.Drawing.Size(116, 22);
            this.GMSJ.TabIndex = 14;
            // 
            // BBSJ
            // 
            this.BBSJ.Location = new System.Drawing.Point(140, 202);
            this.BBSJ.Name = "BBSJ";
            this.BBSJ.Size = new System.Drawing.Size(116, 22);
            this.BBSJ.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "进入系统时间:";
            // 
            // BDJSJ
            // 
            this.BDJSJ.Location = new System.Drawing.Point(140, 146);
            this.BDJSJ.Name = "BDJSJ";
            this.BDJSJ.Size = new System.Drawing.Size(116, 22);
            this.BDJSJ.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "绑定计算机:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "使用状态:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型:";
            // 
            // SN
            // 
            this.SN.Location = new System.Drawing.Point(140, 35);
            this.SN.Name = "SN";
            this.SN.Size = new System.Drawing.Size(125, 22);
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
            // YPDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "YPDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "硬盘详细";
            this.Load += new System.EventHandler(this.YPDetailForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lblBZ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox GMSJ;
        private System.Windows.Forms.TextBox BBSJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BDJSJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SYQK;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox ZT;
        private System.Windows.Forms.TextBox bajsj;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}