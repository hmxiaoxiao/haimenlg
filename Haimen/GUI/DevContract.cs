using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Haimen.Entity;
using Haimen.Helper;

using System.IO;
using System.Diagnostics;

namespace Haimen.GUI
{
    public partial class DevContract : DevExpress.XtraEditors.XtraForm
    {

        private Contract m_contract;

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
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.新增))
            {
                tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.编辑))
            {
                tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.删除))
            {
                tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.审核))
            {
                tbCheckPassed.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                tbCheckFaild.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }


        private winStatusEnum m_status;
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            bar1.Visible = true;
            bar2.Visible = false;
            bar3.Visible = false;
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
                    
                    // 支付申请不能编辑
                    layoutControl2.Enabled = false;
                    bar2.Visible = false;

                    SetControlStatus(true);
                    break;
                case winStatusEnum.查看:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    tbCheckFaild.Enabled = false;
                    layoutControl2.Enabled = false;
                    bar2.Visible = false;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.复核:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckPassed.Enabled = true;
                    tbCheckFaild.Enabled = true;
                    layoutControl2.Enabled = false;
                    bar2.Visible = false;

                    SetControlStatus(false);
                    break;
                case winStatusEnum.付款申请:
                    bar1.Visible = false;
                    bar2.Visible = true;
                    bar2.Offset = 0;
                    xtraTabControl1.SelectedTabPage = xtraTabPage4;

                    dtApplyDate.EditValue = DateTime.Now;

                    // 支付申请能编辑
                    layoutControl2.Enabled = true;

                    SetControlStatus(false);
                    break;

                case winStatusEnum.设置决算价:
                    bar1.Visible = false;
                    bar2.Visible = false;
                    bar3.Visible = true;
                    SetControlStatus(false);
                    calcCostMoney.Enabled = true;
                    tbSave2.Caption = "保存决算价";
                    break;
                case winStatusEnum.设置审计价:
                    bar1.Visible = false;
                    bar2.Visible = false;
                    bar3.Visible = true;
                    SetControlStatus(false);
                    txtCheckMoney.Enabled = true;
                    tbSave2.Caption = "保存审计价";
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
            lueProject.Enabled = enabled;

            dtSignedDate.Enabled = enabled;
            dtBeginDate.Enabled = enabled;
            dtEndDate.Enabled = enabled;
            txtMemo.Enabled = enabled;
            txtMoney.Enabled = enabled;
            txtPayment_ratio.Enabled = enabled;
            txtSecurity.Enabled = enabled;
            txtCheckMoney.Enabled = enabled;
            calcCostMoney.Enabled = enabled;

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
            if (lueProject.EditValue != null)
                m_contract.ProjectID = long.Parse(lueProject.EditValue.ToString());
            m_contract.SignedDate = DateTime.Parse(dtSignedDate.EditValue.ToString());
            m_contract.BeginDate = DateTime.Parse(dtBeginDate.EditValue.ToString());
            m_contract.EndDate = DateTime.Parse(dtEndDate.EditValue.ToString());
            m_contract.Memo = txtMemo.Text;
            m_contract.Money = txtMoney.Value;
            m_contract.CheckMoney = txtCheckMoney.Value;
            m_contract.PaymentRatio = txtPayment_ratio.Value;
            m_contract.Security = txtSecurity.Value;
            if (calcCostMoney.EditValue != null)
                m_contract.Cost = decimal.Parse(calcCostMoney.EditValue.ToString());
        }

        /// <summary>
        /// 将对象映射到界面上
        /// </summary>
        private void Object2Form()
        {
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

            // 项目数据来源
            lueProject.Properties.DataSource = null;
            lueProject.Properties.DataSource = Project.Query();
            lueProject.Properties.DisplayMember = "Name";
            lueProject.Properties.ValueMember = "ID";

            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;

            if (m_contract.ID > 0)
            {
                txtCode.Text = m_contract.Code;
                txtName.Text = m_contract.Name;
                lueOutCompany.EditValue = m_contract.OutCompanyID;
                lueInCompany.EditValue = m_contract.InCompanyID;
                luePartyA.EditValue = m_contract.PartyAID;
                luePartyB.EditValue = m_contract.PartyBID;

                lueProject.EditValue = m_contract.ProjectID;

                dtSignedDate.EditValue = m_contract.SignedDate;
                dtBeginDate.EditValue = m_contract.BeginDate;
                dtEndDate.EditValue = m_contract.EndDate;
                txtMemo.Text = m_contract.Memo;
                txtMoney.Value = m_contract.Money;
                txtCheckMoney.Value = m_contract.CheckMoney;
                calcCostMoney.Value = m_contract.Cost;
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
                calcCostMoney.Value = 0;
                txtPayment_ratio.Value = 0;
                txtSecurity.Value = 0;
            }

            // 设置合同付款申请
            if (m_contract.ID > 0)
            {
                lueApplyStatus.DataSource = ContractApply.ApplyStatus;
                lueApplyStatus.DisplayMember = "Key";
                lueApplyStatus.ValueMember = "Value";

                List<ContractApply> m_applies = ContractApply.Query();
                gridControl2.DataSource = null;
                gridControl2.DataSource = m_applies;

                if (m_status == winStatusEnum.付款申请)
                {
                    dtApplyDate.EditValue = DateTime.Now;
                }

                // 设置已经申请总额
                decimal sum_money = ContractApply.GetAllPayMoney(m_contract.ID);
                calcPayed.EditValue = sum_money;
                txtPayed.Text = Haimen.Helper.Helper.ConvertToChinese((double)sum_money);
            }

            // 显示附件
            lstFiles.Items.Clear();
            foreach (Attach a in m_contract.AttachList)
            {
                lstFiles.Items.Add(String.Format("{0}.{1}", a.ID, a.FileName), 2);
            }

            switch (m_contract.Status)
            {
                case (long)Contract.ContractStatusEnum.未审核:
                    picChecked.Visible = false;
                    picPayed.Visible = false;
                    break;
                case (long)Contract.ContractStatusEnum.审核未通过:
                    picPayed.Visible = true;
                    picChecked.Visible = false;
                    break;
                case (long)Contract.ContractStatusEnum.审核通过:
                case (long)Contract.ContractStatusEnum.已验收:
                case (long)Contract.ContractStatusEnum.已中止:
                    picPayed.Visible = false;
                    picChecked.Visible = true;
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
            m_contract.InsertUpdateVerify();
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

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        private void MyExit()
        {
            if (!(m_status == winStatusEnum.查看))
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
            ContractDetail cd = new ContractDetail() { PayDate = DateTime.Now };
            m_contract.DetailList.Add(cd);
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
            MyExit();
        }



        private void tsbAttachNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog() { Title = "请选择需要上传的文件", 
                                                       ValidateNames = true, 
                                                       CheckFileExists = true, 
                                                       CheckPathExists = true };

            if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fi = new FileInfo(fd.FileName);
                // 先保存到数据库里
                Attach att = new Attach() { FileName = fi.Name, FileType = fi.Extension };
                att.Save();

                FTPClient ftp = INICustomer.GetFTPClient();
                ftp.fileUpload(fi, @"\", att.ID + fi.Extension);

                m_contract.AttachList.Add(att);

                // 加入列表
                lstFiles.Items.Add(String.Format("{0}.{1}", att.ID, fi.Name), 2);
            }
        }

        private void tsbAttachDelete_Click(object sender, EventArgs e)
        {
            string[] temp = lstFiles.Items[lstFiles.SelectedIndex].Value.ToString().Split('.');
            if (temp.Length > 0)
            {
                long id = long.Parse(temp[0]);
                Attach att = Attach.CreateByID(id);

                FTPClient ftp = INICustomer.GetFTPClient();
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

                FTPClient ftp = INICustomer.GetFTPClient();
                string tempPath = Path.GetTempPath();
                if (ftp.fileDownload(tempPath, att.FileName, @"\", att.ID + att.FileType))
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
            SetFormStatus(winStatusEnum.查看);
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

        private void tbApplyExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyExit();
        }

        /// <summary>
        /// 付款申请保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbApplySave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 先将界面的数据保存到对象里
            ContractApply apply = new ContractApply() { ContractID = m_contract.ID, 
                                                        ApplyDate = DateTime.Parse(dtApplyDate.EditValue.ToString()) };
            if (calcApplyMoney.EditValue != null)
                apply.Money = decimal.Parse(calcApplyMoney.EditValue.ToString());
            apply.Memo = txtApplyMemo.Text;

            // 判断是否通过校验
            if (!apply.InsertUpdateVerify())
            {
                dxErrorProvider1.ClearErrors();
                dxErrorProvider1.SetError(calcApplyMoney, apply.ErrorString);
                return;
            }
            else
            {
                apply.Save();
                tbApplySave.Enabled = false;
                layoutControl2.Enabled = false;
                m_status = winStatusEnum.查看;
                MessageBox.Show("合同付款申请保存成功！", "注意");
            }
        }

        private void tbSave2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            m_contract.Save();
            MessageBox.Show("保存成功！");
            tbSave2.Enabled = false;
            m_status = winStatusEnum.查看;
        }

    }
}