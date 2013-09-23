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
        [Field("parent_id")]
        public long Parent_ID { get; set; }

        [Field("bank_id")]
        public long Bank_ID { get; set; }

        [Field("account")]
        public string Account { get; set; }

        [Field("balance")]
        public decimal Balance { get; set; }

        [Field("credit")]
        public decimal Credit { get; set; }

        private Bank m_bank;
        public Bank Bank 
        {
            get
            {
                if (m_bank == null)
                {
                    m_bank = Bank.CreateByID(Bank_ID);
                }
                return m_bank;
            }
        }


        public override bool Verify()
        {
            Error_Info.Clear();

            if (Bank_ID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("", ""));

            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }

    }
}
