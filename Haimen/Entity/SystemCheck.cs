using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Haimen.DB;

namespace Haimen.Entity
{
    /// <summary>
    /// 系统检查类
    /// 检查一下余额是否等于初期+收入-支出
    /// </summary>
    public class SystemCheck
    {
        /// <summary>
        /// 检查的SQL语句
        /// </summary>
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

        /// <summary>
        /// 取得出错的帐号
        /// </summary>
        private const string errsql = "select id, q from (" + checksql + ") b where b.q <> 0";


        /// <summary>
        /// 取得检查的结果,以DataSet返回
        /// 对所有的单位的每个帐号都进行了检查。
        /// </summary>
        /// <returns></returns>
        public DataSet GetCheckResultData()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(checksql, DBConnection.Connection);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                string msg = string.Format("检查余额时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }

        /// <summary>
        /// 自动更新错误的数据
        /// </summary>
        /// <returns></returns>
        public int AutoUpdateData()
        {
            SqlTransaction trans = null;
            try
            {

                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(errsql, DBConnection.Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                trans = DBConnection.BeginTrans();
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
                trans.Commit();

                return ds.Tables[0].Rows.Count;
            }
            catch (Exception e)
            {
                if (trans != null)
                    trans.Rollback();

                string msg = string.Format("检查余额时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }
    }
}
