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
    public partial class DevResetPassword : DevExpress.XtraEditors.XtraForm
    {
        private User m_user;

        private bool Verify()
        {
            if (txtNewpassword.Text != txtPasswordConfirm.Text)
            {
                errorProvider1.SetError(txtPasswordConfirm, "二个密码不一致！");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtPasswordConfirm, "");
                return true;
            }
        }

        public DevResetPassword(User user)
        {
            InitializeComponent();
            m_user = user;
            txtCurrentUser.Text = GlobalSet.Current_User.Name;
            txtUser.Text = m_user.Name;
        }

        private void btnChangepassword_Click(object sender, EventArgs e)
        {
            if (!Verify())
                return;
            m_user.Password = txtNewpassword.Text;
            m_user.Update();
            MessageBox.Show("设置密码成功！", "注意", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}