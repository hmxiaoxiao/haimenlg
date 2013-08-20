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
    public partial class frmContractList : Form
    {

        private List<Contract> m_contracts;

        public frmContractList()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmContract win = new frmContract();
            win.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditContract();
        }

        private void EditContract()
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());

            foreach (Contract c in m_contracts)
            {
                if (c.ID == id)
                {
                    frmContract win = new frmContract(c);
                    win.ShowDialog();
                    return;
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的合同？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除合同成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbVerify_Click(object sender, EventArgs e)
        {
            frmContract win = new frmContract();
            win.ShowDialog();
        }

        private void frmContractList_Load(object sender, EventArgs e)
        {
            m_contracts = Contract.Query();
            gridControl1.DataSource = m_contracts;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            EditContract();
        }
    }
}
