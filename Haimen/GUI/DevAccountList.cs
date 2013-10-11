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

using Haimen.Report;
using DevExpress.XtraReports.UI;

namespace Haimen.GUI
{
    public partial class DevAccountList : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 当前的资金往来列表
        /// </summary>
        private List<Account> m_accounts;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.新增))
            {
                tsbNew.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.编辑))
            {
                tsbEdit.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.删除))
            {
                tsbDelete.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.审核))
            {
                tsbCheck.Dispose();
                tsbUnCheck.Dispose();
            } 
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.支付))
            {
                tsbPay.Dispose();
                tsbUnPay.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.打印))
            {
                tsbPrint.Dispose();
            }
        }

        /// <summary>
        /// 编辑资金
        /// </summary>
        private void EditAccount(winStatusEnum status = winStatusEnum.编辑)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Account a in m_accounts)
            {
                if (a.ID == id)
                {
                    DevMain main = (DevMain)this.ParentForm;
                    main.OpenForm(new DevAccount(status, a));
                    return;
                }
            }
        }

        /// <summary>
        /// 刷新当前的界面
        /// </summary>
        private void MyRefresh()
        {
            // 取得所有的数据
            m_accounts = Account.Query();

            // 绑定到表格中
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_accounts;
            gridView1.BestFitColumns();

            // 显示明细
            ShowDetail();
            gridView3.BestFitColumns();

            lueInvoiceList.DataSource = Account.AccountInvoicList;
            lueInvoiceList.DisplayMember = "Name";
            lueInvoiceList.ValueMember = "ValueInt";

            // 显示数据源
            lueStatus.DataSource = null;
            lueStatus.DataSource = Account.AccountStatusList;
            lueStatus.DisplayMember = "Name";
            lueStatus.ValueMember = "ValueInt";
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
                {
                    gridControl2.DataSource = a.DetailList;

                    tsbPrint.Enabled = a.CanPrint();
                    tsbEdit.Enabled = a.CanEdit();
                    tsbDelete.Enabled = a.CanDelete();
                    tsbCheck.Enabled = a.CanCheck();
                    tsbUnCheck.Enabled = a.CanUnCheck();
                    tsbPay.Enabled = a.CanPay();
                    tsbUnPay.Enabled = a.CanUnPay();
                    tsb2Invoice.Enabled = a.CanConvertInvoice();
                }
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public DevAccountList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 退出当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = 0;
            if (gridView1.FocusedRowHandle >= 0)
                id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            Account acc = Account.CreateByID(id);
            if (acc != null)
            {
                if (!acc.CanDelete())
                {
                    MessageBox.Show("该单据已经审核，不能删除！");
                    return;
                }
                if (MessageBox.Show(this, "是否要删除指定的资金凭证？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    acc.Destory();
                    MessageBox.Show(this, "删除资金凭证成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 去掉当前行
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }

        /// <summary>
        /// 载入窗口时，设置数据库绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevAccountList_Load(object sender, EventArgs e)
        {
            MyRefresh();
            SetControlAccess();
        }


        /// <summary>
        /// 审核当前的资金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount(winStatusEnum.审核);
        }

        /// <summary>
        /// 双击查看当前资金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            EditAccount(winStatusEnum.查看);
        }

        /// <summary>
        /// 因为没有办法显示主从表，故只能手动显示明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 新增资金收入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevAccount(winStatusEnum.新增));
        }


        /// <summary>
        /// 刷新界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount(winStatusEnum.支付);
        }

        private void tsb2Invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount(winStatusEnum.转正式发票);
        }

        private void tsbPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Account a in m_accounts)
            {
                if (a.ID == id)
                {
                    if (!a.CanPrint())
                    {
                        MessageBox.Show("该单据尚未审核，无法打印！");
                        return;
                    }
                }
            }
            
            // Create a report. 
            rptAccountPrint report = new rptAccountPrint(id);

            // Show the report's preview. 
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void tsbView_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            
            EditAccount(winStatusEnum.查看);
        }

        private void tsbUnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount(winStatusEnum.撤审);
        }

        private void tsbUnPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditAccount(winStatusEnum.撤消支付);
        }
    }
}