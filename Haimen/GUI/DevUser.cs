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
    public partial class DevUser : DevExpress.XtraEditors.XtraForm
    {

        // 当前编辑的对象
        private User m_user = null;

        // 用户组
        private List<UserGroup> m_usergroups = UserGroup.Query();

         // 当前窗口状态
        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.用户, (long)ActionEnum.新增))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.用户, (long)ActionEnum.编辑))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.用户, (long)ActionEnum.删除))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
        }

        // 校验所有的数据是否正确输入
        private bool verifyData()
        {
            if (cbAdmin.Checked)
                m_user.Admin = "X";
            else
                m_user.Admin = null;

            bool verify = true;


            if (lueUserGroup.EditValue != null)
            {
                m_user.UserGroupID = long.Parse(lueUserGroup.EditValue.ToString());
            }

            if (m_user.UserGroupID <= 0)
            {
                dxErrorProvider1.SetError(lueUserGroup, "必须选择所属的用户组");
                verify = false;
            }

            // 用户代码
            if (txtCode.Text == "")
            {
                dxErrorProvider1.SetError(txtCode, "用户代码不能为空");
                verify = false;
            }
            else
            {
                if (m_user != null)
                {
                    if (User.Query("Code = '" + txtCode.Text + "' and id <> " + m_user.ID.ToString()).Count > 0)
                    {
                        dxErrorProvider1.SetError(txtCode, "用户代码已经存在");
                        verify = false;
                    }
                    else
                        dxErrorProvider1.SetError(txtCode, "");
                }
                else
                {
                    //  新增用户时的判断
                    if (User.Query("Code = '" + txtCode.Text + "'").Count > 0)
                    {
                        dxErrorProvider1.SetError(txtCode, "用户代码已经存在");
                        verify = false;
                    }
                    else
                        dxErrorProvider1.SetError(txtCode, "");
                }
            }

            // 用户名称
            if (txtName.Text == "")
            {
                dxErrorProvider1.SetError(txtName, "用户名称不能为空");
                verify = false;
            }
            else
                dxErrorProvider1.SetError(txtName, "");

            // 密码
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                dxErrorProvider1.SetError(txtPasswordConfirm, "密码前后不一致");
                verify = false;
            }
            else
                dxErrorProvider1.SetError(txtPasswordConfirm, "");

            return verify;
        }

        // 设置当前窗口状态
        private void SetFormStatus()
        {
            SetControlAccess();
            switch (m_status)
            {
                case winStatusEnum.新增:
                case winStatusEnum.编辑:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;

                    txtCode.Enabled = true;
                    txtName.Enabled = true;
                    txtPassword.Enabled = true;
                    txtPasswordConfirm.Enabled = true;
                    break;
                case winStatusEnum.查看:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbSave.Enabled = false;

                    txtCode.Enabled = false;
                    txtName.Enabled = false;
                    txtPassword.Enabled = false;
                    txtPasswordConfirm.Enabled = false;
                    break;
            }
        }

        // 将对象映射到窗口
        private void SetBindings()
        {
            txtCode.DataBindings.Clear();
            txtName.DataBindings.Clear();
            
            txtCode.DataBindings.Add("Text", m_user, "Code");
            txtName.DataBindings.Add("Text", m_user, "Name");

            if (m_user.Admin == "X")
                cbAdmin.Checked = true;
            else
                cbAdmin.Checked = false;

            lueUserGroup.Properties.DataSource = null;
            lueUserGroup.Properties.DataSource = m_usergroups;
            lueUserGroup.Properties.DisplayMember = "Name";
            lueUserGroup.Properties.ValueMember = "ID";

            lueUserGroup.EditValue = m_user.UserGroupID;

        }

        // 刷新界面
        private void MyRefresh()
        {
            // 先控制按钮的状态
            SetFormStatus();
            SetBindings();
        }

        // 构造函数
        public DevUser(User user = null)
        {
            InitializeComponent();
            if (user != null)
            {
                m_user = user;
                m_status = winStatusEnum.编辑;
            }
            else
            {
                m_user = new User();
                m_status = winStatusEnum.新增;
            }
        }

        // 载入时更新界面
        private void DevUser_Load(object sender, EventArgs e)
        {
            MyRefresh();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_user = new User();
            m_status = winStatusEnum.新增;

            MyRefresh();
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_user != null)
            {
                m_status = winStatusEnum.编辑;
                MyRefresh();
            }
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的数据？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                if (m_user != null && m_user.ID > 0 && m_user.Name != "admin")
                {
                    m_user.Destory();
                    m_user = new User();
                    m_status = winStatusEnum.查看;
                    MyRefresh();
                }
            }
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCode.Focus();
            txtName.Focus();
            
            // 如果校验不通过，直接返回
            if (!verifyData())
                return;

            // 如果设置了密码，则加上
            if (!string.IsNullOrEmpty(txtPassword.Text))
                m_user.Password = txtPassword.Text;

            m_user.Save();
            MessageBox.Show("用户保存成功!", "注意");
            m_status = winStatusEnum.查看;
            MyRefresh();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_status != winStatusEnum.查看)
            {
                if (MessageBox.Show("当前正在编辑数据，这时退出会丢失当前的数据，是否真的要退出？",
                                "注意",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                    return;
            }
            this.Close();
        }
    }
}