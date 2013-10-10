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
    public partial class DevAccess : DevExpress.XtraEditors.XtraForm
    {
        private List<User> m_users = User.Query();
        private List<UserGroup> m_usergroups = UserGroup.Query();

        private List<FAccess> m_accesses = null;

        // 初始化
        private void init()
        {
            cboUType.Properties.Items.Clear();
            cboUType.Properties.Items.Add("用户");
            cboUType.Properties.Items.Add("用户组");
            cboUType.SelectedIndex = 0;

            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.权限, (long)ActionEnum.新增) ||
                Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.权限, (long)ActionEnum.编辑) ||
                Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.权限, (long)ActionEnum.删除) ||
                GlobalSet.Current_User.Admin == "X" )
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        public DevAccess()
        {
            InitializeComponent();
        }


        // 退出
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void DevAccess_Load(object sender, EventArgs e)
        {
            init();
        }

        private void cboUType_EditValueChanged(object sender, EventArgs e)
        {
            if (cboUType.Text == "用户")
            {
                lueList.Properties.DataSource = null;
                lueList.Properties.DataSource = m_users;
                lueList.Properties.DisplayMember = "Name";
                lueList.Properties.ValueMember = "ID";
            }
            else
            {
                lueList.Properties.DataSource = null;
                lueList.Properties.DataSource = m_usergroups;
                lueList.Properties.DisplayMember = "Name";
                lueList.Properties.ValueMember = "ID";
            }
        }


        // 选择了具体用户后再显示可操作的内容
        private void lueList_EditValueChanged(object sender, EventArgs e)
        {
            if (lueList.EditValue == null)
                return;

            Cursor.Current = Cursors.AppStarting;       // 修改光标样式 
            if (cboUType.Text == "用户")
            {
                User user = User.CreateByID(long.Parse(lueList.EditValue.ToString()));
                m_accesses = Access.UserAccess2List(user);
            }
            else
            {
                long usergroup_id = long.Parse(lueList.EditValue.ToString());
                m_accesses = Access.UserGroupAccess2List(usergroup_id);
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_accesses;

            gridView1.BestFitColumns();

            Cursor.Current = Cursors.Default;           // 恢复光标样式
        }

        // 保存权限
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //// 记录下时间
            //DateTime n = DateTime.Now;
            // 切换一下焦点,保证不会丢失数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (lueList.EditValue == null)
                return;

            long id = long.Parse(lueList.EditValue.ToString());

            Cursor.Current = Cursors.AppStarting;
            if (cboUType.Text == "用户")
            {
                User user = User.CreateByID(id);
                Access.SaveUserAll(m_accesses, user.ID, user.UserGroupID);
            }
            else
                Access.SaveGroupAll(m_accesses, id);
            Cursor.Current = Cursors.Default;

            //TimeSpan begin = new TimeSpan(n.Ticks);
            //TimeSpan end = new TimeSpan(DateTime.Now.Ticks);

            //TimeSpan use_time = end.Subtract(begin).Duration();
            

            MessageBox.Show("保存成功！");

        }


    }
}