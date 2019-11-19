namespace GDMAPSM.报备流程
{
    partial class BBLC_ListModel_BL_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl_destroy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControl_add = new DevExpress.XtraGrid.GridControl();
            this.gridView_add = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControl_change = new DevExpress.XtraGrid.GridControl();
            this.gridView_change = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridControl_destroy = new DevExpress.XtraGrid.GridControl();
            this.gridView_destroy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl_destroy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_destroy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_destroy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 451);
            this.panel1.TabIndex = 3;
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl_destroy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton2);
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainer1.Size = new System.Drawing.Size(787, 451);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 15;
            // 
            // tabControl_destroy
            // 
            this.tabControl_destroy.Controls.Add(this.tabPage1);
            this.tabControl_destroy.Controls.Add(this.tabPage2);
            this.tabControl_destroy.Controls.Add(this.tabPage3);
            this.tabControl_destroy.Controls.Add(this.tabPage4);
            this.tabControl_destroy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_destroy.Location = new System.Drawing.Point(0, 0);
            this.tabControl_destroy.Name = "tabControl_destroy";
            this.tabControl_destroy.SelectedIndex = 0;
            this.tabControl_destroy.Size = new System.Drawing.Size(787, 368);
            this.tabControl_destroy.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControl_add);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新增";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControl_add
            // 
            this.gridControl_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_add.Location = new System.Drawing.Point(3, 3);
            this.gridControl_add.MainView = this.gridView_add;
            this.gridControl_add.Name = "gridControl_add";
            this.gridControl_add.Size = new System.Drawing.Size(773, 335);
            this.gridControl_add.TabIndex = 4;
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
            this.gridView_add.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView_add_CellMerge);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_add;
            this.gridView1.Name = "gridView1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControl_change);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "变更";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControl_change
            // 
            this.gridControl_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_change.Location = new System.Drawing.Point(3, 3);
            this.gridControl_change.MainView = this.gridView_change;
            this.gridControl_change.Name = "gridControl_change";
            this.gridControl_change.Size = new System.Drawing.Size(773, 335);
            this.gridControl_change.TabIndex = 5;
            this.gridControl_change.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_change,
            this.gridView3});
            // 
            // gridView_change
            // 
            this.gridView_change.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView_change.GridControl = this.gridControl_change;
            this.gridView_change.Name = "gridView_change";
            this.gridView_change.OptionsBehavior.Editable = false;
            this.gridView_change.OptionsBehavior.ReadOnly = true;
            this.gridView_change.OptionsView.ShowGroupPanel = false;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl_change;
            this.gridView3.Name = "gridView3";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridControl_destroy);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "销毁";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridControl_destroy
            // 
            this.gridControl_destroy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_destroy.Location = new System.Drawing.Point(3, 3);
            this.gridControl_destroy.MainView = this.gridView_destroy;
            this.gridControl_destroy.Name = "gridControl_destroy";
            this.gridControl_destroy.Size = new System.Drawing.Size(773, 335);
            this.gridControl_destroy.TabIndex = 5;
            this.gridControl_destroy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_destroy,
            this.gridView5});
            // 
            // gridView_destroy
            // 
            this.gridView_destroy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView_destroy.GridControl = this.gridControl_destroy;
            this.gridView_destroy.Name = "gridView_destroy";
            this.gridView_destroy.OptionsBehavior.Editable = false;
            this.gridView_destroy.OptionsBehavior.ReadOnly = true;
            this.gridView_destroy.OptionsView.ShowGroupPanel = false;
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControl_destroy;
            this.gridView5.Name = "gridView5";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(600, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "提交";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(779, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "附件";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(700, 27);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "提交";
            // 
            // BBLC_ListModel_BL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 451);
            this.Controls.Add(this.panel1);
            this.Name = "BBLC_ListModel_BL_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "办理中";
            this.Load += new System.EventHandler(this.BBLC_ListPC_Form_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl_destroy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_destroy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_destroy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_add;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabControl tabControl_destroy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControl_change;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_change;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraGrid.GridControl gridControl_destroy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_destroy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.TabPage tabPage4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}