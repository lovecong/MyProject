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
    public partial class YPRecord : DevExpress.XtraEditors.XtraForm
    {
        string BH = "";
        public YPRecord(string bh)
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
            ds = ypbll.GetList(string.Format("BAJSJ='{0}'", this.BH));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                this.comboBox_yps.Items.Add(dr["SN"].ToString());
            }
        }

        private void button_bg_Click(object sender, EventArgs e)
        {
            GDMAPSM.BLL.ypmsg ypbll = new BLL.ypmsg();
            GDMAPSM.Model.ypmsg YPmodel = ypbll.GetModel(this.comboBox_yps.Text);
            GDMAPSM.BLL.yprecord YPRbll = new BLL.yprecord();
            GDMAPSM.Model.yprecord YPRmodel = new Model.yprecord();
            YPRmodel.BH = this.textBox_mbzj.Text;

            if (YPmodel != null)
            {

                YPmodel.BDJSJ = this.textBox_mbzj.Text;

                switch (this.comboBox_LX.Text)
                {
                    case "备案":
                        YPRmodel.LX = "0";
                        break;
                    case "报备中":
                        YPRmodel.LX = "1";
                        break;
                    case "登记":
                        YPRmodel.LX = "2";
                        break;
                    case "销毁":
                        YPRmodel.LX = "3";
                        YPmodel.BDJSJ = "";
                        break;
                    case "销毁登记":
                        YPRmodel.LX = "4";
                        YPmodel.BDJSJ = "";
                        break;
                    case "销毁办理中":
                        YPRmodel.LX = "5";
                        YPmodel.BDJSJ = "";
                        break;
                    case "移去":
                        YPRmodel.LX = "6";
                        YPmodel.SYQK = "1";
                        break;
                    case "移回":
                        YPRmodel.LX = "7";
                        YPmodel.SYQK = "0";
                        break;
                    case "保管":
                        YPRmodel.LX = "8";
                        YPmodel.BDJSJ = "";
                        YPmodel.SYQK = "1";
                        break;
                }

                YPRmodel.SN = this.comboBox_yps.Text;
                YPRmodel.TIME = this.dateTimePicker1.Value.Date;
                if (ypbll.Update(YPmodel))
                {
                    if (YPRbll.Add(YPRmodel))
                    {
                        MessageBox.Show("成功");
                        this.Close();
                    }
                }
            }

        }
        public void selectPC(List<string> BHs)
        {
            if (BHs.Count == 0) return;
            this.textBox_mbzj.Text = BHs[0];
        }

        private void comboBox_LX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.Text != "移回")
            {
                GDMAPSM.报备流程.SelectPCForm selectPcForm = new GDMAPSM.报备流程.SelectPCForm();
                selectPcForm.selectPC += selectPC;
                selectPcForm.ShowDialog();
            }
        }
    }
}


