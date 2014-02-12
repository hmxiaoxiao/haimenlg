using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Haimen.Helper;
using System.Data;

namespace Haimen.DB
{
    public class DBFunction
    {
        // 数据库联接
        private static SqlConnection m_conn;
        public static SqlConnection Connection
        {
            get
            {
                return getConnection();
            }
        }

        /// <summary>
        /// 取得数据库联接
        /// </summary>
        /// <returns>一个数据库的联接</returns>
        private static SqlConnection getConnection()
        {
            try
            {
                if (m_conn == null)
                {
                    string connStr = INICustomer.GetConnectionString();
                    m_conn = new SqlConnection(connStr);
                    m_conn.Open();
                }
                return m_conn;
            }
            catch (HelperException)
            {
                throw;
            }
            catch (Exception e)
            {
                string message = "取得数据库联接出错！原因如下：" + Environment.NewLine + e.Message;
                throw new Exception(message, e);
            }
        }

        /// <summary>
        /// 开始一个事务
        /// </summary>
        /// <returns></returns>
        public SqlTransaction BeginTrans()
        {
            return Connection.BeginTransaction();
        }

        public static DataSet RunQuerySql(string sql)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            cmd.CommandText = sql;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }

    }
}
