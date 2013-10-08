using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Haimen.Helper;
using System.Data;

namespace Haimen.Qy
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

        private static SqlConnection getConnection()
        {
            string connStr = CustomerINI.GetConnectionString();
                //@"Data Source=R400;Initial Catalog=haimen;User ID=sa;Password=heroes22";
            if (m_conn == null)
            {
                m_conn = new SqlConnection(connStr);
                m_conn.Open();
            }
            return m_conn;
        }

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
