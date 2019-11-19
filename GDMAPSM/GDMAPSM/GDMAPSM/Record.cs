using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDMAPSM
{
    public partial class Record : DevExpress.XtraEditors.XtraForm
    {
        string BH = "";
        public Record(string bh)
        {
            InitializeComponent();
            this.BH = bh;
            this.textBox_BH.Text = bh;
        }

        private void Record_Load(object sender, EventArgs e)
        {
            //读取硬盘
            GDMAPSM.BLL.ypmsg ypbll = new BLL.ypmsg();
            DataSet ds = new DataSet();
            ds = ypbll.GetList(string.Format("BDJSJ='{0}'", this.BH));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                this.comboBox_yps.Items.Add(dr["SN"].ToString());
            }
        }

        private void button_bg_Click(object sender, EventArgs e)
        {
            //GDMAPSM.BLL.ypmsg ypbll = new BLL.ypmsg();


            //GDMAPSM.BLL.pcrecord PCR = new BLL.pcrecord();
            //GDMAPSM.Model.pcrecord model = new Model.pcrecord();
            //model.LX = this.comboBox_LX.Text;
            //model.BH = this.BH;
            //model.YPSN = this.comboBox_yps.Text;
            //model.BGSJ = this.dateTimePicker1.Value.Date.ToString();

            //PCR.Add(model);


        }

        private void comboBox_LX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
