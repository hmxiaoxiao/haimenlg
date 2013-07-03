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
    public partial class frmContract : Form
    {
        public frmContract()
        {
            InitializeComponent();
        }



        private void tsbAttachDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的附件？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除附件成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbAttachNew_Click(object sender, EventArgs e)
        {
            frmAttach win = new frmAttach();
            win.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
