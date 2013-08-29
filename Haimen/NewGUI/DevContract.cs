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
    public partial class DevContract : DevExpress.XtraEditors.XtraForm
    {

        private Contract m_contract;
        private List<Company> m_companies = Company.Query();

        private winStatus m_status;
        private void SetFormStatus(winStatus status)
        {
            m_status = status;
            switch (status)
            {
                case winStatus.New:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    break;
                case winStatus.Edit:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    break;
                case winStatus.View:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    break;
            }
        }

        private void InitGUI()
        {
            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";
        }

        private void Object2Form()
        {
            if (m_contract.ID > 0)
            {
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
            }
            else
            {
                txtCode.Text = "";
                txtName.Text = "";
                lueCompany.EditValue = null;
                dtSignedDate.Value = DateTime.Now;
                dtBeginDate.Value = DateTime.Now;
                dtEndDate.Value = DateTime.Now;
                txtMemo.Text = "";
                txtMoney.Text = "";
                txtPayment_ratio.Text = "";
                txtSecurity.Text = "";
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;
        }

        private bool Verify()
        {
            m_contract.Code = txtCode.Text;
            m_contract.Name = txtName.Text;
            m_contract.CompanyID = long.Parse(lueCompany.EditValue.ToString());
            m_contract.SignedDate = dtSignedDate.Value;
            m_contract.BeginDate = dtBeginDate.Value;
            m_contract.EndDate = dtEndDate.Value;
            m_contract.Memo = txtMemo.Text;
            m_contract.Money = decimal.Parse(txtMoney.Text);
            m_contract.PaymentRatio = decimal.Parse(txtPayment_ratio.Text);
            m_contract.Security = decimal.Parse(txtSecurity.Text);

            return true;
        }

        public DevContract(Contract con = null)
        {
            InitializeComponent();
            if (con != null)
            {
                m_contract = con;
                SetFormStatus(winStatus.Edit);
            }
            else
            {
                m_contract = new Contract();
                SetFormStatus(winStatus.New);
            }
        }

        private void DevContract_Load(object sender, EventArgs e)
        {
            InitGUI();
            Object2Form();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_contract.DetailList.Add(new ContractDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            m_contract.Save();
            MessageBox.Show("保存成功！");
        }

        private void tbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_contract = new Contract();
            InitGUI();
            Object2Form();
            SetFormStatus(winStatus.New);
        }

        private void tbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_contract != null && m_contract.ID > 0)
            {
                InitGUI();
                Object2Form();
                SetFormStatus(winStatus.Edit);
            }
        }

        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_contract != null && m_contract.ID > 0)
                m_contract.Destory();
            SetFormStatus(winStatus.View);
        }

        private void tbCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}