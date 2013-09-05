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


        [Field("out_company_id")]
        public long Out_Company_ID { get; set; }
        private Company m_outCompnay = null;
        public Company OutCompany
        {
            get
            {
                if (Out_Company_ID > 0)
                {
                    if (m_outCompnay == null || m_outCompnay.ID != Out_Company_ID)
                        m_outCompnay = Company.CreateByID(Out_Company_ID);
                }
                return m_outCompnay;
            }
        }


        [Field("in_company_id")]
        public long In_Company_ID { get; set; }
        private Company m_inComanpy = null;
        public Company InCompany
        {
            get
            {
                if (In_Company_ID > 0)
                {
                    if (m_inComanpy == null || m_inComanpy.ID != Out_Company_ID)
                        m_inComanpy = Company.CreateByID(In_Company_ID);
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

                Company inCom = Company.CreateByID(this.In_Company_ID);
                Company outCom = Company.CreateByID(this.Out_Company_ID);

                // 加入一个查找标记
                bool finded = false;

                // 先处理收入单位
                foreach (CompanyDetail cd in inCom.DetailList)
                {
                    // 如果找到了，更新该单位的银行资金
                    if (cd.Bank_ID == InCompany.Bank_ID && cd.Account == InCompany.Account)
                    {
                        finded = true;
                        foreach (AccountDetail ad in this.DetailList)
                            cd.Balance += ad.Money;
                    }
                }
                // 如果没有找到，则在单位帐号表里面增加一条记录
                if (!finded)
                {
                    CompanyDetail cde = new CompanyDetail();
                    cde.Bank_ID = this.InCompany.Bank_ID;
                    cde.Account = this.InCompany.Account;
                    foreach (AccountDetail ad in this.DetailList)
                    {
                        cde.Balance += ad.Money;
                    }
                    inCom.DetailList.Add(cde);
                }

                //-------------------
                // 再处理支出单位
                finded = false;
                foreach (CompanyDetail cd in outCom.DetailList)
                {
                    // 如果找到了，更新该单位的银行资金
                    if (cd.Bank_ID == OutCompany.Bank_ID && cd.Account == OutCompany.Account)
                    {
                        finded = true;
                        foreach (AccountDetail ad in this.DetailList)
                            cd.Balance -= ad.Money;
                    }
                }
                // 如果没有找到，则在单位帐号表里面增加一条记录
                if (!finded)
                {
                    CompanyDetail cde = new CompanyDetail();
                    cde.Bank_ID = this.OutCompany.Bank_ID;
                    cde.Account = this.OutCompany.Account;
                    foreach (AccountDetail ad in this.DetailList)
                    {
                        cde.Balance -= ad.Money;
                    }
                    outCom.DetailList.Add(cde);
                }

                inCom.Save();       // 保存收入单位帐号余额
                outCom.Save();      // 保存支出单位的帐号余额
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
    }
}
