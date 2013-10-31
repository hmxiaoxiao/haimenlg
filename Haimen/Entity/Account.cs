﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;
using Haimen.Helper;
using System.Transactions;
using System.Data;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    [Table("t_account")]
    public class Account : TEntityFunction<Account, AccountDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("money")]
        public decimal Money { get; set; }


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

        [Field("balance_id")]
        public long BalanceID { get; set; }

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

        [Field("status")]
        public long Status { get; set; }

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

        /// <summary>
        /// 为了效率，重写在列表显示窗口里的列表取得方法
        /// 直接用SQL语句写
        /// </summary>
        /// <returns></returns>
        public static DataSet GetGUIList()
        {
            string mastersql = @"
                select a.id as id,a.status  as status,a.signed_date as signeddate,a.money as money,
                    a.project_id as project_id,a.invoice as invoice,a.code as code,a.memo as memo,
                    out_c.name as outcompanyname,out_d.name as outbankname,out_b.account as outaccount,
                    in_c.name as incompanyname,in_d.name as inbankname,in_b.account as inaccount
                from t_account a, m_company_detail out_b, m_company out_c, m_bank out_d, m_company_detail in_b, m_company in_c, m_bank in_d
                where a.out_companydetail_id = out_b.id and out_b.parent_id = out_c.id and out_b.bank_id = out_d.id and
                      a.in_companydetail_id = in_b.id and in_b.parent_id = in_c.id and in_b.bank_id = in_d.id and
                      a.deleted = 0
                order by id desc;
            ";
//            string detailsql = @"
//                select a.id, a.parent_id, b.name as 性质, a.money as 金额, a.usage as 用途
//                from t_account_detail a, m_funds b
//                where a.deleted = 0 and a.funds_id = b.id
//            ";
            string detailsql = @"
                select a.id, a.parent_id, b.name, a.money, a.usage
                from t_account_detail a, m_funds b
                where a.deleted = 0 and a.funds_id = b.id
            ";

            SqlDataAdapter damaster = new SqlDataAdapter(mastersql, DBFunction.Connection);
            SqlDataAdapter dadetail = new SqlDataAdapter(detailsql, DBFunction.Connection);
            DataSet ds = new DataSet();
            damaster.Fill(ds, "master");
            dadetail.Fill(ds, "detail");

            DataColumn key = ds.Tables["master"].Columns["id"];
            DataColumn foreignKey = ds.Tables["detail"].Columns["parent_id"];
            ds.Relations.Add("明细", key, foreignKey);

            return ds;
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
            this.Status = (long)AccountStatusEnum.审核通过;
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
            this.Status = (long)AccountStatusEnum.未审核;
            this.Save();
        }

        /// <summary>
        /// 支付
        /// </summary>
        public void Payed()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                this.Status = (long)AccountStatusEnum.已支付;
                this.PayerID = GlobalSet.Current_User.ID;
                this.PayDate = DateTime.Now;

                // 更新二个单位的数据金额
                CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
                CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
                inCD.Balance += Money;
                outCD.Balance -= Money;

                // 更新合同申请中对应的合同的状态
                if (ContractApplyID > 0)
                {
                    ContractApply c = ContractApply.CreateByID(ContractApplyID);
                    c.Status = (long)ContractApplyStatusEnum.已支付;
                    c.Save();
                }

                inCD.Save();        // 保存收入单位帐号余额
                outCD.Save();       // 保存支出单位的帐号余额
                this.Save();        // 保存
            }
        }

        /// <summary>
        /// 撤消支付
        /// </summary>
        public void UnPayed()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                this.Status = (long)AccountStatusEnum.审核通过;

                // 更新二个单位的数据金额
                CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
                CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
                inCD.Balance -= Money;
                outCD.Balance += Money;

                // 更新合同的已付金额
                if (ContractApplyID > 0)
                {
                    ContractApply c = ContractApply.CreateByID(ContractApplyID);
                    c.Status = (long)ContractApplyStatusEnum.已开票;
                    c.Save();
                }


                inCD.Save();        // 保存收入单位帐号余额
                outCD.Save();       // 保存支出单位的帐号余额
                this.Save();        // 保存
            }
        }

        /// <summary>
        /// 校对对象
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
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
        /// 新增时，当前用户作为制作 人
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            MakerID = GlobalSet.Current_User.ID;

            // 重新生成代码
            this.Code = this.OutCompanyDetail.Parent.NextDoc(true);

            // 如果是合同申请生成，则返写一个标志进去
            if (ContractApplyID > 0)
            {
                ContractApply cy = ContractApply.CreateByID(ContractApplyID);
                cy.Status = (long)ContractApplyStatusEnum.已开票;
                cy.Save();
            }

            // 如果是从合同验收生成的，要写到合同验收一个标志
            if (ContractAcceptID > 0)
            {
                ContractAccept c = ContractAccept.CreateByID(ContractAcceptID);
                c.Status = (long)ContractAccept.ContractAcceptStatusEnum.已开票;
                c.Save();
            }

            this.CheckDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
            this.PayDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;

            return base.Insert();
        }

        public override bool Update()
        {
            // 如果更新了合同申请，则修改申请的标志
            if (ContractApplyID > 0)
            {
                // 先取得老的数据
                ContractApply old_c = ContractApply.CreateByID( Account.CreateByID(ID).ContractApplyID);
                ContractApply new_c = ContractApply.CreateByID(ContractApplyID);
                if (old_c.ID != ContractApplyID)  // 如果修改了合同申请
                {
                    old_c.Status = (long)ContractApplyStatusEnum.提交申请;
                    new_c.Status = (long)ContractApplyStatusEnum.已开票;
                }
            }
            return base.Update();
        }

        // 资金的删除不是真正的删除
        // 只是打上标记，默认不会显示
        public override void Destory()
        {
            this.Deleted = 1;       // 打上删除标记
            foreach (AccountDetail ad in DetailList)
            {
                ad.Deleted = 1;
                ad.Save();
            }
            this.Save();
            return;
        }


        /// <summary>
        /// 非正式发票转换为正式发票
        /// </summary>
        public void ConverInvoice()
        {
            if (Invoice != (long)AccountInvoiceEnum.正式发票)
            {
                Invoice = (long)AccountInvoiceEnum.正式发票;
                this.Save();
            }
        }

        /// <summary>
        /// 判断当前对象是否可以编辑
        /// </summary>
        /// <returns></returns>
        public bool CanEdit()
        {
            if (this.Status > (long)AccountStatusEnum.未审核)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 判断当前的对象是否可以打印
        /// </summary>
        /// <returns></returns>
        public bool CanPrint()
        {
            if (this.Status > (long)AccountStatusEnum.审核通过)
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
            if (this.Status != (long)AccountStatusEnum.未审核)
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
            if (this.Status == (long)AccountStatusEnum.未审核)
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
            if (this.Status == (long)AccountStatusEnum.审核通过)
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
            if (this.Status == (long)AccountStatusEnum.审核通过)
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
            if (this.Status == (long)AccountStatusEnum.已支付)
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
            未审核 = 0,
            审核通过,
            已支付,
        }
    }
}
