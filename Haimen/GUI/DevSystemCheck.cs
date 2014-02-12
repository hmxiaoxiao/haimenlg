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
    public partial class DevSystemCheck : DevExpress.XtraEditors.XtraForm
    {
        public DevSystemCheck()
        {
            InitializeComponent();
        }

        private void btnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SystemCheck sc = new SystemCheck();
            gridControl1.DataSource = sc.GetCheckResultData().Tables[0];

            gridView1.BestFitColumns();
        }

        private void btnVerify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SystemCheck sc = new SystemCheck();
            int eff_row = sc.AutoUpdateData();
            if (eff_row > 0)
                MessageBox.Show("更新数据成功!");
            else
                MessageBox.Show("没有错误数据需要更新!");
        }
    }
}