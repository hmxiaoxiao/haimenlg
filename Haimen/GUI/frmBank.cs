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
    public partial class frmBank : Form
    {
        private Bank m_bank;

        public frmBank(Bank bank = null)
        {
            InitializeComponent();
            if (bank != null)
            {
                m_bank = bank;
                txtCode.Text = bank.Code;
                txtName.Text = bank.Name;
            }
            else
                m_bank = new Bank();

            InitBankParent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitBankParent()
        {
            List<Bank> list = Bank.Query();
            cboBankParent.Items.Clear();

            foreach (Bank bank in list)
            {
                cboBankParent.Items.Add(bank.Code + " | " + bank.Name );
            }
        }

        private bool Verify()
        {
            m_bank.Code = txtCode.Text;
            m_bank.Name = txtName.Text;
            if (cboBankParent.Text != "")
            {
                string title = cboBankParent.Text;
                string code = title.Split('|')[0].Trim();
                List<Bank> list = Bank.Query("code = '" + code + "'");
                if (list.Count == 1)
                    m_bank.ParentID = list[0].ID;
            }
            if(m_bank.Verify())
                return true;


            errorProvider1.SetError(txtCode, "");
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(cboBankParent, "");
            foreach (KeyValuePair<string, string> kv in m_bank.Error_Info)
            {
                if (kv.Key.ToLower() == "code")
                    errorProvider1.SetError(txtCode, kv.Value);
                if (kv.Key.ToLower() == "name")
                    errorProvider1.SetError(txtName, kv.Value);
                if (kv.Key.ToLower() == "parent_id")
                    errorProvider1.SetError(cboBankParent, kv.Value);
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Verify())
                return;

            m_bank.Save();
            MessageBox.Show("保存成功，请继续增加新的银行", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitBankParent();
            m_bank = new Bank();
            txtCode.Text = "";
            txtName.Text = "";
            cboBankParent.Text = "";

        }

    }
}
