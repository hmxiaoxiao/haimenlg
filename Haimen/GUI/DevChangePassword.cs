using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public DevChangePassword()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("新密码与确认密码不一致，请确认！");
                txtNewPassword.Focus();
                txtNewPassword.SelectAll();
                return;
            }

            if (User.Login(GlobalSet.Current_User.Code, txtOldPassword.Text) == null)
            {
                MessageBox.Show("老密码不正确，请重新输入！");
                txtOldPassword.Focus();
                txtOldPassword.SelectAll();
                return;
            }

            // 更新用户密码
            GlobalSet.Current_User.Password = txtNewPassword.Text;
            GlobalSet.Current_User.Save();
            MessageBox.Show("密码更新成功!");}
    }
}