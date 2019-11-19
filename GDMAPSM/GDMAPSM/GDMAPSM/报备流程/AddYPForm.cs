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
    //自定义委托
    public delegate void addYP(GDMAPSM.Model.ypmsg  yp);
    public partial class AddYPForm : DevExpress.XtraEditors.XtraForm
    {
        public AddYPForm(string bh)
        {
            InitializeComponent();
            this.BDJSJ.Text = bh;
        }
       

        //2、声明一个委托类型的事件
        public event addYP addYP;

        private void simpleButton_add_Click(object sender, EventArgs e)
        {
            GDMAPSM.BLL.ypmsg BLL = new BLL.ypmsg();
            if (BLL.Exists(this.SN.Text))
            {
                MessageBox.Show("硬盘已存在");
                return;
            }


            GDMAPSM.Model.ypmsg MODEL = new Model.ypmsg();
            MODEL.SN = this.SN.Text;
            switch (this.LX.Text)
            {
                case "移动硬盘":
                    MODEL.LX = "1";
                    break;
                case "硬盘":
                    MODEL.LX = "0";
                    break;
            }
            switch (this.ZT.Text)
            {
                case "已备案":
                    MODEL.ZT = "0";
                    break;
                case "报备中":
                    MODEL.ZT = "1";
                    break;
                case "登记":
                    MODEL.ZT = "2";
                    break;
                case "销毁":
                    MODEL.ZT = "3";
                    break;
            }
            MODEL.BDJSJ = this.BDJSJ.Text;
            MODEL.BAJSJ = this.BDJSJ.Text;
            switch (this.SYQK.Text)
            {
                case "非正常":
                    MODEL.SYQK = "1";
                    break;
                case "正常":
                    MODEL.SYQK = "0";
                    break;
            }
            MODEL.GMSJ = this.GMSJ.Value;
            MODEL.BZ = this.BZ.Text;

            addYP(MODEL);
            this.Close();

        }

        private void AddYPForm_Load(object sender, EventArgs e)
        {
            this.SYQK.SelectedIndex = 0;
        }
    }
}
