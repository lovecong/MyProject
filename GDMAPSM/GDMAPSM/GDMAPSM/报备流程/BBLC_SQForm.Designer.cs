namespace GDMAPSM.报备流程
{
    partial class BBLC_SQForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pdf = new System.Windows.Forms.TextBox();
            this.simpleButton_TJ = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_FJ = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "申报时间";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "附件(pdf)";
            // 
            // textBox_pdf
            // 
            this.textBox_pdf.Location = new System.Drawing.Point(72, 43);
            this.textBox_pdf.Name = "textBox_pdf";
            this.textBox_pdf.ReadOnly = true;
            this.textBox_pdf.Size = new System.Drawing.Size(153, 22);
            this.textBox_pdf.TabIndex = 3;
            // 
            // simpleButton_TJ
            // 
            this.simpleButton_TJ.Location = new System.Drawing.Point(231, 142);
            this.simpleButton_TJ.Name = "simpleButton_TJ";
            this.simpleButton_TJ.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_TJ.TabIndex = 5;
            this.simpleButton_TJ.Text = "提交";
            this.simpleButton_TJ.Click += new System.EventHandler(this.simpleButton_TJ_Click);
            // 
            // simpleButton_FJ
            // 
            this.simpleButton_FJ.Location = new System.Drawing.Point(231, 43);
            this.simpleButton_FJ.Name = "simpleButton_FJ";
            this.simpleButton_FJ.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_FJ.TabIndex = 6;
            this.simpleButton_FJ.Text = "上传";
            this.simpleButton_FJ.Click += new System.EventHandler(this.simpleButton_FJ_Click);
            // 
            // BBLC_SQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 177);
            this.Controls.Add(this.simpleButton_FJ);
            this.Controls.Add(this.simpleButton_TJ);
            this.Controls.Add(this.textBox_pdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "BBLC_SQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提交申报";
            this.Load += new System.EventHandler(this.BBLC_SQForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pdf;
        private DevExpress.XtraEditors.SimpleButton simpleButton_TJ;
        private DevExpress.XtraEditors.SimpleButton simpleButton_FJ;
    }
}