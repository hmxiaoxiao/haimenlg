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
    public partial class DevBalance : DevExpress.XtraEditors.XtraForm
    {
        private Balance m_balance;
        private List<Bank> m_banks = Bank.Query();
        private List<Company> m_companies = Company.Query();

        private winStatusEnum m_status;

        /// <summary>
        /// 设置窗口的状态
        /// </summary>
        /// <param name="status"></param>
        private void SetFromStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.New:
                case winStatusEnum.Edit: 
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCheck.Enabled = false;
                    btnCheckFaild.Enabled = false;

                    SetControlStatus(true);
                    break;
                case winStatusEnum.View:
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCheck.Enabled = false;
                    btnCheckFaild.Enabled = false;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.Check:
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCheck.Enabled = true;
                    btnCheckFaild.Enabled = true;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.OnlyView:
                    btnNew.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    btnCheck.Enabled = false;
                    btnCheckFaild.Enabled = false;

                    SetControlStatus(false);
                    break;
            }
        }

        /// <summary>
        /// 设置窗口控件的可用状态
        /// </summary>
        /// <param name="enabled"></param>
        private void SetControlStatus(bool enabled)
        {
            txtCode.Enabled = enabled;
            txtAccount.Enabled = enabled;
            txtMoney.Enabled = enabled;
            txtRate.Enabled = enabled;
            lueBank.Enabled = enabled;
            lueCompany.Enabled = enabled;
            dtBeginDate.Enabled = enabled;
            dtEndDate.Enabled = enabled;
            cboInterestDate.Enabled = enabled;
            cboRepayDate.Enabled = enabled;

            tsbNew.Enabled = enabled;
            tsbDelete.Enabled = enabled;
            gridView1.OptionsBehavior.Editable = enabled;
        }

        /// <summary>
        /// 将窗口的数据保存到对象里
        /// </summary>
        private void Form2Object()
        {
            m_balance.Code = txtCode.Text;
            m_balance.BankID = long.Parse(lueBank.EditValue.ToString());
            m_balance.CompanyID = long.Parse(lueCompany.EditValue.ToString());
            m_balance.BeginDate = DateTime.Parse(dtBeginDate.EditValue.ToString());
            m_balance.EndDate = DateTime.Parse(dtEndDate.EditValue.ToString());
            m_balance.InterestDate = int.Parse(cboInterestDate.Text);
            m_balance.RepayDate = int.Parse(cboRepayDate.Text);
            m_balance.Account = txtAccount.Text;
            m_balance.Money = decimal.Parse(txtMoney.Text);
            m_balance.Rate = decimal.Parse(txtRate.Text);
        }

        /// <summary>
        /// 将对象的数据显示到界面上
        /// </summary>
        private void Object2Form()
        {
            if (m_balance.ID > 0)
            {
                txtCode.Text = m_balance.Code;
                txtAccount.Text = m_balance.Account;
                txtMoney.Text = m_balance.Money.ToString();
                txtRate.Text = m_balance.Rate.ToString();
                lueBank.EditValue = m_balance.BankID;
                lueCompany.EditValue = m_balance.CompanyID;
                dtBeginDate.EditValue = m_balance.BeginDate;
                dtEndDate.EditValue = m_balance.EndDate;
                cboInterestDate.Text = m_balance.InterestDate.ToString();
                cboRepayDate.Text = m_balance.RepayDate.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtAccount.Text = "";
                txtMoney.Text = "";
                txtRate.Text = "";
                lueBank.EditValue = null;
                lueCompany.EditValue = null;
                dtBeginDate.EditValue = DateTime.Now;
                dtEndDate.EditValue = DateTime.Now;
                cboInterestDate.Text = "";
                cboRepayDate.Text = "";
            }

            lueBank.Properties.DataSource = m_banks;
            lueBank.Properties.DisplayMember = "Name";
            lueBank.Properties.ValueMember = "ID";

            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";

            cboInterestDate.Properties.Items.Clear();
            cboRepayDate.Properties.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                cboInterestDate.Properties.Items.Add(i);
                cboRepayDate.Properties.Items.Add(i);
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balance.DetailList;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="status"></param>
        /// <param name="balance"></param>
        public DevBalance(winStatusEnum status, Balance balance = null)
        {
            InitializeComponent();
            if (balance != null)
                m_balance = balance;
            else
                m_balance = new Balance();

            SetFromStatus(status);
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            Form2Object();
            return true;
        }

        /// <summary>
        /// 载入窗口的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevBalance_Load(object sender, EventArgs e)
        {
            Object2Form();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            m_balance.Save();
            SetFromStatus(winStatusEnum.View);
            MessageBox.Show("保存成功");
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_balance.DetailList.Add(new BalanceDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balance.DetailList;
        }

        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        /// <summary>
        /// 新增一个对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_balance = new Balance();
            Object2Form();
            SetFromStatus(winStatusEnum.New);
        }

        /// <summary>
        /// 编辑对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_balance.ID <= 0)
                return;

            Object2Form();
            SetFromStatus(winStatusEnum.Edit);
        }

        /// <summary>
        /// 删除一个对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_balance.ID > 0)
            {
                m_balance.Destory();
                m_balance = new Balance();
                SetFromStatus(winStatusEnum.View);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(m_status == winStatusEnum.View || m_status == winStatusEnum.OnlyView))
            {
                if (MessageBox.Show("现在退出，当前做的工作将会丢失！是否真的退出？",
                                   "警告",
                                   MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
            }
            this.Close();
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_balance.CheckPass();
            SetFromStatus(winStatusEnum.OnlyView);
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckFaild_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_balance.CheckFaild();
            SetFromStatus(winStatusEnum.View);
        }



    }
}