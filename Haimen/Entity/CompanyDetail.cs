using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_company_detail")]
    public class CompanyDetail : MEntityFunction<CompanyDetail>
    {
        private long m_company_id;

        [Field("company_id")]
        public long Company_ID
        {
            get
            {
                return m_company_id;
            }
            set
            {
                m_company_id = value;
                Company = Company.CreateByID(m_company_id);
            }
        }

        public Company Company { get; set; }


        private long m_bank_id;
        [Field("bank_id")]
        public long Bank_ID
        {
            get
            {
                return m_bank_id;
            }
            set
            {
                m_bank_id = value;
                Bank = Bank.CreateByID(m_bank_id);
            }
        }

        public Bank Bank { get; set; }

        [Field("account")]
        public string Account { get; set; }

        [Field("balance")]
        public decimal Balance { get; set; }

        [Field("credit")]
        public decimal Credit { get; set; }
    }
}
