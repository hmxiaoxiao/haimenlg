using System;
using System.Collections.Generic;
using System.Windows.Forms;

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