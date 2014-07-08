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
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmUser win = new frmUser();
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

        private void frmUserList_Load(object sender, EventArgs e)
        {
            tsbDelete.Enabled = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            User q = DBFactory.CreateQueryEntity<User>();
            List<User> list = new List<User>();
            if (txtCode.Text == "" && txtName.Text == "")
            {
                list = DBFactory.Query<User>().toList<User>();
                List2Grid(list);
            }
        }

        private void List2Grid(List<User> list)
        {
            dataGridView1.RowCount = 0;
            foreach (User user in list)
            {
                dataGridView1.RowCount += 1;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value = user.ID;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = user.Code;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = user.Name;
                if (user.IsAdmin == "X")
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = true;

                //dataGridView1.Rows.Add(["1", "2", "3", "4"]);
            }
        }
    }
}
