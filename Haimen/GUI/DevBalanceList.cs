using System;
using System.Collections.Generic;
using System.Drawing;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevBalanceList : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 当前的货款列表
        /// </summary>
        private List<Balance> m_balances;

        /// <summary>
        /// 主窗口用来打开MDI窗口
        /// </summary>
        private DevMain m_main_window ;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.贷款, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.贷款, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.贷款, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.贷款, (long)ActionEnum.审核))
            {
                tsbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        /// <summary>
        /// 编辑当前的行对象
        /// </summary>
        private void EditBalance()
        {
            Balance bal = CurrentSelectObject();
            if (bal != null)
                m_main_window.OpenForm(new DevBalance(winStatusEnum.编辑, bal));
            return;
        }

        /// <summary>
        /// 当前表格选中的行所对应的对象
        /// </summary>
        /// <returns></returns>
        private Balance CurrentSelectObject()
        {
            if (gridView1.FocusedRowHandle < 0)
                return null;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
            foreach (Balance bl in m_balances)
            {
                if (bl.ID == id)
                    return bl;
            }
            return null;
        }

        /// <summary>
        /// 自定义刷新
        /// 这里刷新会把以前的条件全部去掉，即显示全部对象
        /// </summary>
        private void MyRefresh()
        {
            m_balances = Balance.Query();
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balances;
            gridView1.BestFitColumns();
        }


        public DevBalanceList()
        {
            InitializeComponent();
        }

        private void DevBalanceList_Load(object sender, EventArgs e)
        {
            // 设置父结窗口
            m_main_window = (DevMain)this.ParentForm;

            // 刷新窗口
            MyRefresh();
            SetControlAccess();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevBalance(winStatusEnum.新增));
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditBalance();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Balance bal = CurrentSelectObject();
            if (bal != null)
            {
                bal.Destory();
                MyRefresh();
            }
        }

        
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Balance bal = CurrentSelectObject();
            if (bal != null)
                m_main_window.OpenForm(new DevBalance(winStatusEnum.复核, bal));
        }

        /// <summary>
        /// 查询 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevBalanceQuery query = new DevBalanceQuery();
            if (query.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                //生成查询
                List<string> filters = new List<string>();
                if (query.Q_Code.Length > 0)
                    filters.Add(String.Format(" Code = '%{0}%' ", query.Q_Code));
                if (query.Q_Bank_ID.Length > 0)
                    filters.Add(String.Format(" bank_id = {0} ", query.Q_Bank_ID));
                if (query.Q_Company_ID.Length > 0)
                    filters.Add(String.Format(" Company_id = {0} ", query.Q_Company_ID));
                if (query.Q_Status.Length > 0)
                    filters.Add(" status = " + query.Q_Status);

                string where = "";
                foreach (string filter in filters)
                {
                    where += filter + " and ";
                }
                if (where.Length > 0)
                    where = where.Substring(0, where.Length - 4);

                m_balances = Balance.Query(where);
                gridControl1.DataSource = null;
                gridControl1.DataSource = m_balances;
            }
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void DevBalanceList_Activated(object sender, EventArgs e)
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
                    e.Info.Appearance.BackColor = Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle;
                }
            }
        }
    }
}