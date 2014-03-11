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
using DevExpress.XtraReports.UI;
using Haimen.Report;

namespace Haimen.GUI
{
    public partial class DevAccount : DevExpress.XtraEditors.XtraForm
    {

        private Account _account;                  // 当前正在编辑的资金对象
        private winStatusEnum _status;             // 当前窗口的状态，象新增之类的

        /// <summary>
        /// 计算总金额
        /// </summary>
        private void CalcMoney()
        {
            decimal money = 0;
            foreach (AccountDetail ad in _account.DetailList)
            {
                money += ad.Money;
            }
            txtMoney.Value = money;
            txtCMoney.Text = Haimen.Helper.Helper.ConvertToChinese((double)money);
        }


        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            // 普通新增，编辑，删除
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.授权资金, (long)ActionEnum.新增))
            {
                tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.授权资金, (long)ActionEnum.编辑))
            {
                tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.授权资金, (long)ActionEnum.删除))
            {
                tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            // 审核
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.授权资金, (long)ActionEnum.审核))
            {
                tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            // 支付
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.授权资金, (long)ActionEnum.支付))
            {
                tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            // 打印
            if (!Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.授权资金, (long)ActionEnum.打印))
            {
                tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            // 转正式发票
            if (!Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.授权资金, (long)ActionEnum.转正式发票))
            {
                tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

        }

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatusEnum status)
        {
            _status = status;
            switch (status)
            {
                case winStatusEnum.新增:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.编辑:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.查看:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.复核:
                    tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbCheck.Enabled = true;
                    tbUnCheck.Enabled = false;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.撤消:
                    tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbCheck.Enabled = false;
                    tbUnCheck.Enabled = true;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.纯查看:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                case winStatusEnum.审核:
                    tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Enabled = true;
                    tbUnPay.Enabled = false;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Enabled = false; //m_account.CanPrint();
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.撤审:
                    tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Enabled = false;
                    tbUnPay.Enabled = true;
                    tb2Invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPrint.Enabled = _account.CanPrint();
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.转正式发票:
                    tbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnCheck.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tbUnPay.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    tb2Invoice.Enabled = true;
                    tbPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    SetEditorStatus(false);
                    break;
            }
        }

        /// <summary>
        /// 设置当前输入控件是否可用。
        /// </summary>
        /// <param name="enabled"></param>
        private void SetEditorStatus(bool enabled)
        {
            lueContractApply.Enabled = enabled;      // 合同申请
            calcPayMoney.Enabled = enabled;          // 申请金额

            dtSigned.Enabled = enabled;              // 日期
            //txtCode.Enabled = status;               // 代码
            lueInCompany.Enabled = enabled;          // 收入单位
            lueOutCompany.Enabled = enabled;         // 支出单位
            lueInAccount.Enabled = enabled;          // 收入帐号
            lueOutAccount.Enabled = enabled;         // 支出帐号
            calcAttachCount.Enabled = enabled;       // 附件张数
            txtMemo.Enabled = enabled;               // 备注

            lueProjects.Enabled = enabled;           // 所属项目
            chkRelease.Enabled = enabled;            // 正式发票

            tsbNew.Enabled = enabled;                            // 资金明细新增
            tsbDelete.Enabled = enabled;                         // 资金明细删除
            gridView1.OptionsBehavior.ReadOnly = !enabled;       // 资金列表

            tsbAttachDelete.Enabled = enabled;       // 附件删除
            tsbAttachNew.Enabled = enabled;          // 附件新增
        }

        /// <summary>
        /// 将窗口的信息保存到编辑的对象里去。
        /// </summary>
        private void Form2object()
        {
            _account.SignedDate = dtSigned.DateTime;       // 日期
            _account.Code = txtCode.Text;                  // 代码

            // 支出帐号
            if (this.lueOutAccount.EditValue != null)
                _account.Out_CompanyDetail_ID = long.Parse(lueOutAccount.EditValue.ToString());

            // 收入帐号
            if (lueInAccount.EditValue != null)
                _account.In_CompanyDetail_ID = long.Parse(lueInAccount.EditValue.ToString());

            // 备注
            _account.Memo = txtMemo.Text;

            // 正式发票
            if (chkRelease.Checked)
                _account.Invoice = (long)Account.AccountInvoiceEnum.正式发票;
            else
                _account.Invoice = (long)Account.AccountInvoiceEnum.非正式发票;

            // 总金额
            _account.Money = txtMoney.Value;

            // 合同申请号，如果存在的话
            if (!(lueContractApply.EditValue == null || string.IsNullOrEmpty(lueContractApply.EditValue.ToString())))
                _account.ContractApplyID = long.Parse(lueContractApply.EditValue.ToString());

            // 附件张数
            _account.Attachment = (long)calcAttachCount.Value;

            // 项目
            if (!(lueProjects.EditValue == null || string.IsNullOrEmpty(lueProjects.EditValue.ToString())))
                _account.ProjectID = long.Parse(lueProjects.EditValue.ToString());
        }

        /// <summary>
        /// 将对象印射到窗口上
        /// </summary>
        private void Object2Form()
        {
            // 合同申请状态
            lueContractApplyStatusEnum.DataSource = null;
            lueContractApplyStatusEnum.DataSource = ContractApply.ApplyStatus;
            lueContractApplyStatusEnum.DisplayMember = "Key";
            lueContractApplyStatusEnum.ValueMember = "Value";

            // 合同申请
            lueContractApply.Properties.DataSource = null;
            lueContractApply.Properties.DataSource = ContractApply.Query("status = " + ((long)ContractApplyStatusEnum.提交申请).ToString() + " or status = " + ((long)ContractApplyStatusEnum.已开票).ToString());
            lueContractApply.Properties.DisplayMember = "ContractName";
            lueContractApply.Properties.ValueMember = "ID";

            //先设置单位的数据来源
            Company.OrderBy = " order by doc desc, id ";
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
            Funds.OrderBy = "Order by parent_id, id";
            luefunds.DataSource = Funds.Query();

            // 初始化明细
            gridControl1.DataSource = _account.DetailList;

            // 初始化附件列表
            lstFiles.Items.Clear();
            foreach (Attach a in _account.AttachList)
                lstFiles.Items.Add(a.ID.ToString() + "." + a.FileName, 2);

            // 显示数据
            if (_account.ID > 0)
            {
                dtSigned.DateTime = _account.SignedDate;       // 日期
                txtCode.Text = _account.Code;                  // 代码
                txtMoney.Value = _account.Money;     // 金额
                lueProjects.EditValue = _account.ProjectID;    // 项目
                lueMaker.EditValue = _account.MakerID;         // 制作人
                lueReviewer.EditValue = _account.CheckerID;   // 审核人
                lueCashier.EditValue = _account.PayerID;     // 出纳
                txtMemo.Text = _account.Memo;                  // 备注
                calcAttachCount.Value = _account.Attachment;    // 附件张数
                // 正式发票
                if (_account.Invoice == (long)Account.AccountInvoiceEnum.正式发票)
                    chkRelease.Checked = true;
                else
                    chkRelease.Checked = false;


                // 停止信号同步
                lueOutCompany.Properties.LockEvents();
                lueInCompany.Properties.LockEvents();
                lueInAccount.Properties.LockEvents();
                lueOutAccount.Properties.LockEvents();

                lueOutCompany.EditValue = _account.OutCompanyDetail.ParentID;
                List<CompanyDetail> out_list = CompanyDetail.Query("parent_id = " + _account.OutCompanyDetail.ParentID);
                lueOutAccount.Properties.DataSource = null;
                lueOutAccount.Properties.DataSource = out_list;
                lueOutAccount.Properties.DisplayMember = "Account";
                lueOutAccount.Properties.ValueMember = "ID";
                lueOutAccount.EditValue = _account.OutCompanyDetail.ID;
                txtOutBank.Text = _account.OutCompanyDetail.Bank.Name;

                lueInCompany.EditValue = _account.InCompanyDetail.ParentID;
                List<CompanyDetail> in_list = CompanyDetail.Query("parent_id = " + _account.InCompanyDetail.ParentID);
                lueInAccount.Properties.DataSource = null;
                lueInAccount.Properties.DataSource = in_list;
                lueInAccount.Properties.DisplayMember = "Account";
                lueInAccount.Properties.ValueMember = "ID";
                lueInAccount.EditValue = _account.InCompanyDetail.ID;
                txtInBank.Text = _account.InCompanyDetail.Bank.Name;

                lueOutCompany.Properties.UnLockEvents();
                lueInCompany.Properties.UnLockEvents();
                lueInAccount.Properties.UnLockEvents();
                lueOutAccount.Properties.UnLockEvents();

                calcAttachCount.Value = _account.Attachment;
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
                calcAttachCount.Value = 0;
            }

            // 显示合同或者贷款信息
            if (_account.ContractApplyID > 0)
            {
                lueContractApply.EditValue = _account.ContractApplyID;         // 合同申请号
                calcPayMoney.EditValue = _account.ContractApply.Money;         // 合同申请金额 
                ShowContractInfo(ContractApply.CreateByID(_account.ContractApplyID).Contract);
            }

            // 显示合同验收带来的信息   
            //ShowAcceptInfo();

            // 显示审核标志
            ShowCheckPayPic();

            // 设置各制表人员
            SetAllOperator();

            // 更新金额
            CalcMoney();
        }

        // 设置各制作人员
        public void SetAllOperator()
        {
            if (_status == winStatusEnum.新增)
                lueMaker.EditValue = GlobalSet.Current_User.ID;

            if (_status == winStatusEnum.复核)
                lueReviewer.EditValue = GlobalSet.Current_User.ID;

            if (_status == winStatusEnum.审核)
                lueCashier.EditValue = GlobalSet.Current_User.ID;
        }

        /// <summary>
        /// 显示从合同验收里带来的信息
        /// </summary>
        private void ShowAcceptInfo()
        {
            // 只能新增，才显示
            if (_account.ID == 0 && _account.ContractAcceptID > 0)
            {
                ContractAccept ca = ContractAccept.CreateByID(_account.ContractAcceptID);

                Contract c = ca.Contract;

                lueInCompany.EditValue = c.InCompanyID;
                lueOutCompany.EditValue = c.OutCompanyID;
                lueInCompany.Enabled = false;
                lueOutCompany.Enabled = false;

                // 判断新增时，还要给二个单位赋值
                if (_account.ID > 0)
                    txtMemo.Text = _account.Memo;
                else
                {
                    txtMemo.Text = "本单据通过合同验收生成。";
                    lueInCompany.EditValue = c.InCompanyID;
                    lueOutCompany.EditValue = c.OutCompanyID;
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
                return;
            }

            lueInCompany.EditValue = con.InCompanyID;       // 收入单位
            lueOutCompany.EditValue = con.OutCompanyID;     // 支出单位
            lueInCompany.Enabled = false;                   // 二个单位不可以编辑
            lueOutCompany.Enabled = false;
        }

        // 显示审核的图片
        private void ShowCheckPayPic()
        {
            switch (_account.Status)
            {
                case (long)Account.AccountStatusEnum.已录入:
                    picChecked.Visible = false;
                    picPayed.Visible = false;
                    break;
                case (long)Account.AccountStatusEnum.已复核:
                    picChecked.Visible = true;
                    picPayed.Visible = false;
                    break;
                case (long)Account.AccountStatusEnum.已审核:
                    picChecked.Visible = true;
                    picPayed.Visible = true;
                    break;
            }
        }

        // 关闭窗口
        private void MyFormClose()
        {
            if (!(_status == winStatusEnum.查看 || _status == winStatusEnum.纯查看))
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
            Form2object();

            dxErrorProvider1.ClearErrors();
            _account.InsertUpdateVerify();
            foreach (KeyValuePair<string, string> kv in _account.Error_Info)
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
            if (_account.Error_Info.Count > 0)
                MessageBox.Show(_account.ErrorString, "出错了！",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return _account.Error_Info.Count == 0;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        public DevAccount(winStatusEnum status, Account account = null, long applyid = 0, 
                          long BalanceID = 0, long acceptid = 0)
        {
            InitializeComponent();

            if (account != null)
                _account = account;
            else
                _account = new Account();

            // 保存传过来的对应的贷款或合同ID或者合同验收号
            if (applyid > 0)     
                _account.ContractApplyID = applyid;

            if (BalanceID > 0)
                _account.BalanceID = BalanceID;

            if (acceptid > 0)
                _account.ContractAcceptID = acceptid;

            SetFormStatus(status);
        }


        /// <summary>
        /// 载入时，显示对应的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void  DevAccount_Load(object sender, EventArgs e)
        {
            DateTime begin = DateTime.Now;
            Object2Form();             // 初始化界面
            SetControlAccess();        // 设置访问权限
            Console.WriteLine("#############################################");
            Console.WriteLine("载入总共用了" + Haimen.Helper.Helper.DateDiff(begin,DateTime.Now));
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
                _account.Out_CompanyDetail_ID = long.Parse(lueOutCompany.EditValue.ToString());
                List<CompanyDetail> cd = CompanyDetail.Query("parent_id = " + _account.Out_CompanyDetail_ID.ToString());
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
                _account.In_CompanyDetail_ID = long.Parse(lueInCompany.EditValue.ToString());
                List<CompanyDetail> cd = CompanyDetail.Query("parent_id = " + _account.In_CompanyDetail_ID.ToString());
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
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            _account.DetailList.Add(new AccountDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = _account.DetailList;
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

            if (_account.Save())
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
            _account = new Account();
            Object2Form();
            SetFormStatus(winStatusEnum.新增);
        }


        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!_account.CanEdit())
            {
                MessageBox.Show("该单据已经审核，无法再修改!");
                return;
            }

            if (_account.ID <= 0)
                return;

            Object2Form();
            SetFormStatus(winStatusEnum.编辑);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_account == null)
                return;

            if (!_account.CanDelete())
            {
                MessageBox.Show("该单据已经审核，无法删除！");
                return;
            }

            if (_account.ID > 0)
            {
                _account.Destory();
                _account = null;

                // 这时只能新增，不能再删除和编辑
                tbEdit.Enabled = false;
                tbDelete.Enabled = false;
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

                FTPClient ftp = INICustomer.GetFTPClient();
                ftp.fileUpload(fi, @"\", att.ID.ToString() + fi.Extension);

                _account.AttachList.Add(att);

                // 加入列表
                lstFiles.Items.Add(att.ID.ToString() + "." + fi.Name, 2);
                calcAttachCount.Value = lstFiles.ItemCount;
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

                FTPClient ftp = INICustomer.GetFTPClient();
                ftp.fileDelete(@"\", att.FileName);

                att.Destory();

                lstFiles.Items.Remove(lstFiles.Items[lstFiles.SelectedIndex]);
                calcAttachCount.Value = lstFiles.ItemCount;
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

                FTPClient ftp = INICustomer.GetFTPClient();
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
            _account.Checked();
            ShowCheckPayPic();
            tbCheck.Enabled = false;
            tbUnCheck.Enabled = true;
            _status = winStatusEnum.纯查看;           // 保证退出时不会提示
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
            _account.Out_CompanyDetail_ID = CD_id;
            txtOutBank.Text = _account.OutCompanyDetail.Bank.Name;

            // 生成凭证号
            //if (string.IsNullOrEmpty(txtCode.Text))
            if (lueOutAccount.Text.Trim() == "现金")
                txtCode.Text = _account.OutCompanyDetail.Parent.NextDoc(false, true);
            else
                txtCode.Text = _account.OutCompanyDetail.Parent.NextDoc();
        }

        // 收入帐号处理
        private void lueInAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInAccount.EditValue == null)
                return;

            long id = long.Parse(lueInAccount.EditValue.ToString());
            _account.In_CompanyDetail_ID = id;
            txtInBank.Text = _account.InCompanyDetail.Bank.Name;
        }

        // 更新金额
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "col_money")
            {
                CalcMoney();
            }
        }


        // 支付通过
        private void tbPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _account.Payed();
            tbPay.Enabled = false;
            tbUnPay.Enabled = true;
            tbPrint.Enabled = _account.CanPrint();
            ShowCheckPayPic();                  // 显示支付信息
            _status = winStatusEnum.纯查看;           // 保证退出时不会提示
        }

        // 合同申请变更
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
            calcPayMoney.Enabled = false;
        }

        // 转正式发票
        private void tb2Invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!chkRelease.Checked)
            {
                _account.ConverInvoice();
                //SetFormStatus(winStatusEnum.纯查看);      //审核通过后，只能看。
                ShowCheckPayPic();
                tb2Invoice.Enabled = false;
                chkRelease.Checked = true;
                _status = winStatusEnum.纯查看;           // 保证退出时不会提示
            }
        }

        // 反审核
        private void tbUnCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _account.UnChecked();
            ShowCheckPayPic();
            tbUnCheck.Enabled = false;
            tbCheck.Enabled = true;
            _status = winStatusEnum.纯查看;           // 保证退出时不会提示
        }

        // 取消支付
        private void tbUnPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _account.UnPayed();
            ShowCheckPayPic();
            tbUnPay.Enabled = false;
            tbPay.Enabled = true;
            tbPrint.Enabled = false;
            _status = winStatusEnum.纯查看;           // 保证退出时不会提示
        }

        // 打印单据
        private void tbPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Create a report. 
            rptAccount report = new rptAccount(_account.ID);

            // Show the report's preview. 
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        private void calcDetailMoney_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }
        delegate void EditorSelectAllProc(Control c);
        void EditorSelectAll(Control c)
        {
            ((TextBox)c.Controls[0]).SelectAll();
        }

        private void calcAttachCount_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcAttachCount_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void calcDetailMoney_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        // 当表格失去焦点时，更新界面
        private void gridControl1_Leave(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();
        }
    }
}