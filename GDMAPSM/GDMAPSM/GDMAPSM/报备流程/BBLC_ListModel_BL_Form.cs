using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GDMAPSM.报备流程
{
    
    public partial class BBLC_ListModel_BL_Form : DevExpress.XtraEditors.XtraForm
    {
        public BBLC_ListModel_BL_Form(string bblc1_guid)
        {
            InitializeComponent();
            this.guid = bblc1_guid;
        }
        string guid = "";
       
        private void BBLC_ListPC_Form_Load(object sender, EventArgs e)
        {
            this.gridView_add.OptionsView.AllowCellMerge = true;
            this.gridControl_add.DataSource = getDC_add();
            this.gridControl_change.DataSource = getDC_change();
            this.gridControl_destroy.DataSource = getDC_destroy();

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
            DataSet Dataset = bll.GetList(string.Format("GUID='{0}' and LX='{1}' order by PCBH,BZ", this.guid, "2")); ;
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
        public void Refresh()
        {
            this.gridView_add.OptionsView.AllowCellMerge = true;
            this.gridControl_add.DataSource = getDC_add();
            this.gridControl_change.DataSource = getDC_change();
            this.gridControl_destroy.DataSource = getDC_destroy();
        }
    }
}