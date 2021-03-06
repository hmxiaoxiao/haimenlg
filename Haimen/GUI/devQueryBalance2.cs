﻿using System;
using System.Collections.Generic;
using System.Drawing;

using Haimen.DB;
using DevExpress.XtraPrinting;

namespace Haimen.GUI
{
    public partial class DevQueryBalance2 : DevExpress.XtraEditors.XtraForm
    {

        private List<string> bankid_list = new List<string>();
        private bool bank_selected_all = true;

        private List<string> companyid_list = new List<string>();
        private bool company_selected_all = true;

        public DevQueryBalance2()
        {
            InitializeComponent();
        }

        private void tsbSelectBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevQuerySelectBank dia = new DevQuerySelectBank();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bankid_list = dia.ID_List;
                bank_selected_all = dia.SelectAll;
                MyQuery();
            }
        }

        private void tsbSelectCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevQuerySelectCompany dia = new DevQuerySelectCompany();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                companyid_list = dia.ID_List;
                //bank_selected_all =
                company_selected_all = dia.SelectAll;
                MyQuery();
            }
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyQuery();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void MyQuery()
        {
            string sql = @"
                select c.name as companyname, b.name as bankname, d.account, d.balance, d.credit 
                from m_company_detail d, m_bank b, m_company c 
                where d.parent_id = c.id and d.bank_id = b.id and not(c.input <> 'X' and c.output <> 'X') and c.doc <> ''
            ";

            // 如果不是显示全部银行数据,则只显示选择中数据
            if (!bank_selected_all)
            {
                string ids = "";
                foreach (string id in bankid_list)
                {
                    ids += id + ",";
                }
                if (ids.Length > 0)
                    ids = ids.Substring(0, ids.Length - 1);
                if (bankid_list.Count > 0)
                    sql += String.Format(" and d.bank_id in ({0})", ids);
                else
                    sql += " and d.bank_id in ( 0 )";
            }

            // 单位数据同上处理
            if (!company_selected_all)
            {
                string ids = "";
                foreach (string id in companyid_list)
                {
                    ids += id + ",";
                }
                if (ids.Length > 0)
                    ids = ids.Substring(0, ids.Length - 1);
                if (companyid_list.Count > 0)
                    sql += String.Format(" and d.parent_id in ({0})", ids);
                else
                    sql += " and d.parent_id in ( 0 )";
            }
            sql += " order by c.name, b.name ";

            gridControl1.DataSource = DBConnection.RunQuerySql(sql).Tables[0];
            gridView1.BestFitColumns();
        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.Name == col_account.Name ||
                e.Column.Name == col_balance.Name ||
                e.Column.Name == col_credit.Name)
            {
                e.Merge = false;
                e.Handled = true;
            }
        }

        private void tsbPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem()) { Component = this.gridControl1, Landscape = true, PaperKind = System.Drawing.Printing.PaperKind.A3 };
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.None, "单位余额明细", Color.DarkBlue,
               new RectangleF(0, 0, 100, 30), BorderSide.None);

            brick.LineAlignment = BrickAlignment.Center;
            brick.Alignment = BrickAlignment.Center;
            brick.AutoWidth = true;
            brick.Font = new Font("宋体", 11f, FontStyle.Bold);
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