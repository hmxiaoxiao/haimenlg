﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevAcceptanceBillList : XtraForm
    {
        private List<AcceptanceBill> m_lists;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.承兑汇票, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.承兑汇票, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.承兑汇票, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.承兑汇票, (long)ActionEnum.完结))
            {
                tsbFinish.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public DevAcceptanceBillList()
        {
            InitializeComponent();
        }

        private void DevAcceptanceBillList_Load(object sender, EventArgs e)
        {
            MyRefresh();
            SetControlAccess();
        }

        private void MyRefresh()
        {
            m_lists = AcceptanceBill.Query();
            gridControl1.DataSource = m_lists;
            gridView1.BestFitColumns();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevAcceptanceBill(winStatusEnum.新增));
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (AcceptanceBill a in m_lists)
            {
                if (a.ID == id && a.Status == 0)
                {
                    DevMain main = (DevMain)this.ParentForm;
                    main.OpenForm(new DevAcceptanceBill(winStatusEnum.编辑, a));
                    return;
                }
            }
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的承兑汇票？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                long id = 0;
                if (gridView1.FocusedRowHandle >= 0)
                    id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
                AcceptanceBill acc = AcceptanceBill.CreateByID(id);
                if (acc != null && acc.Status == 0)
                {
                    acc.Destory();
                    MessageBox.Show(this, "删除承兑汇票成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 去掉当前行
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                }
            }
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void tsbFinish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (AcceptanceBill a in m_lists)
            {
                if (a.ID == id && a.Status == 0)
                {
                    DevMain main = (DevMain)this.ParentForm;
                    main.OpenForm(new DevAcceptanceBillFinish(a));
                    return;
                }
            }
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void DevAcceptanceBillList_Activated(object sender, EventArgs e)
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