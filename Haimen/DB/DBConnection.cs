using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Haimen.Helper;
using System.Data;

namespace Haimen.DB
{
    /// <summary>
    /// 数据库的联接及相关操作
    /// </summary>
    public class DBConnection
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
            catch (Exception e)
            {
                string message = String.Format("取得数据库联接出错！原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new Exception(message, e);
            }
        }

        /// <summary>
        /// 开始一个事务
        /// </summary>
        /// <returns></returns>
        public static SqlTransaction BeginTrans()
        {
            return Connection.BeginTransaction();
        }


        /// <summary>
        /// 运行一个查询语句，返回DataSet
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns></returns>
        public static DataSet RunQuerySql(string sql)
        {
            SqlCommand cmd = DBConnection.Connection.CreateCommand();
            cmd.CommandText = sql;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }

    }
}
