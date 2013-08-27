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
    public partial class DevContractList : DevExpress.XtraEditors.XtraForm
    {
        private List<Contract> m_contracts;

        private void EditContract()
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());

            foreach (Contract c in m_contracts)
            {
                if (c.ID == id)
                {
                    DevContract win = new DevContract(c);
                    win.ShowDialog();
                    return;
                }
            }
        }

        public DevContractList()
        {
            InitializeComponent();
        }

        private void DevContractList_Load(object sender, EventArgs e)
        {
            m_contracts = Contract.Query();
            gridControl1.DataSource = m_contracts;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            DevContract win = new DevContract();
            win.ShowDialog();
        }

        private void tsbVerify_Click(object sender, EventArgs e)
        {
            DevContract win = new DevContract();
            win.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            EditContract();
        }

        private void tsbEdit_DoubleClick(object sender, EventArgs e)
        {
            EditContract();
        }
    }
}