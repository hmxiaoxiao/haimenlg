using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;

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

        [Field("direct_input")]
        public string DirectInput { get; set; }

        [Field("direct_output")]
        public string DirectOutput { get; set; }
    }
}
