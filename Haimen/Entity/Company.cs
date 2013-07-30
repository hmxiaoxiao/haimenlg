using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_company")]
    public class Company : MEntityFunction<Company>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("name")]
        public string Name { get; set; }

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
                if (m_bank_id > 0)
                {
                    m_bank = Bank.CreateByID(m_bank_id);
                }
            } 
        }

        [Field("account")]
        public string Account { get; set; }

        [Field("doc")]
        public string Doc { get; set; }

        [Field("output")]
        public string Output { get; set; }

        [Field("input")]
        public string Input { get; set; }

        private long m_bank_id;
        private Bank m_bank;
        public Bank Bank { get { return m_bank; } }


        public List<CompanyDetail> Detail;
    }
}
