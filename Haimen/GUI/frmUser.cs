using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class frmUser : Form
    {
        private User m_user;

        public frmUser(User user = null)
        {
            InitializeComponent();

            if (user != null)
            {
                m_user = user;
                txtCode.Text = m_user.Code;
                txtName.Text = m_user.Name;
                if (m_user.Admin == "X")
                    cbAdmin.Checked = true;
            }
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            verifyData();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            verifyData();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            verifyData();
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            verifyData();
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.SelectAll();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPasswordConfirm_Enter(object sender, EventArgs e)
        {
            txtPasswordConfirm.SelectAll();
        }


        // 按下保存按钮
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
