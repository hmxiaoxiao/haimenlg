using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
            string sql = @"
                select d.name as 单位, c.name as 银行, b1.account as 帐号, a.money as 支出, 0 as 收入, a.signed_date as 业务日期, a.id as id
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
                select d.name as 单位, c.name as 银行, b1.account as 帐号, 0 as 支出, a.money as 收入, a.signed_date as 业务日期, a.id as id
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
                order by a.signed_date
";


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
            SqlCommand cmd = new SqlCommand(sql, DBConnection.Connection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@month", year.ToString()+"-"+month.ToString()+"-01 0:0:0");
            cmd.Parameters.AddWithValue("@nextmonth", nextyear.ToString() + "-" + nextmonth.ToString() + "-01 0:0:0");

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
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = this.gridControl1;
            link.Landscape = true;
            link.PaperKind = System.Drawing.Printing.PaperKind.A3;
            link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
            link.CreateDocument();
            link.ShowPreview();
        }

        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string title = "授权支付明细表";
            PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.None, title, Color.DarkBlue,
               new RectangleF(0, 0, 100, 30), BorderSide.None);

            brick.LineAlignment = BrickAlignment.Center;
            brick.Alignment = BrickAlignment.Center;
            brick.AutoWidth = true;
            brick.Font = new System.Drawing.Font("宋体", 11f, FontStyle.Bold);
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
                    e.Info.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle.ToString();
                }
            }
        }
    }
}