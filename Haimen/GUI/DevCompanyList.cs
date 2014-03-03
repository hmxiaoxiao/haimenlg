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

namespace Haimen.GUI
{
    public partial class DevCompanyList : DevExpress.XtraEditors.XtraForm
    {
        List<Company> m_companies;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.单位, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.单位, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.单位, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        // 刷新界面
        private void myRefresh()
        {
            if (tree.FocusedNode == null)
                return;

            long id = long.Parse(tree.FocusedNode.GetValue(tree_id).ToString());
            m_companies = Company.Query("parent_id = " + id.ToString());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_companies;
            gridView1.BestFitColumns();

            SetControlAccess();
        }

        public DevCompanyList()
        {
            InitializeComponent();
            tree.DataSource = Company.Query("input <> 'X' and output <> 'X'");
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

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
            Company c = Company.CreateByID(id);
            if (!c.DeleteVerify())
            {
                MessageBox.Show(c.ErrorString, "注意");
                return;
            }
            if (MessageBox.Show(this, "是否要删除指定的单位？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Company.Delete(id);
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }

        }

        // 载入刷新界面
        private void DevCompanyList_Load(object sender, EventArgs e)
        {
            myRefresh();
            SetControlAccess();
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
                gridView1.BestFitColumns();
            }
        }

        private void DevCompanyList_Activated(object sender, EventArgs e)
        {
            myRefresh();
        }

        private void tree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            myRefresh();
        }

        private void tsbBatSetOutput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    long id = long.Parse(gridView1.GetRowCellValue(i, col_id).ToString());
                    foreach (Company com in m_companies)
                    {
                        if (com.ID == id)
                        {
                            com.Output = "X";
                            com.Save();
                        }
                    }
                }
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_companies;
        }

        private void tsbUnSetOutput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    long id = long.Parse(gridView1.GetRowCellValue(i, col_id).ToString());
                    foreach (Company com in m_companies)
                    {
                        if (com.ID == id && com.Input == "X")   // 因为二个标记必须有一个，所以如果INPUT没有的话，就不能更新
                        {
                            com.Output = "";
                            com.Save();
                        }
                    }
                }
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_companies;
        }

        private void tsbSetInput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    long id = long.Parse(gridView1.GetRowCellValue(i, col_id).ToString());
                    foreach (Company com in m_companies)
                    {
                        if (com.ID == id)
                        {
                            com.Input = "X";
                            com.Save();
                        }
                    }
                }
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_companies;
        }

        private void tsbUnsetInput_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.IsRowSelected(i))
                {
                    long id = long.Parse(gridView1.GetRowCellValue(i, col_id).ToString());
                    foreach (Company com in m_companies)
                    {
                        if (com.ID == id && com.Output == "X") // 因为二个标记必须有一个，所以如果OUTPUT没有的话，就不能更新
                        {
                            com.Input = "";
                            com.Save();
                        }
                    }
                }
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_companies;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                else if (e.RowHandle < 0 && e.RowHandle > -1000)
                {
                    e.Info.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle.ToString();
                }
            }
        }
    }
}