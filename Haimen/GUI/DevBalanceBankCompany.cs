using System;
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
    public partial class DevBalanceBankCompany : DevExpress.XtraEditors.XtraForm
    {
        public DevBalanceBankCompany()
        {
            InitializeComponent();
        }

        private void barbtnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = BalanceBankCompany.GetDataTable();
            gridView1.BestFitColumns();
            gridView1.OptionsView.ShowFooter = true;
        }
    }
}