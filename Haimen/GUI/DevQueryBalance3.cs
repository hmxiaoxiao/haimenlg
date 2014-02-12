using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.DB;
using System.Data.SqlClient;
using Haimen.Report;
using DevExpress.XtraReports.UI;

namespace Haimen.GUI
{
    public partial class DevQueryBalance3 : DevExpress.XtraEditors.XtraForm
    {
        private DataSet m_ds;

        // 取得所有的银行帐号余额
        private void GetAllBalance()
        {
            m_ds = new DataSet();

            // 取得所有的单位(带凭证号的)
            string sql = @"select doc from m_company where output = 'X'";
            SqlDataAdapter dacompany = new SqlDataAdapter(sql, DBFunction.Connection);
            dacompany.Fill(m_ds, "company");

            // 取得所有的银行
            sql = @"
                    select id,name 
                    from m_bank
                    where id in 
                        (select bank_id
                        from m_company_detail
                        where parent_id in (select id from m_company where output = 'X'))
                    order by parent_id,name";
            SqlDataAdapter dabank = new SqlDataAdapter(sql, DBFunction.Connection);
            dabank.Fill(m_ds, "bank");

            // 取得余额
            sql = @"
                select b.name as b_name, c.doc as c_name, sum(d.balance) as balance
                from m_company_detail d,
                     m_bank b,
                     m_company c
                where d.parent_id in (select id from m_company where output = 'X') and 
                     d.bank_id = b.id and 
                     d.parent_id = c.id 
                group by b.name,c.doc
            ";
            SqlDataAdapter dadetail = new SqlDataAdapter(sql, DBFunction.Connection);
            dadetail.Fill(m_ds, "detail");

            // 总计行
            sql = @"
                select c.doc as doc, sum(balance) as balance
                from m_company_detail d,
                     m_company c
                where d.parent_id = c.id and c.output = 'X'
                group by c.doc        
            ";
            SqlDataAdapter dacount = new SqlDataAdapter(sql, DBFunction.Connection);
            dacount.Fill(m_ds, "count");

            // 现在生成table
            DataTable report = new DataTable("report");
            DataColumn c1 = new DataColumn("序号", typeof(int));
            report.Columns.Add(c1);
            DataColumn c2 = new DataColumn("银行名称", typeof(string));
            report.Columns.Add(c2);
            DataColumn c3 = new DataColumn("小计", typeof(decimal));
            report.Columns.Add(c3);
            foreach (DataRow dr in m_ds.Tables["company"].Rows)
            {
                DataColumn c = new DataColumn(dr["doc"].ToString(),typeof(decimal));
                report.Columns.Add(c);
            }
            // 填充数据
            int i = 1;
            foreach (DataRow bank in m_ds.Tables["bank"].Rows)
            {
                DataRow row = report.NewRow();
                row["序号"] = i++;
                row["银行名称"] = bank["name"];

                decimal sum = 0;
                foreach (DataRow doc in m_ds.Tables["company"].Rows)
                {
                    //row[doc["doc"].ToString()] = 0;
                    
                    foreach (DataRow detail in m_ds.Tables["detail"].Rows)
                    {
                        if (detail["b_name"].ToString() == bank["name"].ToString() &&
                           detail["c_name"].ToString() == doc["doc"].ToString())
                        {
                            if (decimal.Parse(detail["balance"].ToString()) != (decimal)0)
                            {
                                row[doc["doc"].ToString()] = detail["balance"];
                                sum += decimal.Parse(detail["balance"].ToString());
                            }
                        }
                    }
                    //if (decimal.Parse(row[doc["doc"].ToString()]) == 0)
                    //    row[doc["doc"].ToString()] = "";
                    if(sum != 0)
                        row["小计"] = sum;
                }

                report.Rows.Add(row);
            }

            DataRow countrow = report.NewRow();
            countrow["银行名称"] = "总计";
            decimal d_sum = 0;
            foreach (DataRow count in m_ds.Tables["count"].Rows)
            {
                foreach (DataRow doc in m_ds.Tables["company"].Rows)
                {
                    if (doc["doc"].ToString() == count["doc"].ToString() &&
                        decimal.Parse(count["balance"].ToString()) != (decimal)0)
                    {
                        countrow[doc["doc"].ToString()] = count["balance"];
                        d_sum += decimal.Parse(count["balance"].ToString());
                    }
                }
            }
            if (d_sum != (decimal)0)
                countrow["小计"] = d_sum;
            report.Rows.Add(countrow);
            
            m_ds.Tables.Add(report);

            gridControl1.DataSource = m_ds.Tables["report"];
            gridControl1.ForceInitialize();
            foreach (DataRow dr in m_ds.Tables["company"].Rows)
            {
                gridView1.Columns[dr["doc"].ToString()].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns[dr["doc"].ToString()].DisplayFormat.FormatString = "c2";
                gridView1.Columns[dr["doc"].ToString()].Width = 80;
            }
            gridView1.Columns["小计"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["小计"].DisplayFormat.FormatString = "c2";
            gridView1.Columns["小计"].Width = 100;
            gridView1.Columns["序号"].Width = 30;
            gridView1.Columns["银行名称"].Width = 150;
        }

        private void GetCrashBalance()
        {
            m_ds = new DataSet();

            // 取得所有的单位(带凭证号的)
            string sql = @"select doc from m_company where output = 'X'";
            SqlDataAdapter dacompany = new SqlDataAdapter(sql, DBFunction.Connection);
            dacompany.Fill(m_ds, "company");

            // 取得所有的银行
            sql = @"
                    select id,name 
                    from m_bank
                    where id in 
                        (select bank_id
                        from m_company_detail
                        where parent_id in (select id from m_company where output = 'X')) and name = '现金'
                    order by parent_id,name";
            SqlDataAdapter dabank = new SqlDataAdapter(sql, DBFunction.Connection);
            dabank.Fill(m_ds, "bank");

            // 取得现金帐户的余额
            sql = @"
                select b.name as b_name, c.doc as c_name, sum(d.balance) as balance
                from m_company_detail d,
                     m_bank b,
                     m_company c
                where d.parent_id in (select id from m_company where output = 'X') and 
                     d.bank_id = b.id and 
                     d.parent_id = c.id and d.account = '现金'
                group by b.name,c.doc
            ";
            SqlDataAdapter dadetail = new SqlDataAdapter(sql, DBFunction.Connection);
            dadetail.Fill(m_ds, "detail");

            // 总计行
            sql = @"
                select c.doc as doc, sum(balance) as balance
                from m_company_detail d,
                     m_company c
                where d.parent_id = c.id and c.output = 'X' and d.account = '现金'
                group by c.doc        
            ";
            SqlDataAdapter dacount = new SqlDataAdapter(sql, DBFunction.Connection);
            dacount.Fill(m_ds, "count");

            // 现在生成table
            DataTable report = new DataTable("report");
            DataColumn c1 = new DataColumn("序号", typeof(int));
            report.Columns.Add(c1);
            DataColumn c2 = new DataColumn("银行名称", typeof(string));
            report.Columns.Add(c2);
            DataColumn c3 = new DataColumn("小计", typeof(decimal));
            report.Columns.Add(c3);
            foreach (DataRow dr in m_ds.Tables["company"].Rows)
            {
                DataColumn c = new DataColumn(dr["doc"].ToString(), typeof(decimal));
                report.Columns.Add(c);
            }
            // 填充数据
            int i = 1;
            foreach (DataRow bank in m_ds.Tables["bank"].Rows)
            {
                DataRow row = report.NewRow();
                row["序号"] = i++;
                row["银行名称"] = bank["name"];

                decimal sum = 0;
                foreach (DataRow doc in m_ds.Tables["company"].Rows)
                {
                    //row[doc["doc"].ToString()] = 0;

                    foreach (DataRow detail in m_ds.Tables["detail"].Rows)
                    {
                        if (detail["b_name"].ToString() == bank["name"].ToString() &&
                           detail["c_name"].ToString() == doc["doc"].ToString())
                        {
                            if (decimal.Parse(detail["balance"].ToString()) != (decimal)0)
                            {
                                row[doc["doc"].ToString()] = detail["balance"];
                                sum += decimal.Parse(detail["balance"].ToString());
                            }
                        }
                    }
                    //if (decimal.Parse(row[doc["doc"].ToString()]) == 0)
                    //    row[doc["doc"].ToString()] = "";
                    if (sum != 0)
                        row["小计"] = sum;
                }

                report.Rows.Add(row);
            }

            DataRow countrow = report.NewRow();
            countrow["银行名称"] = "总计";
            decimal d_sum = 0;
            foreach (DataRow count in m_ds.Tables["count"].Rows)
            {
                foreach (DataRow doc in m_ds.Tables["company"].Rows)
                {
                    if (doc["doc"].ToString() == count["doc"].ToString() &&
                        decimal.Parse(count["balance"].ToString()) != (decimal)0)
                    {
                        countrow[doc["doc"].ToString()] = count["balance"];
                        d_sum += decimal.Parse(count["balance"].ToString());
                    }
                }
            }
            if (d_sum != (decimal)0)
                countrow["小计"] = d_sum;
            report.Rows.Add(countrow);

            m_ds.Tables.Add(report);

            gridControl1.DataSource = m_ds.Tables["report"];
            gridControl1.ForceInitialize();
            foreach (DataRow dr in m_ds.Tables["company"].Rows)
            {
                gridView1.Columns[dr["doc"].ToString()].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns[dr["doc"].ToString()].DisplayFormat.FormatString = "c2";
                gridView1.Columns[dr["doc"].ToString()].Width = 80;
            }
            gridView1.Columns["小计"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["小计"].DisplayFormat.FormatString = "c2";
            gridView1.Columns["小计"].Width = 100;
            gridView1.Columns["序号"].Width = 30;
            gridView1.Columns["银行名称"].Width = 150;
        }

        private void GetNoCrashBalance()
        {
            m_ds = new DataSet();

            // 取得所有的单位(带凭证号的)
            string sql = @"select doc from m_company where output = 'X'";
            SqlDataAdapter dacompany = new SqlDataAdapter(sql, DBFunction.Connection);
            dacompany.Fill(m_ds, "company");

            // 取得所有的银行
            sql = @"
                    select id,name 
                    from m_bank
                    where id in 
                        (select bank_id
                        from m_company_detail
                        where parent_id in (select id from m_company where output = 'X')) and name <> '现金'
                    order by parent_id,name";
            SqlDataAdapter dabank = new SqlDataAdapter(sql, DBFunction.Connection);
            dabank.Fill(m_ds, "bank");

            // 取得现金帐户的余额
            sql = @"
                select b.name as b_name, c.doc as c_name, sum(d.balance) as balance
                from m_company_detail d,
                     m_bank b,
                     m_company c
                where d.parent_id in (select id from m_company where output = 'X') and 
                     d.bank_id = b.id and 
                     d.parent_id = c.id and d.account <> '现金'
                group by b.name,c.doc
            ";
            SqlDataAdapter dadetail = new SqlDataAdapter(sql, DBFunction.Connection);
            dadetail.Fill(m_ds, "detail");

            // 总计行
            sql = @"
                select c.doc as doc, sum(balance) as balance
                from m_company_detail d,
                     m_company c
                where d.parent_id = c.id and c.output = 'X' and d.account <> '现金'
                group by c.doc        
            ";
            SqlDataAdapter dacount = new SqlDataAdapter(sql, DBFunction.Connection);
            dacount.Fill(m_ds, "count");

            // 现在生成table
            DataTable report = new DataTable("report");
            DataColumn c1 = new DataColumn("序号", typeof(int));
            report.Columns.Add(c1);
            DataColumn c2 = new DataColumn("银行名称", typeof(string));
            report.Columns.Add(c2);
            DataColumn c3 = new DataColumn("小计", typeof(decimal));
            report.Columns.Add(c3);
            foreach (DataRow dr in m_ds.Tables["company"].Rows)
            {
                DataColumn c = new DataColumn(dr["doc"].ToString(), typeof(decimal));
                report.Columns.Add(c);
            }
            // 填充数据
            int i = 1;
            foreach (DataRow bank in m_ds.Tables["bank"].Rows)
            {
                DataRow row = report.NewRow();
                row["序号"] = i++;
                row["银行名称"] = bank["name"];

                decimal sum = 0;
                foreach (DataRow doc in m_ds.Tables["company"].Rows)
                {
                    //row[doc["doc"].ToString()] = 0;

                    foreach (DataRow detail in m_ds.Tables["detail"].Rows)
                    {
                        if (detail["b_name"].ToString() == bank["name"].ToString() &&
                           detail["c_name"].ToString() == doc["doc"].ToString())
                        {
                            if (decimal.Parse(detail["balance"].ToString()) != (decimal)0)
                            {
                                row[doc["doc"].ToString()] = detail["balance"];
                                sum += decimal.Parse(detail["balance"].ToString());
                            }
                        }
                    }
                    //if (decimal.Parse(row[doc["doc"].ToString()]) == 0)
                    //    row[doc["doc"].ToString()] = "";
                    if (sum != 0)
                        row["小计"] = sum;
                }

                report.Rows.Add(row);
            }

            DataRow countrow = report.NewRow();
            countrow["银行名称"] = "总计";
            decimal d_sum = 0;
            foreach (DataRow count in m_ds.Tables["count"].Rows)
            {
                foreach (DataRow doc in m_ds.Tables["company"].Rows)
                {
                    if (doc["doc"].ToString() == count["doc"].ToString() &&
                        decimal.Parse(count["balance"].ToString()) != (decimal)0)
                    {
                        countrow[doc["doc"].ToString()] = count["balance"];
                        d_sum += decimal.Parse(count["balance"].ToString());
                    }
                }
            }
            if (d_sum != (decimal)0)
                countrow["小计"] = d_sum;
            report.Rows.Add(countrow);

            m_ds.Tables.Add(report);

            gridControl1.DataSource = m_ds.Tables["report"];
            gridControl1.ForceInitialize();
            foreach (DataRow dr in m_ds.Tables["company"].Rows)
            {
                gridView1.Columns[dr["doc"].ToString()].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gridView1.Columns[dr["doc"].ToString()].DisplayFormat.FormatString = "c2";
                gridView1.Columns[dr["doc"].ToString()].Width = 80;
            }
            gridView1.Columns["小计"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["小计"].DisplayFormat.FormatString = "c2";
            gridView1.Columns["小计"].Width = 100;
            gridView1.Columns["序号"].Width = 30;
            gridView1.Columns["银行名称"].Width = 150;
        }

        public DevQueryBalance3()
        {
            InitializeComponent();
            GetAllBalance();
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetAllBalance();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void tsbPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBalance report = new rptBalance(m_ds);

            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void barCrash_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetCrashBalance();
        }

        private void barNoCrash_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetNoCrashBalance();
        }


    }
}