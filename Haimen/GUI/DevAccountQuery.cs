using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevAccountQuery : DevExpress.XtraEditors.XtraForm
    {
        public string Q_Code = "";
        public string Q_InCompany_ID = "";
        public String Q_OutCompany_ID = "";

        private List<Company> m_companies = Company.Query();

        public DevAccountQuery()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Q_Code = txtCode.Text;
            if (lueInCompany.EditValue != null)
                Q_InCompany_ID = lueInCompany.EditValue.ToString();
            if (lueOutCompany.EditValue != null)
                Q_OutCompany_ID = lueOutCompany.EditValue.ToString();

            this.Close();
        }

        private void DevAccountQuery_Load(object sender, EventArgs e)
        {
            lueInCompany.Properties.DataSource = m_companies;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            lueOutCompany.Properties.DataSource = m_companies;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}