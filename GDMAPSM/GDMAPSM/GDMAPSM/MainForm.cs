using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using GDMAPSM.报备流程;
using DevExpress.XtraGrid.Views.Base;
using GDMAPSM.Common;
using System.Configuration;

namespace GDMAPSM
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            this.gridControl.DataSource = getDT_sblb("");
            this.gridControl.Refresh();
            this.gridView.DoubleClick += gridView_sb_DoubleClick;

            ConnectSharedFolders csf = new ConnectSharedFolders();

            //连接服务器的共享文件夹
            string ShareFolder = ConfigurationManager.AppSettings["ShareFolder"];
            string ShareFolderUser = ConfigurationManager.AppSettings["ShareFolderUser"];
            string ShareFolderPsw = ConfigurationManager.AppSettings["ShareFolderPsw"];
            if (!System.IO.Directory.Exists(ShareFolder))
            {
                csf.ConnectToSharedFolder(ShareFolder, ShareFolderUser, ShareFolderPsw);
            }
            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            // bsiRecordsCount.Caption = "RECORDS : " + Count;
        }




        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }


        #region 报备流程
        public DataTable getDT_bblc()
        {
            DataTable datatabel = new DataTable();

            DataColumn dc1 = new DataColumn("办理时间",typeof(string));
            DataColumn dc2 = new DataColumn("经办人", typeof(string));
            DataColumn dc3 = new DataColumn("状态", typeof(string));
            DataColumn dc4 = new DataColumn("办结时间", typeof(string));
            DataColumn dc5 = new DataColumn("编号", typeof(string));
            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);
            datatabel.Columns.Add(dc4);
            datatabel.Columns.Add(dc5);
            GDMAPSM.BLL.bblc_1 BLL = new BLL.bblc_1();
            DataSet Dataset= BLL.GetAllList();

            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["办理时间"] = dr["Stime"];
                switch (dr["ZT"].ToString())
                {
                    case "0":
                    dataR["状态"] = "登记";
                        break;
                    case "1":
                        dataR["状态"] = "办理中";
                        break;
                    case "2":
                        dataR["状态"] = "完成";
                        break;
  
                }
                dataR["经办人"] = dr["JBR"];
                
                dataR["办结时间"] = dr["Etime"];
                dataR["编号"] = dr["guid"];
                datatabel.Rows.Add(dataR);
            }

            datatabel.TableName = "BBLC";
            datatabel.DefaultView.Sort = "办理时间 asc";
            return datatabel.DefaultView.ToTable();
        }
     
        //新增报备流程
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddForm_BBLC form = new AddForm_BBLC();
            form.ShowDialog();
            
        }
        // 编辑报备流程
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            string guid = this.gridView.GetRowCellValue(this.gridView.GetSelectedRows()[0], "编号").ToString();
            BBLC_ListModel_DJ_Form form = new BBLC_ListModel_DJ_Form(guid);
            form.ShowDialog();
        }
        private void gridView_bb_DoubleClick(object sender, EventArgs e)
        {

            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            int hand = gv.GetSelectedRows()[0];
            if (hand < 0) return;
            DataRow dr = gv.GetDataRow(hand);
            if (dr == null) return;
            string guid = gv.GetRowCellValue(gv.GetSelectedRows()[0], "编号").ToString();
            BBLC_ListModel_DJ_Form form = new BBLC_ListModel_DJ_Form(guid);
            form.ShowDialog();

        }
        #endregion
        #region 设备列表
        public DataTable getDT_sblb(string SQL)
        {
            int count = 0;
            DataTable datatabel = new DataTable();
            DataColumn dc1 = new DataColumn("序号", typeof(int));
            DataColumn dc2 = new DataColumn("编号", typeof(string));
            DataColumn dc3 = new DataColumn("使用状态", typeof(string));
            DataColumn dc4 = new DataColumn("备案状态", typeof(string));
            DataColumn dc5 = new DataColumn("部门", typeof(string));
            DataColumn dc6 = new DataColumn("责任人", typeof(string));
            DataColumn dc7 = new DataColumn("品牌型号", typeof(string));
            DataColumn dc8 = new DataColumn("位置", typeof(string));

            DataColumn dc9 = new DataColumn("备案编号", typeof(string));
            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);
            datatabel.Columns.Add(dc4);
            datatabel.Columns.Add(dc5);
            datatabel.Columns.Add(dc6);
            datatabel.Columns.Add(dc7);
            datatabel.Columns.Add(dc8);
            datatabel.Columns.Add(dc9);
            GDMAPSM.BLL.pcmsg BLL = new BLL.pcmsg();
            DataSet Dataset = BLL.GetList(SQL);

            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();

                switch (dr["SYZT"].ToString())
                {
                    case "0":
                        dataR["使用状态"] = "正常";
                        break;
                    case "1":
                        dataR["使用状态"] = "停用";
                        break;
                    case "2":
                        dataR["使用状态"] = "销毁";
                        break;
                }
                switch (dr["BAZT"].ToString())
                {
                    case "0":
                        dataR["备案状态"] = "已备案";
                        break;
                    case "1":
                        dataR["备案状态"] = "报备中";
                        break;
                    case "2":
                        dataR["备案状态"] = "登记";
                        break;
                    case "3":
                        dataR["备案状态"] = "销毁";
                        break;
                }
                dataR["编号"] = dr["BH"];
                dataR["部门"] = dr["SYBM"];
                dataR["责任人"] = dr["BMZZR"];
                dataR["品牌型号"] = dr["PPLX"];
                dataR["位置"] = dr["WZ"];
                dataR["备案编号"] = dr["BABH"];
                if (dr["BH"].ToString().Length == 0) break;
                count++;
                dataR["序号"] = count;
                datatabel.Rows.Add(dataR);
            }
            datatabel.TableName = "SBLB";
            this.bsiRecordsCount.Caption = "RECORDS : " + count.ToString();
          //  DataView DV = new DataView(datatabel);
            return datatabel;
        }
        public DataTable getDT_sblb_Print(string SQL)
        {
            int count = 0;
            DataTable datatabel = new DataTable();
            DataColumn dc8 = new DataColumn("序号", typeof(int));
            DataColumn dc1 = new DataColumn("编号", typeof(string));
            DataColumn dc2 = new DataColumn("使用状态", typeof(string));
            DataColumn dc6 = new DataColumn("备案状态", typeof(string));
            
            DataColumn dc3 = new DataColumn("部门", typeof(string));
            DataColumn dc4 = new DataColumn("责任人", typeof(string));
            DataColumn dc5 = new DataColumn("品牌型号", typeof(string));
            DataColumn dc7 = new DataColumn("位置", typeof(string));
            DataColumn dc9 = new DataColumn("备注", typeof(string));

            DataColumn dc10 = new DataColumn("备案编号", typeof(string));
            DataColumn dc11 = new DataColumn("备案时间", typeof(string));

            datatabel.Columns.Add(dc8);
            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc6);
            datatabel.Columns.Add(dc3);
            datatabel.Columns.Add(dc4);
            datatabel.Columns.Add(dc5);
            datatabel.Columns.Add(dc7);
            datatabel.Columns.Add(dc9);
            datatabel.Columns.Add(dc10);
            datatabel.Columns.Add(dc11);

            GDMAPSM.BLL.pcmsg BLL = new BLL.pcmsg();
            DataSet Dataset = BLL.GetList(SQL);

            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();

                switch (dr["SYZT"].ToString())
                {
                    case "0":
                        dataR["使用状态"] = "正常";
                        break;
                    case "1":
                        dataR["使用状态"] = "停用";
                        break;
                    case "2":
                        dataR["使用状态"] = "销毁";
                        break;
                }
                switch (dr["BAZT"].ToString())
                {
                    case "0":
                        dataR["备案状态"] = "已备案";
                        break;
                    case "1":
                        dataR["备案状态"] = "报备中";
                        break;
                    case "2":
                        dataR["备案状态"] = "登记";
                        break;
                    case "3":
                        dataR["备案状态"] = "销毁";
                        break;
                }
                dataR["编号"] = dr["BH"];
                dataR["部门"] = dr["SYBM"];
                dataR["责任人"] = dr["BMZZR"];
                dataR["品牌型号"] = dr["PPLX"];
                dataR["位置"] = dr["WZ"];
                if (dr["BH"].ToString().Length == 0) break;
                count++;
                dataR["序号"] = count;

                datatabel.Rows.Add(dataR);
            }
            datatabel.TableName = "SBLB";
            this.bsiRecordsCount.Caption = "RECORDS : " + count.ToString();
            //  DataView DV = new DataView(datatabel);
            return datatabel;
        }
        private void barButtonItem_SBLB_Detail_ItemClick(object sender, ItemClickEventArgs e)
        {

            int selectedHandle = this.gridView.GetSelectedRows()[0];
            string bh=  this.gridView.GetRowCellValue(selectedHandle, "编号").ToString();

            PCDetail pc = new PCDetail(bh);
            pc.ShowDialog();
        }
        private void gridView_sb_DoubleClick(object sender, EventArgs e)
        {
           
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            
            int hand = gv.GetSelectedRows()[0];
            if (hand < 0) return;
            DataRow dr = gv.GetDataRow(hand);
            if (dr == null) return;
            string bh = gv.GetRowCellValue(gv.GetSelectedRows()[0], "编号").ToString();
            PCDetail pc = new PCDetail(bh);
            pc.ShowDialog();

        }

        //设置设备按部门,按是否正常搜索      
        private void repositoryItemCheckEdit2_Click(object sender, EventArgs e)
        {
           
            Boolean isallfalse = true;
            string SQLBMstring = "SYBM IN ( ";
            foreach (BarEditItemLink o in ribbonPageGroup3.ItemLinks)
            {
                string isCheck = o.EditValue.ToString();
                if (isCheck == "True")
                {
                    SQLBMstring += "'" + o.Caption + "',";
                    isallfalse = false;
                }

            }
            if (isallfalse) SQLBMstring = "";
            else
            {
                SQLBMstring = SQLBMstring.Substring(0, SQLBMstring.Length - 1) + ")";

            }
            foreach (BarEditItemLink o in ribbonPageGroup5.ItemLinks)
            {
                string isCheck = o.EditValue.ToString();
                if ("True" == isCheck)
                {
                    if (SQLBMstring.Length == 0)
                        SQLBMstring = "SYZT ='0'";
                    else
                        SQLBMstring += " AND SYZT ='0'";
                }

            }
            gridControl.DataSource = getDT_sblb(SQLBMstring);
            this.gridControl.Refresh();

        }
        #endregion
        #region 测绘基地
        public DataTable getDT_chjd(string SQL)
        {
            int count = 0;
            DataTable datatabel = new DataTable();
            DataColumn dc0 = new DataColumn("序号", typeof(int));
            DataColumn dc1 = new DataColumn("卡座号", typeof(string));
            DataColumn dc2 = new DataColumn("部门", typeof(string));
            DataColumn dc3 = new DataColumn("MAC", typeof(string));
            DataColumn dc4 = new DataColumn("IP", typeof(string));
            DataColumn dc5 = new DataColumn("光纤号", typeof(string));
            DataColumn dc6 = new DataColumn("交换机号", typeof(string));
            datatabel.Columns.Add(dc0);
            datatabel.Columns.Add(dc1);
            datatabel.Columns.Add(dc2);
            datatabel.Columns.Add(dc3);
            datatabel.Columns.Add(dc4);
            datatabel.Columns.Add(dc5);
            datatabel.Columns.Add(dc6);

            GDMAPSM.BLL.chjdmsg BLL = new BLL.chjdmsg();
            DataSet Dataset = BLL.GetList(SQL);

            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                DataRow dataR = datatabel.NewRow();
                dataR["部门"] = dr["BM"];
                dataR["卡座号"] = dr["KZH"];
                dataR["MAC"] = dr["MAC"];
                dataR["IP"] = dr["IP"];
                dataR["光纤号"] = dr["GQH"];
                dataR["交换机号"] = dr["JHJ"];
                count++;
                dataR["序号"] = count;
                datatabel.Rows.Add(dataR);
            }
            datatabel.TableName = "CHJD";
            this.bsiRecordsCount.Caption = "RECORDS : " + count.ToString();
            //  DataView DV = new DataView(datatabel);
            return datatabel;
        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void ribbonControl_SelectedPageChanging(object sender, DevExpress.XtraBars.Ribbon.RibbonPageChangingEventArgs e)
        {
            this.gridView.DoubleClick -= gridView_sb_DoubleClick;
            this.gridView.DoubleClick -= gridView_bb_DoubleClick;
            switch (e.Page.Text)
            {
                case "设备列表":
                    gridView.Columns.Clear();
                    this.gridControl.DataSource = getDT_sblb("");
                    this.gridControl.Refresh();
                    this.gridView.DoubleClick += gridView_sb_DoubleClick;
                    break;
                case "报备业务":
                   gridView.Columns.Clear();
                   this.gridControl.DataSource = getDT_bblc();
                    this.gridView.DoubleClick += gridView_bb_DoubleClick;
                    break;
                case "测绘基地":
                    gridView.Columns.Clear();
                    this.gridControl.DataSource = getDT_chjd("");
                    break;
            }
        }
        
        private void barButtonItem_Search_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        #region 打印台账封面
        private IList<Dictionary<string, string>> getDC(List<string> BHs)
        {
            if (BHs.Count == 0) return null;
            IList <Dictionary<string, string>> lists = new List<Dictionary<string, string>>();
            Dictionary<string, string> list = null;

            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();
            string BHstr = "";
            foreach (string BH in BHs)
            {
                BHstr +="'"+ BH + "',";
            }
            if (BHstr.Length > 0) BHstr = BHstr.Substring(0, BHstr.Length - 1);
            String SQL = string.Format("SELECT * FROM  (SELECT BH, GROUP_CONCAT(ypmsg.SN) AS SN, pcmsg.PPLX, pcmsg.JSJLX, pcmsg.SYBM, pcmsg.BMZZR, pcmsg.BABH, pcmsg.WZ FROM pcmsg LEFT JOIN ypmsg ON pcmsg.BH = ypmsg.BAJSJ WHERE BH IN({0}) GROUP BY BH) AS A LEFT JOIN chjdmsg ON A.WZ = chjdmsg.KZH", BHstr);
            DataSet Dataset = bll.GetListBySQL(SQL);
            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list = new Dictionary<string, string>();
                list.Add("BMZZR", dr["BMZZR"].ToString()); 
                list.Add("PPLX", dr["PPLX"].ToString());
                list.Add("BM", dr["SYBM"].ToString());
                list.Add("YPSN", dr["SN"].ToString());
                list.Add("MAC", dr["MAC"].ToString());                
                list.Add("WZ", dr["WZ"].ToString());
                list.Add("IP", dr["IP"].ToString());
                list.Add("BH", dr["BH"].ToString()); 
                list.Add("BABH", dr["BABH"].ToString()); //交换机            
                lists.Add(list);
            }
            return lists;
        }
        public void selectPC_TZ(List<string> BHs)
        {
            if (BHs.Count == 0) return;
            WordClass word = new WordClass();
            String path = ConfigurationManager.AppSettings["PRINT"];
            GDMAPSM.Common.WordClass wordClass = new Common.WordClass();
            string outPutPaht = path + @"\Cache" + "\\" + Guid.NewGuid().ToString();

            IList<Dictionary<string, string>> list = getDC(BHs);
            if (!System.IO.Directory.Exists(outPutPaht)) System.IO.Directory.CreateDirectory(outPutPaht); //保存位置
            foreach (var listone in list)
            {
                wordClass.WriteIntoWordone(path + @"\TZ.dot", listone, outPutPaht);
            }
            Clipboard.SetDataObject(outPutPaht, true);
            MessageBox.Show("完成，已把路径复制到剪切板");
            wordClass.CloseOBJAPP();
        }

        //打印台账封面
        private void barButtonItem_PCMSG_PRINT_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectPCForm form = new SelectPCForm();
            form.selectPC += selectPC_TZ;
            form.ShowDialog();
        }
        #endregion
        private void barButtonItem_CHJDprint_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        //打印
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.gridControl.ShowRibbonPrintPreview();
        }

        #region 导出涉密标签Excel

        private DataTable getDT_BQ(List<string> BHs)
        {
            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();

            if (BHs.Count == 0) return null;
            IList<Dictionary<string, string>> lists = new List<Dictionary<string, string>>();

            string BHstr = "";
            foreach (string BH in BHs)
            {
                BHstr += "'" + BH + "',";
            }
            if (BHstr.Length > 0) BHstr = BHstr.Substring(0, BHstr.Length - 1);
            String SQL = string.Format("SELECT * FROM  (SELECT BH, GROUP_CONCAT(ypmsg.SN) AS SN, pcmsg.PPLX, pcmsg.JSJLX, pcmsg.SYBM, pcmsg.BMZZR, pcmsg.BABH, pcmsg.WZ FROM pcmsg LEFT JOIN ypmsg ON pcmsg.BH = ypmsg.BAJSJ WHERE BH IN({0}) GROUP BY BH) AS A LEFT JOIN chjdmsg ON A.WZ = chjdmsg.KZH", BHstr);
            DataSet Dataset = bll.GetListBySQL(SQL);
            DataTable dt = Dataset.Tables[0];
            return dt;
        }
        public void selectPC_BQ(List<string> BHs)
        {
            if (BHs.Count == 0) return;

            SaveFileDialog saveDia = new SaveFileDialog();
            saveDia.Filter = "Excel|*.xls";
            saveDia.Title = "导出为Excel文件";
            if (saveDia.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.Empty.Equals(saveDia.FileName))
            {
                string fileName = saveDia.FileName;
                GDMAPSM.Common.ExcelClass excel = new Common.ExcelClass();
                excel.saveExcelClass(getDT_BQ(BHs), fileName);
            }
        }
        private void barButtonItem_SMBQ_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectPCForm form = new SelectPCForm();
            form.selectPC += selectPC_BQ;
            form.ShowDialog();
        }
        #endregion

        #region 导出涉密硬盘标签Excel
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectPCForm form = new SelectPCForm();
            form.selectPC += selectPC_YPBQ;
            form.ShowDialog();
        }
        public void selectPC_YPBQ(List<string> BHs)
        {
            if (BHs.Count == 0) return;

            SaveFileDialog saveDia = new SaveFileDialog();
            saveDia.Filter = "Excel|*.xls";
            saveDia.Title = "导出为Excel文件";
            if (saveDia.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.Empty.Equals(saveDia.FileName))
            {
                string fileName = saveDia.FileName;
                GDMAPSM.Common.ExcelClass excel = new Common.ExcelClass();
                excel.saveExcelClass(getDT_YPBQ(BHs), fileName);
            }
        }
        private DataTable getDT_YPBQ(List<string> BHs)
        {
            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();

            if (BHs.Count == 0) return null;
            IList<Dictionary<string, string>> lists = new List<Dictionary<string, string>>();

            string BHstr = "";
            foreach (string BH in BHs)
            {
                BHstr += "'" + BH + "',";
            }
            if (BHstr.Length > 0) BHstr = BHstr.Substring(0, BHstr.Length - 1);
            String SQL = string.Format("SELECT a.SN as YPSN,a.BAJSJ AS JSJ,b.BABH,b.SYBM FROM ypmsg as a  LEFT JOIN pcmsg as b  on a.BAJSJ=b.BH WHERE BAJSJ IN ({0}) ORDER BY a.BAJSJ DESC ", BHstr);
            DataSet Dataset = bll.GetListBySQL(SQL);
            DataTable dt = Dataset.Tables[0];
            return dt;
        }
        #endregion

        #region 设备台账打印
        private void barButtonItem_pritTZ_ItemClick(object sender, ItemClickEventArgs e)
        {
            //GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            //GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();

            //if (BHs.Count == 0) return null;
            //IList<Dictionary<string, string>> lists = new List<Dictionary<string, string>>();

            //string BHstr = "";
            //foreach (string BH in BHs)
            //{
            //    BHstr += "'" + BH + "',";
            //}
            //if (BHstr.Length > 0) BHstr = BHstr.Substring(0, BHstr.Length - 1);
            //String SQL = string.Format("SELECT * FROM  (SELECT BH, GROUP_CONCAT(ypmsg.SN) AS SN, pcmsg.PPLX, pcmsg.JSJLX, pcmsg.SYBM, pcmsg.BMZZR, pcmsg.BABH, pcmsg.WZ FROM pcmsg LEFT JOIN ypmsg ON pcmsg.BH = ypmsg.BAJSJ WHERE BH IN({0}) GROUP BY BH) AS A LEFT JOIN chjdmsg ON A.WZ = chjdmsg.KZH", BHstr);
            //DataSet Dataset = bll.GetListBySQL(SQL);
            //DataTable dt = Dataset.Tables[0];
            //return dt;
        }
        #endregion
    }
}