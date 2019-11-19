namespace GDMAPSM
{
    partial class PrintBABForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_SaveWord = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SaveWord
            // 
            this.button_SaveWord.Location = new System.Drawing.Point(50, 64);
            this.button_SaveWord.Name = "button_SaveWord";
            this.button_SaveWord.Size = new System.Drawing.Size(75, 23);
            this.button_SaveWord.TabIndex = 0;
            this.button_SaveWord.Text = "保存word";
            this.button_SaveWord.UseVisualStyleBackColor = true;
            this.button_SaveWord.Click += new System.EventHandler(this.button_SaveWord_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "备案保存Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrintBABForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_SaveWord);
            this.Name = "PrintBABForm";
            this.Text = "打印备案表";
            this.Load += new System.EventHandler(this.PrintBABForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_SaveWord;
        private System.Windows.Forms.Button button2;
    }
}