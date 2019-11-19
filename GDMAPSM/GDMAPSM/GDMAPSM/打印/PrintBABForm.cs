using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

namespace GDMAPSM
{
    public partial class PrintBABForm : DevExpress.XtraEditors.XtraForm
    {
        public PrintBABForm(string guid)
        {
            InitializeComponent();
            this.guid = guid;
        }
        string guid = "";
        private void PrintBABForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 获取信息用于写入备案表。
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private IList<Dictionary<string, string>> getDC(string guid, string type)
        {
            IList<Dictionary<string, string>> lists = new List<Dictionary<string, string>>();
            Dictionary<string, string> list = null;
            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();
            DataSet Dataset1;
            String SQL = string.Format("SELECT BH, GROUP_CONCAT(ypmsg.SN) AS SN, pcmsg.PPLX,pcmsg.JSJLX , pcmsg.SYBM, pcmsg.BMZZR,pcmsg.BABH FROM pcmsg LEFT JOIN ypmsg ON pcmsg.BH = ypmsg.BAJSJ WHERE BH IN(SELECT PCBH FROM bblc_2 WHERE GUID = '{0}'AND LX='{1}' GROUP BY PCBH) GROUP BY BH", guid, type);
            DataSet Dataset = bll.GetListBySQL(SQL);
            DataTable dt = Dataset.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                list = new Dictionary<string, string>();
                list.Add("BMZZR", dr["BMZZR"].ToString());
                list.Add("PPLX", dr["PPLX"].ToString());
                list.Add("SYBM", dr["SYBM"].ToString());
                list.Add("JSJLX", dr["JSJLX"].ToString());
                list.Add("YPSN", dr["SN"].ToString());
                list.Add("SYRYQK", dr["BMZZR"].ToString());
                list.Add("BZ", "电脑编号" + dr["BH"].ToString());
                list.Add("BH", dr["BH"].ToString());
                Dataset1 = bll.GetListBySQL(string.Format("select YPSN FROM  bblc_2  WHERE GUID ='{0}'  and PCBH='{1}' ", guid, dr["BH"].ToString()));
                string yps = "";
                int count = 0;
                foreach (DataRow dr1 in Dataset1.Tables[0].Rows)
                {
                    yps += dr1["YPSN"].ToString() + ";";
                    count++;
                }
                string bgyy = "";
                switch (type)
                {
                    case "0":
                        bgyy = "新增一台计算机";
                        break;
                    case "1":
                        bgyy = string.Format("计算机变更，原备案编号{2}。新增{0}个硬盘，序列号分别为：{1}。", count.ToString(), yps.Substring(0, yps.Length - 1), dr["BABH"].ToString());
                        break;
                    case "2":
                        bgyy = string.Format("设备老化，需要销毁,原备案编号{0}。", dr["BABH"].ToString());
                        break;
                }
                list.Add("BGYY", bgyy);
                lists.Add(list);
            }
            return lists;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="guid"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private DataTable getDT(string guid, string[] typeS)
        {


            DataTable newDT = new DataTable();
            DataColumn dc1 = new DataColumn("序号", typeof(int));
            DataColumn dc2 = new DataColumn("备案编号", typeof(string));
            DataColumn dc3 = new DataColumn("申请业务", typeof(string));
            DataColumn dc4 = new DataColumn("部门", typeof(string));
            DataColumn dc5 = new DataColumn("责任人", typeof(string));
            DataColumn dc6 = new DataColumn("计算机类型", typeof(string));
            DataColumn dc7 = new DataColumn("品牌型号", typeof(string));
            DataColumn dc8 = new DataColumn("硬盘", typeof(string));
            DataColumn dc9 = new DataColumn("院编号", typeof(string));
            DataColumn dc10 = new DataColumn("备注", typeof(string));

            newDT.Columns.Add(dc1);
            newDT.Columns.Add(dc2);
            newDT.Columns.Add(dc3);
            newDT.Columns.Add(dc4);
            newDT.Columns.Add(dc5);
            newDT.Columns.Add(dc6);
            newDT.Columns.Add(dc7);
            newDT.Columns.Add(dc8);
            newDT.Columns.Add(dc9);
            newDT.Columns.Add(dc10);

            GDMAPSM.BLL.pcmsg bll = new BLL.pcmsg();
            GDMAPSM.BLL.ypmsg bll_YP = new BLL.ypmsg();

            DataSet Dataset1;

            foreach (var type in typeS)
            {
                String SQL = string.Format("SELECT BH, GROUP_CONCAT(ypmsg.SN) AS SN, pcmsg.PPLX,pcmsg.JSJLX , pcmsg.SYBM, pcmsg.BMZZR,pcmsg.BABH FROM pcmsg LEFT JOIN ypmsg ON pcmsg.BH = ypmsg.BAJSJ WHERE BH IN(SELECT PCBH FROM bblc_2 WHERE GUID = '{0}'AND LX='{1}' GROUP BY PCBH) GROUP BY BH", guid, type);
                DataSet Dataset = bll.GetListBySQL(SQL);
                DataTable dt = Dataset.Tables[0];
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    DataRow newDR = newDT.NewRow();
                    i++;
                    newDR["序号"] = i;
                    newDR["备案编号"] = dr["BABH"].ToString();
                    newDR["部门"] = dr["SYBM"].ToString();
                    newDR["责任人"] = dr["BMZZR"].ToString();
                    newDR["计算机类型"] = dr["JSJLX"].ToString();
                    newDR["品牌型号"] = dr["PPLX"].ToString();
                    newDR["硬盘"] = dr["SN"].ToString();
                    newDR["院编号"] = dr["BH"].ToString();

                    //获取变化的硬盘
                    Dataset1 = bll.GetListBySQL(string.Format("select YPSN FROM  bblc_2  WHERE GUID ='{0}'  and PCBH='{1}' ", guid, dr["BH"].ToString()));
                    string yps = "";
                    int count = 0;
                    foreach (DataRow dr1 in Dataset1.Tables[0].Rows)
                    {
                        yps += dr1["YPSN"].ToString() + ";";
                        count++;
                    }
                    string bgyy = "";
                    switch (type)
                    {
                        case "0":
                            bgyy = "新增一台计算机";
                            newDR["申请业务"] = "备案";
                            break;
                        case "1":
                            bgyy = string.Format("计算机变更，原备案编号{2}。新增{0}个硬盘，序列号分别为：{1}。", count.ToString(), yps.Substring(0, yps.Length - 1), dr["BABH"].ToString());
                            newDR["申请业务"] = "变更";
                            break;
                        case "2":
                            bgyy = "设备老化，需要销毁";
                            newDR["申请业务"] = "销毁";
                            break;
                    }
                    newDR["备注"] = bgyy;
                    newDT.Rows.Add(newDR);
                }

            }
            return newDT;
        }


