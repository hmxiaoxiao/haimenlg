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

namespace Haimen.NewGUI
{
    public partial class DevBalance : DevExpress.XtraEditors.XtraForm
    {
        private Balance m_balance;
        private List<Bank> m_banks = Bank.Query();
        private List<Company> m_companies = Company.Query();

        private winStatus m_status;

        private void SetFromStatus(winStatus status)
        {
            m_status = status;
            switch (status)
            {
                case winStatus.New:
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case winStatus.Edit:
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case winStatus.View:
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    break;
            }
        }

        public DevBalance(Balance balance = null)
        {
            InitializeComponent();
            if (balance != null)
            {
                m_balance = balance;
                SetFromStatus(winStatus.Edit);
            }
            else
            {
                m_balance = new Balance();
                SetFromStatus(winStatus.New);
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Object2Win()
        {
            if (m_balance.ID > 0)
            {
                txtCode.Text = m_balance.Code;
                txtAccount.Text = m_balance.Account;
                txtMoney.Text = m_balance.Money.ToString();
                txtRate.Text = m_balance.Rate.ToString();
                lueBank.EditValue = m_balance.BankID;
                lueCompany.EditValue = m_balance.CompanyID;
                dtBeginDate.Value = m_balance.BeginDate;
                dtEndDate.Value = m_balance.EndDate;
                cboInterestDate.Text = m_balance.InterestDate.ToString();
                cboRepayDate.Text = m_balance.RepayDate.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtAccount.Text = "";
                txtMoney.Text = "";
                txtRate.Text = "";
                lueBank.EditValue = null;
                lueCompany.EditValue =null;
                dtBeginDate.Value = DateTime.Now;
                dtEndDate.Value = DateTime.Now;
                cboInterestDate.Text = "";
                cboRepayDate.Text = "";
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balance.DetailList;
        }

        private void initWin()
        {
            lueBank.Properties.DataSource = m_banks;
            lueBank.Properties.DisplayMember = "Name";
            lueBank.Properties.ValueMember = "ID";

            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";

            for (int i = 1; i <= 31; i++)
            {
                cboInterestDate.Items.Add(i);
                cboRepayDate.Items.Add(i);
            }
        }

        private bool Verify()
        {
            m_balance.Code = txtCode.Text;
            m_balance.BankID = long.Parse(lueBank.EditValue.ToString());
            m_balance.CompanyID = long.Parse(lueCompany.EditValue.ToString());
            m_balance.BeginDate = dtBeginDate.Value;
            m_balance.EndDate = dtEndDate.Value;
            m_balance.InterestDate = int.Parse(cboInterestDate.Text);
            m_balance.RepayDate = int.Parse(cboRepayDate.Text);
            m_balance.Account = txtAccount.Text;
            m_balance.Money = decimal.Parse(txtMoney.Text);
            m_balance.Rate = decimal.Parse(txtRate.Text);

            return true;
        }

        private void DevBalance_Load(object sender, EventArgs e)
        {
            initWin();
            Object2Win();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            m_balance.Save();
            SetFromStatus(winStatus.View);
            MessageBox.Show("保存成功");
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_balance.DetailList.Add(new BalanceDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balance.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_balance = new Balance();
            Object2Win();
            SetFromStatus(winStatus.New);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_balance.ID <= 0)
                return;

            Object2Win();
            SetFromStatus(winStatus.Edit);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_balance.ID > 0)
                m_balance.Destory();

            SetFromStatus(winStatus.View);
        }
    }
}