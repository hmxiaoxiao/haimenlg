using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.GUI;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevContractAcceptList : DevExpress.XtraEditors.XtraForm
    {
        private List<ContractAccept> m_lists;

        private void MyRefresh()
        {
            m_lists = ContractAccept.Query();
            lueStatus.DataSource = null;
            lueStatus.DataSource = ContractAccept.AcceptStatus;
            lueStatus.DisplayMember = "Name";
            lueStatus.ValueMember = "ValueInt";

            gridControl1.DataSource = m_lists;
            gridView1.BestFitColumns();
        }

        public DevContractAcceptList()
        {
            InitializeComponent();
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void tsbGene_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (ContractAccept a in m_lists)
            {
                if (a.ID == id)
                {
                    DevMain main = (DevMain)this.ParentForm;
                    main.OpenForm(new DevAccount(winStatusEnum.新增, null, 0, 0, id));
                    return;
                }
            }
        }

        private void DevContractAcceptList_Load(object sender, EventArgs e)
        {
            MyRefresh();
        }

        private void DevContractAcceptList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
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