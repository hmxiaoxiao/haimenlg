using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Qy;
using DevExpress.XtraPrinting;

namespace Haimen.GUI
{
    public partial class DevQueryBalance : DevExpress.XtraEditors.XtraForm
    {
        private List<string> bankid_list = new List<string>();
        private bool bank_selected_all = true;

        private List<string> companyid_list = new List<string>();
        private bool company_selected_all = true;

        public DevQueryBalance()
        {
            InitializeComponent();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tsbSelectBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevQuerySelectBank dia = new DevQuerySelectBank();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bankid_list = dia.ID_List;
                //bank_selected_all =
                bank_selected_all = dia.SelectAll;
                MyQuery();
            }
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyQuery();
        }

        private void MyQuery()
        {
            string sql = "select c.name as companyname, b.name as bankname, d.account, d.balance, d.credit ";
            sql += " from m_company_detail d, m_bank b, m_company c ";
            sql += " where d.parent_id = c.id and d.bank_id = b.id and not(c.input <> 'X' and c.output <> 'X') ";

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
                    sql += " and d.bank_id in (" + ids + ")";
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
                    sql += " and d.parent_id in (" + ids + ")";
                else
                    sql += " and d.parent_id in ( 0 )";
            }
            sql += " order by b.name, c.name ";

            gridControl1.DataSource = DBFunction.RunQuerySql(sql).Tables[0];
            gridView1.BestFitColumns();
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


        // 处理合并
        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            //if (e.Column.FieldName == "Order Date")
            //{
            //    GridView view = sender as GridView;
            //    DateTime val1 = (DateTime)view.GetRowCellValue(e.RowHandle1, e.Column);
            //    DateTime val2 = (DateTime)view.GetRowCellValue(e.RowHandle2, e.Column);
            //    e.Merge = val1.Date == val2.Date;
            //    e.Handled = true;
            //}
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
            string title = "单位余额明细";
            PageInfoBrick brick = e.Graph.DrawPageInfo(PageInfo.None, title, Color.DarkBlue,
               new RectangleF(0, 0, 100, 21), BorderSide.None);

            brick.LineAlignment = BrickAlignment.Center;
            brick.Alignment = BrickAlignment.Center;
            brick.AutoWidth = true;
            brick.Font = new System.Drawing.Font("宋体", 11f, FontStyle.Bold);
        }
    }
}