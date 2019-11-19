namespace GDMAPSM
{
    partial class SelecBBLCForm
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
            this.gridControl_add = new DevExpress.XtraGrid.GridControl();
            this.gridView_add = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_add
            // 
            this.gridControl_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_add.Location = new System.Drawing.Point(0, 0);
            this.gridControl_add.MainView = this.gridView_add;
            this.gridControl_add.Name = "gridControl_add";
            this.gridControl_add.Size = new System.Drawing.Size(607, 310);
            this.gridControl_add.TabIndex = 5;
            this.gridControl_add.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_add,
            this.gridView1});
            // 
            // gridView_add
            // 
            this.gridView_add.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView_add.GridControl = this.gridControl_add;
            this.gridView_add.Name = "gridView_add";
            this.gridView_add.OptionsBehavior.Editable = false;
            this.gridView_add.OptionsBehavior.ReadOnly = true;
            this.gridView_add.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_add;
            this.gridView1.Name = "gridView1";
            // 
            // SelecBBLCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 310);
            this.Controls.Add(this.gridControl_add);
            this.Name = "SelecBBLCForm";
            this.Text = "SelecBBLCForm";
            this.Load += new System.EventHandler(this.SelecBBLCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}