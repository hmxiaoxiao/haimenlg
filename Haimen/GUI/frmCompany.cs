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
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class frmCompany : Form
    {
        private Company m_company;
        private bool m_isEdit;

        public frmCompany(Company company = null)
        {
            InitializeComponent();

            if (company != null)
            {
                m_isEdit = true;
                m_company = company;
            }
            else
            {
                m_isEdit = false;
                m_company = new Company();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            if (m_isEdit)
                this.Text += " - 编辑";
            else
                this.Text += " - 新增";

            initBankList();
            GetObjectValue();
        }

        private void initBankList()
        {
            List<Bank> banks = Bank.Query();
            cboBankList.DataSource = banks;
            cboBankList.DisplayMember = "Name";
            cboBankList.ValueMember = "ID";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // 代码以简拼为准
            txtCode.Text = PinyinHelper.GetShortPinyin(txtName.Text).ToUpper();
        }

        // 校验数据是否正确
        private bool Verify()
        {
            SetObjectValue();

            // 调用校验对象
            if (m_company.Verify())
                return true;

            // 错误处理

            return false;
        }

        private void SetErrorInfo()
        {
            errorProvider1.SetError(txtCode, "");
            errorProvider1.SetError(txtDoc, "");
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(cboBankList, "");
            errorProvider1.SetError(txtAccount, "");

            foreach (KeyValuePair<string,string> val in m_company.Error_Info)
            {
                switch  (val.Key.ToLower())
                {
                    case "code":
                        errorProvider1.SetError(txtCode, val.Value);
                        break;
                    case "name":
                        errorProvider1.SetError(txtName, val.Value);
                        break;;
                    case "doc":
                        errorProvider1.SetError(txtDoc, val.Value);
                        break;
                }
            }
        }

        private void GetObjectValue()
        {
            initBankList();
            cboBankList.Text = "";
            if (m_company.Bank_ID > 0)
                cboBankList.SelectedValue = m_company.Bank_ID;
            txtCode.Text = m_company.Code;
            txtDoc.Text = m_company.Doc;
            txtName.Text = m_company.Name;
            txtAccount.Text = m_company.Account;
            if (m_company.Input == "X")
                cbInput.Checked = true;
            else
                cbInput.Checked = false;
            if (m_company.Output == "X")
                cbOutput.Checked = true;
            else
                cbOutput.Checked = false;
        }

        private void SetObjectValue()
        {
            // 将输入的值保存到对象里
            if (cboBankList.SelectedValue != null)
                m_company.Bank_ID = long.Parse(cboBankList.SelectedValue.ToString());
            else
                m_company.Bank_ID = 0;

            m_company.Code = txtCode.Text;
            m_company.Name = txtName.Text;
            m_company.Doc = txtDoc.Text;
            if (cbInput.Checked)
                m_company.Input = "X";
            else
                m_company.Input = "";

            if (cbInput.Checked)
                m_company.Output = "X";
            else
                m_company.Output = "";

            m_company.Account = txtAccount.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Verify())
                return;

            if (!m_company.Save())
            {
                SetErrorInfo();
                return;
            }

            if (m_isEdit)
            {
                MessageBox.Show("编辑成功！", "注意");
                this.Close();
            }
            else
            {
                MessageBox.Show("保存成功，请继续新增.", "注意");
                m_company = new Company();
                GetObjectValue();
            }

        }
    }
}
