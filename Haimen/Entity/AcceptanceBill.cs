using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Helper;
using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_acceptance_bill")]
    public class AcceptanceBill : MEntityFunction<AcceptanceBill>
    {
        /// <summary>
        /// 出票日期
        /// </summary>
        [Field("draw_date")]
        public DateTime DrawDate { get; set; }

        /// <summary>
        /// 票据号
        /// </summary>
        [Field("code")]
        public string Code { get; set; }

        /// <summary>
        /// 付款单位明细ID
        /// </summary>
        [Field("out_companydetail_id")]
        public long OutCompanyDetailID { get; set; }

        private CompanyDetail m_out_cd;
        public CompanyDetail OutCompanyDetail
        {
            get
            {
                if (m_out_cd == null && OutCompanyDetailID > 0)
                    m_out_cd = CompanyDetail.CreateByID(OutCompanyDetailID);
                return m_out_cd;
            }
        }

        /// <summary>
        /// 收款单位明细ID
        /// </summary>
        [Field("in_companydetail_id")]
        public long InCompanyDetailID { get; set; }

        private CompanyDetail m_in_cd;
        public CompanyDetail InCompanyDetail
        {
            get
            {
                if (m_in_cd == null && InCompanyDetailID > 0)
                    m_in_cd = CompanyDetail.CreateByID(InCompanyDetailID);
                return m_in_cd;
            }
        }


        /// <summary>
        /// 背书单位明细ID
        /// </summary>
        [Field("move_companydetail_id")]
        public long MoveCompanyDetailID { get; set; }

        private CompanyDetail m_move_cd;
        public CompanyDetail MoveCompanyDetail
        {
            get
            {
                if (m_move_cd == null && MoveCompanyDetailID > 0)
                    m_move_cd = CompanyDetail.CreateByID(MoveCompanyDetailID);
                return m_move_cd;
            }
        }

        /// <summary>
        /// 出票金额
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        [Field("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 交易合同号
        /// </summary>
        [Field("tradecode")]
        public string TradeCode { get; set; }

        /// <summary>
        /// 标志
        /// </summary>
        [Field("status")]
        public long Status { get; set; }


        /// <summary>
        /// 承兑汇票的校验
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            Error_Info.Clear();

            if (string.IsNullOrWhiteSpace(Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "票据号不能为空！"));

            if (string.IsNullOrWhiteSpace(TradeCode))
                Error_Info.Add(new KeyValuePair<string, string>("TradeCode", "交易合同号不能为空！"));

            if(this.InCompanyDetailID <= 0)
                Error_Info.Add(new KeyValuePair<string,string>("InCompanyDetail", "请选择收入单位！"));

            if (this.OutCompanyDetailID <= 0)
                Error_Info.Add(new KeyValuePair<string,string>("OutCompanyDetail", "请选择支出单位!"));

            if (this.Money <= 0)
                Error_Info.Add(new KeyValuePair<string,string>("Money", "汇票金额不能为空!"));

            return Error_Info.Count == 0;
        }
    }
}
