﻿using System;
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
    public partial class DevQueryAccount : DevExpress.XtraEditors.XtraForm
    {

        List<Project> _projects = Project.Query();

        public DevQueryAccount()
        {
            InitializeComponent();
            MyRefresh();
        }

        private void MyRefresh()
        {
            // 绑定到表格中
            DataSet accounts = Account.GetGUIList(true);
            gridControl1.DataSource = accounts.Tables[0];

            gridView1.BestFitColumns();

            // 是否正式发票
            lueInvoice.DataSource = Account.AccountInvoicList;
            lueInvoice.DisplayMember = "Name";
            lueInvoice.ValueMember = "ValueInt";

            // 显示状态
            lueStatus.DataSource = null;
            lueStatus.DataSource = Account.AccountStatusList;
            lueStatus.DisplayMember = "Name";
            lueStatus.ValueMember = "ValueInt";
        }

        private void barRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "project_id")
            {
                long id = long.Parse(e.Value.ToString());
                if (id == 0)
                {
                    e.DisplayText = "";
                    return;
                }
                foreach (Project p in _projects)
                {
                    if (p.ID == id)
                    {
                        e.DisplayText = p.Name;
                        return;
                    }
                }
                e.DisplayText = "";
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0){
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