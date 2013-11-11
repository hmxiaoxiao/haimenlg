using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    /// <summary>
    /// 承况汇票
    /// </summary>
    public partial class DevAcceptanceBill : DevExpress.XtraEditors.XtraForm
    {

        /// <summary>
        /// 当前编辑的承兑汇票
        /// </summary>
        private AcceptanceBill m_acceptance_bill; 

        /// <summary>
        /// 当前窗口的状态
        /// </summary>
        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.承兑汇票, (long)ActionEnum.新增))
            {
                tsbNew.Dispose();
                //if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.承兑汇票, (long)ActionEnum.编辑))
            {
                tsbEdit.Dispose();
                //if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.承兑汇票, (long)ActionEnum.删除))
            {
                tsbDelete.Dispose();
                //if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (m_status)
            {
                case winStatusEnum.新增:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    break;
                case winStatusEnum.编辑:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    break;
                case winStatusEnum.查看:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbSave.Enabled = false;
                    break;
                case winStatusEnum.复核:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = false;
                    break;
                case winStatusEnum.纯查看:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// 设置当前输入控件是否可用。
        /// </summary>
        /// <param name="status"></param>
        private void SetEditorStatus(bool enabled)
        {
            dtDrawDate.Enabled = enabled;
            txtCode.Enabled = enabled;
            lueInCompany.Enabled = enabled;
            lueOutCompany.Enabled = enabled;
            lueInCompanyDetail.Enabled = enabled;
            lueOutCompanyDetail.Enabled = enabled;
            txtInBank.Enabled = enabled;
            txtOutBank.Enabled = enabled;
            txtTradeCode.Enabled = enabled;
            clMoney.Enabled = enabled;
            dtEndDate.Enabled = enabled;
        }

        /// <summary>
        /// 各控件加上数据源
        /// </summary>
        private void SetDataSource()
        {
            List<Company> outlist = Company.Query("output = 'X'");
            List<Company> inlist = Company.Query("input = 'X'");

            List<CompanyDetail> outDetails = CompanyDetail.Query(" parent_id in ( select id from m_company where output = 'X')");
            List<CompanyDetail> inDetails = CompanyDetail.Query(" parent_id in (select id from m_company where input = 'X')");

            lueOutCompany.Properties.DataSource = null;
            lueOutCompany.Properties.DataSource = outlist;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";

            lueInCompany.Properties.DataSource = null;
            lueInCompany.Properties.DataSource = inlist;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            lueInCompanyDetail.Properties.DataSource = null;
            lueInCompanyDetail.Properties.DataSource = inDetails;
            lueInCompanyDetail.Properties.DisplayMember = "Account";
            lueInCompanyDetail.Properties.ValueMember = "ID";

            lueOutCompanyDetail.Properties.DataSource = null;
            lueOutCompanyDetail.Properties.DataSource = outDetails;
            lueOutCompanyDetail.Properties.DisplayMember = "Account";
            lueOutCompanyDetail.Properties.ValueMember = "ID";
        }



        /// <summary>
        /// 将对象的数据显示到界面上
        /// </summary>
        private void Object2Form()
        {
            // 先设置数据源
            SetDataSource();

            // 再显示数据
            if (m_acceptance_bill.ID > 0)
            {
                dtDrawDate.EditValue = m_acceptance_bill.DrawDate;
                txtCode.Text = m_acceptance_bill.Code;
                lueInCompany.EditValue = m_acceptance_bill.InCompanyDetail.ParentID;
                lueOutCompany.EditValue = m_acceptance_bill.OutCompanyDetail.ParentID;
                lueInCompanyDetail.EditValue = m_acceptance_bill.InCompanyDetailID;
                lueOutCompanyDetail.EditValue = m_acceptance_bill.OutCompanyDetailID;
                txtInBank.Text = m_acceptance_bill.InCompanyDetail.Bank.Name;
                txtOutBank.Text = m_acceptance_bill.OutCompanyDetail.Bank.Name;
                txtTradeCode.Text = m_acceptance_bill.TradeCode;
                clMoney.Value = m_acceptance_bill.Money;
                dtEndDate.EditValue = m_acceptance_bill.EndDate;
            }
            else
            {
                dtDrawDate.EditValue = DateTime.Now;
                txtCode.Text = "";
                lueInCompany.EditValue = null;
                lueOutCompany.EditValue = null;
                lueInCompanyDetail.EditValue = null;
                lueOutCompanyDetail.EditValue = null;
                txtInBank.Text = "";
                txtOutBank.Text = "";
                clMoney.Value = 0;
                dtEndDate.EditValue = DateTime.Now;
            }
        }

        /// <summary>
        /// 将界面上的数据存到对象里
        /// </summary>
        private void Form2Object()
        {
            m_acceptance_bill.DrawDate = dtDrawDate.DateTime;
            m_acceptance_bill.Code = txtCode.Text;
            if (lueInCompanyDetail.EditValue != null)
                m_acceptance_bill.InCompanyDetailID = long.Parse(lueInCompanyDetail.EditValue.ToString());
            if (lueOutCompanyDetail.EditValue != null)
                m_acceptance_bill.OutCompanyDetailID = long.Parse(lueOutCompanyDetail.EditValue.ToString());
            m_acceptance_bill.Money = clMoney.Value;
            m_acceptance_bill.EndDate = dtEndDate.DateTime;
            m_acceptance_bill.TradeCode = txtTradeCode.Text;
        }

        /// <summary>
        /// 校验输入的内容是否正确
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            // 清空已经存在的错误 
            dxErrorProvider1.ClearErrors();

            Form2Object();
            m_acceptance_bill.Verify();
            foreach (KeyValuePair<string, string> kv in m_acceptance_bill.Error_Info)
            {
                switch (kv.Key)
                {
                    case "Code":
                        dxErrorProvider1.SetError(txtCode, kv.Value);
                        break;
                    case "TradeCode":
                        dxErrorProvider1.SetError(txtTradeCode, kv.Value);
                        break;
                    case "InCompanyDetail":
                        dxErrorProvider1.SetError(lueInCompanyDetail, kv.Value);
                        break;
                    case "OutCompanyDetail":
                        dxErrorProvider1.SetError(lueOutCompanyDetail, kv.Value);
                        break;
                    case "Money":
                        dxErrorProvider1.SetError(clMoney, kv.Value);
                        break;
                }
            }

            return !dxErrorProvider1.HasErrors;
        }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="status"></param>
        /// <param name="id"></param>
        public DevAcceptanceBill(winStatusEnum status, AcceptanceBill ab = null)
        {
            InitializeComponent();

            SetFormStatus(status);
            if (ab == null)
                m_acceptance_bill = new AcceptanceBill();
            else
                m_acceptance_bill = ab;
        }

        /// <summary>
        /// 窗口载入时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevAcceptanceBill_Load(object sender, EventArgs e)
        {
            Object2Form();
            SetControlAccess();
        }

        /// <summary>
        /// 当付款单位确认时，更新付款单位帐号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutCompany_EditValueChanged(object sender, EventArgs e)
        {
            // 如果当前没有选择单位，则直接退出
            if (lueOutCompany.EditValue == null)
                return;

            // 取得当前选的单位ID
            long id = 0;
            id = long.Parse(lueOutCompany.EditValue.ToString());
            Company com = Company.CreateByID(id);


            // 取得付款明细的ID
            id = 0;
            if (lueOutCompanyDetail.EditValue != null)
                id = long.Parse(lueOutCompanyDetail.EditValue.ToString());

            // 当前选择的付款单位明细
            lueOutCompanyDetail.Properties.DataSource = null;
            lueOutCompanyDetail.Properties.DataSource = com.DetailList;
            lueOutCompanyDetail.Properties.DisplayMember = "Account";
            lueOutCompanyDetail.Properties.ValueMember = "ID";

            // 判断如果已经选择的单位明细是否在当前的单位里，有的话就显示出来
            if (id > 0)
            {
                foreach (CompanyDetail cd in com.DetailList)
                {
                    if (cd.ID == id)
                    {
                        lueOutCompanyDetail.EditValue = id;
                        return;
                    }
                }
            }

            // 设置银行为空，因为到这里明细还没有设置
            txtOutBank.Text = "";
        }


        // 选择单位明细后，要跟单位联动！
        private void lueOutCompanyDetail_EditValueChanged(object sender, EventArgs e)
        {
            //  如果没有选择，则直接退出
            if (lueOutCompanyDetail.EditValue == null)
                return;

            // 取得当前的ID
            long id = long.Parse(lueOutCompanyDetail.EditValue.ToString());
            CompanyDetail cd = CompanyDetail.CreateByID(id);

            // 设置单位
            lueOutCompany.EditValue = cd.ParentID;

            // 设置银行
            txtOutBank.Text = cd.BankName;
        }


        /// <summary>
        /// 当收款单位确认时，更新付款单位帐号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueInCompany_EditValueChanged(object sender, EventArgs e)
        {
            // 如果当前没有选择单位，则直接退出
            if (lueInCompany.EditValue == null)
                return;

            // 取得当前选的单位ID
            long id = 0;
            id = long.Parse(lueInCompany.EditValue.ToString());
            Company com = Company.CreateByID(id);


            // 取得收款明细的ID
            id = 0;
            if (lueInCompanyDetail.EditValue != null)
                id = long.Parse(lueInCompanyDetail.EditValue.ToString());

            // 当前选择的付款单位明细
            lueInCompanyDetail.Properties.DataSource = null;
            lueInCompanyDetail.Properties.DataSource = com.DetailList;
            lueInCompanyDetail.Properties.DisplayMember = "Account";
            lueInCompanyDetail.Properties.ValueMember = "ID";

            // 判断如果已经选择的单位明细是否在当前的单位里，有的话就显示出来
            if (id > 0)
            {
                foreach (CompanyDetail cd in com.DetailList)
                {
                    if (cd.ID == id)
                    {
                        lueInCompanyDetail.EditValue = id;
                        return;
                    }
                }
            }

            // 到这里，收款单位银行为空
            txtInBank.Text = "";
        }

        // 选择收款单位明细后，要跟单位联动！
        private void lueInCompanyDetail_EditValueChanged(object sender, EventArgs e)
        {
            //  如果没有选择，则直接退出
            if (lueInCompanyDetail.EditValue == null)
                return;

            // 取得当前的ID
            long id = long.Parse(lueInCompanyDetail.EditValue.ToString());
            CompanyDetail cd = CompanyDetail.CreateByID(id);

            // 设置单位
            lueInCompany.EditValue = cd.ParentID;

            // 设置银行
            txtInBank.Text = cd.BankName;
        }


        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_acceptance_bill = new AcceptanceBill();
            Object2Form();                      //  对象显示到界面
            SetFormStatus(winStatusEnum.新增);
            SetEditorStatus(true);              // 可以编辑
            dtDrawDate.Focus();                 // 设置输入焦点
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 只有当前对象有效，才能编辑
            if (m_acceptance_bill != null && m_acceptance_bill.ID > 0)
            {
                Object2Form();                      //  对象显示到界面
                SetFormStatus(winStatusEnum.编辑);
                SetEditorStatus(true);              // 可以编辑
                dtDrawDate.Focus();                 // 设置输入焦点
            }
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 只有当前对象有效，才能删除
            if (m_acceptance_bill != null && m_acceptance_bill.ID > 0)
            {
                m_acceptance_bill.Destory();        // 删除对象
                m_acceptance_bill = new AcceptanceBill();  // 新建一个对象，以便清空界面
                Object2Form();

                m_acceptance_bill = null;
                SetFormStatus(winStatusEnum.查看);
            }
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 先校验是否正确
            if (!Verify())
                return;

            // 保存
            m_acceptance_bill.Save();

            // 设置状态
            SetEditorStatus(false);        // 不可编辑
            SetFormStatus(winStatusEnum.查看);               // 设置状态
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(m_status == winStatusEnum.查看 || m_status == winStatusEnum.纯查看))
            {
                if (MessageBox.Show("现在退出，当前做的工作将会丢失！是否真的退出？",
                                   "警告",
                                   MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
            }
            this.Close();
        }
    }
}