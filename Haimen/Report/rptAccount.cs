using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Haimen.Entity;

namespace Haimen.Report
{
    public partial class rptAccount : DevExpress.XtraReports.UI.XtraReport
    {
        private Account m_account;
        public rptAccount(long id)
        {
            InitializeComponent();

            m_account = Account.CreateByID(id);

            this.SignedDate.Text = string.Format("{0:d}", m_account.SignedDate);
            this.Code.Text = m_account.Code;
            this.txtOutCompany.Text = m_account.OutCompanyDetail.Parent.Name;
            txtInCompany.Text = m_account.InCompanyDetail.Parent.Name;
            txtOutBank.Text = m_account.OutCompanyDetail.Bank.Name;
            txtInBank.Text = m_account.InCompanyDetail.Bank.Name;
            txtOutAccount.Text = m_account.OutCompanyDetail.Account;
            txtInAccount.Text = m_account.InCompanyDetail.Account;
            txtRMB.Text = Helper.Helper.ConvertToChinese((double)m_account.Money);
            txtMoney.Text = string.Format("{0:c}", m_account.Money);
            if (m_account.PayerID > 0)
            {
                txtChecker.Text = "审批： 同意。" + m_account.Payer.Name;
                txtCheckDate.Text = string.Format("{0:d}", m_account.CheckDate);
            }
            else
                txtChecker.Text = "";
            if (m_account.CheckerID > 0)
                txtPayer.Text = "复核：" + m_account.Checker.Name;
            else
                txtPayer.Text = "复核：";

            if (m_account.MakerID > 0)
                txtMaker.Text = "录入：" + m_account.Maker.Name;
            else
                txtMaker.Text = "录入：";

            txtUsage.Text = "";
            txtFunds.Text = "";
            foreach (AccountDetail ad in m_account.DetailList)
            {
                txtUsage.Text += ad.Usage + "  ";
                txtFunds.Text += ad.Funds.Name + "：" + string.Format("{0:c}", ad.Money) + "；  ";
            }

            txtAttach.Text = m_account.Attachment.ToString();
        }

    }
}
