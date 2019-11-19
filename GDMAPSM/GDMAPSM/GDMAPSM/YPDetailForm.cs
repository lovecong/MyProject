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
    public partial class YPDetailForm : DevExpress.XtraEditors.XtraForm
    {
        public YPDetailForm(string sn)
        {
            InitializeComponent();
            model = bll.GetModel(sn);
            if (model == null) {
                MessageBox.Show("无法查找该硬盘");
              
            }
        }
        GDMAPSM.BLL.ypmsg bll = new GDMAPSM.BLL.ypmsg();
        Model.ypmsg model = null;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void YPDetailForm_Load(object sender, EventArgs e)
        {
            this.SN.Text = model.SN;
            this.LX.Text = model.LX;
            

            switch (model.ZT)
            {
                case "0":
                    this.ZT.SelectedIndex = 0;
                    break;
                case "1":
                    this.ZT.SelectedIndex = 1;
                    break;
                case "2":
                    this.ZT.SelectedIndex = 2;
                    break;
                case "3":
                    this.ZT.SelectedIndex = 3;
                    break;
                case "4":
                    this.ZT.SelectedIndex = 4;
                    break;
                case "5":
                    this.ZT.SelectedIndex = 5;
                    break;
            }
            this.BDJSJ.Text = model.BDJSJ;

            switch (model.SYQK)
            {
                case "0":
                    this.SYQK.SelectedIndex = 0;
                    break;
                case "1":
                    this.SYQK.SelectedIndex = 1;
                    break;
            }

            this.GMSJ.Text = model.GMSJ.ToString();
            this.BBSJ.Text = model.BBSJ.ToString();
            this.lblBZ.Text = model.BZ;
            this.bajsj.Text = model.BAJSJ;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            switch (this.SYQK.Text)
            {
                case "正常":
                    model.SYQK = "0";
                    break;
                case "非正常":
                    model.SYQK = "1";
                    break;
            }
            switch (this.ZT.Text)
            {
                case "已备案":
                    model.ZT = "0";
                    break;
                case "报备中":
                    model.ZT = "1";
                    break;
                case "登记":
                    model.ZT = "2";
                    break;
                case "销毁":
                    model.ZT = "3";
                    break;
                case "销毁登记":
                    model.ZT = "4";
                    break;
                case "销毁办理中":
                    model.ZT = "5";
                    break;
            }

            model.BDJSJ = this.BDJSJ.Text;
            model.BZ = this.lblBZ.Text;
            if (bll.Update(model))
            {
                MessageBox.Show("更新成功");
            };
        }

        private void simpleButton_huishou_Click(object sender, EventArgs e)
        {
            model.BAJSJ = "0000";
            model.BDJSJ = "0000";
            if (bll.Update(model))
            {
                MessageBox.Show("回收成功");
            };
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (this.SN.Text.Length == 0) return;
            DialogResult dialogResult = MessageBox.Show("是否更新硬盘序列号", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (model.SN != this.SN.Text)
                {
                    if (bll.UpdateSN(model.SN,this.SN.Text))
                    {
                        MessageBox.Show("更新成功");
                        model.SN = this.SN.Text;
                    }
                }
            }
        }
    }
}
