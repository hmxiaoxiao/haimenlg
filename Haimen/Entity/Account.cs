﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using Haimen.Entity;
using Haimen.Helper;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    /// <summary>
    /// 授权资金对象实体类
    /// </summary>
    [Table("t_account")]
    public class Account : ComplexEntity<Account, AccountDetail>
    {
        /// <summary>
        /// 凭证号
        /// </summary>
        [Field("code")]
        public string Code { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }

        /// <summary>
        /// 支出单位帐号ID
        /// </summary>
        [Field("out_companydetail_id")]
        public long Out_CompanyDetail_ID { get; set; }
        private CompanyDetail m_outCompnay = null;
        public CompanyDetail OutCompanyDetail
        {
            get
            {
                if (Out_CompanyDetail_ID > 0)
                {
                    if (m_outCompnay == null || m_outCompnay.ID != Out_CompanyDetail_ID)
                        m_outCompnay = CompanyDetail.CreateByID(Out_CompanyDetail_ID);
                }
                return m_outCompnay;
            }
        }

        /// <summary>
        /// 收入单位帐号ID
        /// </summary>
        [Field("in_companydetail_id")]
        public long In_CompanyDetail_ID { get; set; }
        private CompanyDetail m_inComanpy = null;
        public CompanyDetail InCompanyDetail
        {
            get
            {
                if (In_CompanyDetail_ID > 0)
                {
                    if (m_inComanpy == null || m_inComanpy.ID != Out_CompanyDetail_ID)
                        m_inComanpy = CompanyDetail.CreateByID(In_CompanyDetail_ID);
                }
                return m_inComanpy;
            }
        }


        /// <summary>
        /// 相关合同验收单ID
        /// </summary>
        [Field("contract_accept_id")]
        public long ContractAcceptID { get; set; }
        private ContractAccept m_accept;
        public ContractAccept ContractAccept
        {
            get
            {
                if (m_accept == null && ContractAcceptID > 0)
                    m_accept = ContractAccept.CreateByID(ContractAcceptID);
                return m_accept;
            }
        }

        /// <summary>
        /// 合同ID
        /// </summary>
        [Field("contract_apply_id")]
        public long ContractApplyID { get; set; }
        private ContractApply m_contract_apply = null;
        public ContractApply ContractApply
        {
            get
            {
                if (ContractApplyID > 0)
                {
                    if (m_contract_apply == null || m_contract_apply.ID != ContractApplyID)
                        m_contract_apply = ContractApply.CreateByID(ContractApplyID);
                }
                return m_contract_apply;
            }
        }

        /// <summary>
        /// 贷款ID
        /// </summary>
        [Field("balance_id")]
        public long BalanceID { get; set; }

        /// <summary>
        /// 制作 
        /// </summary>
        [Field("maker_id")]
        public long MakerID { get; set; }
        private User m_maker = null;
        public User Maker
        {
            get
            {
                if (MakerID > 0)
                {
                    if (m_maker == null || m_maker.ID != MakerID)
                        m_maker = User.CreateByID(MakerID);
                }
                return m_maker;
            }
        }

        /// <summary>
        /// 审批
        /// </summary>
        [Field("checker_id")]
        public long CheckerID { get; set; }
        private User m_checker = null;
        public User Checker
        {
            get
            {
                if (CheckerID > 0)
                {
                    if (m_checker == null || m_checker.ID != CheckerID)
                        m_checker = User.CreateByID(CheckerID);
                }
                return m_checker;
            }
        }

        /// <summary>
        /// 审核日期
        /// </summary>
        [Field("check_date")]
        public DateTime CheckDate { get; set; }


        /// <summary>
        /// 出纳
        /// </summary>
        [Field("payer_id")]
        public long PayerID { get; set; }
        private User m_payer = null;
        public User Payer
        {
            get
            {
                if (PayerID > 0)
                {
                    if (m_payer == null || m_payer.ID != PayerID)
                        m_payer = User.CreateByID(PayerID);
                }
                return m_payer;
            }
        }

        /// <summary>
        /// 支付日期
        /// </summary>
        [Field("pay_date")]
        public DateTime PayDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Field("status")]
        public long Status { get; set; }

        /// <summary>
        /// 附件张数
        /// </summary>
        [Field("attachment")]
        public long Attachment { get; set; }

        // 支出签证
        [Field("direct_input")]
        public string DirectInput { get; set; }

        // 支出凭证
        [Field("direct_output")]
        public string DirectOutput { get; set; }

        // 签订日期
        [Field("signed_date")]
        public DateTime SignedDate { get; set; }

        // 备注
        [Field("memo")]
        public string Memo { get; set; }

        // 是否正式发票 0为是，1为不是，跟
        // AccountInvoiceEnum的一致
        [Field("invoice")]
        public long Invoice { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [Field("project_id")]
        public long ProjectID { get; set; }
        private Project m_project;
        public Project Project
        {
            get
            {
                if (m_project == null && ProjectID > 0)
                    m_project = Project.CreateByID(ProjectID);
                return m_project;
            }
        }


        private static void SetNoUsedDetail2Deleted()
        {
            DBConnection.RunNoQuerySql(@"
Update t_account set deleted = 1 
where id in (select id from t_account where in_companydetail_id not in(select id from m_company_detail) and deleted = 0)
");
        }

        public enum ShowStatus : long
        {
            R100 = 1,       // 只显示最近一百条 
            R500,          // 只显示最近五百条
            All             // 显示全部
        }

        /// <summary>
        /// 为了效率，重写在列表显示窗口里的列表取得方法
        /// 直接用SQL语句写
        /// 根据传入的参数，显示本日，本月以及全部的数据
        /// </summary>
        /// <returns></returns>
        public static DataSet GetGUIList(ShowStatus status = ShowStatus.R500)
        {
            // 将支出单位明细已经不存在的数据设置为删除
            SetNoUsedDetail2Deleted();

            string mastersql = "";

            switch (status)
            {
                case ShowStatus.R100:
                    mastersql = "Select top 100 ";
                    break;
                case ShowStatus.R500:
                    mastersql = "Select top 500 ";
                    break;
                case ShowStatus.All:
                    mastersql = "Select  ";
                    break;
            }

            mastersql += @"
                    a.id as id,a.status  as status,a.signed_date as signeddate,a.money as money,
                    a.project_id as project_id,a.invoice as invoice,a.code as code,a.memo as memo,
                    out_c.name as outcompanyname,out_d.name as outbankname,out_b.account as outaccount,
                    in_c.name as incompanyname,in_d.name as inbankname,in_b.account as inaccount
                from t_account a, m_company_detail out_b, m_company out_c, m_bank out_d, m_company_detail in_b, m_company in_c, m_bank in_d
                where a.out_companydetail_id = out_b.id and out_b.parent_id = out_c.id and out_b.bank_id = out_d.id and
                      a.in_companydetail_id = in_b.id and in_b.parent_id = in_c.id and in_b.bank_id = in_d.id and
                      a.deleted = 0 ";

            mastersql += "    order by id desc;";

            string detailsql = @"
                select a.id, a.parent_id, b.name, a.money, a.usage
                from t_account_detail a, m_funds b
                where a.deleted = 0 and a.funds_id = b.id ";
            switch (status)
            {
                case ShowStatus.R100:
                    detailsql += " and a.parent_id in (select top 100 id from t_account where deleted = 0 order by id desc)";
                    break;
                case ShowStatus.R500:
                    detailsql += " and a.parent_id in (select top 500 id from t_account where deleted = 0 order by id desc)";
                    break;
                case ShowStatus.All:
                    break;
            }

            try
            {
                SqlDataAdapter damaster = new SqlDataAdapter(mastersql, DBConnection.Connection);
                SqlDataAdapter dadetail = new SqlDataAdapter(detailsql, DBConnection.Connection);
                DataSet ds = new DataSet();
                damaster.Fill(ds, "master");
                dadetail.Fill(ds, "detail");

                DataColumn key = ds.Tables["master"].Columns["id"];
                DataColumn foreignKey = ds.Tables["detail"].Columns["parent_id"];
                ds.Relations.Add("明细", key, foreignKey, false);
                return ds;
            }
            catch (Exception e)
            {
                string msg = string.Format("查询授权资金列表出错，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }



        // 发票状态的枚举
        private static List<Dict> m_invoice_enum = null;
        public static List<Dict> AccountInvoicList
        {
            get
            {
                if (m_invoice_enum == null)
                {
                    m_invoice_enum = new List<Dict>();
                    foreach (string s in Enum.GetNames(typeof(AccountInvoiceEnum)))
                    {
                        m_invoice_enum.Add(new Dict(s, long.Parse(Enum.Format(typeof(AccountInvoiceEnum), Enum.Parse(typeof(AccountInvoiceEnum), s), "d")))); ;
                    }
                }
                return m_invoice_enum;
            }
        }


        /// <summary>
        /// 资金单据的状态枚举
        /// </summary>
        private static List<Dict> m_account_status_list = null;
        public static List<Dict> AccountStatusList
        {
            get
            {
                if (m_account_status_list == null)
                {
                    m_account_status_list = new List<Dict>();
                    foreach (long sn in Enum.GetValues(typeof(AccountStatusEnum)))
                        m_account_status_list.Add(new Dict(Enum.GetName(typeof(AccountStatusEnum), sn), sn));
                }
                return m_account_status_list;
            }
        }


        /// <summary>
        /// 审核通过
        /// </summary>
        public void Checked()
        {
            // 改标志为已审核
            this.CheckerID = GlobalSet.Current_User.ID;
            this.Status = (long)AccountStatusEnum.已复核;
            this.CheckDate = DateTime.Now;
            this.PayDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            this.Save();
        }

        /// <summary>
        /// 撤审
        /// </summary>
        public void UnChecked()
        {
            this.CheckerID = 0;
            this.Status = (long)AccountStatusEnum.已录入;
            this.Save();
        }

        /// <summary>
        /// 支付
        /// </summary>
        public bool Payed()
        {
            this.Status = (long)AccountStatusEnum.已审核;
            this.PayerID = GlobalSet.Current_User.ID;
            this.PayDate = DateTime.Now;

            // 更新二个单位的数据金额
            CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
            CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
            inCD.Balance += Money;
            outCD.Balance -= Money;


            try
            {
                Account.ExceptionString = "";
                DBConnection.BeginTrans();

                bool success =  inCD.Update(true) &&        // 保存收入单位帐号余额
                                outCD.Update(true) &&       // 保存支出单位的帐号余额
                                this.Update(true);        // 保存
                // 更新合同申请中对应的合同的状态
                if (ContractApplyID > 0)
                {
                    ContractApply c = ContractApply.CreateByID(ContractApplyID);
                    c.Status = (long)ContractApplyStatusEnum.已支付;
                    success = success && c.Save(true);
                }

                if (success)
                    DBConnection.CommitTrans();
                else
                    DBConnection.RollbackTrans();

                return success;  
            }
            catch(Exception e)
            {
                if (DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("授权资金支付时出错，错误原因如下：{0}{1}", Environment.NewLine, e);
                Account.ExceptionString = msg;
                return true;
            }
        }

        /// <summary>
        /// 撤消支付
        /// </summary>
        public bool UnPayed()
        {

            this.Status = (long)AccountStatusEnum.已复核;

            // 更新二个单位的数据金额
            CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
            CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
            inCD.Balance -= Money;
            outCD.Balance += Money;

            try
            {
                Account.ExceptionString = "";
                DBConnection.BeginTrans();
                
                bool success = inCD.Update(true) &&         // 保存收入单位帐号余额
                               outCD.Update(true)  &&      // 保存支出单位的帐号余额
                                this.Update(true);        // 保存
                // 更新合同的已付金额
                if (ContractApplyID > 0)
                {
                    ContractApply c = ContractApply.CreateByID(ContractApplyID);
                    c.Status = (long)ContractApplyStatusEnum.已开票;
                    c.Update(true);
                }

                if (success)
                    DBConnection.CommitTrans();
                else
                    DBConnection.RollbackTrans();

                return success;
            }
            catch (Exception e)
            {
                if (DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("授权资金撤消支付时出错，错误原因如下：{0}{1}", Environment.NewLine, e);
                Account.ExceptionString = msg;
                return false;
            }
        }

        /// <summary>
        /// 校对对象
        /// </summary>
        /// <returns></returns>
        public override bool InsertUpdateVerify()
        {
            Error_Info.Clear();
            if (this.In_CompanyDetail_ID <= 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("In_CompanyDetail_ID", "请选择收入单位帐号！"));
            }

            if (this.Out_CompanyDetail_ID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("Out_CompanyDetail_ID", "请选择支出单位的帐号!"));

            if (ContractApplyID > 0)
            {
                ContractApply cy = ContractApply.CreateByID(ContractApplyID);
                if (cy.Status == (long)ContractApplyStatusEnum.已支付)
                    Error_Info.Add(new KeyValuePair<string, string>("ContractApplyID", "您选择的合同申请号已经支付，无需再生成凭证！"));
            }

            if (Money == 0)
                Error_Info.Add(new KeyValuePair<string,string>("Money", "必须输入发生的金额（金额不能为零）！"));

            return Error_Info.Count == 0;
        }


        /// <summary>
        /// 新增时，当前用户作为制作人
        /// </summary>
        /// <returns></returns>
        public override bool Insert(bool hasTrans = false)
        {
            try
            {
                if (!hasTrans)
                    DBConnection.BeginTrans();
                MakerID = GlobalSet.Current_User.ID;
                bool success = true;


                // 重新生成代码
                // 现金与非现金生成的代码不一致（票据号）
                if (OutCompanyDetail.Account.Trim() == "现金")
                    this.Code = this.OutCompanyDetail.Parent.NextDoc(true, true);
                else
                    this.Code = this.OutCompanyDetail.Parent.NextDoc(true);

                // 如果是合同申请生成，则返写一个标志进去
                if (ContractApplyID > 0)
                {
                    ContractApply cy = ContractApply.CreateByID(ContractApplyID);
                    cy.Status = (long)ContractApplyStatusEnum.已开票;
                    if (!cy.Save(true))
                        success = false;
                }

                // 如果是从合同验收生成的，要写到合同验收一个标志
                if (ContractAcceptID > 0)
                {
                    ContractAccept c = ContractAccept.CreateByID(ContractAcceptID);
                    c.Status = (long)ContractAccept.ContractAcceptStatusEnum.已开票;
                    if (!c.Save(true))
                        success = false;
                }

                this.CheckDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                this.PayDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                if (!base.Insert(true))
                    success = false;

                if (!hasTrans)
                {
                    if (success)
                        DBConnection.CommitTrans();
                    else
                        DBConnection.RollbackTrans();
                }

                return success;
            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("授权资金新增时出错，错误原因如下：{0}{1}", Environment.NewLine, e);
                Account.ExceptionString = msg;
                return false;
            }
        }

        public override bool Update(bool hasTrans = false)
        {
            if (!InsertUpdateVerify())
                return false;

            // 如果更新了合同申请，则修改申请的标志
            try
            {
                bool success = true;
                if(!hasTrans)
                    DBConnection.BeginTrans();

                if (ContractApplyID > 0)
                {
                    // 先取得老的数据
                    ContractApply old_c = ContractApply.CreateByID(Account.CreateByID(ID).ContractApplyID);
                    ContractApply new_c = ContractApply.CreateByID(ContractApplyID);
                    if (old_c.ID != ContractApplyID)  // 如果修改了合同申请
                    {
                        old_c.Status = (long)ContractApplyStatusEnum.提交申请;
                        new_c.Status = (long)ContractApplyStatusEnum.已开票;

                        success = old_c.Update(true) && new_c.Update(true);
                    }
                }

                success = success && base.Update(true);
                if (!hasTrans)
                {
                    if (success)
                        DBConnection.CommitTrans();
                    else
                        DBConnection.RollbackTrans();
                }
                return success;
            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("授权资金更新时出错，错误原因如下：{0}{1}", Environment.NewLine, e);
                Account.ExceptionString = msg;
                return false;
            }
        }

        // 资金的删除不是真正的删除
        // 只是打上标记，默认不会显示
        public override bool Destory(bool hasTrans = false)
        {
            try
            {
                if (!hasTrans)
                    DBConnection.BeginTrans();
                bool success = true;

                this.Deleted = 1;       // 打上删除标记
                foreach (AccountDetail ad in DetailList)
                {
                    ad.Deleted = 1;
                    if (!ad.Update(true))
                        success = false;
                }

                success = success && this.Update(true);

                if (!hasTrans)
                {
                    if (success)
                        DBConnection.CommitTrans();
                    else
                        DBConnection.RollbackTrans();
                }
                return success;
            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("授权资金删除时出错，错误原因如下：{0}{1}", Environment.NewLine, e);
                Account.ExceptionString = msg;
                return false;
            }
        }


        /// <summary>
        /// 非正式发票转换为正式发票
        /// </summary>
        public bool ConverInvoice()
        {
            if (Invoice != (long)AccountInvoiceEnum.正式发票)
            {
                Invoice = (long)AccountInvoiceEnum.正式发票;
                return this.Save();
            }
            return true;
        }

        /// <summary>
        /// 判断当前对象是否可以编辑
        /// </summary>
        /// <returns></returns>
        public bool CanEdit()
        {
            if (this.Status > (long)AccountStatusEnum.已录入)
                return false;
            else
            {
                // 如果已经跨月了就不可以修改
                if (this.SignedDate.Year == DateTime.Now.Year && SignedDate.Month == DateTime.Now.Month)
                    return true;
                else
                    return true;
            }
        }

        /// <summary>
        /// 判断当前的对象是否可以打印
        /// </summary>
        /// <returns></returns>
        public bool CanPrint()
        {
            if (this.Status > (long)AccountStatusEnum.已复核)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 判断当前的对象是否可以删除
        /// </summary>
        /// <returns></returns>
        public bool CanDelete()
        {
            if (this.Status != (long)AccountStatusEnum.已录入)
                return false;
            else
                return true;
        }
        /// <summary>
        /// 判断当前对象是否可以审核
        /// </summary>
        /// <returns></returns>
        public bool CanCheck()
        {
            if (this.Status == (long)AccountStatusEnum.已录入)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 判断当前对象是否可以支付
        /// </summary>
        /// <returns></returns>
        public bool CanPay()
        {
            if (this.Status == (long)AccountStatusEnum.已复核)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 当前对象是否可以撤审
        /// </summary>
        /// <returns></returns>
        public bool CanUnCheck()
        {
            if (this.Status == (long)AccountStatusEnum.已复核)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 当前对象是否可以撤消支付
        /// </summary>
        /// <returns></returns>
        public bool CanUnPay()
        {
            if (this.Status == (long)AccountStatusEnum.已审核)
                return true;
            else
                return false;
        }

        /// <summary>
        ///  当前对象是否可以转为正式发票
        /// </summary>
        /// <returns></returns>
        public bool CanConvertInvoice()
        {
            if (this.Invoice == (long)AccountInvoiceEnum.非正式发票)
                return true;
            else
                return false;
        }

        public enum AccountInvoiceEnum : long
        {
            正式发票 = 1,
            非正式发票,
        }

        /// <summary>
        /// 资金的状态
        /// </summary>
        public enum AccountStatusEnum : long
        {
            已录入 = 0,
            已复核,
            已审核,
        }

        public override string ToString()
        {
            return string.Format("id:{0}, code:{1}, money:{2}, outcompanydetailid:{3}, incompanydetailid:{4}," +
                                 "makerid{5}, checkerid:{6}, payerid:{7}, paydate:{8}, status:{9}, signeddate:{10}" +
                                 "memo:{11}, projectid:{12}",
                                 ID, Code, Money, Out_CompanyDetail_ID, In_CompanyDetail_ID,
                                 MakerID, CheckerID, PayerID, PayDate, Status, SignedDate, Money, ProjectID);
        }
    }
}
