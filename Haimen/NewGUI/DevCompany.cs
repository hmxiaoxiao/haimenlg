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
    public partial class DevCompany : DevExpress.XtraEditors.XtraForm
    {
        private Company m_company;
        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.New))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.Edit))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.Delete))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
        }

        /// <summary>
        /// 根据是编辑 还是新增，设置按钮的状态
        /// </summary>
        /// <param name="status"></param>
        public void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.New:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbSave.Enabled = true;

                    this.Text = " 单位管理 - 新增 ";
                    break;
                case winStatusEnum.Edit:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbSave.Enabled = true;

                    this.Text = " 单位管理 - 编辑 ";
                    break;
                case winStatusEnum.View:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbSave.Enabled = false;

                    this.Text = " 单位管理 - 查看 ";
                    break;
            }
        }

        /// <summary>
        /// 初始化银行下拉框
        /// </summary>
        private void initBankList()
        {
            List<Bank> banks = Bank.Query();
            cboBankList.Properties.DataSource = null;
            cboBankList.Properties.DataSource = banks;
            cboBankList.Properties.DisplayMember = "Name";
            cboBankList.Properties.ValueMember = "ID";
        }

        // 校验数据是否正确
        private bool Verify()
        {
            Form2Object();

            // 调用校验对象
            if (m_company.Verify())
                return true;

            // 错误处理
            SetErrorInfo();
            return false;
        }

        /// <summary>
        /// 显示错误信息
        /// </summary>
        private void SetErrorInfo()
        {
            dxErrorProvider1.ClearErrors();

            foreach (KeyValuePair<string, string> val in m_company.Error_Info)
            {
                switch (val.Key.ToLower())
                {
                    case "code":
                        dxErrorProvider1.SetError(txtCode, val.Value);
                        break;
                    case "name":
                        dxErrorProvider1.SetError(txtName, val.Value);
                        break; ;
                    case "doc":
                        dxErrorProvider1.SetError(txtDoc, val.Value);
                        break;
                }
            }
        }

        /// <summary>
        /// 将对象显示到界面上
        /// </summary>
        private void Object2Form()
        {
            initBankList();
            cboBankList.Text = "";
            if (m_company.Bank_ID > 0)
                cboBankList.EditValue = m_company.Bank_ID;
            txtCode.Text = m_company.Code;
            txtDoc.Text = m_company.Doc;
            txtName.Text = m_company.Name;
            txtAccount.Text = m_company.Account;

            if (m_company.Input == "X")
                cbInput.Checked = true;
            else
                cbInput.Checked = false;

            if (m_company.Output == "X")
                cbOutput.Checked = true;
            else
                cbOutput.Checked = false;
        }

        /// <summary>
        /// 将界面的内容保存到对象里
        /// </summary>
        private void Form2Object()
        {
            // 将输入的值保存到对象里
            if (cboBankList.EditValue != null)
                m_company.Bank_ID = long.Parse(cboBankList.EditValue.ToString());
            else
                m_company.Bank_ID = 0;

            m_company.Code = txtCode.Text;
            m_company.Name = txtName.Text;
            m_company.Doc = txtDoc.Text;
            if (cbInput.Checked)
                m_company.Input = "X";
            else
                m_company.Input = "";

            if (cbInput.Checked)
                m_company.Output = "X";
            else
                m_company.Output = "";

            m_company.Account = txtAccount.Text;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="company"></param>
        public DevCompany(Company company = null)
        {
            InitializeComponent();
            if (company != null)
            {
                SetFormStatus(winStatusEnum.Edit);
                m_company = company;
            }
            else
            {
                SetFormStatus(winStatusEnum.New);
                m_company = new Company();
            }
        }

        /// <summary>
        /// 载入时，初始化界面，并将对象赋值到界面上。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevCompany_Load(object sender, EventArgs e)
        {
            initBankList();
            Object2Form();
            SetControlAccess();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // 代码以简拼为准
            txtCode.Text = PinyinHelper.GetShortPinyin(txtName.Text).ToUpper();
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCode.Focus();
            txtName.Focus();
            
            if (!Verify())
                return;

            if (!m_company.Save())
            {
                SetErrorInfo();
                return;
            }

            MessageBox.Show("保存成功！", "注意",MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetFormStatus(winStatusEnum.View);
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_status != winStatusEnum.View)
            {
                if (MessageBox.Show("现在退出，当前的数据将会丢失，是否要退出？", "注意！",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                    return;
            }
            this.Close();
        }

        // 新增单位
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_company = new Company();
            initBankList();
            Object2Form();
            SetFormStatus(winStatusEnum.New);
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            initBankList();
            Object2Form();
            SetFormStatus(winStatusEnum.New);
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_company.ID > 0)
            {
                m_company.Destory();
                m_company = new Company();
                initBankList();
                Object2Form();
                SetFormStatus(winStatusEnum.New);
            }
        }


    }
}