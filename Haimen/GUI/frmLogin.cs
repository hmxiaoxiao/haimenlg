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
    public partial class frmLogin : Form
    {
        private bool m_verify = false;

        public bool getVierfy()
        {
            return m_verify;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        // 关闭窗口
        private void btnLogin_Click(object sender, EventArgs e)
        {
            m_verify = true;
            this.Close();
        }
    }
}
