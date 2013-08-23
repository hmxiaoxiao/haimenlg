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
    public partial class DevLogin : DevExpress.XtraEditors.XtraForm
    {
        public DevLogin()
        {
            InitializeComponent();
        }

        // 更多非设置性的初始化
        private void myInitialize()
        {
            this.Text = GlobalSet.SystemName;
        }

        // 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User LoginUser = User.Login(lueCode.EditValue.ToString(), txtPassword.Text);
            if (LoginUser != null)
            {
                GlobalSet.Current_User = LoginUser;
                this.Close();
            }
            else
            {
                MessageBox.Show("用户代码或密码不正确，请重新输入");
                txtPassword.SelectAll();
                txtPassword.Focus();
            }
        }

        // 初始化用户列表
        private void DevLogin_Load(object sender, EventArgs e)
        {
            List<User> users = User.Query();
            lueCode.Properties.DataSource = users;
            lueCode.Properties.ValueMember = "Code";
            lueCode.Properties.DisplayMember = "Code";
        }

        // 关闭窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}