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
//    public partial class frmCompanyList : Form
//    {
//        public frmCompanyList()
//        {
//            InitializeComponent();
//        }

//        private void tsbNew_Click(object sender, EventArgs e)
//        {
//            frmCompany win = new frmCompany();
//            win.ShowDialog();
//        }

//        private void tsbEdit_Click(object sender, EventArgs e)
//        {
//            for (int i = 0; i < grid.RowCount; i++)
//            {
//                if (grid.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
//                {
//                    long id = long.Parse(grid.Rows[i].Cells["col_id"].Value.ToString());
//                    Company bk = Company.CreateByID(id);
//                    if (bk != null)
//                    {
//                        frmCompany win = new frmCompany(bk);
//                        win.ShowDialog();
//                        Refrush();
//                        return;
//                    }
//                }
//            }
//        }

//        private void tsbDelete_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show(this, "是否要删除指定的单位？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
//            {
//                for (int i = 0; i < grid.RowCount; i++)
//                {
//                    if (grid.Rows[i].Cells["col_selected"].EditedFormattedValue.ToString() == true.ToString())
//                    {
//                        long id = long.Parse(grid.Rows[i].Cells["col_id"].Value.ToString());
//                        Company.Delete(id);
//                    }
//                }
//                Refrush();
//                MessageBox.Show(this, "删除单位成功!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//        }

//        private void tsbExit_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void frmCompanyList_Load(object sender, EventArgs e)
//        {
//            InitGrid();   
//        }

//        private void InitGrid(List<Company> list = null)
//        {
//            if (list == null)
//                list = Company.Query();
//            grid.RowCount = 0;
//            foreach (Company com in list)
//            {
//                grid.RowCount += 1;
//                grid.Rows[grid.RowCount - 1].Cells["col_id"].Value = com.ID;
//                grid.Rows[grid.RowCount - 1].Cells["col_code"].Value = com.Code;
//                grid.Rows[grid.RowCount - 1].Cells["col_doc"].Value = com.Doc;
//                grid.Rows[grid.RowCount - 1].Cells["col_name"].Value = com.Name;
//                grid.Rows[grid.RowCount - 1].Cells["col_bank"].Value = com.Bank.Name;
//                grid.Rows[grid.RowCount - 1].Cells["col_account"].Value = com.Account;
//                grid.Rows[grid.RowCount - 1].Cells["col_input"].Value = com.Input;
//                grid.Rows[grid.RowCount - 1].Cells["col_output"].Value = com.Output;
//            }
//        }

//        private void btnQuery_Click(object sender, EventArgs e)
//        {
//            Refrush();
//        }

//        private void Refrush()
//        {
//            string sql = "";
//            if (txtQCode.Text != "")
//                sql = " Code = '" + txtQCode.Text + "' and ";
//            if (txtQName.Text != "")
//                sql += " Name = '" + txtQName.Text + "' and ";

//            if (sql.Length > 0)
//                sql = sql.Substring(0, sql.Length - 4);

//            InitGrid(Company.Query(sql));
//        }
//    }
//}
