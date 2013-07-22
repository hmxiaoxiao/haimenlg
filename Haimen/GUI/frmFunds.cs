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
    public partial class frmFunds : Form
    {
        private Funds m_funds;

        public frmFunds(Funds funds = null)
        {
            InitializeComponent();

            if (funds != null)
            {
                m_funds = funds;
                txtName.Text = funds.Name;
            }
            else
            {
                m_funds = new Funds();
            }

            initParent();
        }

        private void initParent()
        {
            cboParent.Items.Clear();
            List<Funds> list = Funds.Query();
            foreach (Funds f in list)
            {
                cboParent.Items.Add(f.ID.ToString() + " | " + f.Name);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Verify()
        {
            m_funds.Name = txtName.Text;
            long parent_id = 0;
            if (cboParent.Text != "")
            {
                string parent = cboParent.Text;
                parent_id = long.Parse(parent.Split('|')[0].Trim());
                if (Funds.CreateByID(parent_id) != null)
                    m_funds.Parent_ID = parent_id;
                else
                    m_funds.Parent_ID = 0;
            }

            bool verify = m_funds.Verify();
            errorProvider1.SetError(txtName, "");
            errorProvider1.SetError(cboParent, "");
            if (m_funds.Error_Info.Count > 0)
            {
                foreach (KeyValuePair<string, string> kv in m_funds.Error_Info)
                {
                    if (kv.Key.ToLower() == "name")
                        errorProvider1.SetError(txtName, kv.Value);
                    if (kv.Key.ToLower() == "parent_id")
                        errorProvider1.SetError(cboParent, kv.Value);
                }
            }
            return verify;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Verify())
                return;
            long id = m_funds.ID;
            m_funds.Save();
            if (id > 0)
                MessageBox.Show("资金性质更新成功！", "注意");
            else
            {
                MessageBox.Show("资金性质新增成功！", "注意");
                m_funds = new Funds();
                txtName.Text = "";

                initParent();
            }

        }
    }
}
