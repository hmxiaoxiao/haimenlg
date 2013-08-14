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
    public partial class frmBankList : Form
    {
        public frmBankList()
        {
            InitializeComponent();
            initTree();
        }

        private void initTree()
        {
            treeBank.Nodes.Clear();
            List<Bank> list = Bank.Query("parent_id = 0");
            foreach (Bank bk in list)
            {
                TreeNode td = new TreeNode();
                td.Name = bk.ID.ToString();
                td.Text = bk.Name;
                appendTree(bk.ID, td);
                treeBank.Nodes.Add(td);
            }
        }

        private void appendTree(long parent_id, TreeNode parent_node)
        {
            List<Bank> list = Bank.Query("parent_id = " + parent_id.ToString());
            foreach (Bank bk in list)
            {
                TreeNode td = new TreeNode();
                td.Name = bk.ID.ToString();
                td.Text = bk.Name;
                appendTree(bk.ID, td);
                parent_node.Nodes.Add(td);

            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            frmBank win = new frmBank();
            win.ShowDialog();

            initTree();    // 刷新树
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.RowCount; i++)
            {
                if (grid.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
                {
                    long id = long.Parse(grid.Rows[i].Cells["col_id"].Value.ToString());
                    Bank bk = Bank.CreateByID(id);
                    if (bk != null)
                    {
                        frmBank win = new frmBank(bk);
                        win.ShowDialog();

                        initTree();     // 刷新树
                        return;
                    }
                }
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "是否要删除选中的银行？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                for (int i = 0; i < grid.RowCount; i++)
                {
                    if (grid.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
                    {
                        long id = long.Parse(grid.Rows[i].Cells["col_id"].Value.ToString());
                        Bank.Delete(id);
                    }
                }
            }
        }

        // 点击树结点，显示下面的所有的列表
        private void treeBank_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            long id = long.Parse(e.Node.Name);
            showGrid(id);
        }

        private void showGrid(long id)
        {
            grid.RowCount = 0;
            Bank bk = Bank.CreateByID(id);
            addGridRow(bk);

            addSubBank(id);
        }

        private void addGridRow(Bank bank)
        {
            grid.RowCount += 1;
            grid.Rows[grid.RowCount - 1].Cells["col_id"].Value = bank.ID;
            grid.Rows[grid.RowCount - 1].Cells["col_code"].Value = bank.Code;
            grid.Rows[grid.RowCount - 1].Cells["col_name"].Value = bank.Name;
        }

        private void addSubBank(long id)
        {
            List<Bank> list = Bank.Query("parent_id = " + id.ToString());
            foreach (Bank bank in list)
            {
                addGridRow(bank);
                addSubBank(bank.ID);
            }
        }
    }
}
