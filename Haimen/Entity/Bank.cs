using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_bank")]
    public class Bank : EntityFunction<Bank>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("name")]
        public string Name { get; set; }


        // 取得下属银行
        public static List<Bank> GetChildren(int id)
        {
            List<Bank> list = Bank.Query("parent_id = " + id.ToString());
            return list;
        }

    }
}
