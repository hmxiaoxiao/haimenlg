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
    public partial class frmDeptList : Form
    {
        public frmDeptList()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmDept win = new frmDept();
            win.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            frmDept win = new frmDept();
            win.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("警告", "是否要删除指定的部门？", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show("删除成功！");
            }
        }
    }
}
