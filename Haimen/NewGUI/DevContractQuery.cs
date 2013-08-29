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
    public partial class DevContractQuery : DevExpress.XtraEditors.XtraForm
    {
        public string Q_Code = "";
        public string Q_company_ID = "";

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
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Q_Code = txtCode.Text;
            if (lueCompany.EditValue != null)
                Q_company_ID = lueCompany.EditValue.ToString();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}