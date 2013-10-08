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
        public long ParentID { get; set; }
        private Company m_parent;
        public Company Parent
        {
            get
            {
                if (m_parent == null)
                    m_parent = Company.CreateByID(ParentID);
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
                    m_parent = Company.CreateByID(ParentID);
                return m_parent.Name;
            }
        }

        /// <summary>
        /// 银行ID
        /// </summary>
        [Field("bank_id")]
        public long BankID { get; set; }

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

        /// <summary>
        /// 原始余额
        /// </summary>
        [Field("obalance")]
        public decimal OBalance { get; set; }

        /// <summary>
        /// 原始贷款
        /// </summary>
        [Field("ocredit")]
        public decimal OCredit { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

        
        private Bank m_bank;
        public Bank Bank 
        {
            get
            {
                if (m_bank == null)
                    m_bank = Bank.CreateByID(BankID);
                return m_bank;
            }
        }

        // for lookupedit控件
        public string BankName
        {
            get
            {
                if (m_bank == null)
                    m_bank = Bank.CreateByID(BankID);
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

            if (BankID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("BankID", "银行不能为空"));

            if (string.IsNullOrEmpty(Account))
                Error_Info.Add(new KeyValuePair<string, string>("Account", "帐户不能为空"));
            List<CompanyDetail> list;
            list = CompanyDetail.Query(" account = '" + Account + "' and id <> " + ID.ToString());
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string,string>("Account", "您输入的帐户已经存在，请检查后再输入。"));

            return Error_Info.Count == 0;
        }

        /// <summary>
        /// 新增时，将余额，与原始余额保持一致。贷款也一样
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            Balance = OBalance;
            Credit = OCredit;
            return base.Insert();
        }

        /// <summary>
        /// 修改时，要将原始余额的差异保持到余额上，贷款也一样。
        /// </summary>
        /// <returns></returns>
        public override bool Update()
        {
            // 先取得原始记录
            CompanyDetail ocom = CompanyDetail.CreateByID(ID);
            
            // 再取得差异, 并将差异保持到余额上
            decimal def = this.OBalance - ocom.OBalance;
            this.Balance += def;

            def = this.OCredit - ocom.OCredit;
            this.Credit += def;

            return base.Update();
        }

    }
}
