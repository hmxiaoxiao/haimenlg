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

namespace Haimen.GUI
{
    public partial class DevQuerySelectBank : DevExpress.XtraEditors.XtraForm
    {
        public List<string> ID_List { get; set; }
        public Boolean SelectAll { get; set; }

        public DevQuerySelectBank()
        {
            InitializeComponent();
        }

        private void devQuerySelectBank_Load(object sender, EventArgs e)
        {
            string sql = @"
                Select 'Y' as sel, id, code, name from m_bank
                where id in (
                   select bank_id 
                   from m_company_detail 
                   where parent_id in (select id from m_company
                                    where doc <> ''))
                order by parent_id
            ";
            gridControl1.DataSource = DBFunction.RunQuerySql(sql).Tables[0];
            gridView1.BestFitColumns();
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

        private void tsbSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridView1.Columns["sel"], "Y");
            }
        }

        private void tsbReselect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (gridView1.GetRowCellValue(i,gridView1.Columns[0]).ToString() == "Y")
                    gridView1.SetRowCellValue(i, gridView1.Columns[0], "N");
                else
                    gridView1.SetRowCellValue(i, gridView1.Columns[0], "Y");
            }
        }

        private void tsbUnselected_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, gridView1.Columns[0], "N");
            }
        }

        private void tsbCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

    }
}