using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_account")]
    public class Account : MEntityFunction<Account>
    {
        [Field("code")]
        public string Code { get; set; }

        public Company OutCompany { get; set; }
        public Company InCompany { get; set; }
        public Contract Contract { get; set; }

        private long m_out_company_id;
        private long m_in_company_id;
        private long m_contract_id;
        [Field("out_company_id")]
        public long Out_Company_ID
        {
            get
            {
                return m_out_company_id;
            }
            set 
            {
                m_out_company_id = value;
                OutCompany = Company.CreateByID(value);
            }
        }

        [Field("in_company_id")]
        public long In_Company_ID
        {
            get
            {
                return m_in_company_id;
            }
            set 
            {
                m_in_company_id = value;
                InCompany = Company.CreateByID(value);
            }
        }

        [Field("contract_id")]
        public long Contract_ID
        {
            get
            {
                return m_contract_id;
            }
            set
            {
                m_contract_id = value;
                Contract = Contract.CreateByID(value);
            }
        }

        public User Applicant;
        public User Reviewer;
        public User Cashier;

        private long m_app_user_id;
        private long m_rev_user_id;
        private long m_cas_user_id;
        [Field("applicant")]
        public long AppUserID
        {
            get
            {
                return m_app_user_id;
            }
            set
            {
                m_app_user_id = value;
                Applicant = User.CreateByID(value);
            }
        }

        [Field("reviewer")]
        public long RevUserID
        {
            get
            {
                return m_rev_user_id;
            }
            set
            {
                m_rev_user_id = value;
                Reviewer = User.CreateByID(value);
            }
        }

        [Field("cashier")]
        public long CasUserID
        {
            get
            {
                return m_cas_user_id;
            }
            set
            {
                m_cas_user_id = value;
                Cashier = User.CreateByID(value);
            }
        }

        [Field("status")]
        public int Status { get; set; }

        [Field("attachment")]
        public int Attachment { get; set; }

        [Field("direct_input")]
        public string DirectInput { get; set; }

        [Field("direct_output")]
        public string DirectOutput { get; set; }
    }
}
