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

namespace Haimen.NewGUI
{
    // 用户登录
    public partial class DevLogin : DevExpress.XtraEditors.XtraForm
    {
        // 重试次数，超过三次就退出系统
        private int m_retry = 0;

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
                m_retry++;
                if (m_retry < 3)
                {
                    MessageBox.Show("用户代码或密码不正确，请重新输入");
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("密码输入错误超过三次，系统退出！", "出错了!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        // 初始化用户列表
        private void DevLogin_Load(object sender, EventArgs e)
        {
            List<User> users = User.Query();
            lueCode.Properties.DataSource = users;
            lueCode.Properties.ValueMember = "Code";
            lueCode.Properties.DisplayMember = "Code";

            // 设置皮肤
            CustomerINI.SetFormSkin();
            
        }

        // 关闭窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}