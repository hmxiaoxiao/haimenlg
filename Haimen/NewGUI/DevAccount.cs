using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.NewGUI
{
    public partial class DevAccount : DevExpress.XtraEditors.XtraForm
    {

        Account m_account;

        List<Bank> m_banks = Bank.Query();
        List<Company> m_companies = Company.Query();
        List<Funds> m_funds = Funds.Query();

        private void Object2form()
        {
            if (m_account.ID > 0)
            {
                dtSigned.Value = m_account.SignedDate;
                txtCode.Text = m_account.Code;
                lueInCompany.EditValue = m_account.In_Company_ID;
                lueOutCompany.EditValue = m_account.Out_Company_ID;
                txtOutComapnyAccount.Text = m_account.OutCompany.Account;
                txtOutCompanyBank.Text = m_account.OutCompany.Bank.Name;

                txtInCompanyAccount.Text = m_account.InCompany.Account;
                txtInCompanyBank.Text = m_account.InCompany.Bank.Name;

                txtMemo.Text = m_account.Memo;
            }
        }

        private void InitList()
        {
            lueInCompany.Properties.DataSource = m_companies;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            lueOutCompany.Properties.DataSource = m_companies;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";

            //lueInCompanyBank.Properties.DataSource = m_banks;
            //lueInCompanyBank.Properties.DisplayMember = "Name";
            //lueInCompanyBank.Properties.ValueMember = "ID";

            //lueOutCompanyBank.Properties.DataSource = m_banks;
            //lueOutCompanyBank.Properties.DisplayMember = "Name";
            //lueOutCompanyBank.Properties.ValueMember = "ID";

            gridControl1.DataSource = m_account.DetailList;

            inplace_funds.DataSource = m_funds;
            inplace_funds.DisplayMember = "Name";
            inplace_funds.ValueMember = "ID";

        }

        private bool Verify()
        {
            m_account.SignedDate = dtSigned.Value;
            return true;
        }

        public DevAccount(Account account = null)
        {
            InitializeComponent();

            if (account != null)
                m_account = account;
            else
                m_account = new Account();
        }

        private void DevAccount_Load(object sender, EventArgs e)
        {
            // 初始化界面
            InitList();
            Object2form();
        }

        private void lueOutCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutCompany.EditValue != null)
                m_account.Out_Company_ID = long.Parse(lueOutCompany.EditValue.ToString());
            txtOutCompanyBank.Text = m_account.OutCompany.Bank.Name;
            txtOutComapnyAccount.Text = m_account.OutCompany.Account;
        }

        private void lueInCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInCompany.EditValue != null)
                m_account.In_Company_ID = long.Parse(lueInCompany.EditValue.ToString());
            txtInCompanyBank.Text = m_account.InCompany.Bank.Name;
            txtInCompanyAccount.Text = m_account.InCompany.Account;
        }

        private void dtSigned_ValueChanged(object sender, EventArgs e)
        {
            m_account.SignedDate = dtSigned.Value;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            m_account.Code = txtCode.Text;
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            m_account.Memo = txtMemo.Text;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_account.DetailList.Add(new AccountDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_account.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            if (m_account.Save())
                MessageBox.Show("保存成功！");
        }
    }
}