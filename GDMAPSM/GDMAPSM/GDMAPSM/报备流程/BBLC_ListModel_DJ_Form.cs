using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.IO;

namespace GDMAPSM.报备流程
{

    public partial class BBLC_ListModel_DJ_Form : DevExpress.XtraEditors.XtraForm
    {
        public BBLC_ListModel_DJ_Form(string bblc1_guid)
        {
            InitializeComponent();
            this.guid = bblc1_guid;
        }
        string guid = "";

        private void BBLC_ListPC_Form_Load(object sender, EventArgs e)
        {
            BLL.bblc_1 bll1 = new BLL.bblc_1();
            Model.bblc_1 model = bll1.GetModel(this.guid);
            switch (model.ZT)
            {
                case "0":
                    this.Text = "登记";
                    break;
                case "1":
                    this.Text = "办理中";
                    break;
            }
            this.gridView_add.OptionsView.AllowCellMerge = true;
            this.gridControl_add.DataSource = getDC_add();
            this.gridControl_change.DataSource = getDC_change();
            this.gridControl_destroy.DataSource = getDC_destroy();

            //设置表格自动合并
            this.gridView_add.OptionsView.AllowCellMerge = false;
            this.gridView_change.OptionsView.AllowCellMerge = false;
            this.gridView_destroy.OptionsView.AllowCellMerge = false;
            //  this.gridView_add.CellMerge += gridView_add_CellMerge;
            //  this.gridView_change.CellMerge += gridView_add_CellMerge;
            //  this.gridView_destroy.CellMerge += gridView_add_CellMerge;


        }

