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

namespace Haimen.NewGUI
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
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.新增))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.编辑))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.删除))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.审核))
            {
                if (tsbCheck.Enabled == true) tsbCheck.Enabled = false;
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
        /// 生成凭证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbGene_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
                m_main_window.OpenForm(new DevBalance(winStatusEnum.审核, bal));
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
                    filters.Add(" Code = '%" + query.Q_Code + "%' ");
                if (query.Q_Bank_ID.Length > 0)
                    filters.Add(" bank_id = " + query.Q_Bank_ID + " ");
                if (query.Q_Company_ID.Length > 0)
                    filters.Add(" Company_id = " + query.Q_Company_ID + " ");
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
    }
}