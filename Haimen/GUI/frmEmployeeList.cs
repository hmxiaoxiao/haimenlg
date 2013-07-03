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
    public partial class frmEmployeeList : Form
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmEmployee win = new frmEmployee();
            win.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            frmEmployee win = new frmEmployee();
            win.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的员工？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
