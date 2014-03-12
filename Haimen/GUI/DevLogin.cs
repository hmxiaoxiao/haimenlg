using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    // 用户登录
    public partial class DevLogin : DevExpress.XtraEditors.XtraForm
    {
        // 重试次数，超过三次就退出系统
        private int m_retry = 0;

        public DevLogin()
        {
            InitializeComponent();
            myInitialize();
        }

        // 更多非设置性的初始化
        private void myInitialize()
        {
            this.Text = GlobalSet.SystemName;
        }

        // 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (lueCode.EditValue == null)
                return;

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
                    MessageBox.Show("用户代码或密码不正确，请重新输入", "错误！", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
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
            INICustomer.SetFormSkin();

            // 设置标题
            this.Text = GlobalSet.SystemName;
            
        }

        // 关闭窗口
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}