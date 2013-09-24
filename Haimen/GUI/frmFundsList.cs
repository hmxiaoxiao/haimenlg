//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//using Haimen.Entity;

//namespace Haimen.GUI
//{
//    public partial class frmFundsList : Form
//    {
//        public frmFundsList()
//        {
//            InitializeComponent();
//        }

//        private void tsbDelete_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show(this, "是否要删除指定的资金性质？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
//            {
//                for (int i = 0; i < grid.RowCount; i++)
//                {
//                    if (grid.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
//                    {
//                        long id = long.Parse(grid.Rows[i].Cells["col_id"].Value.ToString());
//                        Funds.Delete(id);
//                    }
//                }
//                MessageBox.Show(this, "删除成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                initTree();
//                initGrid();
//            }
//        }

//        private void tsbNew_Click(object sender, EventArgs e)
//        {
//            frmFunds win = new frmFunds();
//            win.ShowDialog(this);

//            initTree();
//            initGrid();
//        }

//        private void frmFundsList_Load(object sender, EventArgs e)
//        {
//            initTree();
//            initGrid();
//        }

//        private void initGrid()
//        {
//            List<Funds> list;
//            if (txtQName.Text != "")
//                list = Funds.Query("Name = '" + txtQName.Text + "'");
//            else
//                list = Funds.Query();

//            grid.RowCount = 0;
//            foreach (Funds f in list)
//            {
//                grid.RowCount += 1;
//                grid.Rows[grid.RowCount - 1].Cells["col_id"].Value = f.ID;
//                grid.Rows[grid.RowCount - 1].Cells["col_name"].Value = f.Name;
//            }
//        }

//        private void initTree()
//        {
//            tree.Nodes.Clear();
//            List<Funds> list = Funds.Query("parent_id = 0");
//            foreach (Funds bk in list)
//            {
//                TreeNode td = new TreeNode();
//                td.Name = bk.ID.ToString();
//                td.Text = bk.Name;
//                appendTree(bk.ID, td);
//                tree.Nodes.Add(td);
//            }
//        }

//        private void appendTree(long parent_id, TreeNode parent_node)
//        {
//            List<Funds> list = Funds.Query("parent_id = " + parent_id.ToString());
//            foreach (Funds bk in list)
//            {
//                TreeNode td = new TreeNode();
//                td.Name = bk.ID.ToString();
//                td.Text = bk.Name;
//                appendTree(bk.ID, td);
//                parent_node.Nodes.Add(td);
//            }
//        }

//        private void tsbEdit_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < grid.RowCount; i++)
//            {
//                if (grid.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
//                {
//                    long id = long.Parse(grid.Rows[i].Cells["col_id"].Value.ToString());
//                    Funds bk = Funds.CreateByID(id);
//                    if (bk != null)
//                    {
//                        frmFunds win = new frmFunds(bk);
//                        win.ShowDialog();

//                        initTree();     // 刷新树
//                        initGrid();
//                        return;
//                    }
//                }
//            }
//        }

//        private void tsbExit_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}
