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
    public partial class DevCompanyDetailList : DevExpress.XtraEditors.XtraForm
    {
        private List<Bank> banks = Bank.Query();
        private Company m_company;
        private CompanyDetail m_detail;
        private winStatusEnum m_status;

        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.View:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbSave.Enabled = false;
                    break;
                case winStatusEnum.Edit:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    break;
                case winStatusEnum.New:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    break;
            }
        }

        private void Ower_refresh()
        {
            List<Company> companies = Company.Query();
            tree.DataSource = companies;
        }

        private bool Verify()
        {
            return true;
        }

        public DevCompanyDetailList()
        {
            InitializeComponent();
        }

        private void DevCompanyDetailList_Load(object sender, EventArgs e)
        {
            Ower_refresh();
            SetFormStatus(winStatusEnum.View);
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            ShowCompanyDetail();
        }

        private void ShowCompanyDetail()
        {
            if (tree.FocusedNode == null)
                return;

            long id = long.Parse(tree.FocusedNode.GetValue(node_id).ToString());
            Company com = Company.CreateByID(id);
            if (com == null)
                return;    // 如果是空对象，可能被删除了。

            txtCode.Enabled = true;
            txtDoc.Enabled = true;
            txtBank.Enabled = true;
            txtName.Enabled = true;
            txtAccount.Enabled = true;

            txtCode.Text = com.Code;
            txtDoc.Text = com.Doc;
            txtBank.Text = com.Bank.Name;
            txtName.Text = com.Name;
            txtAccount.Text = com.Account;

            txtCode.Enabled = false;
            txtDoc.Enabled = false;
            txtBank.Enabled = false;
            txtName.Enabled = false;
            txtAccount.Enabled = false;

            lueBanks.DataSource = banks;
            lueBanks.DisplayMember = "Name";
            lueBanks.ValueMember = "ID";
            gridControl1.DataSource = com.DetailList;

            m_company = com;
        }

        private void tree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            ShowCompanyDetail();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_detail = new CompanyDetail();
            m_company.DetailList.Add(m_detail);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_company.DetailList;

            SetFormStatus(winStatusEnum.New);
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                SetFormStatus(winStatusEnum.View);
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (m_status == winStatusEnum.New || m_status == winStatusEnum.Edit)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_detail.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (m_status == winStatusEnum.New || m_status == winStatusEnum.Edit)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_detail.ID)
                    e.Allow = false;
            }
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_status != winStatusEnum.View)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            // 找到要编辑的银行
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (CompanyDetail cd in m_company.DetailList)
            {
                if (cd.ID == id)
                    m_detail = cd;
            }
            gridView1.OptionsBehavior.Editable = true;
            SetFormStatus(winStatusEnum.Edit);
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_status != winStatusEnum.View)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            Ower_refresh();
            SetFormStatus(winStatusEnum.View);
        }
    }
}