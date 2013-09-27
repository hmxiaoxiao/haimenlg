﻿using System;
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
    public partial class DevAcceptanceBillList : DevExpress.XtraEditors.XtraForm
    {
        private List<AcceptanceBill> m_lists;

        public DevAcceptanceBillList()
        {
            InitializeComponent();
        }

        private void DevAcceptanceBillList_Load(object sender, EventArgs e)
        {
            MyRefresh();
        }

        private void MyRefresh()
        {
            m_lists = AcceptanceBill.Query();
            gridControl1.DataSource = m_lists;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevAcceptanceBill(winStatusEnum.New));
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
                    main.OpenForm(new DevAcceptanceBill(winStatusEnum.Edit, a));
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
    }
}