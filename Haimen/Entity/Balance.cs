using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_balance")]
    public class Balance : TEntityFunction<Balance, BalanceDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        private long m_company_id;
        public Company Company { get; set; }
        [Field("company_id")]
        public long CompanyID
        {
            get
            {
                return m_company_id;
            }
            set 
            {
                m_company_id = value;
                Company = Company.CreateByID(value);
            }
        }

        private long m_bank_id;
        public Bank Bank{ get; set; }
        [Field("bank_id")]
        public long BankID
        {
            get
            {
                return m_bank_id;
            }
            set
            {
                m_bank_id = value;
                Bank = Bank.CreateByID(value);
            }
        }

        [Field("account")]
        public string Account { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("remaining")]
        public decimal Remaining { get; set; }

        [Field("begin_date")]
        public DateTime BeginDate { get; set; }

        [Field("end_date")]
        public DateTime EndDate { get; set; }

        [Field("rate")]
        public decimal Rate { get; set; }

        [Field("total_interest")]
        public decimal TotalInterest { get; set; }

        [Field("interest_date")]
        public int InterestDate { get; set; }

        [Field("repay_date")]
        public int RepayDate { get; set; }

        [Field("month_interest")]
        public decimal MonthIntereset { get; set; }

        [Field("already_interest")]
        public decimal AlreadyInterest { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

    }
}
