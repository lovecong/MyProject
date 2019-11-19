using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDMAPSM
{
    public delegate void GetPC(GDMAPSM.Model.pcmsg pc, List<GDMAPSM.Model.ypmsg> yps);
    public partial class AddPCForm : DevExpress.XtraEditors.XtraForm
    {
        public AddPCForm()
        {
            InitializeComponent();
        }
        public event GetPC getpc; 
        List<GDMAPSM.Model.ypmsg> yps = new List<Model.ypmsg>();
        private void button_AddYP_Click(object sender, EventArgs e)
        {
            AddYPForm addyp = new AddYPForm(this.BH.Text);
            addyp.addYP += frmAddYP;
            addyp.ShowDialog();
        }
        public void frmAddYP(GDMAPSM.Model.ypmsg YP)
        {
            yps.Add(YP);
            this.YPSN.Text += YP.SN + ";";
        }

        private void button_AddPC_Click(object sender, EventArgs e)
        {
            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            if (bll.Exists(this.BH.Text))
            {
                MessageBox.Show("编号已存在");
                return;
            }

            GDMAPSM.Model.pcmsg model = new Model.pcmsg();
            model.BH = this.BH.Text;
            model.SYBM = this.SYBM.Text;
            switch (this.SYZT.Text)
            {
                case "正常":
                    model.SYZT = "0";
                    break;
                case "停用":
                    model.SYZT = "1";
                    break;
                case "销毁":
                    model.SYZT = "2";
                    break;
            }
            model.BAZT = "2";
            model.BMZZR = this.BMZZR.Text;
            model.SYR = this.SYR.Text;
            model.JSJLX = this.JSJLX.Text;
            model.PPLX = this.PPLX.Text;
            model.BZ = this.lblBZ.Text;
            model.SN = this.SN.Text;
            model.DJSJ = this.DJSJ.Value;
            model.QYSJ = this.dateTimePicker_QYSJ.Value;
            model.WZ = this.WZ.Text;
            getpc(model, yps);
            this.Close();

        }

        private void AddPCForm_Load(object sender, EventArgs e)
        {
            this.SYBM.SelectedIndex = 0;
            this.SYZT.SelectedIndex = 0;
            this.JSJLX.SelectedIndex = 0;
            BLL.count c = new BLL.count();

            this.BH.Text ="JA"+ c.GetModel(1).COUNT.ToString();


        }
    }
}
