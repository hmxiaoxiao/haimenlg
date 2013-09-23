using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;
using Haimen.Helper;
using System.Transactions;

namespace Haimen.Entity
{
    [Table("t_account")]
    public class Account : TEntityFunction<Account, AccountDetail>
    {
        [Field("code")]
        public string Code { get; set; }


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
        

        [Field("contract_id")]
        public long Contract_ID { get; set; }
        private Contract m_contract = null;
        public Contract Contract
        {
            get
            {
                if (Contract_ID > 0)
                {
                    if (m_contract == null || m_contract.ID != Contract_ID)
                        m_contract = Contract.CreateByID(Contract_ID);
                }
                return m_contract;
            }
        }

        [Field("balance_id")]
        public long Balance_ID { get; set; }

        [Field("applicant")]
        public long AppUserID { get; set; }
        private User m_applicant = null;
        public User Applicant
        {
            get
            {
                if (AppUserID > 0)
                {
                    if (m_applicant == null || m_applicant.ID != AppUserID)
                        m_applicant = User.CreateByID(AppUserID);
                }
                return m_applicant;
            }
        }

        [Field("reviewer")]
        public long RevUserID { get; set; }
        private User m_reviewer = null;
        public User Reviewer
        {
            get
            {
                if (RevUserID > 0)
                {
                    if (m_reviewer == null || m_reviewer.ID != RevUserID)
                        m_reviewer = User.CreateByID(RevUserID);
                }
                return m_reviewer;
            }
        }

        [Field("cashier")]
        public long CasUserID { get; set; }
        private User m_cashier = null;
        public User Cashier
        {
            get
            {
                if (CasUserID > 0)
                {
                    if (m_cashier == null || m_cashier.ID != CasUserID)
                        m_cashier = User.CreateByID(CasUserID);
                }
                return m_cashier;
            }
        }

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

        /// <summary>
        /// 审核通过
        /// </summary>
        public void CheckPass()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                // 改标志为已审核
                this.Status = 1;

                CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
                CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
                decimal money = 0;
                foreach (AccountDetail ad in this.DetailList)
                {
                    money += ad.Money;
                }
                inCD.Balance += money;
                outCD.Balance -= money;

                inCD.Save();       // 保存收入单位帐号余额
                outCD.Save();      // 保存支出单位的帐号余额
                this.Save();        // 保存审核标记

                ts.Complete();
            }
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
        public void CheckFaild()
        {
            this.Status = (long)MyCheckStatus.Unpass;
            this.Save();
        }

        public override bool Verify()
        {
            Error_Info.Clear();
            if (this.In_CompanyDetail_ID <= 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("In_CompanyDetail_ID", "请选择收入单位帐号！"));
            }

            if (this.Out_CompanyDetail_ID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("Out_CompanyDetail_ID", "请选择支出单位的帐号"));

            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }
    }
}
