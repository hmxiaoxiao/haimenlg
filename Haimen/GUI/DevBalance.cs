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
    public partial class DevBalance : DevExpress.XtraEditors.XtraForm
    {
        private Balance m_balance;

        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.新增))
            {
                btnNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.编辑))
            {
                btnEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.删除))
            {
                btnDelete.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.审核))
            {
                btnCheck.Enabled = false;
            }
        }

        /// <summary>
        /// 设置窗口的状态
        /// </summary>
        /// <param name="status"></param>
        private void SetFromStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.新增:
                case winStatusEnum.编辑: 
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCheck.Enabled = false;
                    btnCheckFaild.Enabled = false;

                    SetControlStatus(true);
                    break;
                case winStatusEnum.查看:
                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCheck.Enabled = false;
                    btnCheckFaild.Enabled = false;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.审核:
                    barCheck.Visible = true;
                    barNormal.Visible = false;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.纯查看:
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
            calcMoney.Enabled = enabled;
            calcRate.Enabled = enabled;
            lueCompanyDetail.Enabled = enabled;
            lueCompany.Enabled = enabled;
            dtBeginDate.Enabled = enabled;
            dtEndDate.Enabled = enabled;

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
            m_balance.Name = txtName.Text;
            m_balance.CompanyDetailID = long.Parse(lueCompanyDetail.EditValue.ToString());
            m_balance.BeginDate = dtBeginDate.DateTime;
            m_balance.EndDate = dtEndDate.DateTime;
            m_balance.Money = calcMoney.Value;
            m_balance.Rate = calcRate.Value;
        }

        /// <summary>
        /// 将对象的数据显示到界面上
        /// </summary>
        private void Object2Form()
        {

            lueCompany.Properties.DataSource = Company.Query();
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";

            if (m_balance.ID > 0)
            {
                txtCode.Text = m_balance.Code;
                calcMoney.Text = m_balance.Money.ToString();
                calcRate.Text = m_balance.Rate.ToString();

                lueCompany.Properties.LockEvents();
                lueCompanyDetail.Properties.LockEvents();

                lueCompany.EditValue = m_balance.CompanyDetail.ParentID;

                lueCompanyDetail.Properties.DataSource = m_balance.CompanyDetail.Parent.DetailList;
                lueCompanyDetail.Properties.DisplayMember = "Name";
                lueCompanyDetail.Properties.ValueMember = "ID";
                lueCompanyDetail.EditValue = m_balance.CompanyDetailID;

                lueCompanyDetail.Properties.UnLockEvents();
                lueCompany.Properties.UnLockEvents();

                dtBeginDate.EditValue = m_balance.BeginDate;
                dtEndDate.EditValue = m_balance.EndDate;
            }
            else
            {
                txtCode.Text = "";
                txtName.Text = "";
                txtAccount.Text = "";
                calcMoney.Value = 0;
                calcRate.Value = 0;
                lueCompanyDetail.EditValue = null;
                lueCompany.EditValue = null;
                dtBeginDate.DateTime = DateTime.Now;
                dtEndDate.DateTime = DateTime.Now;

                lueCompanyDetail.Properties.DataSource = null;
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balance.DetailList;
        }

        /// <summary>
        /// 显示审核的标志
        /// </summary>
        private void ShowCheckPic()
        {
            switch (m_balance.Status)
            {
                case (long)Balance.BalanceStatusEnum.未审核:
                    picPass.Visible = false;
                    break;
                case (long)Balance.BalanceStatusEnum.审核通过:
                    picPass.Visible = true;
                    break;
                case (long)Balance.BalanceStatusEnum.贷款到帐:
                    picPass.Visible = true;
                    break;
            }
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

            dxErrorProvider1.ClearErrors();

            m_balance.Verify();
            foreach (KeyValuePair<string, string> kv in m_balance.Error_Info)
            {
                switch (kv.Key)
                {
                    case "Code":
                        dxErrorProvider1.SetError(txtCode, kv.Value);
                        break;
                    case "Name":
                        dxErrorProvider1.SetError(txtName, kv.Value);
                        break;
                    case "CompanyDetailID":
                        dxErrorProvider1.SetError(lueCompanyDetail, kv.Value);
                        break;
                    case "Money":
                        dxErrorProvider1.SetError(calcMoney, kv.Value);
                        break;
                }
            }

            return !dxErrorProvider1.HasErrors;
        }

        /// <summary>
        /// 载入窗口的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevBalance_Load(object sender, EventArgs e)
        {
            Object2Form();
            SetControlAccess();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 同步表格数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            
            if (!Verify())
                return;

            m_balance.Save();
            SetFromStatus(winStatusEnum.查看);
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
            SetFromStatus(winStatusEnum.新增);
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
            SetFromStatus(winStatusEnum.编辑);
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
                SetFromStatus(winStatusEnum.查看);
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(m_status == winStatusEnum.查看 || m_status == winStatusEnum.纯查看))
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
            SetFromStatus(winStatusEnum.纯查看);
        }

        private void lueCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCompany.EditValue == null)
                return;

            long id = long.Parse(lueCompany.EditValue.ToString());
            lueCompanyDetail.Properties.DataSource = null;
            lueCompanyDetail.Properties.DataSource = Company.CreateByID(id).DetailList;
            lueCompanyDetail.Properties.DisplayMember = "BankName";
            lueCompanyDetail.Properties.ValueMember = "ID";
            lueCompanyDetail.Enabled = true;
        }

        private void lueCompanyDetail_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCompanyDetail.EditValue == null)
                return;

            long id = long.Parse(lueCompanyDetail.EditValue.ToString());
            txtAccount.Text = CompanyDetail.CreateByID(id).Account;
        }



    }
}