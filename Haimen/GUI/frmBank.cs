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
//using Haimen.Helper;

//namespace Haimen.GUI
//{
//    public partial class frmBank : Form
//    {
//        private Bank m_bank;

//        public frmBank(Bank bank = null)
//        {
//            InitializeComponent();

//            // 判断是新增还是编辑
//            if (bank != null)
//            {
//                // 编辑银行
//                this.Text += " - 编辑";
//                m_bank = bank;
//                txtCode.Text = bank.Code;
//                txtName.Text = bank.Name;
//            }
//            else
//            {
//                this.Text += " - 新增";
//                m_bank = new Bank();
//            }

//            InitBankParent();
//        }

//        private void btnExit_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        // 初始化银行父结点的下拉列表
//        private void InitBankParent()
//        {
//            List<Bank> list = Bank.Query();
//            lstBankParent.DataSource = list;
//            lstBankParent.ValueMember = "ID";
//            lstBankParent.DisplayMember = "Name";
//        }

//        private bool Verify()
//        {
//            // 清空错误信息
//            errorProvider1.SetError(txtCode, "");
//            errorProvider1.SetError(txtName, "");
//            errorProvider1.SetError(lstBankParent, "");

//            // 先给当前对象赋值
//            m_bank.Code = txtCode.Text;
//            m_bank.Name = txtName.Text;
//            if (lstBankParent.SelectedValue != null)
//                m_bank.ParentID = long.Parse(lstBankParent.SelectedValue.ToString());
//            else
//                m_bank.ParentID = 0;

//            // 校验数据
//            if (m_bank.Verify())
//                return true;

//            // 校验没有通过的处理方法
//            foreach (KeyValuePair<string, string> kv in m_bank.Error_Info)
//            {
//                if (kv.Key.ToLower() == "code")
//                    errorProvider1.SetError(txtCode, kv.Value);
//                if (kv.Key.ToLower() == "name")
//                    errorProvider1.SetError(txtName, kv.Value);
//                if (kv.Key.ToLower() == "parent_id")
//                    errorProvider1.SetError(lstBankParent, kv.Value);
//            }
//            return false;
//        }

//        // 保存
//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            if (!Verify())
//                return;

//            m_bank.Save();

//            // 当前如果中编辑，则提示修改成功后直接退出
//            // 新增的话，则提示继续增加
//            if (this.Text.IndexOf("编辑") > 0)
//            {
//                MessageBox.Show("修改成功", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.Close();
//            }
//            else
//            {
//                MessageBox.Show("保存成功，请继续增加新的银行", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                m_bank = new Bank();
//                txtCode.Text = "";
//                txtName.Text = "";
//                lstBankParent.Text = "";
//                InitBankParent();
//            }

//        }

//        // 自动生成名称的简拼作为代码
//        private void txtName_TextChanged(object sender, EventArgs e)
//        {
//            txtCode.Text = PinyinHelper.GetShortPinyin(txtName.Text).ToUpper();
//        }

//    }
//}
