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
    public partial class frmFundsList : Form
    {
        public frmFundsList()
        {
            InitializeComponent();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的资金性质？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
