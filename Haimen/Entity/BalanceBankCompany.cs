using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Haimen.DB;

namespace Haimen.Entity
{
    /// <summary>
    /// 银行单位的余额及明细表表，用来显示余额以及明细的
    /// </summary>
    public class BalanceBankCompany
    {
        public static DataTable GetDataTable()
        {
            string sql = "select * from m_company where output = 'X'";
            DataSet ds = DBConnection.RunQuerySql(sql);

            DataTable dt = new DataTable();
            dt.Columns.Add("银行", typeof(System.String));
            dt.Columns.Add("帐号", typeof(System.String));
            foreach (DataRow a in ds.Tables[0].Rows)
            {
                dt.Columns.Add(a["name"].ToString(), typeof(System.Decimal));
            }

            sql = @"
select a.name bankname, b.name companyname, c.account, c.balance
from m_bank a, m_company b,
(select parent_id, bank_id, account, sum(balance) as balance
from m_company_detail where parent_id in (select id from m_company where output = 'X')
group by parent_id, bank_id, account) c
where b.id = c.parent_id and a.id = c.bank_id
order by a.name, b.name
";
            ds = DBConnection.RunQuerySql(sql);
            bool finded = false;
            foreach (DataRow a in ds.Tables[0].Rows)
            {
                finded = false;
                foreach (DataRow b in dt.Rows)
                {
                    if (b["银行"] == a["bankname"])
                    {
                        finded = true;
                        b["帐号"] = a["account"];
                        b[a["companyname"].ToString()] = a["balance"];
                    }
                }
                if (!finded)
                {
                    DataRow c = dt.NewRow();
                    c["银行"] = a["bankname"];
                    c["帐号"] = a["account"];
                    c[a["companyname"].ToString()] = a["balance"];
                    dt.Rows.Add(c);
                }
            }


            return dt;
        }
    }
}
