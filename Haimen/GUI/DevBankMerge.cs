using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevBankMerge : DevExpress.XtraEditors.XtraForm
    {
        public DevBankMerge()
        {
            InitializeComponent();
        }

        private void InitGUI()
        {
            Bank.OrderBy = " order by name";
            List<Bank> list = Bank.Query();
            sueOldBank.Properties.DataSource = null;
            sueOldBank.Properties.DataSource = list;
            sueOldBank.Properties.DisplayMember = "Name";
            sueOldBank.Properties.ValueMember = "ID";
            sueOldBank.EditValue = null;
            gridControl1.DataSource = null;

            sueNewBank.Properties.DataSource = null;
            sueNewBank.Properties.DataSource = list;
            sueNewBank.Properties.DisplayMember = "Name";
            sueNewBank.Properties.ValueMember = "ID";
            sueNewBank.EditValue = null;
            gridControl2.DataSource = null;
        }

        private void DevBankMerge_Load(object sender, EventArgs e)
        {
            Bank.OrderBy = " order by name";
            List<Bank> list = Bank.Query();
            sueOldBank.Properties.DataSource = list;
            sueOldBank.Properties.DisplayMember = "Name";
            sueOldBank.Properties.ValueMember = "ID";

            sueNewBank.Properties.DataSource = list;
            sueNewBank.Properties.DisplayMember = "Name";
            sueNewBank.Properties.ValueMember = "ID";
        }

        private void sueOldBank_EditValueChanged(object sender, EventArgs e)
        {
            if (sueOldBank.EditValue == null)
                return;

            long id = long.Parse(sueOldBank.EditValue.ToString());
            List<CompanyDetail> list = CompanyDetail.Query("bank_id = " + id.ToString());
            gridControl1.DataSource = null;
            gridControl1.DataSource = list;
            gridView1.BestFitColumns();

        }

        private void sueNewBank_EditValueChanged(object sender, EventArgs e)
        {
            if (sueNewBank.EditValue == null)
                return;

            long id = long.Parse(sueNewBank.EditValue.ToString());
            List<CompanyDetail> list = CompanyDetail.Query("bank_id = " + id.ToString());
            gridControl2.DataSource = null;
            gridControl2.DataSource = list;
            gridView2.BestFitColumns();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (sueOldBank.EditValue == null || sueNewBank.EditValue == null)
                return;

            long old_id = long.Parse(sueOldBank.EditValue.ToString());
            long new_id = long.Parse(sueNewBank.EditValue.ToString());

            Bank newbank = Bank.CreateByID(new_id);
            if (!newbank.Merge(old_id, new_id))
            {
                MessageBox.Show(newbank.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("合并成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitGUI();
            }
        }
    }
}