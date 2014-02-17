using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Reflection;
using System.Data.SqlClient;

namespace Haimen.DB
{
    [Serializable]
    public class SingleEntity<T> where T : new()
    {
        /// <summary>
        /// 每个实体类都有的ID值
        /// </summary>
        [Field("id")]
        public long ID { get; set; }


        /// <summary>
        /// 每个实体类都有的创建时间
        /// </summary>
        [Field("created_date")]
        public DateTime CreatedDate { get; set; }


        /// <summary>
        /// 每个实体类都有的更新时间
        /// </summary>
        [Field("updated_date")]
        public DateTime UpdatedDate { get; set; }


        /// <summary>
        /// 每个实体类都有的删除标记，0 为正常，1为删除
        /// </summary>
        [Field("deleted")]
        public long Deleted { get; set; }


        /// <summary>
        /// 用于保存错误信息
        /// 如果与字段有关，则key为字段
        /// 否则与调用的函数名有关，比如Verify等
        /// 另外，每次调用方法后，都可能会清空上次的信息，故需及时处理
        /// </summary>
        public List<KeyValuePair<string, string>> Error_Info = new List<KeyValuePair<string, string>>();


        /// <summary>
        /// 返回错误原因
        /// </summary>
        public string ErrorString
        {
            get
            {
                string m_errorstring = "";
                foreach (KeyValuePair<string, string> kv in Error_Info)
                {
                    m_errorstring += kv.Value + Environment.NewLine;
                }
                return m_errorstring;
            }
        }


        /// <summary>
        /// 用来在导常时，保存异常信息，以供GUI显示
        /// </summary>
        public static string ExceptionString { get; set; }





        /// <summary>
        /// 是否显示已经打上删除标记的记录
        /// </summary>
        public static bool ShowDeleteRecord = false;


        /// <summary>
        /// 当前对象指定的排序字段
        /// 默认是后增加的在前面
        /// </summary>
        public static string OrderBy = " Order By ID Desc";


        /// <summary>
        /// 新增校验数据是否正确
        /// </summary>
        /// <returns>true为成功，若失败，可以在Error_Info中查到</returns>
        public virtual bool InsertVerify()
        {
            return false;
        }



        /// <summary>
        /// 更新校验数据是否正确
        /// </summary>
        /// <returns>true为成功，若失败，可以在Error_Info中查到</returns>
        public virtual bool UpdateVerify()
        {
            return true;
        }

        /// <summary>
        /// 删除数据时，检验是否可以删除
        /// </summary>
        /// <returns></returns>
        public virtual bool DeleteVerify()
        {
            return true;
        }


        /// <summary>
        /// 取得当前对象对应数据库的字段以及值
        /// </summary>
        /// <returns>返回列表：每个列表的值为一个字典，key为字段名，Value为保存的值</returns>
        private List<KeyValuePair<string, dynamic>> GetFieldsAndValues()
        {
            List<KeyValuePair<string, dynamic>> list = new List<KeyValuePair<string, dynamic>>();
            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                string field = GetFieldName(info);
                if (field != null && field != "")
                {
                    KeyValuePair<string, dynamic> kp = new KeyValuePair<string, dynamic>(GetFieldName(info), info.GetValue(this, null));
                    list.Add(kp);
                }
            }
            return list;
        }


        /// <summary>
        /// 取得属性对应的表的字段
        /// </summary>
        /// <param name="info">实体类的每个PropertyInfo</param>
        /// <returns>该属性对应的字段</returns>
        private string GetFieldName(PropertyInfo info)
        {
            string name = "";
            foreach (Attribute attr in info.GetCustomAttributes(false))
            {
                if (attr is Field)
                {
                    Field a = (Field)attr;
                    name = a.Name;
                }
            }
            return name;
        }


        /// <summary>
        /// 取得类对应的表名
        /// </summary>
        /// <returns>对应的表名，没有找到为空</returns>
        public static string GetTableName(Type t)
        {
            string name = "";
            foreach (Attribute attr in t.GetCustomAttributes(false))
            {
                if (attr is Table)
                {
                    Table a = (Table)attr;
                    name = a.Name;
                }
            }
            return name;
        }


        /// <summary>
        /// 保存当前的实体类,有事务支持
        /// </summary>
        /// <returns>保存成功为真，否则出错原因可在Error_Info中找到</returns>
        public bool Save(bool hasTrans = false)
        {
            if (this.ID > 0)
                return Update(hasTrans);
            else
                return Insert(hasTrans);
        }


