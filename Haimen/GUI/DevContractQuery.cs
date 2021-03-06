﻿using System;
using System.Collections.Generic;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevContractQuery : DevExpress.XtraEditors.XtraForm
    {
        public string Q_Code = "";
        public string Q_company_ID = "";
        public string Q_Check = "";

        private List<Company> m_companies = Company.Query();

        public DevContractQuery()
        {
            InitializeComponent();
        }

        private void DevContractQuery_Load(object sender, EventArgs e)
        {
            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";

            lueCheck.Properties.DataSource = Account.AccountStatusList;
            lueCheck.Properties.DisplayMember = "Key";
            lueCheck.Properties.ValueMember = "Value";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Q_Code = txtCode.Text;
            if (lueCompany.EditValue != null)
                Q_company_ID = lueCompany.EditValue.ToString();
            if (lueCheck.EditValue != null)
                Q_Check = lueCheck.EditValue.ToString();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}