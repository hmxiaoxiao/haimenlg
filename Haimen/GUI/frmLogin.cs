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
    public partial class frmLogin : Form
    {
        private bool m_verify = false;
        private User m_user = new User();

        public bool getVierfy()
        {
            return m_verify;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        // 判断登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            m_user.Code = txtCode.Text;
            m_user.Password = txtPassword.Text;

            if (m_user.Verify(txtCode.Text, txtPassword.Text))
            {
                m_verify = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("用户代码或密码不正确，请重新输入");
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }
    }
}
