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
        private DevMain m_main;

        private Contract CurrentSelectedObject()
        {
            if (gridView1.FocusedRowHandle < 0)
                return null;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());

            foreach (Contract c in m_contracts)
            {
                if (c.ID == id)
                {
                    return c;
                }
            }
            return null;
        }

        private void MyRefresh(string where = "")
        {
            m_contracts = Contract.Query(where);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contracts;
        }

        public DevContractList()
        {
            InitializeComponent();
        }

        private void DevContractList_Load(object sender, EventArgs e)
        {
            m_main = (DevMain)this.ParentForm;

            MyRefresh();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_main.OpenForm(new DevContract());
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(ct));
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(ct));

            m_contracts = Contract.Query();
            MyRefresh();
        }

        private void tsbCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(ct));
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tsbGen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevContractQuery bq = new DevContractQuery();
            if (bq.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // 生成SQL语句
                List<string> filters = new List<string>();
                if (bq.Q_Code.Length > 0)
                    filters.Add(" code like '%" + bq.Q_Code + "%' ");
                if (bq.Q_company_ID.Length > 0)
                    filters.Add(" company_id = " + bq.Q_company_ID + " ");

                // 生成where
                string where = "";
                foreach (string filter in filters)
                {
                    where += filter + " and ";
                }
                if (where.Length > 0)
                    where = where.Substring(0, where.Length - 4);

                MyRefresh(where);
            }
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}