        ///// <summary>
        ///// 保存当前的实体类,无事务支持
        ///// </summary>
        ///// <returns>保存成功为真，否则出错原因可在Error_Info中找到</returns>
        //public bool SaveNoTrans(SqlTransaction trans = null)
        //{
        //    if (this.ID > 0)
        //        return UpdateNoTrans(trans);
        //    else
        //        return Insert(false);
        //}


        //public virtual bool InsertNoTrans(SqlTransaction trans = null)
        //{
        //    return true;
        //}

        /// <summary>
        /// 拥有事务的新增
        /// </summary>
        /// <returns>成功与否</returns>
        //public virtual bool Insert()
        //{
        //    //插入前校验
        //    if (!InsertVerify())
        //        return false;

        //    SqlTransaction trans = null;
        //    try
        //    {
        //        using (trans = DBConnection.BeginTrans())
        //        {
        //            //bool blnOK = this.InsertNoTrans();
        //            trans.Commit();
        //            return true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        if (trans != null)
        //            trans.Rollback();

        //        string msg = string.Format("在新增数据时出错，请与供应商联系，取得支持，错误原因： {0}{1}", Environment.NewLine, e.Message);
        //        throw new DBException(msg, e);
        //    }
        //}


        /// <summary>
        /// 插入新的实体类
        /// 这个方法不做事务处理
        /// </summary>
        /// <returns>成功为真</returns>
        public virtual bool Insert(bool hasTrans = false)
        {
            // 插入前校验
            if (!InsertVerify())
                return false;

            try
            {
                // 生成插入的SQL语句
                List<KeyValuePair<string, dynamic>> list_fv = GetFieldsAndValues();
                SqlCommand cmd = DBConnection.getCommand();

                string table_name = GetTableName(typeof(T));
                string sql = "Insert into " + table_name;
                string fields = "";
                string values = "";

                foreach (KeyValuePair<string, dynamic> item in list_fv)
                {
                    switch (item.Key.ToUpper())
                    {
                        case "ID":  // 不处理,会自动生成！
                            break;
                        case "CREATED_DATE":
                        case "UPDATED_DATE":
                            fields += item.Key + ",";
                            values += String.Format("@{0},", item.Key);
                            cmd.Parameters.AddWithValue("@" + item.Key, DateTime.Now);
                            break;
                        default:
                            if (item.Value != null)
                            {
                                fields += item.Key + ",";
                                values += String.Format("@{0},", item.Key);
                                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                            }
                            break;
                    }
                }
                sql += String.Format("({0}) ", fields.Substring(0, fields.Length - 1));
                sql += String.Format(" values({0})", values.Substring(0, values.Length - 1));
                sql += "; select @@identity ";

                // 如果不在一个事务里面，就开启一个事务
                if (!hasTrans)
                    DBConnection.BeginTrans();  // 开始一个事务
                
                cmd.CommandText = sql;
                cmd.Transaction = DBConnection.Transaction;
                this.ID = long.Parse(cmd.ExecuteScalar().ToString());

                // 提交事务
                if (!hasTrans)
                    DBConnection.CommitTrans();

                return true;
            }
            catch (Exception e)
            {
                // 如果是发起事务的函数，则需要回滚事务
                if (!hasTrans)
                    DBConnection.RollbackTrans();

                string msg = string.Format("在新增数据时出错，请与供应商联系，取得支持，错误原因： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        /// <summary>
        /// 更新实体类
        /// 注意，校验应由客户端调用，更新里不会去调用
        /// 无事务支持
        /// </summary>
        /// <returns>true 为成功</returns>
        public virtual bool Update(bool hasTrans = false)
        {
            if (!UpdateVerify())
                return false;

            try
            {
                List<KeyValuePair<string, dynamic>> list_fv = GetFieldsAndValues();
                SqlCommand cmd = DBConnection.getCommand();

                string table_name = GetTableName(typeof(T));
                string sql = "Update " + table_name;
                string sets = "";
                foreach (KeyValuePair<string, dynamic> item in list_fv)
                {
                    switch (item.Key.ToUpper())
                    {
                        case "ID":  // 不处理
                        case "CREATED_DATE":
                            break;
                        case "UPDATED_DATE":
                            sets += String.Format("{0}= @{0},", item.Key);
                            cmd.Parameters.AddWithValue("@" + item.Key, DateTime.Now);
                            break;
                        default:
                            if (item.Value != null)
                            {
                                sets += String.Format("{0}= @{0},", item.Key);
                                cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                            }
                            break;
                    }
                }


                sql += " Set " + sets.Substring(0, sets.Length - 1);
                // 加上条件
                sql += " Where id = @id";
                cmd.Parameters.AddWithValue("@id", this.ID);

                if (!hasTrans)
                    DBConnection.BeginTrans();
                
                cmd.Transaction = DBConnection.Transaction;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                if (!hasTrans)
                    DBConnection.CommitTrans();

                return true;
            }
            catch (Exception e)
            {

                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("更新数据时出错，请与供应商联系，取得支持！错误原因：{0}{1}",
                    Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        /// <summary>
        /// 删除实体类,这个只能删除一个实体类，如果要删除含明细的实体类，请使用Destory方法
        /// 静态调用,此调用不会判断是否可以删除，需要调用者已经调用判断
        /// 事务支持
        /// </summary>
        /// <param name="id">需要删除实体类的ID</param>
        public static bool Delete(long id)
        {
            try
            {
                DBConnection.BeginTrans();

                string table_name = GetTableName(typeof(T));
                string sql = String.Format("Delete from {0} where id = {1}", table_name, id);

                SqlCommand cmd = DBConnection.getCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                DBConnection.CommitTrans();
                return true;
            }
            catch (Exception e)
            {
                if (DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("删除数据出错，原因如下：", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }



        /// <summary>
        /// 删除实体类
        /// 实例调用
        /// </summary>
        public virtual bool Destory(bool hasTrans = false)
        {
            try
            {
                string table_name = GetTableName(typeof(T));
                string sql = String.Format("Delete from {0} where id = {1}", table_name, this.ID);

                SqlCommand cmd = DBConnection.getCommand();
                if (!hasTrans)
                    DBConnection.BeginTrans();

                cmd.Transaction = DBConnection.Transaction;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                if (!hasTrans)
                    DB.DBConnection.CommitTrans();

                return true;
            }
            catch (Exception e)
            {

                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("删除数据出错，原因如下：", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        /// <summary>
        /// 查找符合条件的实体类
        /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
        /// 必须是实例类调用
        /// </summary>
        /// <param name="where"> 除去where以外的where子句</param>
        /// <returns>含实体类的列表</returns>
        public virtual List<T> Find(string where = "")
        {
            try
            {
                string table_name = GetTableName(typeof(T));
                string sql = string.Format("Select * from {0}", table_name);

                // 生成SQL语句
                SqlCommand cmd = DBConnection.getCommand();
                if (where.Length > 0)
                {
                    if (!ShowDeleteRecord)
                        sql += String.Format(" where {0} and deleted = 0 ", where);
                    else
                        sql += " where " + where;
                }
                else
                {
                    if (!ShowDeleteRecord)
                        sql += " where deleted = 0 ";
                }

                // 按生成的ID降序排列
                sql += " " + OrderBy;


                cmd.CommandText = sql;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds.toList<T>();
            }
            catch (Exception e)
            {
                string msg = string.Format("查找数据时出错，请与供应商联系，取得支持！错误原因：{0}{1}",
                        Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        /// <summary>
        /// 查找符合条件的实体类
        /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
        /// 静态调用
        /// </summary>
        /// <param name="where"> 除去where以外的where子句</param>
        /// <returns>含实体类的列表</returns>
        public static List<T> Query(string where = "")
        {
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;
            //List<string> whereList = new List<string>();

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += String.Format(" where {0} and deleted = 0", where);
                else
                    sql += " where " + where;
            }
            else
            {
                if (!ShowDeleteRecord)
                    sql += " where deleted = 0";
            }

            // 按生成的ID降序排列
            sql += " " + OrderBy;

            try
            {
                SqlCommand cmd = DBConnection.getCommand();
                cmd.CommandText = sql;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                return ds.toList<T>();
            }
            catch (Exception e)
            {
                string message = String.Format("向数据库查询出错！原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new DBException(message, e);
            }
        }



        /// <summary>
        /// 通过ID生成实体类
        /// </summary>
        /// <param name="id">实体ID</param>
        /// <returns>该ID对应的实体类</returns>
        public static T CreateByID(long id)
        {
            string table_name = GetTableName(typeof(T));
            string sql = String.Format("Select * from {0} where id = {1}", table_name, id);

            try
            {
                SqlCommand cmd = DBConnection.getCommand();
                cmd.CommandText = sql;

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                List<T> list = ds.toList<T>();
                if (list.Count == 1)
                    return list[0];
                else
                    return default(T);
            }
            catch (Exception e)
            {
                string msg = string.Format("生成实体类出错，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }
    }
}
