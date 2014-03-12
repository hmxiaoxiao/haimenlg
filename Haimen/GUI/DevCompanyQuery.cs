using System;
using System.Collections.Generic;


namespace Haimen.GUI
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
            this.Close();
        }
    }
}