//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Haimen.Qy;
//using Haimen.Entity;

//namespace HaimenEntity.BaseObject
//{
//    [Table("t_contract")]
//    public class Contract : TEntityFunction<Contract, ContractDetail>
//    {
//        [Field("code")]
//        public string Code { get; set; }

//        [Field("company_id")]
//        public long CompanyID { get; set; }
//        private Company m_company = null;
//        public Company Belong_Company
//        {
//            get
//            {
//                if (CompanyID > 0)
//                {
//                    if (m_company == null || m_company.ID != CompanyID)
//                        m_company = Company.CreateByID(CompanyID);
//                }
//                return m_company;
//            }
//        }

//        [Field("signed_date")]
//        public DateTime SignedDate { get; set; }

//        [Field("begin_date")]
//        public DateTime BeginDate { get; set; }

//        [Field("end_date")]
//        public DateTime EndDate { get; set; }

//        [Field("name")]
//        public string Name { get; set; }

//        [Field("money")]
//        public decimal Money { get; set; }

//        [Field("security")]
//        public decimal Security { get; set; }

//        [Field("payment_ratio")]
//        public decimal PaymentRatio { get; set; }

//        [Field("attachment")]
//        public long Attachment { get; set; }

//        [Field("pay")]
//        public decimal Pay { get; set; }

//        [Field("explanation")]
//        public string Explanation { get; set; }

//        [Field("typist")]
//        public long TypUserID { get; set; }
//        private User m_typist = null;
//        public User Typist
//        {
//            get
//            {
//                if (TypUserID > 0)
//                {
//                    if (m_typist == null || m_typist.ID != TypUserID)
//                        m_typist = User.CreateByID(TypUserID);
//                }
//                return m_typist;
//            }
//        }


//        [Field("static")]
//        public long Static { get; set; }

//        [Field("memo")]
//        public string Memo { get; set; }
//    }
//}
