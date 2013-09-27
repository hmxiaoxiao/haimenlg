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
        /// <summary>
        /// 编号
        /// </summary>
        [Field("code")]
        public string Code { get; set; }

        /// <summary>
        /// 付款单位
        /// </summary>
        [Field("out_company_id")]
        public long OutCompanyID { get; set; }
        private Company m_out_company = null;
        public Company OutCompany
        {
            get
            {
                if (OutCompanyID > 0)
                {
                    if (m_out_company == null || m_out_company.ID != OutCompanyID)
                        m_out_company = Company.CreateByID(OutCompanyID);
                }
                return m_out_company;
            }
        }


        /// <summary>
        /// 收款单位
        /// </summary>
        [Field("in_company_id")]
        public long InCompanyID { get; set; }
        private Company m_in_company = null;
        public Company InCompany
        {
            get
            {
                if (InCompanyID > 0)
                {
                    if (m_in_company == null || m_in_company.ID != InCompanyID)
                        m_in_company = Company.CreateByID(InCompanyID);
                }
                return m_in_company;
            }
        }

        /// <summary>
        /// 甲方
        /// </summary>
        [Field("partya")]
        public long PartyAID { get; set; }
        private Company m_partya = null;
        public Company PartyA
        {
            get
            {
                if (PartyAID > 0)
                {
                    if (m_partya == null || m_partya.ID != PartyAID)
                        m_partya = Company.CreateByID(PartyAID);
                }
                return m_partya;
            }
        }

        // 以下二个属性，只为lue控件使用
        public string PartyAName
        {
            get
            {
                if (PartyAID > 0)
                {
                    if (m_partya == null || m_partya.ID != PartyAID)
                        m_partya = Company.CreateByID(PartyAID);
                }
                return m_partya.Name;
            }
        }
        public string PartyBName
        {
            get
            {
                if (PartyBID > 0)
                {
                    if (m_partyb == null || m_partyb.ID != PartyBID)
                        m_partyb = Company.CreateByID(PartyBID);
                }
                return m_partyb.Name;
            }
        }

        /// <summary>
        /// 乙方
        /// </summary>
        [Field("partyb")]
        public long PartyBID { get; set; }
        private Company m_partyb = null;
        public Company PartyB
        {
            get
            {
                if (PartyBID > 0)
                {
                    if (m_partyb == null || m_partyb.ID != PartyBID)
                        m_partyb = Company.CreateByID(PartyBID);
                }
                return m_partyb;
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

        /// <summary>
        /// 决算价
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }

        /// <summary>
        /// 审计价
        /// </summary>
        [Field("checkmoney")]
        public decimal CheckMoney { get; set; }

        /// <summary>
        /// 保证金
        /// </summary>
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
            this.Status = (long)AccountStatusEnum.审核通过;
            this.Save();
        }

        // 审核不通过
        public void CheckFaild()
        {
            this.Status = (long)AccountStatusEnum.审核未通过;
            this.Save();
        }

        /// <summary>
        /// 校验数据是否正确
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(this.Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "代码不能为空"));

            if (this.OutCompanyID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("OutCompanyID", "请选择签合同的付款单位!"));

            if (this.InCompanyID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("IntCompanyID", "请选择签合同的收款单位!"));
            
            if (this.PartyAID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("PartyA_ID", "请选择签合同的甲方!"));

            if (this.PartyBID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("PartyB_ID", "请选择签合同的乙方!"));


            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 更新已付的金额
        /// </summary>
        /// <param name="money"></param>
        public void UpdatePay(decimal money)
        {
            Pay += money;
            Status = (long)ContractStatusEnum.付款中;
            Save();
        }
    }
}
