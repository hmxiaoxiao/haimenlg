﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using Haimen.Entity;
using Haimen.DB;
using System.Data.SqlClient;
using DevExpress.XtraPrinting;

namespace Haimen.GUI
{
    public partial class DevQueryIODetail : DevExpress.XtraEditors.XtraForm
    {
        public DevQueryIODetail()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            _out_company_list.DataSource = Company.Query("output = 'X'");
        }

        private void query(long id, long year, long month)
        {
            long nextyear = 0;
            long nextmonth = 0;
            if(month == 12)
            {
                nextyear = year + 1;
                nextmonth = 1;
            }
            else
            {
                nextyear = year;
                nextmonth = month + 1;
            }
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(@"
                select d.name as 单位, c.name as 银行, b1.account as 帐号, a.money as 支出, 0 as 收入, a.signed_date as 业务日期, '授权支出' as 说明, a.id as id
                from t_account a,
                     m_company_detail b1,
                     m_bank c,
                     m_company  d
                where signed_date >= @month and 
	                signed_date < @nextmonth and 
                    b1.id = a.out_companydetail_id and 
                    b1.parent_id = d.id and 
                    b1.bank_id = c.id and d.id = @id and 
                    a.deleted = 0
                union
                select d.name as 单位, c.name as 银行, b1.account as 帐号, 0 as 支出, a.money as 收入, a.signed_date as 业务日期, '授权收入' as 说明, a.id as id
                from t_account a,
                     m_company_detail b1,
                     m_bank c,
                     m_company  d
                where signed_date >= @month and 
	                signed_date < @nextmonth and 
                    b1.id = a.in_companydetail_id and 
                    b1.parent_id = d.id and 
                    b1.bank_id = c.id and d.id = @id and
                    a.deleted = 0
                union
                select b.name as 单位, d.name as 银行, c.account as 帐号, a.money as 支出, 0 as 收入, signed_date as 业务日期, '非授权支出' as 说明, a.id as id
                from t_unauth a,
                    m_company b,
                    m_company_detail c,
                    m_bank d
                where a.company_id = b.id and c.id = a.companydetail_id and c.bank_id = d.id and 
                    a.output = 'X' and signed_date >= @month and 
                    signed_date < @nextmonth 
                union
                select b.name as 单位, d.name as 银行, c.account as 帐号, 0 as 支出, a.money as 收入, signed_date as 业务日期, '非授权收入' as 说明, a.id as id
                from t_unauth a,
                    m_company b,
                    m_company_detail c,
                    m_bank d
                where a.company_id = b.id and c.id = a.companydetail_id and c.bank_id = d.id and 
                    a.input = 'X' and signed_date >= @month and 
                    signed_date < @nextmonth 
                order by a.signed_date
", DBConnection.Connection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", String.Format("{0}-{1}-01 0:0:0", year, month));
            cmd.Parameters.AddWithValue("@nextmonth", String.Format("{0}-{1}-01 0:0:0", nextyear, nextmonth));

            SqlDataAdapter da = new SqlDataAdapter(cmd);da.Fill(ds, "master");

//            string d_sql = @"
//                select a.id, a.parent_id, b.name, a.money, a.usage
//                from t_account_detail a, m_funds b
//                where a.deleted = 0 and a.funds_id = b.id and
//                      a.parent_id in (select id from t_account  where signed_date >= @month and signed_date < @nextmonth and deleted = 0 and out_companydetail_id in (
//                             select id from m_company_detail where parent_id = @id
//))
//            ";
            
//            SqlCommand dcmd = new SqlCommand(d_sql, DBFunction.Connection);
//            dcmd.Parameters.AddWithValue("@id", id);
//            dcmd.Parameters.AddWithValue("@month", year.ToString() + "-" + month.ToString() + "-01 0:0:0");
//            dcmd.Parameters.AddWithValue("@nextmonth", nextyear.ToString() + "-" + nextmonth.ToString() + "-01 0:0:0");
//            SqlDataAdapter dda = new SqlDataAdapter(dcmd);
//            dda.Fill(ds, "detail");DataColumn key = ds.Tables["master"].Columns["id"];
//            DataColumn foreignKey = ds.Tables["detail"].Columns["parent_id"];
//            ds.Relations.Add("明细", key, foreignKey);

            gridControl1.DataSource = ds.Tables[0];
        }

        // 查询
        private void barQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Console.WriteLine("##########################");
            //Console.WriteLine(cboCompanyList.EditValue.ToString());
            //Console.WriteLine(barYM.EditValue.ToString());
            //Console.WriteLine("##########################");
            if (cboCompanyList.EditValue == null)
                return;
            if (barYM.EditValue == null)
                return;
            long id = long.Parse(cboCompanyList.EditValue.ToString());
            DateTime dt = DateTime.Parse(barYM.EditValue.ToString());
            long year = dt.Year;
            long month = dt.Month;
            query(id,year,month);
            gridView1.BestFitColumns();
        }

        private void barPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem()) { Component = this.gridControl1, Landscape = true, PaperKind = System.Drawing.Printing.PaperKind.A3 };
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.None, "授权支付明细表", Color.DarkBlue,
               new RectangleF(0, 0, 100, 30), BorderSide.None);

            brick.LineAlignment = BrickAlignment.Center;
            brick.Alignment = BrickAlignment.Center;
            brick.AutoWidth = true;
            brick.Font = new Font("宋体", 11f, FontStyle.Bold);
        }

        private void barExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
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