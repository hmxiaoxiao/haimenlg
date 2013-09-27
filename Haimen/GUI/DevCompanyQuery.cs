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
    public partial class DevCompanyQuery : DevExpress.XtraEditors.XtraForm
    {
        public string Q_Code = "";
        public string Q_Name = "";
        public string Q_Account = "";
        public string Q_BankID = "";

        public DevCompanyQuery()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Q_Code = txtCode.Text;
            Q_Name = txtName.Text;
            Q_Account = txtAccount.Text;
            if (lueBanks.EditValue != null)
                Q_BankID = lueBanks.EditValue.ToString();
            this.Close();
        }

        private void DevCompanyQuery_Load(object sender, EventArgs e)
        {
            lueBanks.Properties.DataSource = Bank.Query();
            lueBanks.Properties.DisplayMember = "Name";
            lueBanks.Properties.ValueMember = "ID";
        }
    }
}