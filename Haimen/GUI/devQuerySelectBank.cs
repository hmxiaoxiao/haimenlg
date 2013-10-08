﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Qy;

namespace Haimen.GUI
{
    public partial class devQuerySelectBank : DevExpress.XtraEditors.XtraForm
    {
        public List<string> ID_List { get; set; }
        public Boolean SelectAll { get; set; }

        public devQuerySelectBank()
        {
            InitializeComponent();
        }

        private void devQuerySelectBank_Load(object sender, EventArgs e)
        {
            string sql = "Select 'Y' as sel, id, code, name from m_bank";
            gridControl1.DataSource = DBFunction.RunQuerySql(sql).Tables[0];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}