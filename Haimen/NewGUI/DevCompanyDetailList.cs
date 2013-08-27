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
    public partial class DevCompanyDetailList : DevExpress.XtraEditors.XtraForm
    {
        List<Bank> banks;
        Company m_company;

        private void Ower_refresh()
        {
            List<Company> companies = Company.Query();
            tree.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Name = "root";
            root.Text = "单位列表";
            tree.Nodes.Add(root);
            foreach (Company c in companies)
            {
                TreeNode tn = new TreeNode();
                tn.Name = c.ID.ToString();
                tn.Text = c.Name;
                root.Nodes.Add(tn);
            }
        }

        private bool Verify()
        {
            return true;
        }

        public DevCompanyDetailList()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            CompanyDetail cd = new CompanyDetail();
            m_company.DetailList.Add(cd);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_company.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (m_company == null || m_company.Code != txtCode.Text)
                return;

            if (!Verify())
                return;

            if (!m_company.Save())
            {
                string err = "";
                foreach (KeyValuePair<string, string> kv in m_company.Error_Info)
                {
                    err += kv.Value + Environment.NewLine;
                }
                MessageBox.Show(err, "出错啦!");
            }
            else
            {
                MessageBox.Show("保存成功！", "注意");
            }
        }

        private void DevCompanyDetailList_Load(object sender, EventArgs e)
        {
            Ower_refresh();
        }

        private void tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string id = e.Node.Name;
            if (id == "root")
                return;     // 根结点就不用管了

            Company com = Company.CreateByID(long.Parse(id));
            if (com == null)
                return;    // 如果是空对象，可能被删除了。

            txtCode.Text = com.Code;
            txtDoc.Text = com.Doc;
            txtBank.Text = com.Bank.Name;
            txtName.Text = com.Name;
            txtAccount.Text = com.Account;

            inplace_banks.DataSource = banks;
            inplace_banks.DisplayMember = "Name";
            inplace_banks.ValueMember = "ID";
            gridControl1.DataSource = com.DetailList;

            m_company = com;
        }
    }
}