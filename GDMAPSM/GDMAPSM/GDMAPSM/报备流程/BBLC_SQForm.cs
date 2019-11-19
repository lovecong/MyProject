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
using System.IO;

namespace GDMAPSM.报备流程
{
    public partial class BBLC_SQForm : DevExpress.XtraEditors.XtraForm
    {
        public BBLC_SQForm(string guid)
        {
            InitializeComponent();
            this.GUID = guid;
        }
        string GUID = "";
        public event Refresh refreshParentForm;
        private void buttonFJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.textBox_pdf.Text = openFile.FileName;
            }
        }

        private void BBLC_SQForm_Load(object sender, EventArgs e)
        {
            this.simpleButton_FJ.Click += buttonFJ_Click;

        }

        private void simpleButton_TJ_Click(object sender, EventArgs e)
        {

            BLL.bblc_1 bll_1 = new BLL.bblc_1();
            BLL.bblc_2 bll_2 = new BLL.bblc_2();
            BLL.pcmsg bll_pc = new BLL.pcmsg();
            BLL.ypmsg bll_yp = new BLL.ypmsg();

            Model.bblc_1 MODEL_1 = bll_1.GetModel(this.GUID);
            MODEL_1.ZT = "1";
            MODEL_1.BBSJ = this.dateTimePicker1.Value;

            if (bll_1.Update(MODEL_1))
            {
                //新增计算机 更改 备案状态
                DataSet dataSet = Maticsoft.DBUtility.DbHelperMySQL.Query(string.Format("SELECT PCBH FROM bblc_2 where GUID='{0}' GROUP BY PCBH", this.GUID));

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    string pcbh = dr["PCBH"].ToString();
                    Model.pcmsg model_pc = bll_pc.GetModel(pcbh);
                    model_pc.BAZT = "1";
                    if (bll_pc.Update(model_pc))
                    {
                        //添加PC登记记录
                        BLL.pcrecord pcrecordBll = new BLL.pcrecord();
                        Model.pcrecord pcrecordModel = new Model.pcrecord();
                        pcrecordModel.LX = model_pc.BAZT;
                        pcrecordModel.TIME = this.dateTimePicker1.Value;
                        pcrecordModel.BH = model_pc.BH;
                        pcrecordBll.Add(pcrecordModel);
                    }
                }
                //新增、变更的硬盘 更改 状态
                dataSet = Maticsoft.DBUtility.DbHelperMySQL.Query(string.Format("SELECT YPSN FROM bblc_2 where GUID='{0}' and LX!='2' ", this.GUID));
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    string sn = dr["YPSN"].ToString();
                    Model.ypmsg model_yp = bll_yp.GetModel(sn);
                    model_yp.ZT = "1";
                    if (bll_yp.Update(model_yp))
                    {
                        //添加硬盘记录
                        Model.yprecord yprM = new Model.yprecord();
                        BLL.yprecord yprbll = new BLL.yprecord();
                        yprM.LX = model_yp.ZT;
                        yprM.TIME = yprM.TIME = this.dateTimePicker1.Value;
                        yprM.SN = model_yp.SN;
                        yprbll.Add(yprM);
                    }

                }
                //销毁的硬盘 更改状态为 5
                dataSet = Maticsoft.DBUtility.DbHelperMySQL.Query(string.Format("SELECT YPSN FROM bblc_2 where GUID='{0}' and LX='2' ", this.GUID));
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    string sn = dr["YPSN"].ToString();
                    Model.ypmsg model_yp = bll_yp.GetModel(sn);
                    model_yp.ZT = "5";
                    model_yp.SYQK = "1";
                    model_yp.BDJSJ = "";
                    if (bll_yp.Update(model_yp))
                    {
                        //添加硬盘记录
                        Model.yprecord yprM = new Model.yprecord();
                        BLL.yprecord yprbll = new BLL.yprecord();
                        yprM.LX = model_yp.ZT;
                        yprM.TIME = yprM.TIME = this.dateTimePicker1.Value;
                        yprM.SN = model_yp.SN;
                        yprbll.Add(yprM);
                    }
                }
                //保存附件
                if (this.textBox_pdf.Text != "")
                {
                    string G = Guid.NewGuid().ToString();
                    string outFliePath = ConfigurationManager.AppSettings["BLLC"] + "\\BL\\" + this.GUID + "\\" + G + ".pdf";
                    if (!System.IO.Directory.Exists(outFliePath)) Directory.CreateDirectory(outFliePath);
                    File.Copy(this.textBox_pdf.Text, outFliePath);

                }

                MessageBox.Show("完成");
                refreshParentForm();
                this.Close();
            }

            // 
        }
        //申请报备
        public void SQBB()
        {
            BLL.bblc_1 bll_1 = new BLL.bblc_1();
            BLL.bblc_2 bll_2 = new BLL.bblc_2();
            BLL.pcmsg bll_pc = new BLL.pcmsg();
            BLL.ypmsg bll_yp = new BLL.ypmsg();

            Model.bblc_1 MODEL_1 = bll_1.GetModel(this.GUID);
            MODEL_1.ZT = "1";
            MODEL_1.BBSJ = this.dateTimePicker1.Value;
            if (bll_1.Update(MODEL_1))
            {
                //新增计算机 更改 备案状态
                DataSet dataSet = Maticsoft.DBUtility.DbHelperMySQL.Query(string.Format("SELECT PCBH FROM bblc_2 where GUID='{0}' GROUP BY PCBH", this.GUID));

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    string pcbh = dr["PCBH"].ToString();
                    Model.pcmsg model_pc = bll_pc.GetModel(pcbh);
                    model_pc.BAZT = "1";
                    bll_pc.Update(model_pc);
                }
                //新增、变更的硬盘 更改 状态
                dataSet = Maticsoft.DBUtility.DbHelperMySQL.Query(string.Format("SELECT YPSN FROM bblc_2 where GUID='{0}' and LX!='2' ", this.GUID));
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    string sn = dr["YPSN"].ToString();
                    Model.ypmsg model_yp = bll_yp.GetModel(sn);
                    model_yp.ZT = "1";
                    bll_yp.Update(model_yp);
                }
                //销毁的硬盘 更改状态为 5
                dataSet = Maticsoft.DBUtility.DbHelperMySQL.Query(string.Format("SELECT YPSN FROM bblc_2 where GUID='{0}' and LX='2' ", this.GUID));
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    string sn = dr["YPSN"].ToString();
                    Model.ypmsg model_yp = bll_yp.GetModel(sn);
                    model_yp.ZT = "5";
                    bll_yp.Update(model_yp);
                }
                //上传附件

                MessageBox.Show("完成");
                refreshParentForm();
                this.Close();
            }

        }

        private void simpleButton_FJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter= "PDF|*.PDF|pdf|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_pdf.Text = openFileDialog.FileName;
               
            }
        }
    }
}