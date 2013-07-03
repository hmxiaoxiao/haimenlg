﻿using System;
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
    public partial class frmAccountList: Form
    {
        public frmAccountList()
        {
            InitializeComponent();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNewOut_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }

        private void tsbNewIn_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除指定的资金凭证？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show(this, "删除资金凭证成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbVerify_Click(object sender, EventArgs e)
        {
            frmAccount win = new frmAccount();
            win.ShowDialog();
        }
    }
}