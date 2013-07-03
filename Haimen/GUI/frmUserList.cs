using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haimen.GUI
{
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmUser win = new frmUser();
            //win.MdiParent = this.ParentForm;
            //win.WindowState = FormWindowState.Maximized;
            win.ShowDialog(this);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            frmUser win = new frmUser();
            //win.MdiParent = this.ParentForm;
            //win.WindowState = FormWindowState.Maximized;
            win.ShowDialog(this);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbResetPassword_Click(object sender, EventArgs e)
        {
            frmResetPassword win = new frmResetPassword();
            win.ShowDialog(this);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的用户？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除用户成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
