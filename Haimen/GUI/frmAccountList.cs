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
    public partial class frmAccountList: Form
    {

        private List<Account> m_accounts;

        public frmAccountList()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNewOut_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }

        private void tsbNewIn_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditAccount();
        }

        private void EditAccount()
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Account a in m_accounts)
            {
                if(a.ID == id)
                {
                    frmAccount win = new frmAccount(a);
                    win.ShowDialog();
                    return;
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的资金凭证？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除资金凭证成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbVerify_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }

        private void frmAccountList_Load(object sender, EventArgs e)
        {
            m_accounts = Account.Query();
            gridControl1.DataSource = m_accounts;
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            EditAccount();
        }
    }
}
