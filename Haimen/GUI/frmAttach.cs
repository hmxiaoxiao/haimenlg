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
    public partial class frmAttach : Form
    {
        public frmAttach()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog win = new OpenFileDialog();
            if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileName.Text = win.FileName;
            }
        }
    }
}
