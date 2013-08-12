//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Haimen.Qy;
//using Haimen.Entity;

//namespace HaimenEntity.BaseObject
//{
//    [Table("t_account_detail")]
//    public class AccountDetail : MEntityFunction<AccountDetail>
//    {
//        [Field("parent_id")]
//        public long Parent_ID { get; set; }

//        [Field("funds_id")]
//        public long Funds_ID { get; set; }
//        private Funds m_funds = null;
//        public Funds Funds
//        {
//            get
//            {
//                if (Funds_ID > 0)
//                {
//                    if (m_funds == null || m_funds.ID != Funds_ID)
//                        m_funds = Funds.CreateByID(Funds_ID);
//                }
//                return m_funds;
//            }
//        }

//        [Field("usage")]
//        public string Usage { get; set; }

//        [Field("money")]
//        public Decimal Money { get; set; }
//    }
//}
