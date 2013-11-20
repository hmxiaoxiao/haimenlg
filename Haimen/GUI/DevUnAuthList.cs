using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevUnAuthList : DevExpress.XtraEditors.XtraForm
    {
        public DevUnAuthList()
        {
            InitializeComponent();

            Refresh();
        }

        private void Refresh()
        {
            List<UnAuth> list = UnAuth.Query();

            gridControl1.DataSource = null;
            gridControl1.DataSource = list;

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
            Refresh();
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
            UnAuth.Delete(id);

            Refresh();}

        private void DevUnAuthList_Activated(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}