using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;

namespace Haimen.Entity
{
    [Table("m_company")]
    public class Company : TEntityFunction<Company, CompanyDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("name")]
        public string Name { get; set; }

        [Field("bank_id")]
        public long BankID { get; set; }

        [Field("account")]
        public string Account { get; set; }

        [Field("doc")]
        public string Doc { get; set; }

        [Field("output")]
        public string Output { get; set; }

        [Field("input")]
        public string Input { get; set; }

        private Bank m_bank;
        public Bank Bank
        {
            get
            {
                if (m_bank == null && BankID > 0)
                {
                    m_bank = Bank.CreateByID(BankID);
                }
                return m_bank;
            }
        }

        /// <summary>
        /// 单位的数据校验
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            Error_Info.Clear();
            List<Company> list;

            // 校验代码
            if (string.IsNullOrEmpty(Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "代码不能为空！"));
            if (ID == 0)
                list = Company.Query("code = '" + Code + "'");
            else
                list = Company.Query("code = '" + Code + "' and id <> " + ID.ToString());
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Code","您输入的代码已经存在，请重新输入"));

            // 校验名称
            if (string.IsNullOrEmpty(Name))
                Error_Info.Add(new KeyValuePair<string, string>("Name", "名称不能为空"));

            list = Company.Query("name = '" + Name + "' and id <> " + ID.ToString()); // 如果ID为0，也没有问题
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", "您输入的名称已经存在，请重新输入"));

            // 校验帐号
            if (string.IsNullOrEmpty(Account))
                Error_Info.Add(new KeyValuePair<string, string>("Account", "帐号不能为空"));
            list = Company.Query("account = '" + Account + "' and id <> " + ID.ToString());
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Account", "您输入的帐号已经存在，请重新输入!"));

            // 校验开户行
            if (BankID== 0)
                Error_Info.Add(new KeyValuePair<string,string>("BankID", "开户行不能为空"));


            return Error_Info.Count == 0;
        }

        [Field("doc_date")]
        public string DocDate { get; set; }

        [Field("gen_doc")]
        public long GenDoc { get; set; }
        
        /// <summary>
        /// 生成单据字
        /// </summary>
        /// <returns></returns>
        public string NextDoc()
        {
            string relVal = "";
            // 如果不需要单据字，则直接退出
            if (string.IsNullOrEmpty(this.Doc))
                return relVal;


            // 因为在内存的对象可能是很久以前的数据，
            // 所以要重新从数据库里面取一次。
            Company com = Company.CreateByID(this.ID);
            if (string.IsNullOrEmpty(this.DocDate))
            {
                com.DocDate = string.Format("{0:yyyyMMdd}", DateTime.Now);
                com.GenDoc = 1;
                com.Save();
            }
            else
            {
                if (com.DocDate == string.Format("{0:yyyyMMdd}", DateTime.Now))
                {
                    com.GenDoc += 1;
                    com.Save();
                }
                else
                {
                    com.DocDate = string.Format("{0:yyyyMMdd}", DateTime.Now);
                    com.GenDoc = 1;
                    com.Save();
                }
            }
            relVal = com.Doc + com.DocDate + string.Format("{0:000}",com.GenDoc);
            return relVal;
        }

        /// <summary>
        /// 新增单位时，自动增加一个明细，为开户银行
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            CompanyDetail cd = new CompanyDetail();
            cd.BankID = BankID;
            cd.Account = Account;

            DetailList.Add(cd);

            return base.Insert();
        }

    }
}
