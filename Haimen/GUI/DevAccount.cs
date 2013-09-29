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
    public partial class DevAccount : DevExpress.XtraEditors.XtraForm
    {

        private Account m_account;
        //private long m_contract_id = -1;        // 关联的合同ID
        //private long m_balance_id = -1;         // 关联的贷款ID

        private List<Bank> m_banks = Bank.Query();
        //private List<Company> m_companies = Company.Query();
        //private List<Funds> m_funds = Funds.Query();
        //private List<Contract> m_contracts = Contract.Query();  // 所有的合同
        //private List<Balance> m_balances = Balance.Query();     // 所有的贷款


        private winStatusEnum m_status;

        /// <summary>
        /// 计算总金额
        /// </summary>
        private void CalcMoney()
        {
            decimal money = 0;
            foreach (AccountDetail ad in m_account.DetailList)
            {
                money += ad.Money;
            }
            txtMoney.Text = money.ToString();
        }



        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.New))
            {
                if (tbNew.Enabled == true) tbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.Edit))
            {
                if (tbEdit.Enabled == true) tbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.Delete))
            {
                if (tbDelete.Enabled == true) tbDelete.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.Check))
            {
                if (tbCheckPassed.Enabled == true) tbCheckPassed.Enabled = false;
                if (tbCheckFaild.Enabled == true) tbCheckFaild.Enabled = false;
            }
        }

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.新增:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.编辑:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.查看:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.审核:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckFaild.Enabled = true;
                    tbCheckPassed.Enabled = true;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.纯查看:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.支付:
                    bar1.Visible = false;
                    bar2.Visible = true;
                    bar2.Offset = 0;

                    SetEditorStatus(false);
                    break;
            }
        }

        /// <summary>
        /// 设置当前输入控件是否可用。
        /// </summary>
        /// <param name="status"></param>
        private void SetEditorStatus(bool status)
        {
            dtSigned.Enabled = status;
            txtCode.Enabled = status;
            lueInCompany.Enabled = status;
            lueOutCompany.Enabled = status;
            lueInAccount.Enabled = status;
            lueOutAccount.Enabled = status;
            txtMemo.Enabled = status;

            lueProjects.Enabled = status;
            chkRelease.Enabled = status;
            lueMaker.Enabled = status;
            lueReviewer.Enabled = status;
            lueCashier.EditValue = status;


            tsbNew.Enabled = status;
            tsbDelete.Enabled = status;
            gridView1.OptionsBehavior.ReadOnly = !status;

            tsbAttachDelete.Enabled = status;
            tsbAttachNew.Enabled = status;
        }

        private void form2object()
        {
            m_account.SignedDate = dtSigned.DateTime;
            m_account.Code = txtCode.Text;

            if (this.lueOutAccount.EditValue != null)
                m_account.Out_CompanyDetail_ID = long.Parse(lueOutAccount.EditValue.ToString());

            if (lueInAccount.EditValue != null)
                m_account.In_CompanyDetail_ID = long.Parse(lueInAccount.EditValue.ToString());

            m_account.Memo = txtMemo.Text;
            if (string.IsNullOrEmpty(txtMoney.Text))
                m_account.Money = 0;
            else
                m_account.Money = decimal.Parse(txtMoney.Text);
        }

        /// <summary>
        /// 将对象印射到窗口上
        /// </summary>
        private void Object2form()
        {
            // 合同区先不显示，有需要显示的，下面自己把它显示出来
            layoutControl2.Visible = false;

            //先设置单位的数据来源
            List<Company> outlist = Company.Query("output = 'X'");
            List<Company> inlist = Company.Query("input = 'X'");

            lueInCompany.Properties.DataSource = inlist;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            lueOutCompany.Properties.DataSource = outlist;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";

            // 项目数据来源
            lueProjects.Properties.DataSource = null;
            lueProjects.Properties.DataSource = Project.Query();
            lueProjects.Properties.DisplayMember = "Name";
            lueProjects.Properties.ValueMember = "ID";

            // 制作人，审核人，出纳人的数据来源
            List<User> users = User.Query();
            lueMaker.Properties.DataSource = null;
            lueMaker.Properties.DataSource = users;
            lueMaker.Properties.DisplayMember = "Name";
            lueMaker.Properties.ValueMember = "ID";

            lueReviewer.Properties.DataSource = null;
            lueReviewer.Properties.DataSource = users;
            lueReviewer.Properties.DisplayMember = "Name";
            lueReviewer.Properties.ValueMember = "ID";

            lueCashier.Properties.DataSource = null;
            lueCashier.Properties.DataSource = users;
            lueCashier.Properties.DisplayMember = "Name";
            lueCashier.Properties.ValueMember = "ID";

            // 初始化明细
            List<Funds> fundslist = Funds.Query();
            luefunds.DataSource = fundslist;
            luefunds.DisplayMember = "Name";
            luefunds.ValueMember = "ID";

            gridControl1.DataSource = m_account.DetailList;


            // 初始化附件列表
            lstFiles.Items.Clear();
            foreach (Attach a in m_account.AttachList)
                lstFiles.Items.Add(a.ID.ToString() + "." + a.FileName, 2);

            // 显示数据
            if (m_account.ID > 0)
            {
                dtSigned.DateTime = m_account.SignedDate;
                txtCode.Text = m_account.Code;
                txtMoney.Text = m_account.Money.ToString();
                lueProjects.EditValue = m_account.ProjectID;
                lueMaker.EditValue = m_account.MakerID;
                lueReviewer.EditValue = m_account.ReviewerID;
                lueCashier.EditValue = m_account.CashierID;

                lueOutCompany.Properties.LockEvents();
                lueInCompany.Properties.LockEvents();
                lueInAccount.Properties.LockEvents();
                lueOutAccount.Properties.LockEvents();

                //List<CompanyDetail> outDetails = CompanyDetail.Query(" parent_id in ( select id from m_company where output = 'X')");
                //List<CompanyDetail> inDetails = CompanyDetail.Query(" parent_id in (select id from m_company where input = 'X')");

                lueOutCompany.EditValue = m_account.OutCompanyDetail.ParentID;
                List<CompanyDetail> out_list = CompanyDetail.Query("parent_id = " + m_account.OutCompanyDetail.ParentID);
                lueOutAccount.Properties.DataSource = null;
                lueOutAccount.Properties.DataSource = out_list;
                lueOutAccount.Properties.DisplayMember = "Account";
                lueOutAccount.Properties.ValueMember = "ID";
                lueOutAccount.EditValue = m_account.OutCompanyDetail.ID;
                txtOutBank.Text = m_account.OutCompanyDetail.Bank.Name;

                lueInCompany.EditValue = m_account.InCompanyDetail.ParentID;
                List<CompanyDetail> in_list = CompanyDetail.Query("parent_id = " + m_account.InCompanyDetail.ParentID);
                lueInAccount.Properties.DataSource = null;
                lueInAccount.Properties.DataSource = in_list;
                lueInAccount.Properties.DisplayMember = "Account";
                lueInAccount.Properties.ValueMember = "ID";
                lueInAccount.EditValue = m_account.InCompanyDetail.ID;
                txtInBank.Text = m_account.InCompanyDetail.Bank.Name;

                lueOutCompany.Properties.UnLockEvents();
                lueInCompany.Properties.UnLockEvents();
                lueInAccount.Properties.UnLockEvents();
                lueOutAccount.Properties.UnLockEvents();

                txtMemo.Text = m_account.Memo;
            }
            else
            {
                // 制作人为当前用户
                lueMaker.EditValue = GlobalSet.Current_User.ID;

                dtSigned.EditValue = DateTime.Now;
                txtCode.Text = "";
                
                lueInCompany.EditValue = null;
                lueInAccount.EditValue = null;
                txtOutBank.Text = "";

                lueOutCompany.EditValue = null;
                lueOutAccount.EditValue = null;
                txtInBank.Text = "";

                txtMemo.Text = "";
            }

            // 显示合同或者贷款信息
            ShowContractOrBalanceInfo();

            // 显示合同验收带来的信息   
            ShowAcceptInfo();

            // 显示审核标志
            ShowCheckPic();
        }

        /// <summary>
        /// 显示从合同里带来的信息
        /// </summary>
        private void ShowAcceptInfo()
        {
            // 只能新增，才显示
            if (m_account.ID == 0 && m_account.ContractAcceptID > 0)
            {
                ContractAccept ca = ContractAccept.CreateByID(m_account.ContractAcceptID);

                layoutControl2.Visible = true;
                Contract c = ca.Contract;
                txtContractCode.Text = c.Code;
                txtContractName.Text = c.Name;
                txtContractMoney.Text = c.Money.ToString();
                txtContractAlreadyPay.Text = c.Pay.ToString();
                txtContractUnpay.Text = (c.Money - c.Pay).ToString();

                lueInCompany.EditValue = c.InCompanyID;
                lueOutCompany.EditValue = c.OutCompanyID;
                lueInCompany.Enabled = false;
                lueOutCompany.Enabled = false;

                // 判断新增时，还要给二个单位赋值
                if (m_account.ID > 0)
                    txtMemo.Text = m_account.Memo;
                else
                {
                    txtMemo.Text = "本单据通过合同验收生成。";
                    lueInCompany.EditValue = c.InCompanyID;
                    lueOutCompany.EditValue = c.OutCompanyID;
                    txtMustPay.Text = ca.Money.ToString();
                }
            }
        }

        // 显示合同或贷款信息
        private void ShowContractOrBalanceInfo()
        {
            // 显示合同信息
            if (m_account.ContractID > 0)  // 显示合同信息
            {
                layoutControl2.Visible = true;
                Contract c = Contract.CreateByID(m_account.ContractID);
                txtContractCode.Text = c.Code;
                txtContractName.Text = c.Name;
                txtContractMoney.Text = c.Money.ToString();
                txtContractAlreadyPay.Text = c.Pay.ToString();
                txtContractUnpay.Text = (c.Money - c.Pay).ToString();

                lueInCompany.EditValue = c.InCompanyID;
                lueOutCompany.EditValue = c.OutCompanyID;
                lueInCompany.Enabled = false;
                lueOutCompany.Enabled = false;

                // 判断新增时，还要给二个单位赋值
                if (m_account.ID > 0)
                    txtMemo.Text = m_account.Memo;
                else
                {
                    txtMemo.Text = "本单据通过合同生成。";
                    lueInCompany.EditValue = c.InCompanyID;
                    lueOutCompany.EditValue = c.OutCompanyID;
                }
            }

            // 设置贷款信息
            if (m_account.BalanceID > 0)
            {
            }
        }

        // 显示审核的图片
        private void ShowCheckPic()
        {
            switch (m_account.Status)
            {
                case 1:
                    picPass.Visible = true;
                    picCheckFaild.Visible = false;
                    break;
                case 2:
                    picPass.Visible = false;
                    picCheckFaild.Visible = true;
                    break;
            }
        }

        // 关闭窗口
        private void FormClose()
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
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            form2object();

            dxErrorProvider1.ClearErrors();
            m_account.Verify();
            foreach (KeyValuePair<string, string> kv in m_account.Error_Info)
            {
                switch (kv.Key)
                {
                    case "In_CompanyDetail_ID":
                        dxErrorProvider1.SetError(lueInAccount, kv.Value);
                        break;
                    case "Out_CompanyDetail_ID":
                        dxErrorProvider1.SetError(lueOutAccount, kv.Value);
                        break;
                }
            }
            return !dxErrorProvider1.HasErrors;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        public DevAccount(winStatusEnum status, Account account = null, long ContractID = 0, 
                          long BalanceID = 0, long acceptid = 0)
        {
            InitializeComponent();

            SetFormStatus(status);
            if (account != null)
                m_account = account;
            else
                m_account = new Account();


            // 保存传过来的对应的贷款或合同ID或者合同验收号
            if (ContractID > 0)     
                m_account.ContractID = ContractID;

            if (BalanceID > 0)
                m_account.BalanceID = BalanceID;

            if (acceptid > 0)
                m_account.ContractAcceptID = acceptid;

        }

        private void DevAccount_Load(object sender, EventArgs e)
        {
            // 初始化界面
            Object2form();

            SetControlAccess();
        }

        /// <summary>
        /// 同步支出单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutCompany.EditValue != null)
            {
                m_account.Out_CompanyDetail_ID = long.Parse(lueOutCompany.EditValue.ToString());
                List<CompanyDetail> cd = CompanyDetail.Query("parent_id = " + m_account.Out_CompanyDetail_ID.ToString());
                lueOutAccount.Properties.DataSource = null;
                lueOutAccount.Properties.DataSource = cd;
                lueOutAccount.Properties.DisplayMember = "Account";
                lueOutAccount.Properties.ValueMember = "ID";
            }
        }

        /// <summary>
        /// 同步收入单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueInCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInCompany.EditValue != null)
            {
                m_account.In_CompanyDetail_ID = long.Parse(lueInCompany.EditValue.ToString());
                List<CompanyDetail> cd = CompanyDetail.Query("parent_id = " + m_account.In_CompanyDetail_ID.ToString());
                lueInAccount.Properties.DataSource = null;
                lueInAccount.Properties.DataSource = cd;
                lueInAccount.Properties.DisplayMember = "Account";
                lueInAccount.Properties.ValueMember = "ID";
            }
        }

        private void dtSigned_ValueChanged(object sender, EventArgs e)
        {
            m_account.SignedDate = DateTime.Parse(dtSigned.EditValue.ToString());
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            m_account.Code = txtCode.Text;
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            m_account.Memo = txtMemo.Text;
        }

        /// <summary>
        /// 增加明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_account.DetailList.Add(new AccountDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_account.DetailList;
        }

        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
            CalcMoney();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 更新编辑中的数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (!Verify())
                return;

            if (m_account.Save())
            {
                MessageBox.Show("保存成功！");
                SetFormStatus(winStatusEnum.查看);
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
            SetFormStatus(winStatusEnum.新增);
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
            SetFormStatus(winStatusEnum.编辑);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_account.ID > 0)
            {
                m_account.Destory();
                m_account = null;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                m_account.AttachList.Add(att);

                // 加入列表
                lstFiles.Items.Add(att.ID.ToString() + "." + fi.Name, 2);
            }
        }

        /// <summary>
        /// 关闭窗口
        /// 如果当前属新增或者编辑，则提示是否真的退出，只能选择了是才能退出。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormClose();
        }



        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// 双击附件，显示附件内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCheckPassed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.CheckPass();
            SetFormStatus(winStatusEnum.纯查看);      //审核通过后，只能看。
            ShowCheckPic();
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCheckFaild_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.CheckFaild();
            SetFormStatus(winStatusEnum.查看);
        }


        /// <summary>
        /// 选择帐户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutAccount.EditValue == null)
                return;

            long CD_id = long.Parse(lueOutAccount.EditValue.ToString());
            //CompanyDetail cd = CompanyDetail.CreateByID(CD_id);
            m_account.Out_CompanyDetail_ID = CD_id;
            txtOutBank.Text = m_account.OutCompanyDetail.Bank.Name;

            // 生成单据字
            if (string.IsNullOrEmpty(txtCode.Text))
                txtCode.Text = Company.CreateByID(m_account.OutCompanyDetail.ParentID).NextDoc();
        }

        private void lueInAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInAccount.EditValue == null)
                return;

            long id = long.Parse(lueInAccount.EditValue.ToString());
            m_account.In_CompanyDetail_ID = id;
            txtInBank.Text = m_account.InCompanyDetail.Bank.Name;
        }

        // 更新金额
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "col_money")
            {
                CalcMoney();
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            txtCMoney.Text = Haimen.Helper.Helper.ConvertToChinese( double.Parse(txtMoney.Text) );
        }

        private void tbExit2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormClose();
        }

        private void tbPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.Payed();
            SetFormStatus(winStatusEnum.纯查看);      //审核通过后，只能看。
            ShowCheckPic();
        }
    }
}