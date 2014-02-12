using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Haimen.DB;

namespace Haimen.Entity
{
    // 系统检查类
    public class SystemCheck
    {
        private const string checksql = @"
select a.id, sum(a.q) as q
from (
	select id, obalance as q from m_company_detail where parent_id in (select id from m_company where output = 'X')
	union
	select id, -balance as q from m_company_detail where parent_id in (select id from m_company where output = 'X')
	union
	select companydetail_id as id, sum(money) as q from t_unauth
		where input = 'X'
		group by companydetail_id
	union
	select companydetail_id as id, -sum(money) as q from t_unauth
		where output = 'X'
		group by companydetail_id
	union
	select out_companydetail_id as id, -sum(money) as q from t_account where out_companydetail_id in (select id from m_company_detail where parent_id in (
	  select id from m_company where output = 'X')) and deleted = 0 and status = 2
	group by out_companydetail_id
	union
	select in_companydetail_id as id, sum(money) as q from t_account where in_companydetail_id in (select id from m_company_detail where parent_id in (
	  select id from m_company where output = 'X')) and deleted = 0 and status = 2
	group by in_companydetail_id
	) as a
group by a.id
";

        private const string errsql = "select id, q from (" + checksql + ") b where b.q <> 0";


        public DataSet GetCheckResultData()
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(checksql, DBConnection.Connection);

            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            da.Fill(ds);

            return ds;
        }

        public int ModifyData()
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(errsql, DBConnection.Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string id = row["id"].ToString();
                Decimal money = Decimal.Parse(row["q"].ToString());
                if (!string.IsNullOrEmpty(id))
                {
                    CompanyDetail cd = CompanyDetail.CreateByID(long.Parse(id));
                    cd.Balance += money;
                    cd.Save();
                }
            }

            return ds.Tables[0].Rows.Count;
        }
    }
}
