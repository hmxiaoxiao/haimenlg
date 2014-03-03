using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.DB;
using Haimen.Entity;

using DevExpress.XtraTreeList.Nodes;

namespace Haimen.GUI
{
    public partial class DevQuerySelectCompany : DevExpress.XtraEditors.XtraForm
    {
        public List<string> ID_List { get; set; }
        public Boolean SelectAll { get; set; }

        public DevQuerySelectCompany()
        {
            InitializeComponent();
        }

        private void devQuerySelectCompany_Load(object sender, EventArgs e)
        {
            string sql = @"
                Select 'Y' as sel, id, code, name from m_company
                where doc <> ''
            ";
            gridControl1.DataSource = DBConnection.RunQuerySql(sql).Tables[0];
            gridView1.BestFitColumns();
        }

        private void tsbSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridView1.Columns["sel"], "Y");
            }
        }

        private void tsbReSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i, gridView1.Columns[0]).ToString() == "Y")
                    gridView1.SetRowCellValue(i, gridView1.Columns[0], "N");
                else
                    gridView1.SetRowCellValue(i, gridView1.Columns[0], "Y");
            }
        }

        private void tsbUnSelected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridView1.Columns[0], "N");
            }
        }

        private void tsbConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            long count = gridView1.RowCount;
            SelectAll = true;
            ID_List = new List<string>();
            for (int i = 0; i < count; i++)
            {

                if (gridView1.GetRowCellValue(i, col_selected).ToString() == "Y")
                    ID_List.Add(gridView1.GetRowCellValue(i, col_id).ToString());
                else
                    SelectAll = false;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tsbClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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