using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevUnAuthList : DevExpress.XtraEditors.XtraForm
    {
        public DevUnAuthList()
        {
            InitializeComponent();
            MyRefresh();
        }

        private void MyRefresh()
        {
            //List<UnAuth> list = UnAuth.Query();

            gridControl1.DataSource = null;
            gridControl1.DataSource = UnAuth.GetGUIList().Tables[0];

            gridView1.BestFitColumns();
        }

        private void EditObject(winStatusEnum status = winStatusEnum.编辑)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, a_id).ToString());

            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevUnAuth(status, UnAuth.CreateByID(id)));
            return;

        }

        private void tsbView_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditObject(winStatusEnum.查看);
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevUnAuth(winStatusEnum.新增));
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditObject(winStatusEnum.编辑);
        }

        private void txtDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, a_id).ToString());
            if (id <= 0)
                return;

            if (MessageBox.Show(this, "是否要删除指定的非授权资金凭证？", "警告", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                UnAuth unauth = UnAuth.CreateByID(id);
                unauth.Destory();

                MessageBox.Show(this, "删除非授权资金凭证成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 去掉当前行
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        private void DevUnAuthList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                    e.Info.DisplayText = "G" + e.RowHandle;
                }
            }
        }
    }
}