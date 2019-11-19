using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using GDMAPSM.Common;

namespace GDMAPSM
{
    public partial class PCDetail : DevExpress.XtraEditors.XtraForm
    {
        public PCDetail(string bh)
        {
            InitializeComponent();
            ShowInfo(bh);
            this.gridControl_BA.DataSource = loadBAYP(bh);
            this.gridControl_JR.DataSource = loadJRYP(bh);
            this.gridView1.DoubleClick += gridView_DoubleClick;
            this.gridView2.DoubleClick += gridView_DoubleClick;
            this.gridView2.RowCellStyle += gridView_RowCellStyle;
            _connectionString = ConfigurationManager.AppSettings["FJBAB"] + "\\" + this.bh;
            //加载图片
            loadpic();
            //加载变更记录
            loadRecord();
        }

        private void ShowInfo(string bh)
        {
            GDMAPSM.BLL.pcmsg bll = new GDMAPSM.BLL.pcmsg();
            GDMAPSM.Model.pcmsg model = bll.GetModel(bh);

            this.lblBH.Text = model.BH;

            switch (model.SYZT)
            {
                case "0":
                    this.lblSYZT.SelectedIndex = 0;
                    break;
                case "1":
                    this.lblSYZT.SelectedIndex = 1;
                    break;
                case "2":
                    this.lblSYZT.SelectedIndex = 2;
                    break;

            }
            switch (model.BAZT)
            {
                case "0":
                    this.lblBAZT.SelectedIndex = 0;
                    break;
                case "1":
                    this.lblBAZT.SelectedIndex = 1;
                    break;
                case "2":
                    this.lblBAZT.SelectedIndex = 2;
                    break;
                case "3":
                    this.lblBAZT.SelectedIndex = 3;
                    break;
                case "4":
                    this.lblBAZT.SelectedIndex = 4;
                    break;
                case "5":
                    this.lblBAZT.SelectedIndex = 5;
                    break;
            }
         



            this.lblBABH.Text = model.BABH;
            this.lblBASJ.Text = model.BASJ;
            this.lblSYBM.Text = model.SYBM;
            this.lblBMZZR.Text = model.BMZZR;
            this.lblSYR.Text = model.SYR;
            this.lblJSJLX.Text = model.JSJLX;
            this.lblPPLX.Text = model.PPLX;
            this.lblWZ.Text = model.WZ;
            this.lblBZ.Text = model.BZ;
            this.lblSN.Text = model.SN;
            if(model.QYSJ!=null)
            this.dateTimePicker_QYSJ.Value =(DateTime) model.QYSJ;
            this.bh = model.BH;
        }

