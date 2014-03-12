using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using Haimen.Entity;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace Haimen.GUI
{
    public partial class DevBalanceBankCompany : DevExpress.XtraEditors.XtraForm
    {
        public DevBalanceBankCompany()
        {
            InitializeComponent();
        }

        private void barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataSet dt = BalanceBankCompany.GetDataTable();
            //foreach (DataColumn a in dt.Columns)
            //{
            //    GridColumn col = new GridColumn() { Caption = a.ColumnName, FieldName = a.ColumnName, Visible = true };
            //    if (col.Caption == "银行")
            //    {
            //        col.GroupIndex = 0;
            //    }
            //    else if (col.Caption == "帐号")
            //    {
            //        col.GroupIndex = 1;
            //    }
            //    //else
            //    //{
            //    //    GridSummaryItem gsi = new GridSummaryItem(DevExpress.Data.SummaryItemType.Sum, a.ColumnName,"小计：{0:C2}");
            //    //    gridView1.GroupSummary.Add(gsi);
            //    //}
            //    gridView1.Columns.Add(col);

            //}
            //GridColumn c_bankname = new GridColumn();
            //c_bankname.Caption = "银行";
            //c_bankname.Name = "c_bankname";
            //c_bankname.FieldName = "银行";
            ////c_bankname.Width = 25;
            //c_bankname.Visible = true;

            //GridColumn c_account = new GridColumn();
            //c_account.Caption = "帐号";
            //c_account.Name = "c_account";
            //c_account.FieldName = "帐号";
            //c_account.Visible = true;


            //gridView1.Columns.Add(c_bankname);
            //gridView1.Columns.Add(c_account);
            gridControl1.DataSource = dt.Tables[0];
            gridView1.BestFitColumns();
            gridView1.OptionsView.ShowFooter = true;
            //MessageBox.Show(gridView1.Columns.ToString());
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
                    e.Info.DisplayText = "G" + e.RowHandle;
                }
            }
        }
    }
}