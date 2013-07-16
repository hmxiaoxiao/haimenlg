using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_contract")]
    public class Contract : EntityFunction<Contract>
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

        [Field("signed_date")]
        public DateTime SignedDate { get; set; }

        [Field("begin_date")]
        public DateTime BeginDate { get; set; }

        [Field("end_date")]
        public DateTime EndDate { get; set; }

        [Field("name")]
        public string Name { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("security")]
        public decimal Security { get; set; }

        [Field("payment_ratio")]
        public decimal PaymentRatio { get; set; }

        [Field("attachment")]
        public long Attachment { get; set; }

        [Field("pay")]
        public decimal Pay { get; set; }

        [Field("explanation")]
        public string Explanation { get; set; }

        private long m_typ_user_id;
        public User Typist;
        [Field("typist")]
        public long TypUserID
        {
            get
            {
                return m_typ_user_id;
            }
            set
            {
                m_typ_user_id = value;
                Typist = User.CreateByID(value);
            }
        }


        [Field("static")]
        public int Static { get; set; }

        [Field("memo")]
        public string Memo { get; set; }
    }
}
