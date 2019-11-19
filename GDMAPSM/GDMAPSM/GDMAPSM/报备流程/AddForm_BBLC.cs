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
    public partial class AddForm_BBLC : DevExpress.XtraEditors.XtraForm
    {
        public AddForm_BBLC()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GDMAPSM.BLL.bblc_1 bll = new BLL.bblc_1();
            GDMAPSM.Model.bblc_1 model = new Model.bblc_1();
            model.GUID = Guid.NewGuid().ToString();
            model.BZ = this.BZ.Text;
            model.JBR = this.JBR.Text;

            switch (this.ZT.Text)
            {
                case "登记":
                    model.ZT = "0";
                    break;
                case "办理中":
                    model.ZT = "1";
                    break;
                case "完成":
                    model.ZT = "2";
                    break;
                  
            }
            model.Etime =DateTime.Parse( this.Etime.Value.ToLongDateString());
            model.Stime = DateTime.Parse(this.Stime.Value.ToLongDateString());
            if (bll.Add(model))
            {
                BBLC_ListModel_DJ_Form from = new BBLC_ListModel_DJ_Form(model.GUID);
                from.ShowDialog();
                this.Close();
            }
        }

        private void AddForm_BBLC_Load(object sender, EventArgs e)
        {
            this.ZT.SelectedIndex = 0;
        }
    }
}