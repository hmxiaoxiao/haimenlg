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
        /// 取得一个Command
        /// </summary>
        /// <returns></returns>
        public static SqlCommand getCommand()
        {
            SqlCommand comm = Connection.CreateCommand();
            if (m_trans != null)
                comm.Transaction = m_trans;
            return comm;
        }


        /// <summary>
        /// 当前的事务
        /// </summary>
        private static SqlTransaction m_trans = null;

        public static SqlTransaction Transaction
        {
            get
            {
                return m_trans;
            }
        }

        /// <summary>
        /// 开始一个事务
        /// </summary>
        /// <returns></returns>
        public static SqlTransaction BeginTrans()
        {
            try
            {
                m_trans = Connection.BeginTransaction();
                return m_trans;
            }
            catch (Exception e)
            {
                string message = String.Format("开始一个事务出错！原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new Exception(message, e);
            }
        }


        /// <summary>
        /// 提交一个事务
        /// </summary>
        /// <returns></returns>
        public static void CommitTrans()
        {
            try
            {
                m_trans.Commit();
                m_trans = null;
            }
            catch (Exception e)
            {
                string message = String.Format("提交事务出错出错！原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new Exception(message, e);
            }
        }


        /// <summary>
        /// 回滚一个事务
        /// </summary>
        /// <returns></returns>
        public static void RollbackTrans()
        {
            try
            {
                m_trans.Rollback();
                m_trans = null;
            }
            catch (Exception e)
            {
                string message = String.Format("回滚事务出错！原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new Exception(message, e);
            }
        }


        /// <summary>
        /// 运行一个查询语句，返回DataSet
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns></returns>
        public static DataSet RunQuerySql(string sql)
        {
            SqlCommand cmd = DBConnection.getCommand();
            cmd.CommandText = sql;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds;
        }


        public static int RunNoQuerySql(string sql)
        {
            SqlCommand cmd = DBConnection.getCommand();
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }


        /// <summary>
        /// 测试当前的数据库联接是否正确
        /// </summary>
        /// <returns></returns>
        public static bool TestDBConnection(out string errinfo)
        {
            try
            {
                if (getConnection() != null)
                {
                    errinfo = "";
                    return true;
                }
                else
                {
                    errinfo = "";
                    return false;
                }
            }
            catch (Exception e)
            {
                errinfo = e.ToString();
                return false;
            }
        }

    }
}
