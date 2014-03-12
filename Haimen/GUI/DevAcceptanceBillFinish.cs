using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevAcceptanceBillFinish : XtraForm
    {
        private AcceptanceBill m_acceptance_bill;

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


        private void Init()
        {
            List<Company> inlist = Company.Query("input = 'X'");

            List<CompanyDetail> inDetails = CompanyDetail.Query(" parent_id in (select id from m_company where input = 'X')");

            lueMoveCompany.Properties.DataSource = null;
            lueMoveCompany.Properties.DataSource = inlist;
            lueMoveCompany.Properties.DisplayMember = "Name";
            lueMoveCompany.Properties.ValueMember = "ID";

            lueMoveAccount.Properties.DataSource = null;
            lueMoveAccount.Properties.DataSource = inDetails;
            lueMoveAccount.Properties.DisplayMember = "Account";
            lueMoveAccount.Properties.ValueMember = "ID";
        }

        public DevAcceptanceBillFinish(AcceptanceBill ab)
        {
            InitializeComponent();
            m_acceptance_bill = ab;
        }

        private void DevAcceptanceBillFinish_Load(object sender, EventArgs e)
        {
            Object2Form();
            Init();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void chkMove_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMove.Checked)
            {
                lueMoveCompany.Enabled = true;
                lueMoveAccount.Enabled = true;
            }
        }

        private void chkNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                lueMoveCompany.Enabled = false;
                lueMoveAccount.Enabled = false;
            }
        }

        private void lueMoveCompany_EditValueChanged(object sender, EventArgs e)
        {
            // 如果当前没有选择单位，则直接退出
            if (lueMoveCompany.EditValue == null)
                return;

            // 取得当前选的单位ID
            long id = long.Parse(lueMoveCompany.EditValue.ToString());
            Company com = Company.CreateByID(id);


            // 取得付款明细的ID
            id = 0;
            if (lueMoveAccount.EditValue != null)
                id = long.Parse(lueMoveAccount.EditValue.ToString());

            // 当前选择的付款单位明细
            lueMoveAccount.Properties.DataSource = null;
            lueMoveAccount.Properties.DataSource = com.DetailList;
            lueMoveAccount.Properties.DisplayMember = "Account";
            lueMoveAccount.Properties.ValueMember = "ID";

            // 判断如果已经选择的单位明细是否在当前的单位里，有的话就显示出来
            if (id > 0)
            {
                foreach (CompanyDetail cd in com.DetailList)
                {
                    if (cd.ID == id)
                    {
                        lueMoveAccount.EditValue = id;
                        return;
                    }
                }
            }

            // 设置银行为空，因为到这里明细还没有设置
            txtMoveBank.Text = "";
        }

        private void lueMoveAccount_EditValueChanged(object sender, EventArgs e)
        {
            //  如果没有选择，则直接退出
            if (lueMoveAccount.EditValue == null)
                return;

            // 取得当前的ID
            long id = long.Parse(lueMoveAccount.EditValue.ToString());
            CompanyDetail cd = CompanyDetail.CreateByID(id);

            // 设置单位
            lueMoveCompany.EditValue = cd.ParentID;

            // 设置银行
            txtMoveBank.Text = cd.BankName;
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (chkNormal.Checked)
            {
                m_acceptance_bill.Status = 1;
                m_acceptance_bill.MoveCompanyDetailID = 0;
            }
            if (chkMove.Checked)
            {
                m_acceptance_bill.Status = 2;
                m_acceptance_bill.MoveCompanyDetailID = long.Parse(lueMoveAccount.EditValue.ToString());
            }

            m_acceptance_bill.Save();

            layoutControl2.Enabled = false;
            layoutControl1.Enabled = false;
        }
    }
}