        private void simpleButton_add_Click(object sender, EventArgs e)
        {

            AddModelForm form = new AddModelForm(guid);
            form.refreshParentForm += Refresh;
            form.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        #region 新增
        private DataTable getDC_add()
        {

            // DataSet  dt = 
            DataTable datatabel = new DataTable();

            DataColumn dc1 = new DataColumn("计算机编号", typeof(string));
            DataColumn dc2 = new DataColumn("硬盘编号", typeof(string));
            DataColumn dc3 = new DataColumn("备注", typeof(string));

            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);

            GDMAPSM.BLL.bblc_2 bll = new BLL.bblc_2();
            //   DataSet Dataset = bll.GetList(string.Format("GUID='{0}' and LX='{1}' order by PCBH", this.guid, "0")); ;

            String SQLstr = string.Format("SELECT  a.PCBH,GROUP_CONCAT(b.SN) AS SN,MAX(a.BZ) AS BZ " +
       "FROM(SELECT PCBH, MAX(BZ)AS BZ FROM `bblc_2` WHERE GUID = '{0}' and LX = '{1}' GROUP BY PCBH) as a " +
    ", ypmsg as b WHERE a.PCBH = b.BAJSJ  GROUP BY a.PCBH", guid, "0");
            DataSet Dataset = bll.GetListBySQL(SQLstr);
            DataTable dt = Dataset.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["计算机编号"] = dr["PCBH"];
                dataR["硬盘编号"] = dr["SN"];
                dataR["备注"] = dr["BZ"];
                datatabel.Rows.Add(dataR);
            }
            return datatabel;
        }
        private void gridView_add_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            string fistCname = "计算机编号";
            if (e.Column.FieldName == fistCname)
            {
                string valueFirstColumn1 = Convert.ToString(view.GetRowCellValue(e.RowHandle1, view.Columns[fistCname]));
                string valueFirstColumn2 = Convert.ToString(view.GetRowCellValue(e.RowHandle2, view.Columns[fistCname]));
                if (valueFirstColumn1 == valueFirstColumn2)
                {
                    e.Merge = true;
                    e.Handled = true;
                }
            }
            else
            {
                e.Merge = false;
                e.Handled = true;
            }

        }
        #endregion
        #region 变更
        private DataTable getDC_change()
        {

            // DataSet  dt = 
            DataTable datatabel = new DataTable();

            DataColumn dc1 = new DataColumn("计算机编号", typeof(string));
            DataColumn dc2 = new DataColumn("硬盘编号", typeof(string));
            DataColumn dc3 = new DataColumn("备注", typeof(string));

            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);

            GDMAPSM.BLL.bblc_2 bll = new BLL.bblc_2();
            DataSet Dataset = bll.GetList(string.Format("GUID='{0}' and LX='{1}' order by PCBH", this.guid, "1")); ;
            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["计算机编号"] = dr["PCBH"];
                dataR["硬盘编号"] = dr["YPSN"];
                dataR["备注"] = dr["BZ"];
                datatabel.Rows.Add(dataR);
            }
            return datatabel;
        }
        private void gridView_change_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            string fistCname = "计算机编号";
            if (e.Column.FieldName == fistCname)
            {
                e.Merge = true;
                e.Handled = true;
            }
            else
            {
                e.Merge = false;
                e.Handled = true;
            }

        }
        #endregion
        #region 销毁
        private DataTable getDC_destroy()
        {

            // DataSet  dt = 
            DataTable datatabel = new DataTable();

            DataColumn dc1 = new DataColumn("计算机编号", typeof(string));
            DataColumn dc2 = new DataColumn("硬盘编号", typeof(string));
            DataColumn dc3 = new DataColumn("备注", typeof(string));
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc3);

            GDMAPSM.BLL.bblc_2 bll = new BLL.bblc_2();
            DataSet Dataset = bll.GetList(string.Format("GUID='{0}' and LX='{1}' order by BZ ASC,PCBH ASC", this.guid, "2")); ;
            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["计算机编号"] = dr["PCBH"];
                dataR["硬盘编号"] = dr["YPSN"];
                dataR["备注"] = dr["BZ"];
                datatabel.Rows.Add(dataR);
            }
            return datatabel;
        }
        private void gridView_destroy_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            string fistCname = "计算机编号";
            if (e.Column.FieldName == fistCname)
            {
                string valueFirstColumn1 = Convert.ToString(view.GetRowCellValue(e.RowHandle1, view.Columns[fistCname]));
                string valueFirstColumn2 = Convert.ToString(view.GetRowCellValue(e.RowHandle2, view.Columns[fistCname]));
                if (valueFirstColumn1 == valueFirstColumn2)
                {
                    e.Merge = true;
                    e.Handled = true;
                }
            }
            else
            {
                e.Merge = false;
                e.Handled = true;
            }

        }
        #endregion
        public void refresh()
        {
            this.gridView_add.OptionsView.AllowCellMerge = true;
            this.gridControl_add.DataSource = getDC_add();
            this.gridControl_change.DataSource = getDC_change();
            this.gridControl_destroy.DataSource = getDC_destroy();
        }
        //提交报备
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BBLC_SQForm sqf = new BBLC_SQForm(this.guid);
            sqf.refreshParentForm += refresh;
            sqf.ShowDialog();
        }
        //添加附件
        private void simpleButton_fj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF|*.PDF|pdf|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string G = Guid.NewGuid().ToString();
                string outFliePath = ConfigurationManager.AppSettings["BLLC"] + "\\DJ\\" + this.guid;
                if (!System.IO.Directory.Exists(outFliePath)) Directory.CreateDirectory(outFliePath);
                File.Copy(openFileDialog.FileName, outFliePath + "\\" + G + ".pdf");
                MessageBox.Show("添加成功");
            }
        }

        private void simpleButton_print_Click(object sender, EventArgs e)
        {

            switch (this.tabControl_dengji.SelectedTab.Text)
            {
                case "新增":
                    this.gridControl_add.ShowRibbonPrintPreview();
                    break;
                case "变更":
                    this.gridControl_change.ShowRibbonPrintPreview();
                    break;
                case "销毁":
                    this.gridControl_destroy.ShowRibbonPrintPreview();
                    break;
            }
        }

        private void simpleButton_printBAB_Click(object sender, EventArgs e)
        {
            PrintBABForm F = new PrintBABForm(this.guid);
            F.Show();
        }

        #region 弹出菜单

        #region 新增表
        //新增表弹出菜单
        private void gridView_add_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (this.gridView_add.GetRowCellValue(e.RowHandle, "计算机编号").ToString().Length > 0)
                {
                    this.contextMenuStrip_XZ.Show(Cursor.Position);
                    gridView_add.SelectRow(e.RowHandle);
                }
            }
        }

        //新增表中 删除计算机
        private void ToolStripMenuItem_XZ_DeletePC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除计算机", "删除", MessageBoxButtons.YesNoCancel);
            if (result.ToString() == "Yes")
            {

                string BH = this.gridView_add.GetRowCellValue(this.gridView_add.GetSelectedRows()[0], "计算机编号").ToString();

                //删除流程
                string resultstr = "";
                DAL.bblc_2 bllc2Dal = new DAL.bblc_2();
                if (bllc2Dal.DeleteByPCBH(BH))
                    resultstr += "流程删除成功；";
                else
                    resultstr += "流程删除失败；";

                //开始删除计算机
                DAL.pcmsg pcDAL = new DAL.pcmsg();
                if (pcDAL.Delete(BH))
                    resultstr += "计算机删除成功；";
                else
                    resultstr += "计算机删除失败；";
                //开始删除硬盘
                DAL.ypmsg ypDAL = new DAL.ypmsg();
                if (ypDAL.DeleteBYBH(BH))
                    resultstr += "硬盘删除成功；";
                else
                    resultstr += "硬盘删除失败；";
                MessageBox.Show(resultstr);
            }
        }
        #endregion
        #region 变更表
        //变更弹出菜单
        private void gridView_change_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (this.gridView_change.GetRowCellValue(e.RowHandle, "计算机编号").ToString().Length > 0)
                {
                    this.contextMenuStrip_BG.Show(Cursor.Position);
                    gridView_change.SelectRow(e.RowHandle);
                }
            }

        }
        //变更表中 删除硬盘
        private void toolStripMenuItem_BG_DeleteYP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否硬盘", "删除", MessageBoxButtons.YesNoCancel);
            if (result.ToString() == "Yes")
            {
                string YPSN = this.gridView_change.GetRowCellValue(this.gridView_change.GetSelectedRows()[0], "硬盘编号").ToString();

                //删除流程
                string resultstr = "";
                DAL.bblc_2 bllc2Dal = new DAL.bblc_2();
                if (bllc2Dal.DeleteByYPSN(YPSN))
                    resultstr += "流程删除成功；";
                else
                    resultstr += "流程删除失败；";
                //开始删除硬盘
                DAL.ypmsg ypDAL = new DAL.ypmsg();
                if (ypDAL.Delete(YPSN))
                    resultstr += "硬盘删除成功；";
                else
                    resultstr += "硬盘删除失败；";
                MessageBox.Show(resultstr);
            }
        }

        #endregion
        #region 销毁表菜单
        private void gridView_destroy_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (this.gridView_destroy.GetRowCellValue(e.RowHandle, "计算机编号").ToString().Length > 0)
                {
                    this.contextMenuStrip_XH.Show(Cursor.Position);
                    gridView_destroy.SelectRow(e.RowHandle);
                }
            }
        }
        private void toolStripMenuItem_XH_DeleteYP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除流程", "删除", MessageBoxButtons.YesNoCancel);
            if (result.ToString() == "Yes")
            {
                string YPSN = this.gridView_destroy.GetRowCellValue(this.gridView_destroy.GetSelectedRows()[0], "硬盘编号").ToString();

                //删除流程
                string resultstr = "";
                DAL.bblc_2 bllc2Dal = new DAL.bblc_2();
                if (bllc2Dal.DeleteByYPSN(YPSN))
                    resultstr += "销毁流程删除成功；";
                else
                    resultstr += "销毁流程删除失败；";
                MessageBox.Show(resultstr);
            }
        }
        #endregion
    }

    #endregion
}