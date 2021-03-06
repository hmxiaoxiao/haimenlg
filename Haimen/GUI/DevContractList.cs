﻿using System;
using System.Collections.Generic;
using System.Drawing;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevContractList : DevExpress.XtraEditors.XtraForm
    {
        private List<Contract> m_contracts;
        private DevMain m_main;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.审核))
            {
                tsbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        /// <summary>
        /// 当前表格被选中的对象
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// 自定义的刷新
        /// </summary>
        /// <param name="where"></param>
        private void MyRefresh(string where = "")
        {
            m_contracts = Contract.Query(where);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contracts;

            lueStatus.DataSource = null;
            lueStatus.DataSource = Contract.ContractStatus;
            lueStatus.DisplayMember = "Key";
            lueStatus.ValueMember = "Value";

            gridView1.BestFitColumns();
            // 显示数据源
            SetControlAccess();
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

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_main.OpenForm(new DevContract(winStatusEnum.新增));
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(winStatusEnum.编辑, ct));
        }

        /// <summary>
        /// 删除一个对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            ct.Destory();

            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(winStatusEnum.复核, ct));
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevContractQuery bq = new DevContractQuery();
            if (bq.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // 生成SQL语句
                List<string> filters = new List<string>();
                if (bq.Q_Code.Length > 0)
                    filters.Add(String.Format(" code like '%{0}%' ", bq.Q_Code));
                if (bq.Q_company_ID.Length > 0)
                    filters.Add(String.Format(" company_id = {0} ", bq.Q_company_ID));
                if (bq.Q_Check.Length > 0)
                    filters.Add(" status = " + bq.Q_Check);

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

        /// <summary>
        /// 生成支付凭证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbGen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevAccount(winStatusEnum.新增, null, ct.ID));
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        // 合同验收
        private void tsbAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContractAccept(ct));
        }

        private void tsbPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(winStatusEnum.付款申请, ct));
        }

        /// <summary>
        /// 设置决算价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCostMoney_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(winStatusEnum.设置决算价, ct));
        }

        /// <summary>
        /// 设置审计价
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCheckMoney_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Contract ct = CurrentSelectedObject();
            if (ct != null)
                m_main.OpenForm(new DevContract(winStatusEnum.设置审计价, ct));
        }

        private void DevContractList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
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
                    e.Info.Appearance.BackColor = Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle;
                }
            }
        }
    }
}