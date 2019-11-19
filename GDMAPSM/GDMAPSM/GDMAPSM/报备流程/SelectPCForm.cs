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
    public delegate void SelectPC(List<string> BH);
    public partial class SelectPCForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectPCForm()
        {
            InitializeComponent();
        }

        public event SelectPC selectPC;
        ToolTip tp = new ToolTip();
        public DataTable getDT(string sql)
        {
            DataTable datatabel = new DataTable();
            DataColumn dc1 = new DataColumn("编号", typeof(string));
            DataColumn dc2 = new DataColumn("部门", typeof(string));
            DataColumn dc3 = new DataColumn("责任人", typeof(string));
            DataColumn dc4 = new DataColumn("备案状态", typeof(string));
            DataColumn dc5 = new DataColumn("使用状态", typeof(string));
            DataColumn dc6 = new DataColumn("位置", typeof(string));
            DataColumn dc7 = new DataColumn("备案编号", typeof(string));

            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);
            datatabel.Columns.Add(dc4);
            datatabel.Columns.Add(dc5);
            datatabel.Columns.Add(dc6);
            datatabel.Columns.Add(dc7);
            GDMAPSM.BLL.pcmsg BLL = new BLL.pcmsg();
            DataSet Dataset = BLL.GetList(sql);

            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["编号"] = dr["BH"];
                dataR["部门"] = dr["SYBM"];
                dataR["责任人"] = dr["BMZZR"];
                dataR["备案状态"] = dr["BAZT"];
                dataR["使用状态"] = dr["SYZT"];
                dataR["位置"] = dr["WZ"];
                dataR["备案编号"] = dr["BABH"];
                datatabel.Rows.Add(dataR);
            }
            return datatabel;
        }

        private void SelectPCForm_Load(object sender, EventArgs e)
        {
            this.gridControl.DataSource = getDT("BAZT!='3' AND BH!=''");
           
            tp.ShowAlways = true;
           

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // this.gridView.GetRowCellValue(this.gridView.GetSelectedRows()[0], "编号").ToString();
            List<string> BHs = new List<string>();
            int[] selects = this.gridView.GetSelectedRows();
            for (int select = 0; select < selects.Length; select++)
            {
                BHs.Add(this.gridView.GetRowCellValue(this.gridView.GetSelectedRows()[select], "编号").ToString());
            }
            
            selectPC(BHs);
            this.Close();
        }

        private void PCBH_TextChanged(object sender, EventArgs e)
        {
            string sql = "";
            switch (this.combobox_ZD.Text)
            {
                case "计算机编号":
                    sql = String.Format("BAZT!='3' AND BH like '%{0}%'", this.PCBH.Text);
                    tp.SetToolTip(this.PCBH, "JA..");
                    break;
                case "备案编号":
                    sql = String.Format("BAZT!='3' AND BABH like '%{0}%'", this.PCBH.Text);
                    tp.SetToolTip(this.PCBH, "");
                    break;
                case "备案状态":
                    sql = String.Format("BAZT!='3' AND BAZT like '%{0}%'", this.PCBH.Text);
                    tp.SetToolTip(this.PCBH, "0已备案，1报备中；2登记;3销毁；4销毁登记；5销毁办理中");
                    break;
                case "使用状态":
                    sql = String.Format("BAZT!='3' AND SYZT like '%{0}%'", this.PCBH.Text);
                    tp.SetToolTip(this.PCBH, "'0'表示正常；‘1’表示停用；‘2’表示销毁");
                    break;
                case "位置":
                    sql = String.Format("BAZT!='3' AND WZ like '%{0}%'", this.PCBH.Text);
                    tp.SetToolTip(this.PCBH, "部门区域，如A1");
                    break;
            }
            this.gridControl.DataSource = getDT(sql);
        }
    }
}