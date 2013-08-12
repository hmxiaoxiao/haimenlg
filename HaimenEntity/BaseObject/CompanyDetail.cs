//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Haimen.Qy;

//namespace HaimenEntity.BaseObject
//{
//    [Table("m_company_detail")]
//    public class CompanyDetail : MEntityFunction<CompanyDetail>
//    {
//        [Field("parent_id")]
//        public long Parent_ID { get; set; }

//        private long m_bank_id;
//        [Field("bank_id")]
//        public long Bank_ID { get; set; }

//        [Field("account")]
//        public string Account { get; set; }

//        [Field("balance")]
//        public decimal Balance { get; set; }

//        [Field("credit")]
//        public decimal Credit { get; set; }

//        private Bank m_bank;
//        public Bank Bank 
//        {
//            get
//            {
//                if (m_bank == null)
//                {
//                    m_bank = Bank.CreateByID(Bank_ID);
//                }
//                return m_bank;
//            }
//        }


//    }
//}
