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

namespace Haimen.GUI
{
    public partial class DevAccount : DevExpress.XtraEditors.XtraForm
    {

        private Account m_account;                  // 当前正在编辑的资金对象
        private winStatusEnum m_status;             // 当前窗口的状态，象新增之类的

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
            calc2Money.EditValue = money;
        }


        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            // 普通新增，编辑，删除
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.新增))
            {
                tbNew.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.编辑))
            {
                tbEdit.Dispose();
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.删除))
            {
                tbDelete.Dispose();
            }

            // 审核
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.审核))
            {
                tbCheck.Dispose();
                tbUnCheck.Dispose();
            }

            // 支付
            if (!Access.getUserAccess(GlobalSet.Current_User.ID,  (long)FctionEnum.资金, (long)ActionEnum.支付))
            {
                tbPay.Dispose();
                tbUnPay.Dispose();
            }

        }

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            barNormal.Visible = true;
            barCheck.Visible = false;
            barPay.Visible = false;
            barInvoice.Visible = false;

            switch (status)
            {
                case winStatusEnum.新增:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheck.Enabled = false;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.编辑:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheck.Enabled = false;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.查看:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    tbCheck.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.审核:
                    barNormal.Visible = false;
                    barCheck.Visible = true;
                    barPay.Visible = false;
                    barInvoice.Visible = false;
                    barCheck.Offset = 0;        // 把状态条的位置移动第一位
                    tbCheck.Enabled = true;
                    tbUnCheck.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.撤审:
                    barNormal.Visible = false;
                    barCheck.Visible = true;
                    barPay.Visible = false;
                    barInvoice.Visible = false;
                    barCheck.Offset = 0;        // 把状态条的位置移动第一位
                    tbCheck.Enabled = false;
                    tbUnCheck.Enabled = true;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.纯查看:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheck.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.支付:
                    barNormal.Visible = false;
                    barCheck.Visible = false;
                    barPay.Visible = true;
                    barInvoice.Visible = false;
                    barPay.Offset = 0;          // 把状态条的位置移到第一条
                    tbPay.Enabled = true;
                    tbUnPay.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.撤消支付:
                    barNormal.Visible = false;
                    barCheck.Visible = false;
                    barPay.Visible = true;
                    barInvoice.Visible = false;
                    barPay.Offset = 0;          // 把状态条的位置移到第一条
                    tbPay.Enabled = false;
                    tbUnPay.Enabled = true;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.转正式发票:
                    barNormal.Visible = false;
                    barPay.Visible = false;
                    barCheck.Visible = false;
                    barInvoice.Visible = true;
                    barInvoice.Offset = 0;
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
            lueContractApply.Enabled = status;      // 合同申请
            calcPayMoney.Enabled = status;          // 申请金额

            dtSigned.Enabled = status;              // 日期
            txtCode.Enabled = status;               // 代码
            lueInCompany.Enabled = status;          // 收入单位
            lueOutCompany.Enabled = status;         // 支出单位
            lueInAccount.Enabled = status;          // 收入帐号
            lueOutAccount.Enabled = status;         // 支出帐号
            calcAttachCount.Enabled = status;       // 附件张数
            txtMemo.Enabled = status;               // 备注

            lueProjects.Enabled = status;           // 所属项目
            chkRelease.Enabled = status;            // 正式发票

            tsbNew.Enabled = status;                            // 资金明细新增
            tsbDelete.Enabled = status;                         // 资金明细删除
            gridView1.OptionsBehavior.ReadOnly = !status;       // 资金列表

            tsbAttachDelete.Enabled = status;       // 附件删除
            tsbAttachNew.Enabled = status;          // 附件新增
        }

        /// <summary>
        /// 将窗口的信息保存到编辑的对象里去。
        /// </summary>
        private void form2object()
        {
            m_account.SignedDate = dtSigned.DateTime;       // 日期
            m_account.Code = txtCode.Text;                  // 代码

            // 支出帐号
            if (this.lueOutAccount.EditValue != null)
                m_account.Out_CompanyDetail_ID = long.Parse(lueOutAccount.EditValue.ToString());

            // 收入帐号
            if (lueInAccount.EditValue != null)
                m_account.In_CompanyDetail_ID = long.Parse(lueInAccount.EditValue.ToString());

            // 备注
            m_account.Memo = txtMemo.Text;

            // 正式发票
            if (chkRelease.Checked)
                m_account.Invoice = (long)Account.AccountInvoiceEnum.正式发票;
            else
                m_account.Invoice = (long)Account.AccountInvoiceEnum.非正式发票;

            // 总金额
            if (string.IsNullOrEmpty(txtMoney.Text))
                m_account.Money = 0;
            else
                m_account.Money = decimal.Parse(txtMoney.Text);

            // 合同申请号，如果存在的话
            if (!(lueContractApply.EditValue == null || string.IsNullOrEmpty(lueContractApply.EditValue.ToString())))
                m_account.ContractApplyID = long.Parse(lueContractApply.EditValue.ToString());

            // 附件张数
            m_account.Attachment = m_account.AttachList.Count;

            // 项目
            if (!(lueProjects.EditValue == null || string.IsNullOrEmpty(lueProjects.EditValue.ToString())))
                m_account.ProjectID = long.Parse(lueProjects.EditValue.ToString());
        }

        /// <summary>
        /// 将对象印射到窗口上
        /// </summary>
        private void Object2form()
        {
            // 合同申请状态
            lueContractApplyStatusEnum.DataSource = null;
            lueContractApplyStatusEnum.DataSource = ContractApply.ApplyStatus;
            lueContractApplyStatusEnum.DisplayMember = "Name";
            lueContractApplyStatusEnum.ValueMember = "ValueInt";

            // 合同申请
            lueContractApply.Properties.DataSource = null;
            lueContractApply.Properties.DataSource = ContractApply.Query("status = " + ((long)ContractApplyStatusEnum.提交申请).ToString() + " or status = " + ((long)ContractApplyStatusEnum.已开票).ToString());
            lueContractApply.Properties.DisplayMember = "ContractName";
            lueContractApply.Properties.ValueMember = "ID";

            // 合同区先不显示，有需要显示的，下面自己把它显示出来
            xtraTabPage4.PageVisible = false;

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

            // 明细数据中的资金来源
            List<Funds> fundslist = Funds.Query();
            luefunds.DataSource = fundslist;
            luefunds.DisplayMember = "Name";
            luefunds.ValueMember = "ID";

            // 初始化明细
            gridControl1.DataSource = m_account.DetailList;

            // 初始化附件列表
            lstFiles.Items.Clear();
            foreach (Attach a in m_account.AttachList)
                lstFiles.Items.Add(a.ID.ToString() + "." + a.FileName, 2);

            // 显示数据
            if (m_account.ID > 0)
            {
                dtSigned.DateTime = m_account.SignedDate;       // 日期
                txtCode.Text = m_account.Code;                  // 代码
                txtMoney.Text = m_account.Money.ToString();     // 金额
                lueProjects.EditValue = m_account.ProjectID;    // 项目
                lueMaker.EditValue = m_account.MakerID;         // 制作人
                lueReviewer.EditValue = m_account.CheckerID;   // 审核人
                lueCashier.EditValue = m_account.PayerID;     // 出纳
                txtMemo.Text = m_account.Memo;                  // 备注
                calcAttachCount.EditValue = m_account.Attachment;    // 附件张数
                // 正式发票
                if (m_account.Invoice == (long)Account.AccountInvoiceEnum.正式发票)
                    chkRelease.Checked = true;
                else
                    chkRelease.Checked = false;


                // 停止信号同步
                lueOutCompany.Properties.LockEvents();
                lueInCompany.Properties.LockEvents();
                lueInAccount.Properties.LockEvents();
                lueOutAccount.Properties.LockEvents();

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

            }
            else
            {
                // 新增时的数据设置
                dtSigned.EditValue = DateTime.Now;
                txtCode.Text = "";

                lueContractApply.EditValue = null;
                lueInCompany.EditValue = null;
                lueInAccount.EditValue = null;
                txtOutBank.Text = "";

                lueOutCompany.EditValue = null;
                lueOutAccount.EditValue = null;
                txtInBank.Text = "";

                lueProjects.EditValue = null;
                chkRelease.Checked = true;      // 默认为正式发票

                txtMemo.Text = "";
            }

            // 显示合同或者贷款信息
            if (m_account.ContractApplyID > 0)
            {
                lueContractApply.EditValue = m_account.ContractApplyID;         // 合同申请号
                calcPayMoney.EditValue = m_account.ContractApply.Money;         // 合同申请金额 
                ShowContractInfo(ContractApply.CreateByID(m_account.ContractApplyID).Contract);
            }

            // 显示合同验收带来的信息   
            ShowAcceptInfo();

            // 显示审核标志
            ShowCheckPayPic();

            // 设置各制表人员
            SetAllOperator();
        }

        // 设置各制作人员
        public void SetAllOperator()
        {
            if (m_status == winStatusEnum.新增)
                lueMaker.EditValue = GlobalSet.Current_User.ID;

            if (m_status == winStatusEnum.审核)
                lueReviewer.EditValue = GlobalSet.Current_User.ID;

            if (m_status == winStatusEnum.支付)
                lueCashier.EditValue = GlobalSet.Current_User.ID;
        }

        /// <summary>
        /// 显示从合同验收里带来的信息
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

        /// <summary>
        /// 根据传过来的合同，显示出相关合同信息
        /// </summary>
        /// <param name="con">需要显示的合同</param>
        private void ShowContractInfo(Contract con)
        {
            // 如果合同没有，则直接返回
            if (con == null)
            {
                xtraTabPage4.PageVisible = false;
                return;
            }

            // 显示合同信息
            xtraTabPage4.PageVisible = true;
            txtContractCode.Text = con.Code;            // 合同代码 
            txtContractName.Text = con.Name;            // 合同名称
            txtContractMoney.Text = con.Money.ToString();           // 合同金额
            txtContractAlreadyPay.Text = con.Pay.ToString();        // 已付金额
            txtContractUnpay.Text = (con.Money - con.Pay).ToString();    // 未付金额

            lueInCompany.EditValue = con.InCompanyID;       // 收入单位
            lueOutCompany.EditValue = con.OutCompanyID;     // 支出单位
            lueInCompany.Enabled = false;                   // 二个单位不可以编辑
            lueOutCompany.Enabled = false;
        }

        // 显示审核的图片
        private void ShowCheckPayPic()
        {
            switch (m_account.Status)
            {
                case (long)Account.AccountStatusEnum.未审核:
                    picChecked.Visible = false;
                    picPayed.Visible = false;
                    break;
                case (long)Account.AccountStatusEnum.审核通过:
                    picChecked.Visible = true;
                    picPayed.Visible = false;
                    break;
                case (long)Account.AccountStatusEnum.已支付:
                    picChecked.Visible = true;
                    picPayed.Visible = true;
                    break;
            }
        }

        // 关闭窗口
        private void MyFormClose()
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
                    case "ContractApplyID":
                        dxErrorProvider1.SetError(lueContractApply, kv.Value);
                        break;
                    case "Money":
                        dxErrorProvider1.SetError(txtMoney, kv.Value);
                        break;
                }
            }
            if (m_account.Error_Info.Count > 0)
                MessageBox.Show(m_account.ErrorString, "出错了！",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return m_account.Error_Info.Count == 0;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        public DevAccount(winStatusEnum status, Account account = null, long applyid = 0, 
                          long BalanceID = 0, long acceptid = 0)
        {
            InitializeComponent();

            SetFormStatus(status);
            if (account != null)
                m_account = account;
            else
                m_account = new Account();


            // 保存传过来的对应的贷款或合同ID或者合同验收号
            if (applyid > 0)     
                m_account.ContractApplyID = applyid;

            if (BalanceID > 0)
                m_account.BalanceID = BalanceID;

            if (acceptid > 0)
                m_account.ContractAcceptID = acceptid;

        }


        /// <summary>
        /// 载入时，显示对应的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevAccount_Load(object sender, EventArgs e)
        {

            Object2form();             // 初始化界面
            SetControlAccess();        // 设置访问权限
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
            if (!m_account.CanEdit())
            {
                MessageBox.Show("该单据已经审核，无法再修改!");
                return;
            }

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
            if (!m_account.CanDelete())
            {
                MessageBox.Show("该单据已经审核，无法删除！");
                return;
            }

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
                calcAttachCount.EditValue = lstFiles.ItemCount;
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
            MyFormClose();
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
                calcAttachCount.EditValue = lstFiles.ItemCount;
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
            m_account.Checked();
            ShowCheckPayPic();
            tbCheck.Enabled = false;
            m_status = winStatusEnum.纯查看;           // 保证退出时不会提示
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
            txtC2Money.Text = txtCMoney.Text;
            calc2Money.EditValue = txtMoney.Text;
        }

        private void tbExit2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyFormClose();
        }


        // 支付通过
        private void tbPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.Payed();
            tbPay.Enabled = false;
            ShowCheckPayPic();                  // 显示支付信息
            m_status = winStatusEnum.纯查看;           // 保证退出时不会提示
            //ShowCheckPic();
        }

        private void lueContractApply_EditValueChanged(object sender, EventArgs e)
        {
            if (lueContractApply.EditValue == null)
            {
                lueInCompany.Enabled = true;
                lueOutCompany.Enabled = true;
                return;
            }

            long id = long.Parse(lueContractApply.EditValue.ToString());
            ContractApply cy = ContractApply.CreateByID(id);

            lueOutCompany.EditValue = cy.Contract.OutCompanyID;
            lueOutCompany.Enabled = false;
            lueInCompany.EditValue = cy.Contract.InCompanyID;
            lueInCompany.Enabled = false;
            calcPayMoney.EditValue = cy.Money;
            calc2PayMoney.EditValue = cy.Money;
            calc2PayMoney.Enabled = false;
            calcPayMoney.Enabled = false;
        }

        private void tbExit3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyFormClose();
        }

        private void tbExit4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyFormClose();
        }

        private void tb2Invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!chkRelease.Checked)
            {
                m_account.ConverInvoice();
                //SetFormStatus(winStatusEnum.纯查看);      //审核通过后，只能看。
                ShowCheckPayPic();
                tb2Invoice.Enabled = false;
                chkRelease.Checked = true;
                m_status = winStatusEnum.纯查看;           // 保证退出时不会提示
            }
        }

        private void tbUnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.UnChecked();
            ShowCheckPayPic();
            tbUnCheck.Enabled = false;
            m_status = winStatusEnum.纯查看;           // 保证退出时不会提示
        }

        private void tbUnPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.UnPayed();
            ShowCheckPayPic();
            tbUnPay.Enabled = false;
            m_status = winStatusEnum.纯查看;           // 保证退出时不会提示
        }
    }
}