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
    public partial class frmChangePassword : Form
    {
        // 校验老密码
        private bool verify_old_password()
        {
            if (User.Verify(GlobalSet.Current_User.Code, txtOldPassword.Text) == null)
            {
                errorProvider1.SetError(txtOldPassword, "老密码不正确");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtOldPassword, "");
                return true;
            }
        }

        // 校验新密码
        private bool verify_new_password()
        {
            if (txtNewpassword.Text != txtPasswordConfirm.Text)
            {
                errorProvider1.SetError(txtPasswordConfirm, "新密码与确认密码不一致");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtPasswordConfirm, "");
                return true;
            }
        }

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            // 设置当前用户名字
            txtUser.Text = GlobalSet.Current_User.Name;
        }

        // 更改密码
        private void btnChangepassword_Click(object sender, EventArgs e)
        {
            if (verify_new_password() && verify_old_password())
            {
                GlobalSet.Current_User.Password = txtNewpassword.Text;
                DBFactory.Update(GlobalSet.Current_User);

                MessageBox.Show("成功更新密码", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtOldPassword_Leave(object sender, EventArgs e)
        {
            verify_old_password();
        }

        private void txtNewpassword_Leave(object sender, EventArgs e)
        {
            verify_new_password();
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            verify_new_password();
        }
    }
}
