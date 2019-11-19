using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GDMAPSM
{
    public partial class SelecBBLCForm : DevExpress.XtraEditors.XtraForm
    {
        public SelecBBLCForm(string guid)
        {
            InitializeComponent();
            this.guid = guid;
        }
        string guid = "";
        private void SelecBBLCForm_Load(object sender, EventArgs e)
        {
            gridControl_add.DataSource = getDC_add(this.guid);
            gridControl_add.ShowRibbonPrintPreview();
        }
        private DataTable getDC_add(string guid)
        {

            // DataSet  dt = 
            DataTable datatabel = new DataTable();

            DataColumn dc1 = new DataColumn("计算机编号", typeof(string));
            DataColumn dc2 = new DataColumn("责任人", typeof(string));
            DataColumn dc3 = new DataColumn("型号", typeof(string));
            DataColumn dc4 = new DataColumn("部门", typeof(string));
            DataColumn dc5 = new DataColumn("IP", typeof(string));
            DataColumn dc6 = new DataColumn("硬盘编号", typeof(string));
            DataColumn dc7 = new DataColumn("位置", typeof(string));

            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);
            datatabel.Columns.Add(dc4);
            datatabel.Columns.Add(dc5);
            datatabel.Columns.Add(dc6);
            datatabel.Columns.Add(dc7);

            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();

            DataSet Dataset = bll.GetListBySQL(string.Format("SELECT BH, GROUP_CONCAT(ypmsg.SN) AS SN, pcmsg.PPLX, pcmsg.WZ, pcmsg.SYBM, pcmsg.BMZZR FROM pcmsg LEFT JOIN ypmsg ON pcmsg.BH = ypmsg.BDJSJ WHERE BH IN(SELECT PCBH FROM bblc_2 WHERE GUID = '{0}' GROUP BY PCBH) GROUP BY BH", guid)); 
            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["计算机编号"] = dr["BH"];               
                dataR["责任人"] = dr["BMZZR"];
                dataR["型号"] = dr["PPLX"];               
                dataR["位置"] = dr["WZ"];
                dataR["IP"] = dr["WZ"];// getIP(dr["WZ"].ToString()) ;
                dataR["部门"] = dr["SYBM"];
                dataR["硬盘编号"] = dr["SN"];
                datatabel.Rows.Add(dataR);
            }
            return datatabel;
        }

        private string getIP(string wz)
        {

            string t = wz.Substring(0, 1);
            string ip = "";
            int count= int.Parse(wz.Substring(1, wz.Length - 1)) + 10;
            switch (t)
            {
                case "A":
                    ip= "192.168.20." +count;
                    break;
                case "B":
                    ip = "192.168.30." + count;
                    break;
                case "D":
                    ip = "192.168.40." + count;
                    break;
                case "E":
                    ip = "192.168.50." + count;
                    break;
                case "F":
                    ip = "192.168.70." + count;
                    break;
            }
            return ip;
        }
    }
}