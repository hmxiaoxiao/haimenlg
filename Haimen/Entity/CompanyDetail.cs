using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    /// <summary>
    /// 单位银行帐户实体类
    /// </summary>
    [Table("m_company_detail")]
    public class CompanyDetail : SingleEntity<CompanyDetail>
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
        /// 帐号
        /// </summary>
        [Field("account")]
        public string Account { get; set; }

        /// <summary>
        /// 帐户类型
        /// </summary>
        [Field("dtype")]
        public string AccountType { get; set; }

        private static List<string> m_list;
        public static List<string> AccountTypeList
        {
            get
            {
                if (m_list == null)
                {
                    m_list = new List<string>();
                    m_list.Add("基本户");
                    m_list.Add("一般户");
                    m_list.Add("现金户");
                    m_list.Add("贷款户");
                    m_list.Add("一般户");
                    m_list.Add("预算内");
                    m_list.Add("预算外");
                    m_list.Add("贷款户");
                    m_list.Add("风险保证金");
                    m_list.Add("公积金");
                    m_list.Add("基本户");
                    m_list.Add("经费帐");
                    m_list.Add("取款专户");
                    m_list.Add("收息户");
                    m_list.Add("税款户");
                    m_list.Add("信贷资金");
                    m_list.Add("偿债备时金");
                    m_list.Add("承兑保证金户");
                }
                return m_list;
            }
        }

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


        public bool CanDelete(long id)
        {
            Error_Info.Clear();
            if (Haimen.Entity.Account.Query(" in_companydetail_id = " + id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除单位明细","该单位明细已经被资金中引用"));
                return false;
            }
            if (Haimen.Entity.Account.Query(" out_companydetail_id = " + id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除单位明细","该单位明细已经被资金中引用"));
                return false;
            }
            if(Haimen.Entity.Balance.Query("companydetail_id = " + id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除单位明细","该单位明细已经被贷款中引用"));
                return false;
            }
            return true;
        }


        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        public override bool InsertVerify()
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
