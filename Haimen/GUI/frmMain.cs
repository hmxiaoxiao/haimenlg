using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.GUI;

namespace Haimen
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void menuUser_Click(object sender, EventArgs e)
        {
            frmChangePassword win = new frmChangePassword();
            win.ShowDialog();
        }

        private void menuUser_Click_1(object sender, EventArgs e)
        {
            frmUserList win = new frmUserList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeList win = new frmEmployeeList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuDept_Click(object sender, EventArgs e)
        {
            frmDeptList win = new frmDeptList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuBank_Click(object sender, EventArgs e)
        {
            frmBankList win = new frmBankList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            frmCompanyList win = new frmCompanyList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuFunds_Click(object sender, EventArgs e)
        {
            frmFundsList win = new frmFundsList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuInit_Click(object sender, EventArgs e)
        {
            frmInit win = new frmInit();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuCompanyAccountInfo_Click(object sender, EventArgs e)
        {
            frmCompanyDetailList win = new frmCompanyDetailList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuCreditList_Click(object sender, EventArgs e)
        {
            frmCreditList win = new frmCreditList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuCreditVerify_Click(object sender, EventArgs e)
        {
            frmCreditList win = new frmCreditList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuContract_Click(object sender, EventArgs e)
        {
            frmContractList win = new frmContractList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void 合同审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContractList win = new frmContractList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuAccount_Click(object sender, EventArgs e)
        {
            frmAccountList win = new frmAccountList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuAccountVerify_Click(object sender, EventArgs e)
        {
            frmAccountList win = new frmAccountList();
            win.MdiParent = this;
            win.WindowState = FormWindowState.Maximized;
            win.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword win = new frmChangePassword();
            win.ShowDialog();
        }
    }
}
