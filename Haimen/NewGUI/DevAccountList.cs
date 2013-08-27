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
    public partial class DevAccountList : DevExpress.XtraEditors.XtraForm
    {
        private List<Account> m_accounts;

        private void EditAccount()
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Account a in m_accounts)
            {
                if (a.ID == id)
                {
                    DevAccount win = new DevAccount(a);
                    win.ShowDialog();
                    return;
                }
            }
        }

        public DevAccountList()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevAccount win = new DevAccount();
            win.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevAccount win = new DevAccount();
            win.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的资金凭证？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除资金凭证成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DevAccountList_Load(object sender, EventArgs e)
        {
            m_accounts = Account.Query();
            gridControl1.DataSource = m_accounts;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevAccount win = new DevAccount();
            win.ShowDialog();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            EditAccount();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            long id = 0;
            if (e.RowHandle >= 0)
                id = long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString());


            foreach (Account a in m_accounts)
            {
                if (id == a.ID)
                    gridControl2.DataSource = a.DetailList;
            }
        }
    }
}