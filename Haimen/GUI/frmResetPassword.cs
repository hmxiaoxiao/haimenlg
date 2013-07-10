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
    public partial class frmResetPassword : Form
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

        public frmResetPassword(User user)
        {
            InitializeComponent();

            m_user = user;
            txtCurrentUser.Text = GlobalSet.Current_User.Name;
            txtUser.Text = m_user.Name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangepassword_Click(object sender, EventArgs e)
        {
            if (!Verify())
                return;
            m_user.Password = txtNewpassword.Text;
            DBFactory.Update(m_user);
            MessageBox.Show("设置密码成功！", "注意", MessageBoxButtons.OK);
        }
    }
}
