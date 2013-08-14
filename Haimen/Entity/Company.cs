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
        public long Bank_ID { get; set; }

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
                if (m_bank == null && Bank_ID > 0)
                {
                    m_bank = Bank.CreateByID(Bank_ID);
                }
                return m_bank;
            }
        }

        public override bool Verify()
        {
            Error_Info.Clear();
            string err = "";
            List<Company> list;

            // 校验代码
            if (ID == 0)
                list = Company.Query("Code = '" + Code + "'");
            else
                list = Company.Query("Code = '" + Code + "' and id <> " + ID.ToString());
            if (list.Count > 0)
            {
                err = "您输入的代码已经存在，请更改后再输入";
                Error_Info.Add(new KeyValuePair<string, string>("Code",err));
            }

            return true;
        }

    }
}
