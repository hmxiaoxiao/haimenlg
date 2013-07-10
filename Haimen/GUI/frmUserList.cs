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

        // 新增
        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmUser win = new frmUser();
            win.ShowDialog(this);
        }

        // 编辑
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.RowCount;
            for (int i = 0; i < row; i++)
            {
                if (dataGridView1.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
                {
                    User user = User.Where<User>("id=" + dataGridView1.Rows[i].Cells["col_id"].Value.ToString())[0];
                    frmUser win = new frmUser(user);
                    win.ShowDialog(this); int j = i;
                    return;
                }
            }
        }

        // 退出
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 修改密码
        private void tsbResetPassword_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount;
            for (int i = 0; i < rows; i++)
            {
                if (dataGridView1.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
                {
                    int id = int.Parse(dataGridView1.Rows[i].Cells["col_id"].Value.ToString());
                    frmResetPassword win = new frmResetPassword(User.New<User>(id));
                    win.ShowDialog(this);
                    return;
                }
            }
        }

        // 删除
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount;
            List<int> delete_user_id_list = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                if (dataGridView1.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
                {
                    delete_user_id_list.Add(int.Parse(dataGridView1.Rows[i].Cells["col_id"].Value.ToString()));
                }
            }
            if (delete_user_id_list.Count > 0)
            {
                if (MessageBox.Show(this, "是否要删除选中的用户？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    foreach (int id in delete_user_id_list)
                    {
                        User del = User.New<User>(id);
                        if (del != null)
                            DBFactory.Delete<User>(del);
                    }
                    MessageBox.Show(this, "删除用户成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshGrid();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        // 刷新表格
        private void refreshGrid()
        {
            User q = DBFactory.CreateQueryEntity<User>();
            List<User> list = new List<User>();
            if (txtCode.Text == "" && txtName.Text == "")
            {
                list = DBFactory.Query<User>().toList<User>();
                List2Grid(list);
            }
            else
            {
                q.Code = txtCode.Text;
                q.Name = txtName.Text;
                list = DBFactory.Query(q).toList<User>();
                List2Grid(list);
            }
        }

        // 将列表影射到表格
        private void List2Grid(List<User> list)
        {
            dataGridView1.RowCount = 0;
            foreach (User user in list)
            {
                dataGridView1.RowCount += 1;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = user.ID;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2].Value = user.Code;
                dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[3].Value = user.Name;
                if (user.Admin == "X")
                    dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[4].Value = true;
            }
        }
    }
}
