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
    public delegate void Refresh();
    public partial class AddModelForm : DevExpress.XtraEditors.XtraForm
    {
        public AddModelForm(string GUID)
        {
            InitializeComponent();
            this.GUID = GUID;
        }
        string GUID = "";

        public event Refresh refreshParentForm;
        private void AddPCForm_Load(object sender, EventArgs e)
        {
            //  this.LX.SelectedIndex = 0;
            this.BZ.SelectedIndex = 0;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LX_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.simpleButton_addyp.Click -= simpleButton_destroy_Click;
            this.simpleButton_addyp.Click -= simpleButton_addyp_Click;
            this.simpleButton_addyp.Click -= simpleButton_change_Click;
            add_pc = null;
            add_yps.Clear();
            yps_changes.Clear();
            yps_destroy.Clear();
            switch (this.LX.SelectedIndex)
            {
                case 0:
                    this.simpleButton_addyp.Click += simpleButton_addyp_Click;
                    this.PCBH.Text = "";
                    GDMAPSM.AddPCForm form = new GDMAPSM.AddPCForm();
                    form.getpc += addPC;
                    form.ShowDialog();

                    break;
                case 1:

                    this.simpleButton_addyp.Click += simpleButton_change_Click;
                    GDMAPSM.报备流程.SelectPCForm selectPcForm = new SelectPCForm();
                    selectPcForm.selectPC += selectPC;
                    selectPcForm.ShowDialog();
                    break;
                case 2:
                    this.PCBH.Text = "";

                    this.simpleButton_addyp.Click += simpleButton_destroy_Click;
                    GDMAPSM.报备流程.SelectPCForm selectPcForm1 = new SelectPCForm();
                    selectPcForm1.selectPC += selectPC;
                    selectPcForm1.ShowDialog();
                    break;
            }
        }
        #region 新增
        GDMAPSM.Model.pcmsg add_pc;
        List<Model.ypmsg> add_yps=new List<Model.ypmsg>();
        //当选择是“新增”时，返回值
        public void addPC(Model.pcmsg pc, List<Model.ypmsg> yps)
        {
            this.add_pc = pc;
            this.add_yps = yps;
            this.PCBH.Text = pc.BH;
            Re_add();
        }

        private void simpleButton_addyp_Click(object sender, EventArgs e)
        {
            AddYPForm form = new AddYPForm(this.PCBH.Text);
            form.addYP += addYP_add;
            form.ShowDialog();
        }
        private void addYP_add(Model.ypmsg yp)
        {
            this.add_yps.Add(yp);
            Re_add();
        }
        //刷新硬盘显示数量
        private void Re_add()
        {
            this.YPSN.Text = "";
            foreach (var yp in this.add_yps)
            {
                this.YPSN.Text += yp.SN + ";";
            }
        }
        private void Save_add()
        {
            BLL.pcmsg pc_bll = new BLL.pcmsg();
            BLL.ypmsg ypbll = new BLL.ypmsg();
            BLL.bblc_2 bblc2_bll = new BLL.bblc_2();

            //
            this.add_pc.BAZT = "2"; //备案状态为 登记
            if (pc_bll.Add(this.add_pc))
            {
                //添加PC登记记录
                BLL.pcrecord pcrecordBll = new BLL.pcrecord();
                Model.pcrecord pcrecordModel = new Model.pcrecord();
                pcrecordModel.LX = add_pc.BAZT;
                pcrecordModel.TIME = add_pc.DJSJ;
                pcrecordModel.BH = add_pc.BH;
                pcrecordBll.Add(pcrecordModel);

                foreach (var yp in this.add_yps)
                {
                    yp.ZT = "2";// 备案状态为 登记
                    if (ypbll.Add(yp))
                    {
                        //添加流程表2
                        Model.bblc_2 model = new Model.bblc_2();
                        model.GUID = this.GUID;
                        model.LX = "0";
                        model.BZ = this.BZ.Text;
                        model.PCBH = add_pc.BH;
                        model.YPSN = yp.SN;
                        model.BLSJ = this.dateTimePicker_DJSJ.Value;
                        bblc2_bll.Add(model);
                        // 添加硬盘记录
                      
                        //添加记录
                        Model.yprecord yprM = new Model.yprecord();
                        BLL.yprecord yprbll = new BLL.yprecord();
                        yprM.LX = yp.ZT;
                        yprM.TIME = yprM.TIME = yp.GMSJ;
                        yprM.SN = yp.SN;
                        yprbll.Add(yprM);
                    }
                }
            }
        }
        #endregion

        #region 变更
        //当选择 是“变更”时，返回值
        List< Model.ypmsg> yps_changes=new List<Model.ypmsg>();       
        public void selectPC(List<string> BHs)
        {
            if (BHs.Count == 0) return;
          this.PCBH.Text =BHs[0];
        }
        public void selectYP(string BH)
        {
            this.PCBH.Text = BH;
        }
        public void addYP_change(Model.ypmsg  YP)
        {
            this.yps_changes.Add(YP);
            Re_change();
        }
        private void simpleButton_change_Click(object sender, EventArgs e)
        {
            AddYPForm form = new AddYPForm(this.PCBH.Text);
            form.addYP += addYP_change;
            form.ShowDialog();
        }
        //刷新 变更硬盘
        private void Re_change()
        {
            this.YPSN.Text = "";
            foreach (var yp in this.yps_changes)
            {
                this.YPSN.Text += yp.SN + ";";
            }
        }
        //保存
        private void save_change()
        {
            BLL.ypmsg bll = new BLL.ypmsg();
            BLL.bblc_2 bll_bblc2 = new BLL.bblc_2();
            foreach (var yp in this.yps_changes)
            {
                //保存硬盘
                if (bll.Add(yp))
                {
                    //保存流程2
                    Model.bblc_2 bblc_2_model = new Model.bblc_2();
                    bblc_2_model.BZ = this.BZ.Text;
                    bblc_2_model.LX = "1";
                    bblc_2_model.YPSN = yp.SN;
                    bblc_2_model.PCBH = yp.BAJSJ;
                    bblc_2_model.GUID = this.GUID;
                    bblc_2_model.BLSJ = this.dateTimePicker_DJSJ.Value;
                    bll_bblc2.Add(bblc_2_model);

                    //添加记录
                    Model.yprecord yprM = new Model.yprecord();
                    BLL.yprecord yprbll = new BLL.yprecord();
                    yprM.LX = yp.ZT;
                    yprM.TIME =yp.GMSJ;
                    yprM.SN = yp.SN;
                    yprbll.Add(yprM);
                }
            }
        }
        #endregion

        #region 销毁
        public List<Model.ypmsg> yps_destroy = new List<Model.ypmsg>();
        public void SelectPY_Destroy(List<Model.ypmsg> YPs)
        {
            this.yps_destroy = YPs;
            Re_destroy();
        }
        private void Re_destroy()
        {
            this.YPSN.Text = "";
            foreach (var yp in this.yps_destroy)
            {
                this.YPSN.Text += yp.SN + ";";
            }
        }
        private void destroyYP(Model.ypmsg ypModel)
        {
            
            this.YPSN.Text = ypModel.SN;
        }
        private void simpleButton_destroy_Click(object sender, EventArgs e)
        {
            SelectYPForm form = new SelectYPForm(this.PCBH.Text);
            form.selectYP += SelectPY_Destroy;
            form.ShowDialog();
        }
        //保存
        private void save_destory()
        {
            BLL.ypmsg bll = new BLL.ypmsg();
            BLL.bblc_2 bll_bblc2 = new BLL.bblc_2();
            foreach (var yp in this.yps_destroy)
            {
                //保存硬盘
                yp.ZT = "4";
                if (bll.Update(yp))
                {
                    //保存流程2
                    Model.bblc_2 bblc_2_model = new Model.bblc_2();
                    bblc_2_model.BZ = this.BZ.Text;
                    bblc_2_model.LX = "2";
                    bblc_2_model.YPSN = yp.SN;
                    bblc_2_model.PCBH = yp.BAJSJ;
                    bblc_2_model.GUID = this.GUID;
                    bblc_2_model.BLSJ = this.dateTimePicker_DJSJ.Value;
                    bll_bblc2.Add(bblc_2_model);

                    // 添加硬盘记录
                    //添加记录
                    Model.yprecord yprM = new Model.yprecord();
                    BLL.yprecord yprbll = new BLL.yprecord();
                    yprM.LX = yp.ZT;
                    yprM.TIME = yprM.TIME = yp.GMSJ;
                    yprM.SN = yp.SN;
                    yprbll.Add(yprM);
                }
            }
        }
        #endregion

        private void simpleButton_JSJ_SELECT_Click(object sender, EventArgs e)
        {

         
        }

        private void simpleButton_ypClear_Click(object sender, EventArgs e)
        {
            this.YPSN.Text = "";
            add_yps.Clear();
            yps_changes.Clear();
            yps_destroy.Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(this.LX.Text=="新增")
            Save_add();

            if (this.LX.Text == "变更")
                save_change();

            if (this.LX.Text == "销毁")
                save_destory();

            MessageBox.Show("成功");
            refreshParentForm(); //刷新父窗体
            this.Close();

        }


    }
}