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

using System.IO;
using System.Diagnostics;

namespace Haimen.NewGUI
{
    public partial class DevContract : DevExpress.XtraEditors.XtraForm
    {

        private Contract m_contract;
        //private List<Company> m_companies = Company.Query();

        /// <summary>
        /// 设置保证金，自动计算
        /// </summary>
        private void SetSecurity()
        {
            decimal total = txtMoney.Value;
            decimal rate = txtPayment_ratio.Value;

            txtSecurity.Value = decimal.Round(total * rate / 100, 4);
        }


        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.New))
            {
                if (tbNew.Enabled == true) tbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.Edit))
            {
                if (tbEdit.Enabled == true) tbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.Delete))
            {
                if (tbDelete.Enabled == true) tbDelete.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.Check))
            {
                if (tbCheckPassed.Enabled == true) tbCheckPassed.Enabled = false;
                if (tbCheckFaild.Enabled == true) tbCheckFaild.Enabled = false;
            }
        }


        private winStatusEnum m_status;
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.新增:
                case winStatusEnum.编辑:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheckPassed.Enabled = false;
                    tbCheckFaild.Enabled = false;

                    SetControlStatus(true);
                    break;
                case winStatusEnum.查看:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    tbCheckFaild.Enabled = false;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.审核:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckPassed.Enabled = true;
                    tbCheckFaild.Enabled = true;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.纯查看:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    tbCheckFaild.Enabled = false;

                    SetControlStatus(false);
                    break;
            }
        }

        // 设置输入控件的可用与否
        private void SetControlStatus(bool enabled)
        {
            txtCode.Enabled = enabled;
            txtName.Enabled = enabled;
            lueOutCompany.Enabled = enabled;
            lueInCompany.Enabled = enabled;
            luePartyA.Enabled = enabled;
            luePartyB.Enabled = enabled;

            dtSignedDate.Enabled = enabled;
            dtBeginDate.Enabled = enabled;
            dtEndDate.Enabled = enabled;
            txtMemo.Enabled = enabled;
            txtMoney.Enabled = enabled;
            txtPayment_ratio.Enabled = enabled;
            txtSecurity.Enabled = enabled;
            txtCheckMoney.Enabled = enabled;

            tsbNew.Enabled = enabled;
            tsbDelete.Enabled = enabled;

            tsbAttachDelete.Enabled = enabled;
            tsbAttachNew.Enabled = enabled;

            gridView1.OptionsBehavior.Editable = enabled;
        }

        /// <summary>
        /// 将界面上的数据映射到对象里
        /// </summary>
        private void Form2Object()
        {
            m_contract.Code= txtCode.Text;
            m_contract.Name = txtName.Text;
            if (lueOutCompany.EditValue != null)
                m_contract.OutCompanyID = long.Parse(lueOutCompany.EditValue.ToString());
            if (lueInCompany.EditValue != null)
                m_contract.InCompanyID = long.Parse(lueInCompany.EditValue.ToString());
            if(luePartyA.EditValue != null)
                m_contract.PartyAID = long.Parse(luePartyA.EditValue.ToString());
            if(luePartyB.EditValue != null)
                m_contract.PartyBID = long.Parse(luePartyB.EditValue.ToString());
            m_contract.SignedDate = DateTime.Parse(dtSignedDate.EditValue.ToString());
            m_contract.BeginDate = DateTime.Parse(dtBeginDate.EditValue.ToString());
            m_contract.EndDate = DateTime.Parse(dtEndDate.EditValue.ToString());
            m_contract.Memo = txtMemo.Text;
            m_contract.Money = txtMoney.Value;
            m_contract.CheckMoney = txtCheckMoney.Value;
            m_contract.PaymentRatio = txtPayment_ratio.Value;
            m_contract.Security = txtSecurity.Value;
        }

        /// <summary>
        /// 将对象映射到界面上
        /// </summary>
        private void Object2Form()
        {
            if (m_contract.ID > 0)
            {
                txtCode.Text = m_contract.Code;
                txtName.Text = m_contract.Name;
                lueOutCompany.EditValue = m_contract.OutCompanyID;
                lueInCompany.EditValue = m_contract.InCompanyID;
                luePartyA.EditValue = m_contract.PartyAID;
                luePartyB.EditValue = m_contract.PartyBID;

                dtSignedDate.EditValue = m_contract.SignedDate;
                dtBeginDate.EditValue = m_contract.BeginDate;
                dtEndDate.EditValue = m_contract.EndDate;
                txtMemo.Text = m_contract.Memo;
                txtMoney.Value = m_contract.Money;
                txtCheckMoney.Value = m_contract.CheckMoney;
                txtPayment_ratio.Value = m_contract.PaymentRatio;
                txtSecurity.Value = m_contract.Security;
            }
            else
            {
                txtCode.Text = "";
                txtName.Text = "";
                lueOutCompany.EditValue = null;
                lueInCompany.EditValue = null;
                luePartyA.EditValue = null;
                luePartyB.EditValue = null;
                dtSignedDate.EditValue = DateTime.Now;
                dtBeginDate.EditValue = DateTime.Now;
                dtEndDate.EditValue = DateTime.Now;
                txtMemo.Text = "";
                txtMoney.Value = 0;
                txtCheckMoney.Value = 0;
                txtPayment_ratio.Value = 0;
                txtSecurity.Value = 0;
            }

            // 设置收支单位的数据来源
            List<Company> outlist = Company.Query("output = 'X'");
            List<Company> inlist = Company.Query("input = 'X'"); 
            
            lueOutCompany.Properties.DataSource = null;
            lueOutCompany.Properties.DataSource = outlist;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";

            lueInCompany.Properties.DataSource = null;
            lueInCompany.Properties.DataSource = inlist;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            luePartyA.Properties.DataSource = null;
            luePartyA.Properties.DataSource = outlist;
            luePartyA.Properties.DisplayMember = "Name";
            luePartyA.Properties.ValueMember = "ID";

            luePartyB.Properties.DataSource = null;
            luePartyB.Properties.DataSource = inlist;
            luePartyB.Properties.DisplayMember = "Name";
            luePartyB.Properties.ValueMember = "ID";

            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;

            lstFiles.Items.Clear();
            foreach (Attach a in m_contract.AttachList)
            {
                lstFiles.Items.Add(a.ID.ToString() + "." + a.FileName, 2);
            }

            switch (m_contract.Status)
            {
                case (long)AccountStatusEnum.未审核:
                    picPass.Visible = false;
                    picCheckFaild.Visible = false;
                    break;
                case (long)AccountStatusEnum.审核未通过:
                    picCheckFaild.Visible = true;
                    picPass.Visible = false;
                    break;
                case (long)AccountStatusEnum.审核通过:
                case (long)AccountStatusEnum.已支付:
                case (long)AccountStatusEnum.已关闭:
                    picCheckFaild.Visible = false;
                    picPass.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            Form2Object();
            dxErrorProvider1.ClearErrors();
            m_contract.Verify();
            foreach (KeyValuePair<string, string> kv in m_contract.Error_Info)
            {
                switch (kv.Key)
                {
                    case "Code":
                        dxErrorProvider1.SetError(txtCode, kv.Value);
                        break;
                    case "OutCompanyID":
                        dxErrorProvider1.SetError(lueOutCompany, kv.Value);
                        break;
                    case "InCompanyID":
                        dxErrorProvider1.SetError(lueInCompany, kv.Value);
                        break;
                    case "PartyA_ID":
                        dxErrorProvider1.SetError(luePartyA, kv.Value);
                        break;
                    case "PartyB_ID":
                        dxErrorProvider1.SetError(luePartyB, kv.Value);
                        break;
                }
            }


            return !dxErrorProvider1.HasErrors;
        }

        public DevContract(winStatusEnum status, Contract con = null)
        {
            InitializeComponent();
            if (con != null)
                m_contract = con;
            else
                m_contract = new Contract();

            SetFormStatus(status);
        }


        // 载入时，显示对象
        private void DevContract_Load(object sender, EventArgs e)
        {
            Object2Form();
            SetControlAccess();
        }

        // 增加明细
        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_contract.DetailList.Add(new ContractDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;
        }

        // 删除明细
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        // 保存
        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // 同步输入
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
            
            if (!Verify())
                return;

            m_contract.Save();
            MessageBox.Show("保存成功！");
            SetFormStatus(winStatusEnum.查看);
        }


        // 新增
        private void tbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_contract = new Contract();
            Object2Form();
            SetFormStatus(winStatusEnum.新增);
        }

        // 编辑对象
        private void tbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_contract != null && m_contract.ID > 0)
            {
                Object2Form();
                SetFormStatus(winStatusEnum.编辑);
            }
        }

        // 删除对象
        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_contract != null && m_contract.ID > 0)
            {
                m_contract.Destory();
                m_contract = new Contract();
                Object2Form();
                SetFormStatus(winStatusEnum.查看);
            }
        }

        private void tbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void tsbAttachNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "请选择需要上传的文件";
            fd.ValidateNames = true;
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;

            if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fi = new FileInfo(fd.FileName);
                // 先保存到数据库里
                Attach att = new Attach();
                att.FileName = fi.Name;
                att.FileType = fi.Extension;
                att.Save();

                FTPClient ftp = CustomerINI.GetFTPClient();
                ftp.fileUpload(fi, @"\", att.ID.ToString() + fi.Extension);

                m_contract.AttachList.Add(att);

                // 加入列表
                lstFiles.Items.Add(att.ID.ToString() + "." + fi.Name, 2);
            }
        }

        private void tsbAttachDelete_Click(object sender, EventArgs e)
        {
            string[] temp = lstFiles.Items[lstFiles.SelectedIndex].Value.ToString().Split('.');
            if (temp.Length > 0)
            {
                long id = long.Parse(temp[0]);
                Attach att = Attach.CreateByID(id);

                FTPClient ftp = CustomerINI.GetFTPClient();
                ftp.fileDelete(@"\", att.FileName);

                att.Destory();

                lstFiles.Items.Remove(lstFiles.Items[lstFiles.SelectedIndex]);

            }
        }

        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            string[] temp = lstFiles.Items[lstFiles.SelectedIndex].Value.ToString().Split('.');
            if (temp.Length > 0)
            {
                long id = long.Parse(temp[0]);
                Attach att = Attach.CreateByID(id);

                FTPClient ftp = CustomerINI.GetFTPClient();
                string tempPath = Path.GetTempPath();
                if (ftp.fileDownload(tempPath, att.FileName, @"\", att.ID.ToString() + att.FileType))
                {
                    Process.Start(Path.Combine(tempPath, att.FileName));
                }
                else
                {
                    MessageBox.Show("下载附件失败！");
                }

            }
        }

        // 审核通过
        private void tbCheckPassed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_contract.CheckPassed();
            SetFormStatus(winStatusEnum.纯查看);
        }

        // 审核不通过
        private void tbCheckFaild_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_contract.CheckFaild();
            SetFormStatus(winStatusEnum.查看);
        }

        /// <summary>
        /// 支付比例修改后，保证金自动调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPayment_ratio_EditValueChanged(object sender, EventArgs e)
        {
            SetSecurity();
        }

        private void txtMoney_EditValueChanged(object sender, EventArgs e)
        {
            SetSecurity();
        }

    }
}