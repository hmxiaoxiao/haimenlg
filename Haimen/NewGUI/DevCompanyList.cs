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
    public partial class DevCompanyList : DevExpress.XtraEditors.XtraForm
    {
        List<Company> m_companies;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.New))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.Edit))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.Delete))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
        }

        // 刷新界面
        private void myRefresh()
        {
            m_companies = Company.Query();
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_companies;

            SetControlAccess();
        }

        public DevCompanyList()
        {
            InitializeComponent();
        }

        // 增加
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevCompany());
        }

        // 退出
        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        // 删除
        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            if (MessageBox.Show(this, "是否要删除指定的单位？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
                Company.Delete(id);
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }

        }

        // 载入刷新界面
        private void DevCompanyList_Load(object sender, EventArgs e)
        {
            myRefresh();
        }

        // 刷新
        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            myRefresh();
        }

        // 修改
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
            Company com = Company.CreateByID(id);

            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevCompany(com));
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevCompanyQuery query_win = new DevCompanyQuery();
            if (query_win.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // 生成查询字符串
                string qcode = query_win.Q_Code;
                string qname = query_win.Q_Name;
                string qaccount = query_win.Q_Account;
                string qbankid = query_win.Q_BankID;

                List<string> filters = new List<string>();
                if (qcode.Length > 0)
                    filters.Add(" Code like '%" + qcode + "%' ");
                if (qname.Length > 0)
                    filters.Add(" Name like '%" + qname + "%' ");
                if (qaccount.Length > 0)
                    filters.Add(" Account like '%" + qaccount + "%' ");
                if (qbankid.Length > 0)
                    filters.Add(" Bank_ID = " + qbankid + " ");

                string where = "";
                foreach (string filter in filters)
                {
                    where += filter + " and ";
                }

                if (where.Length > 0)
                    where = where.Substring(0, where.Length - 4);

                // 刷新界面
                gridControl1.DataSource = null;
                gridControl1.DataSource = Company.Query(where);
            }
        }

        private void DevCompanyList_Activated(object sender, EventArgs e)
        {
            myRefresh();
        }
    }
}