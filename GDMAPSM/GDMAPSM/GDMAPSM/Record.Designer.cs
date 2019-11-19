namespace GDMAPSM
{
    partial class Record
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_LX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_yps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_BH = new System.Windows.Forms.TextBox();
            this.button_bg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "报备主机:";
            // 
            // comboBox_LX
            // 
            this.comboBox_LX.FormattingEnabled = true;
            this.comboBox_LX.Items.AddRange(new object[] {
            "新增",
            "减少"});
            this.comboBox_LX.Location = new System.Drawing.Point(118, 94);
            this.comboBox_LX.Name = "comboBox_LX";
            this.comboBox_LX.Size = new System.Drawing.Size(157, 22);
            this.comboBox_LX.TabIndex = 8;
            this.comboBox_LX.SelectedIndexChanged += new System.EventHandler(this.comboBox_LX_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "变更类型:";
            // 
            // comboBox_yps
            // 
            this.comboBox_yps.FormattingEnabled = true;
            this.comboBox_yps.Location = new System.Drawing.Point(118, 196);
            this.comboBox_yps.Name = "comboBox_yps";
            this.comboBox_yps.Size = new System.Drawing.Size(157, 22);
            this.comboBox_yps.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "硬盘序列号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "时间:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBox_BH
            // 
            this.textBox_BH.Location = new System.Drawing.Point(118, 38);
            this.textBox_BH.Name = "textBox_BH";
            this.textBox_BH.ReadOnly = true;
            this.textBox_BH.Size = new System.Drawing.Size(157, 22);
            this.textBox_BH.TabIndex = 13;
            // 
            // button_bg
            // 
            this.button_bg.Location = new System.Drawing.Point(246, 323);
            this.button_bg.Name = "button_bg";
            this.button_bg.Size = new System.Drawing.Size(73, 27);
            this.button_bg.TabIndex = 14;
            this.button_bg.Text = "变更";
            this.button_bg.UseVisualStyleBackColor = true;
            this.button_bg.Click += new System.EventHandler(this.button_bg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "目标主机:";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 362);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_bg);
            this.Controls.Add(this.textBox_BH);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_yps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_LX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC变更";
            this.Load += new System.EventHandler(this.Record_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_LX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_yps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_BH;
        private System.Windows.Forms.Button button_bg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}