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
        public static DataSet GetDataTable()
        {
            string sql = "select * from m_company where output = 'X'";
            DataSet ds = DBConnection.RunQuerySql(sql);

            DataTable dt_master = new DataTable();
            dt_master.Columns.Add("银行", typeof(System.String));
            foreach (DataRow a in ds.Tables[0].Rows)
            {
                dt_master.Columns.Add(a["doc"].ToString(), typeof(System.Decimal));
            }

            // 先建立列
            DataTable dt_detail = new DataTable();
            dt_detail.Columns.Add("银行", typeof(System.String));
            dt_detail.Columns.Add("帐号", typeof(System.String));
            foreach (DataRow a in ds.Tables[0].Rows)
            {
                dt_detail.Columns.Add(a["doc"].ToString(), typeof(System.Decimal));
            }


            sql = @"
select bankname, companyname, sum(balance) as balance
from
(select a.name bankname, b.doc companyname, c.account, c.balance
from m_bank a, m_company b,
(select parent_id, bank_id, account, sum(balance) as balance
from m_company_detail where parent_id in (select id from m_company where output = 'X')
group by parent_id, bank_id, account) c
where b.id = c.parent_id and a.id = c.bank_id) a
group by bankname, companyname
order by bankname
";

            ds = DBConnection.RunQuerySql(sql);
            bool finded = false;
            foreach (DataRow a in ds.Tables[0].Rows)
            {
                finded = false;
                foreach (DataRow b in dt_master.Rows)
                {
                    if (b["银行"].ToString() == a["bankname"].ToString())
                    {
                        finded = true;
                        b[a["companyname"].ToString()] = a["balance"];
                    }
                }
                if (!finded)
                {
                    DataRow c = dt_master.NewRow();
                    c["银行"] = a["bankname"];
                    c[a["companyname"].ToString()] = a["balance"];
                    dt_master.Rows.Add(c);
                }
            }




            sql = @"
select a.name bankname, b.doc companyname, c.account, c.balance
from m_bank a, m_company b,
(select parent_id, bank_id, account, sum(balance) as balance
from m_company_detail where parent_id in (select id from m_company where output = 'X')
group by parent_id, bank_id, account) c
where b.id = c.parent_id and a.id = c.bank_id
order by a.name, b.name
";
            ds = DBConnection.RunQuerySql(sql);
            foreach (DataRow a in ds.Tables[0].Rows)
            {

                DataRow c = dt_detail.NewRow();
                c["银行"] = a["bankname"];
                c["帐号"] = a["account"];
                c[a["companyname"].ToString()] = a["balance"];
                dt_detail.Rows.Add(c);

            }


            DataSet revl = new DataSet();
            revl.Tables.Add(dt_master);
            revl.Tables.Add(dt_detail);

            DataColumn key = revl.Tables[0].Columns["银行"];
            DataColumn foreignKey = revl.Tables[1].Columns["银行"];
            revl.Relations.Add("明细", key, foreignKey, false);

            return revl;
        }
    }
}
