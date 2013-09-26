using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using System.Transactions;

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

        [Field("status")]
        public long Status { get; set; }


        /// <summary>
        /// 审核通过
        /// </summary>
        public void CheckPass()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                // 改标志为已审核
                this.Status = (long)MyCheckStatus.Checked;

                Company cor = Company.CreateByID(this.CompanyID);

                // 加入一个查找标记
                bool finded = false;
                foreach (CompanyDetail cd in cor.DetailList)
                {
                    // 如果找到了，更新该单位的银行资金
                    if (cd.BankID == this.BankID && cd.Account == this.Account)
                    {
                        finded = true;
                        cd.Credit += this.Money;
                    }
                }
                // 如果没有找到，则在单位帐号表里面增加一条记录
                if (!finded)
                {
                    CompanyDetail cde = new CompanyDetail();
                    cde.BankID = this.BankID;
                    cde.Account = this.Account;
                    cde.Credit += this.Money;
                }

                cor.Save();      
                this.Save();        // 保存审核标记

                ts.Complete();
            }
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
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
                Error_Info.Add(new KeyValuePair<string, string>("CompanyID", "请选择贷款单位"));

            if (this.BankID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("BankID", "请选择贷款银行"));

            if (string.IsNullOrEmpty(this.Account))
                Error_Info.Add(new KeyValuePair<string, string>("Account", "请输入贷款帐号"));

            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }
    }
}
