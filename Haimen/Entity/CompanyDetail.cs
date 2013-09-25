using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_company_detail")]
    public class CompanyDetail : MEntityFunction<CompanyDetail>
    {
        /// <summary>
        /// 父对象
        /// </summary>
        [Field("parent_id")]
        public long Parent_ID { get; set; }
        public Company m_parent;
        public Company Parent
        {
            get
            {
                if (m_parent == null)
                    m_parent = Company.CreateByID(Parent_ID);
                return m_parent;
            }
        }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string CompanyName
        {
            get
            {
                if (m_parent == null)
                    m_parent = Company.CreateByID(Parent_ID);
                return m_parent.Name;
            }
        }

        /// <summary>
        /// 银行ID
        /// </summary>
        [Field("bank_id")]
        public long Bank_ID { get; set; }

        /// <summary>
        /// 帐号
        /// </summary>
        [Field("account")]
        public string Account { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [Field("balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// 贷款
        /// </summary>
        [Field("credit")]
        public decimal Credit { get; set; }

        private Bank m_bank;
        public Bank Bank 
        {
            get
            {
                if (m_bank == null)
                {
                    m_bank = Bank.CreateByID(Bank_ID);
                }
                return m_bank;
            }
        }

        // for lookupedit控件
        public string BankName
        {
            get
            {
                if (m_bank == null)
                    m_bank = Bank.CreateByID(Bank_ID);
                return m_bank.Name;
            }
        }


        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            Error_Info.Clear();

            if (Bank_ID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("", ""));

            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }

    }
}
