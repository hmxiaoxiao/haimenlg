using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.NewGUI
{
    public partial class DevAccount : DevExpress.XtraEditors.XtraForm
    {

        private Account m_account;

        private List<Bank> m_banks = Bank.Query();
        private List<Company> m_companies = Company.Query();
        private List<Funds> m_funds = Funds.Query();

        private winStatus m_status;

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatus status)
        {
            m_status = status;
            switch (status)
            {
                case winStatus.New:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    break;
                case winStatus.Edit:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    break;
                case winStatus.View:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// 将对象印射到窗口上
        /// </summary>
        private void Object2form()
        {
            if (m_account.ID > 0)
            {
                dtSigned.Value = m_account.SignedDate;
                txtCode.Text = m_account.Code;
                lueInCompany.EditValue = m_account.In_Company_ID;
                lueOutCompany.EditValue = m_account.Out_Company_ID;
                txtOutComapnyAccount.Text = m_account.OutCompany.Account;
                txtOutCompanyBank.Text = m_account.OutCompany.Bank.Name;

                txtInCompanyAccount.Text = m_account.InCompany.Account;
                txtInCompanyBank.Text = m_account.InCompany.Bank.Name;

                txtMemo.Text = m_account.Memo;
            }
            else
            {
                dtSigned.Value = DateTime.Now;
                txtCode.Text = "";
                lueInCompany.EditValue = null;
                lueOutCompany.EditValue = null;
                txtOutComapnyAccount.Text = "";
                txtOutCompanyBank.Text = "";

                txtInCompanyAccount.Text = "";
                txtInCompanyBank.Text = "";

                txtMemo.Text = "";
            }
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitList()
        {
            lueInCompany.Properties.DataSource = m_companies;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            lueOutCompany.Properties.DataSource = m_companies;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";

            gridControl1.DataSource = m_account.DetailList;

            luefunds.DataSource = m_funds;
            luefunds.DisplayMember = "Name";
            luefunds.ValueMember = "ID";
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            m_account.SignedDate = dtSigned.Value;
            //TODO: 未完成
            return true;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        public DevAccount(Account account = null)
        {
            InitializeComponent();

            if (account != null)
            {
                m_account = account;
                SetFormStatus(winStatus.Edit);
            }
            else
            {
                m_account = new Account();
                SetFormStatus(winStatus.New);
            }
        }

        private void DevAccount_Load(object sender, EventArgs e)
        {
            // 初始化界面
            InitList();
            Object2form();
        }

        /// <summary>
        /// 同步支出单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutCompany.EditValue != null)
                m_account.Out_Company_ID = long.Parse(lueOutCompany.EditValue.ToString());
            txtOutCompanyBank.Text = m_account.OutCompany.Bank.Name;
            txtOutComapnyAccount.Text = m_account.OutCompany.Account;
        }

        /// <summary>
        /// 同步收入单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueInCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInCompany.EditValue != null)
                m_account.In_Company_ID = long.Parse(lueInCompany.EditValue.ToString());
            txtInCompanyBank.Text = m_account.InCompany.Bank.Name;
            txtInCompanyAccount.Text = m_account.InCompany.Account;
        }

        private void dtSigned_ValueChanged(object sender, EventArgs e)
        {
            m_account.SignedDate = dtSigned.Value;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            m_account.Code = txtCode.Text;
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            m_account.Memo = txtMemo.Text;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_account.DetailList.Add(new AccountDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_account.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            if (m_account.Save())
            {
                MessageBox.Show("保存成功！");
                SetFormStatus(winStatus.View);
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account = new Account();
            Object2form();
            SetFormStatus(winStatus.New);
        }


        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_account.ID <= 0)
                return;

            Object2form();
            SetFormStatus(winStatus.Edit);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_account.ID > 0)
                m_account.Destory();
        }
    }
}