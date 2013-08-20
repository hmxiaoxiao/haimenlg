using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class frmContract : Form
    {

        private Contract m_contract;

        private List<Company> m_companies = Company.Query();

        public frmContract(Contract con = null)
        {
            InitializeComponent();
            if (con != null)
                m_contract = con;
            else
                m_contract = new Contract();
        }

        private void tsbAttachDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContract_Load(object sender, EventArgs e)
        {
            InitGUI();   
            Object2Win();
        }

        private void InitGUI()
        {
            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";
        }

        private void Object2Win()
        {
            if (m_contract.ID <= 0)
                return;

            txtCode.Text = m_contract.Code;
            txtName.Text = m_contract.Name;
            lueCompany.EditValue = m_contract.CompanyID;
            dtSignedDate.Value = m_contract.SignedDate;
            dtBeginDate.Value = m_contract.BeginDate;
            dtEndDate.Value = m_contract.EndDate;
            txtMemo.Text = m_contract.Memo;
            txtMoney.Text = m_contract.Money.ToString();
            txtPayment_ratio.Text = m_contract.PaymentRatio.ToString();
            txtSecurity.Text = m_contract.Security.ToString();

            gridControl1.DataSource = m_contract.DetailList;
        }

        private bool Verify()
        {
            m_contract.Code = txtCode.Text ;
            m_contract.Name = txtName.Text;
            m_contract.CompanyID = long.Parse(lueCompany.EditValue.ToString());
            m_contract.SignedDate = dtSignedDate.Value;
            m_contract.BeginDate = dtBeginDate.Value;
            m_contract.EndDate = dtEndDate.Value;
            m_contract.Memo = txtMemo.Text;
            m_contract.Money = decimal.Parse( txtMoney.Text );
            m_contract.PaymentRatio = decimal.Parse( txtPayment_ratio.Text );
            m_contract.Security = decimal.Parse( txtSecurity.Text );

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Verify())
                return;

            m_contract.Save();
            MessageBox.Show("保存成功！");
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_contract.DetailList.Add(new ContractDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;
        }
    }
}
