using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.NewGUI
{
    public partial class DevUser : DevExpress.XtraEditors.XtraForm
    {
        private User m_user;

        // 校验所有的数据是否正确输入
        private bool verifyData()
        {
            bool verify = true;
            // 用户代码
            if (txtCode.Text == "")
            {
                errorProvider1.SetError(txtCode, "用户代码不能为空");
                verify = false;
            }
            else
            {
                if (m_user != null)
                {
                    if (User.Query("Code = '" + txtCode.Text + "' and id <> " + m_user.ID.ToString()).Count > 0)
                    {
                        errorProvider1.SetError(txtCode, "用户代码已经存在");
                        verify = false;
                    }
                    else
                        errorProvider1.SetError(txtCode, "");
                }
                else
                {
                    //  新增用户时的判断
                    if (User.Query("Code = '" + txtCode.Text + "'").Count > 0)
                    {
                        errorProvider1.SetError(txtCode, "用户代码已经存在");
                        verify = false;
                    }
                    else
                        errorProvider1.SetError(txtCode, "");
                }
            }

            // 用户名称
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "用户名称不能为空");
                verify = false;
            }
            else
                errorProvider1.SetError(txtName, "");

            // 密码
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                errorProvider1.SetError(txtPasswordConfirm, "密码前后不一致");
                verify = false;
            }
            else
                errorProvider1.SetError(txtPasswordConfirm, "");

            return verify;
        }

        public DevUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 如果校验不通过，直接返回
            if (!verifyData())
                return;

            User user = new User();
            user.Code = txtCode.Text;
            user.Name = txtName.Text;
            if (m_user != null)
            {
                user.Password = null;
                user.ID = m_user.ID;
            }
            else
                user.Password = txtPassword.Text;

            if (cbAdmin.Checked)
                user.Admin = "X";


            user.Save();
            MessageBox.Show("编辑用户保存成功!", "注意");
            if (m_user == null)
            {
                // 如果保存成功，则清空输入框，等待增加新用户
                MessageBox.Show("新增用户保存成功!", "注意");
                txtCode.Text = "";
                txtName.Text = "";
                txtPassword.Text = "";
                txtPasswordConfirm.Text = "";
                cbAdmin.Checked = false;
                txtCode.Focus();
            }
        }
    }
}