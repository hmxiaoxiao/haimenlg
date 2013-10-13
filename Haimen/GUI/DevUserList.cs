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
    public partial class DevUserList : DevExpress.XtraEditors.XtraForm
    {
        // 当前的用户列表
        private List<User> m_users = null;

        // 主窗口
        private DevMain m_main_window;


        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, (long)FctionEnum.用户, (long)ActionEnum.新增))
            {
                tsbNew.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, (long)FctionEnum.用户, (long)ActionEnum.编辑))
            {
                tsbEdit.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, (long)FctionEnum.用户, (long)ActionEnum.删除))
            {
                tsbDelete.Dispose();
            }
        }


        // 刷新界面
        private void MyRefresh()
        {
            m_users = User.Query();

            gridControl1.DataSource = null;
            gridControl1.DataSource = m_users;
            gridView1.BestFitColumns();

            SetControlAccess();
        }

        // 取得当前行对应的对象
        private User GetSelectedUser()
        {
            if (gridView1.FocusedRowHandle < 0)
                return null;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
            foreach (User u in m_users)
            {
                if (u.ID == id)
                {
                    return u;
                }
            }
            return null;
        }

        // 编辑用户
        private void EditUser()
        {
            User u = GetSelectedUser();
            if (u == null)
                return;

            DevUser win = new DevUser(u);
            m_main_window.OpenForm(win);
        }

        public DevUserList()
        {
            InitializeComponent();
        }

        // 
        private void DevUserList_Load(object sender, EventArgs e)
        {
            m_main_window = (DevMain)this.ParentForm;
            MyRefresh();
        }
        
        // 新建用户
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevUser win = new DevUser();
            m_main_window.OpenForm(win);
        }

        // 编辑
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditUser();
        }

        // 删除用户
        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            User u = GetSelectedUser();
            if (u == null)
                return;

            u.Destory();
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        // 表格双击编辑对象
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            EditUser();
        }

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }
    }
}