        /// <summary>
        /// 保存到WORD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveWord_Click(object sender, EventArgs e)
        {
            String path = ConfigurationManager.AppSettings["PRINT"];
           
            GDMAPSM.Common.WordClass wordClass = new Common.WordClass();
            string outPutPaht = path + @"\Cache\" + Guid.NewGuid().ToString();

            for (int i = 0; i < 3; i++)
            {
                IList<Dictionary<string, string>> list = getDC(this.guid, i.ToString());
                if (!System.IO.Directory.Exists(outPutPaht)) System.IO.Directory.CreateDirectory(outPutPaht); //保存位置
                foreach (var listone in list)
                {
                    wordClass.WriteIntoWordone(path + @"\MB.dot", listone, outPutPaht);
                }

            }
            wordClass.CloseOBJAPP();
            Clipboard.SetDataObject(outPutPaht, true);
            MessageBox.Show("完成，已把路径复制到剪切板");
        }

        /// <summary>
        /// 新增保存到excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveDia = new SaveFileDialog();
            saveDia.Filter = "Excel|*.xls";
            saveDia.Title = "导出为Excel文件";
            if (saveDia.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.Empty.Equals(saveDia.FileName))
            {
                string fileName = saveDia.FileName;
                GDMAPSM.Common.ExcelClass excel = new Common.ExcelClass();
                string[] types= new string[3];
                types[0] = "0";
                types[1] = "1";
                types[2] = "2";
                excel.saveExcelClass(getDT(this.guid, types), fileName);
            }

        }
    }
}