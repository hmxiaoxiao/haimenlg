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
        /// <summary>
        /// 当前的资金往来列表
        /// </summary>
        private List<Account> m_accounts;

        /// <summary>
        /// 编辑资金
        /// </summary>
        private void EditAccount()
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Account a in m_accounts)
            {
                if (a.ID == id)
                {
                    DevMain main = (DevMain)this.ParentForm;
                    main.OpenForm(new DevAccount(a));
                    return;
                }
            }
        }

        /// <summary>
        ///  显示当前列表的明细
        /// </summary>
        private void ShowDetail()
        {
            long id = 0;
            if (gridView1.FocusedRowHandle >= 0)
                id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());


            foreach (Account a in m_accounts)
            {
                if (id == a.ID)
                    gridControl2.DataSource = a.DetailList;
            }
        }

        public DevAccountList()
        {
            InitializeComponent();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tsbNewOutput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevAccount());
        }

        private void tsbNewInput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevAccount());
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount();
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            ShowDetail();
        }

        private void tsbVerify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            EditAccount();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ShowDetail();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevAccountQuery aq = new DevAccountQuery();
            if (aq.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // 生成查询SQL
                List<string> filters = new List<string>();
                if (aq.Q_Code.Length > 0)
                    filters.Add(" Code like '%" + aq.Q_Code + "%' ");
                if (aq.Q_InCompany_ID.Length > 0)
                    filters.Add(" in_company_id = " + aq.Q_InCompany_ID + " ");
                if (aq.Q_OutCompany_ID.Length > 0)
                    filters.Add(" out_company_id = " + aq.Q_OutCompany_ID + " ");

                string where = "";
                foreach (string filter in filters)
                {
                    where += filter + " and ";
                }
                if (where.Length > 0)
                    where = where.Substring(0, where.Length - 4);

                m_accounts = Account.Query(where);
                gridControl1.DataSource = m_accounts;
                ShowDetail();

            }
        }


    }
}