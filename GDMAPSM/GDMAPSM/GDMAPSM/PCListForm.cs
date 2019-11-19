using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GDMAPSM.DAL;
namespace GDMAPSM
{
    public partial class PCListForm : DevExpress.XtraEditors.XtraForm
    {
        public PCListForm()
        {
            InitializeComponent();
        }
        GDMAPSM.BLL.pcmsg bll = new GDMAPSM.BLL.pcmsg();
        private void Form1_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();


            ds = bll.GetList("ID <> -1");
            DataTable  dt = ds.Tables[0];
            gridView.DataSource = dt;
            



        }

        private void gridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string bh = this.gridView.CurrentRow.Cells[1].Value.ToString();
            PCDetail pc = new PCDetail(bh);
            pc.ShowDialog();
        }

        private void comboBox_bm_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string sqlstr = string.Format("SYBM='{0}'", comboBox_bm.Text);
            ds = bll.GetList(sqlstr);
            DataTable dt = ds.Tables[0];
            gridView.DataSource = dt;
        }
    }
}
