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
     public delegate void SelectYP( List< Model.ypmsg> ypModels);
    public partial class SelectYPForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectYPForm( string PCBH)
        {
            InitializeComponent();
            this.gridControl.DataSource = getDT(String.Format("ZT!='3' and BAJSJ like '{0}'", PCBH));
        }

        public event SelectYP selectYP;

        public DataTable getDT(string sql)
        {
            DataTable datatabel = new DataTable();
            DataColumn dc1 = new DataColumn("序列号", typeof(string));
            DataColumn dc2 = new DataColumn("状态", typeof(string));
         

            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
           

            GDMAPSM.BLL.ypmsg BLL = new BLL.ypmsg();
            DataSet Dataset = BLL.GetList(sql);

            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["序列号"] = dr["SN"];
                switch( dr["ZT"].ToString())
                {
                    case "0":
                        dataR["状态"] = "已备案";
                        break;
                    case "1":
                        dataR["状态"] = "报备中";
                        break;
                    case "2":
                        dataR["状态"] = "登记";
                        break;

                }
                
                datatabel.Rows.Add(dataR);
            }
            return datatabel;
        }

        private void SelectPCForm_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GDMAPSM.BLL.ypmsg BLL = new BLL.ypmsg();
            int[] selects = this.gridView.GetSelectedRows();
            string where = "SN IN (";
            for (int select=0;select< selects.Length;select++)
            {
                string SN = this.gridView.GetRowCellValue(this.gridView.GetSelectedRows()[select], "序列号").ToString();
                where += "'" + SN + "',";
            }
            where = where.Substring(0, where.Length - 1)+")";
            selectYP(BLL.GetModelList(where));

            this.Close();
        }

        private void PCBH_TextChanged(object sender, EventArgs e)
        {
            //this.gridControl.DataSource = getDT(String.Format("ZT!='3' and SN like '%{0}%'", this.PCBH.Text));
        }
    }
}