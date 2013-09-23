using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;

namespace Haimen.Entity
{
    [Table("t_contract")]
    public class Contract : TEntityFunction<Contract, ContractDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("company_id")]
        public long CompanyID { get; set; }
        private Company m_company = null;
        public Company Company
        {
            get
            {
                if (CompanyID > 0)
                {
                    if (m_company == null || m_company.ID != CompanyID)
                        m_company = Company.CreateByID(CompanyID);
                }
                return m_company;
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

        [Field("typist")]
        public long TypUserID { get; set; }
        private User m_typist = null;
        public User Typist
        {
            get
            {
                if (TypUserID > 0)
                {
                    if (m_typist == null || m_typist.ID != TypUserID)
                        m_typist = User.CreateByID(TypUserID);
                }
                return m_typist;
            }
        }


        [Field("status")]
        public long Status { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

        // 审核通过
        public void CheckPassed()
        {
            this.Status = (long)MyCheckStatus.Checked;
            this.Save();
        }

        // 审核不通过
        public void CheckFaild()
        {
            this.Status = (long)MyCheckStatus.Unpass;
            this.Save();
        }

        public override bool Verify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(this.Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "代码不能为空"));

            if (this.CompanyID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("CompanyID", "请选择签合同的单位!"));


            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }
    }
}
