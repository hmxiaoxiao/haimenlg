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
    public partial class DevBalanceQuery : DevExpress.XtraEditors.XtraForm
    {
        public string Q_Code = "";
        public string Q_Bank_ID = "";
        public string Q_Company_ID = "";
        public string Q_Status = "";

        private List<Bank> m_banks;
        private List<Company> m_companies;

        public DevBalanceQuery()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Q_Code = txtCode.Text;
            if (lueBank.EditValue != null)
                Q_Bank_ID = lueBank.EditValue.ToString();
            if (lueCompany.EditValue != null)
                Q_Company_ID = lueCompany.EditValue.ToString();
            if (lueCheck.EditValue != null)
                Q_Status = lueCheck.EditValue.ToString();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DevBalanceQuery_Load(object sender, EventArgs e)
        {
            m_banks = Bank.Query();
            m_companies = Company.Query();

            lueBank.Properties.DataSource = m_banks;
            lueBank.Properties.DisplayMember = "Name";
            lueBank.Properties.ValueMember = "ID";

            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";

            lueCheck.Properties.DataSource = GlobalSet.AccountStatus;
            lueCheck.Properties.DisplayMember = "Name";
            lueCheck.Properties.ValueMember = "ValueInt";
        }
    }
}