        //load 备案硬盘
        private DataTable loadBAYP(string bh)
        {
            DataTable newdt = new DataTable();
            DataColumn dc1 = new DataColumn("序列号", typeof(string));
            DataColumn dc2 = new DataColumn("使用情况", typeof(string));
            DataColumn dc3 = new DataColumn("报备状态", typeof(string));
            newdt.Columns.Add(dc1);
            newdt.Columns.Add(dc2);
            newdt.Columns.Add(dc3);
            //读取硬盘
            GDMAPSM.BLL.ypmsg ypbll = new BLL.ypmsg();

            DataSet ds = new DataSet();
            ds = ypbll.GetList(string.Format("BAJSJ='{0}'", bh));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow newdr = newdt.NewRow();
                newdr["序列号"] = dr["SN"];            
                switch (dr["ZT"].ToString())
                {
                    case "0":
                        newdr["报备状态"] = "已备案";
                        break;
                    case "1":
                        newdr["报备状态"] = "报备中";
                        break;
                    case "2":
                        newdr["报备状态"] = "登记";
                        break;
                    case "3":
                        newdr["报备状态"] = "销毁";
                        break;
                    case "4":
                        newdr["报备状态"] = "销毁登记";
                        break;
                    case "5":
                        newdr["报备状态"] = "销毁办理中";
                        break;
                }
                switch (dr["SYQK"].ToString())
                {
                    case "0":
                        newdr["使用情况"] = "正常";
                        break;
                    case "1":
                        newdr["使用情况"] = "非正常";
                        break;
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;

        }
        //load 接入硬盘
        private DataTable loadJRYP(string bh)
        {
            DataTable newdt = new DataTable();
            DataColumn dc1 = new DataColumn("序列号", typeof(string));
            DataColumn dc2 = new DataColumn("使用情况", typeof(string));
            DataColumn dc3 = new DataColumn("报备状态", typeof(string));
            DataColumn dc4 = new DataColumn("报备计算机", typeof(string));
            newdt.Columns.Add(dc1);
            newdt.Columns.Add(dc2);
            newdt.Columns.Add(dc3);
            newdt.Columns.Add(dc4);

            //读取硬盘
            GDMAPSM.BLL.ypmsg ypbll = new BLL.ypmsg();

            DataSet ds = new DataSet();
            ds = ypbll.GetList(string.Format("BDJSJ='{0}'", bh));
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow newdr = newdt.NewRow();
                newdr["序列号"] = dr["SN"];
                newdr["报备计算机"] = dr["BAJSJ"];
                switch (dr["ZT"].ToString())
                {
                    case "0":
                        newdr["报备状态"] = "已备案";
                        break;
                    case "1":
                        newdr["报备状态"] = "报备中";
                        break;
                    case "2":
                        newdr["报备状态"] = "登记";
                        break;
                    case "3":
                        newdr["报备状态"] = "销毁";
                        break;
                    case "4":
                        newdr["报备状态"] = "销毁登记";
                        break;
                    case "5":
                        newdr["报备状态"] = "销毁办理中";
                        break;

                }
                switch (dr["SYQK"].ToString())
                {
                    case "0":
                        newdr["使用情况"] = "正常";
                        break;
                    case "1":
                        newdr["使用情况"] = "非正常";
                        break;

                }
                newdt.Rows.Add(newdr);
            }

            return newdt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Record re = new Record(this.bh);
            re.ShowDialog();
        }
        //加载图片
        private List<string> picturepath = new List<string>();
        private int index_pic = 0;
        private string bh = "";
        string _connectionString = "";
        private void loadpic()
        {
            picturepath.Clear();
            if (!Directory.Exists(_connectionString)) Directory.CreateDirectory(_connectionString);

            DirectoryInfo theFolder = new DirectoryInfo(_connectionString);
            FileInfo[] fileinfos = theFolder.GetFiles();
            foreach (FileInfo item in fileinfos)
            {
                picturepath.Add(item.FullName);
            }
            if (picturepath.Count != 0)
                this.pictureBox1.Load(picturepath[index_pic]);


        }
        private void PCDetail_Load(object sender, EventArgs e)
        {
            this.lblWZ.Items.Clear();
            GDMAPSM.BLL.chjdmsg bll = new BLL.chjdmsg();
            
            string listWZ = bll.GetString("SELECT GROUP_CONCAT(KZH) as KZH FROM chjdmsg", "KZH");
            foreach (string wz in listWZ.Split(','))
            {
                if (wz.Length != 0)
                    this.lblWZ.Items.Add(wz);
            }

        }
        //上传图片
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openfile.FileName, _connectionString + "\\" + openfile.SafeFileName);
            }
            loadpic();

        }
        //读取变更记录
        private void loadRecord()
        {
            DataTable newdt = new DataTable();
            DataColumn dc1 = new DataColumn("时间", typeof(string));
            DataColumn dc2 = new DataColumn("硬盘SN", typeof(string));
            DataColumn dc3 = new DataColumn("事件", typeof(string));
          
            newdt.Columns.Add(dc1);
            newdt.Columns.Add(dc2);
            newdt.Columns.Add(dc3);


            GDMAPSM.BLL.yprecord bll = new BLL.yprecord();
            DataSet ds = new DataSet();
            ds = bll.GetListBySQL(String.Format("SELECT * FROM `yprecord`   where SN in( SELECT SN FROM ypmsg WHERE BAJSJ ='{0}') ORDER BY TIME ASC", this.bh));
            DataTable DT = ds.Tables[0];

            foreach (DataRow dr in DT.Rows)
            {
                DataRow drnew = newdt.NewRow();
                drnew["时间"] = dr["TIME"];
                drnew["硬盘SN"] = dr["SN"];
                switch (dr["LX"].ToString()) {

                    case "0":
                        drnew["事件"] = "备案成功";
                        break;
                    case "1":
                        drnew["事件"] = "申报报备中";
                        break;
                    case "2":
                        drnew["事件"] = "新增登记";
                        break;
                    case "3":
                        drnew["事件"] = "已销毁";
                        break;
                    case "4":
                        drnew["事件"] = "申请销毁登记中";
                        break;
                    case "5":
                        drnew["事件"] = "销毁办理中";
                        break;
                    case "6":
                        drnew["事件"] = "挂接到电脑" + dr["BH"];
                        break;
                    case "7":
                        drnew["事件"] = "挂接回备案计算机";
                        break;
                    case "8":
                        drnew["事件"] = "被管理员保管";
                        break;
                }
                newdt.Rows.Add(drnew);
            }

            this.gridControl_bgjl.DataSource = newdt;
        }
        //双击硬盘，查看硬盘详细情况
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int selectHander = gv.GetSelectedRows()[0];
            string sn = gv.GetRowCellValue(selectHander, "序列号").ToString();
            YPDetailForm ypf = new YPDetailForm(sn);
            ypf.ShowDialog();
        }

        //设置 gridview 颜色
        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            int hand = e.RowHandle;
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (hand < 0) return;
            DataRow dr = gv.GetDataRow(hand);
            if (dr==null) return;
            string syzt = dr["使用情况"].ToString();
            if (syzt == "非正常")
            {
                e.Appearance.ForeColor = Color.Red;// 改变行字体颜色
              //  e.Appearance.BackColor = Color.Red;// 改变行背景颜色
              //  e.Appearance.BackColor2 = Color.Blue;// 添加渐变颜色
            }
        }

        private void button_YD_Click(object sender, EventArgs e)
        {

            YPRecord YPRecord = new YPRecord(this.bh);
            YPRecord.ShowDialog();
        }
        //更新
        private void simpleButton_UPDATE_Click(object sender, EventArgs e)
        {
           
            GDMAPSM.BLL.pcmsg bllPC = new BLL.pcmsg();
            GDMAPSM.Model.pcmsg pcModel = bllPC.GetModel(this.bh);
          
            pcModel.BMZZR = this.lblBMZZR.Text;
            pcModel.JSJLX = this.lblJSJLX.Text;
            pcModel.SYR = this.lblSYR.Text;
            pcModel.PPLX = this.lblPPLX.Text;
            pcModel.WZ = this.lblWZ.Text;
            pcModel.SN = this.lblSN.Text;
            pcModel.BZ = this.lblBZ.Text;
            pcModel.BABH = this.lblBABH.Text;
            pcModel.BASJ = this.lblBASJ.Value.ToLongDateString();
            pcModel.QYSJ= this.dateTimePicker_QYSJ.Value;
            switch (this.lblSYZT.Text)
            {
                case "正常":
                    pcModel.SYZT = "0";
                    break;
                case "停用":
                    pcModel.SYZT = "1";
                    break;
                case "销毁":
                    pcModel.SYZT = "2";
                    break;
            }

            switch (this.lblBAZT.Text)
            {
                case "已备案":
                    pcModel.BAZT = "0";
                    break;
                case "报备中":
                    pcModel.BAZT = "1";
                    break;
                case "登记":
                    pcModel.BAZT = "2";
                    break;
                case "销毁":
                    pcModel.BAZT = "3";
                    break;
                case "销毁登记":
                    pcModel.BAZT = "4";
                    break;
                case "销毁办理中":
                    pcModel.BAZT = "5";
                    break;

            }
            if (bllPC.Update(pcModel))
            {
                MessageBox.Show("成功");
                this.Close();
            }
        }
    }
}
