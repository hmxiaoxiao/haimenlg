using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    [Table("t_balance")]
    public class Balance : ComplexEntity<Balance, BalanceDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        private long m_companydetail_id;
        public CompanyDetail CompanyDetail { get; set; }
        [Field("companydetail_id")]
        public long CompanyDetailID
        {
            get
            {
                return m_companydetail_id;
            }
            set 
            {
                m_companydetail_id = value;
                CompanyDetail = CompanyDetail.CreateByID(value);
            }
        }

        /// <summary>
        /// 贷款金额
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }

        /// <summary>
        /// 贷款余额
        /// </summary>
        [Field("remaining")]
        public decimal Remaining { get; set; }

        [Field("begin_date")]
        public DateTime BeginDate { get; set; }

        [Field("end_date")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 利率
        /// </summary>
        [Field("rate")]
        public decimal Rate { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

        [Field("status")]
        public long Status { get; set; }


        /// <summary>
        /// 审核通过
        /// </summary>
        public void CheckPass()
        {
            // 改标志为已审核
            this.Status = (long)BalanceStatusEnum.审核通过;
            this.Save();        // 保存审核标记
        }

        public override bool InsertVerify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(this.Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "贷款编号不能为空"));

            if (string.IsNullOrEmpty(this.Name))
                Error_Info.Add(new KeyValuePair<string, string>("Name", "贷款合同名称不能为空"));

            if (this.CompanyDetailID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("CompanyDetailID", "请选择贷款单位"));

            if (this.Money <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("Money", "贷款金额不能为零"));

            return Error_Info.Count == 0;
        }

        public override bool Insert()
        {
            this.Remaining = this.Money;
            return base.Insert();
        }

        public override bool Update()
        {
            // 当前已还贷金额
            Balance old_balance = Balance.CreateByID(this.ID);

            decimal d = old_balance.Money - old_balance.Remaining;
            this.Remaining = Money - d;     //当前的还贷余额
            return base.Update();
        }

        /// <summary>
        /// 资金的状态
        /// </summary>
        public enum BalanceStatusEnum : long
        {
            未审核 = 0,
            审核通过,
            贷款到帐,
        }
    }
}
