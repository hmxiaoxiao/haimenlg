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
        public frmUser()
        {
            InitializeComponent();
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
                User q = DBFactory.CreateQueryEntity<User>();
                q.Code = txtCode.Text;
                if (DBFactory.Query<User>(q).toList<User>().Count > 0)
                {
                    errorProvider1.SetError(txtCode, "用户代码已经存在");
                    verify = false;
                }
                else
                    errorProvider1.SetError(txtCode, "");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!verifyData())
                return;

            User user = new User();
            user.Code = txtCode.Text;
            user.Name = txtName.Text;
            user.Password = txtPassword.Text;
            if (cbAdmin.Checked)
                user.IsAdmin = "X";

            if (0 < DBFactory.Save(user))
            {
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
