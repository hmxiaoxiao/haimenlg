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

namespace Haimen.GUI
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
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.单位, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.单位, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.单位, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        /// <summary>
        /// 设置窗口的控件是否可用
        /// </summary>
        /// <param name="enabled"></param>
        private void SetControlStatus(bool enabled)
        {
            txtCode.Enabled = enabled;
            txtName.Enabled = enabled;
            txtDoc.Enabled = enabled;
            sueCompany.Enabled = enabled;
            cbInput.Enabled = enabled;
            cbOutput.Enabled = enabled;
        }

        /// <summary>
        /// 根据是编辑 还是新增，设置按钮的状态
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.新增:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbSave.Enabled = true;
                    SetControlStatus(true);     //  控件可用
                    break;
                case winStatusEnum.编辑:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbSave.Enabled = true;
                    SetControlStatus(true);     //  控件可用
                    break;
                case winStatusEnum.查看:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbSave.Enabled = false;
                    SetControlStatus(false);    //  控件不可使用
                    break;
            }
        }


        // 校验数据是否正确
        private bool Verify()
        {
            Form2Object();

            // 清空错误
            dxErrorProvider1.ClearErrors();

            // 调用校验对象
            if (m_company.Verify())
                return true;

            // 错误处理
            ShowErrorInfo();
            return false;
        }

        /// <summary>
        /// 显示错误信息
        /// </summary>
        private void ShowErrorInfo()
        {
 

            foreach (KeyValuePair<string, string> val in m_company.Error_Info)
            {
                switch (val.Key.ToLower())
                {
                    case "code":
                        dxErrorProvider1.SetError(txtCode, val.Value);
                        break;
                    case "name":
                        dxErrorProvider1.SetError(txtName, val.Value);
                        break;
                    case "doc":
                        dxErrorProvider1.SetError(txtDoc, val.Value);
                        break;
                    case "parentid":
                        dxErrorProvider1.SetError(sueCompany, val.Value);
                        break;
                }
            }
        }

        /// <summary>
        /// 将对象显示到界面上
        /// </summary>
        private void Object2Form()
        {
            txtCode.Text = m_company.Code;
            txtDoc.Text = m_company.Doc;
            txtName.Text = m_company.Name;

            List<Company> list = Company.Query("input <> 'X' and output <> 'X'");
            sueCompany.Properties.DataSource = list;
            sueCompany.Properties.DisplayMember = "Name";
            sueCompany.Properties.ValueMember = "ID";

            sueCompany.EditValue = m_company.ParentID;

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
            m_company.Code = txtCode.Text;
            m_company.Name = txtName.Text;
            m_company.Doc = txtDoc.Text;
            if (sueCompany.EditValue != null)
                m_company.ParentID = long.Parse(sueCompany.EditValue.ToString());

            if (cbInput.Checked)
                m_company.Input = "X";
            else
                m_company.Input = "";

            if (cbInput.Checked)
                m_company.Output = "X";
            else
                m_company.Output = "";
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
                SetFormStatus(winStatusEnum.编辑);
                m_company = company;
            }
            else
            {
                SetFormStatus(winStatusEnum.新增);
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
            if (!Verify())
                return;

            if (!m_company.Save())
            {
                ShowErrorInfo();
                return;
            }

            MessageBox.Show("保存成功！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetFormStatus(winStatusEnum.查看);
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_status != winStatusEnum.查看)
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
            Object2Form();
            SetFormStatus(winStatusEnum.新增);
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Object2Form();
            SetFormStatus(winStatusEnum.新增);
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_company.ID > 0)
            {
                if (!m_company.CanDelete(m_company.ID))
                {
                    MessageBox.Show(m_company.ErrorString, "注意");
                    return;
                }
                m_company = null;
                SetFormStatus(winStatusEnum.查看);
            }
        }
    }
}