//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

////using MySql.Data;
////using MySql.Data.MySqlClient;
//using System.Data.SqlClient;
//using System.Reflection;
//using System.Diagnostics;
//using System.Data;

//namespace Haimen.Entity
//{
//    /// <summary>
//    /// 实体类的基础类，实现增加，删除，保存，查询等功能
//    /// </summary>
//    public class DBFactory
//    {
//        // 数据库联接
//        private static SqlConnection m_conn;
//        public static SqlConnection Connection 
//        { 
//            get
//            { 
//                return getConnection(); 
//            } 
//        }

//        // 生成一个查询对象
//        // 为了防止查询中0判断是输入，还是未输入，故特意加入此生成对象
//        // 该对象中可以用MinValue的都用了MinValue.
//        public static T CreateQueryEntity<T>() where T : BaseEntity, new()
//        {
//            T t = new T();
//            foreach (PropertyInfo info in t.GetType().GetProperties())
//            {
//                if (info.PropertyType == typeof(DateTime))
//                {
//                    info.SetValue(t, System.Data.SqlTypes.SqlDateTime.MinValue.Value, null);
//                }
//                else
//                {
//                    FieldInfo fi = info.PropertyType.GetField("MinValue");
//                    if (fi != null)
//                    {
//                        info.SetValue(t, fi.GetValue(null), null);
//                    }
//                }
//            }
//            return t;
//        }


//        // 返回当前对象对应数据库的字段以及值
//        private static List<KeyValuePair<string,dynamic>> getFieldsAndValues<T>(T t)
//        {
//            List<KeyValuePair<string, dynamic>> list = new List<KeyValuePair<string, dynamic>>();
//            foreach (PropertyInfo info in t.GetType().GetProperties())
//            {
//                string field = GetFieldName(info);
//                if (field != null && field != "")
//                {
//                    KeyValuePair<string, dynamic> kp = new KeyValuePair<string, dynamic>(GetFieldName(info), info.GetValue(t, null));
//                    list.Add(kp);
//                }
//            }
//            return list;
//        }


//        // 返回查询对象里面设置的值
//        private static List<KeyValuePair<string, dynamic>> getQueryFieldsAndValues<T>(T t) where T : new()
//        {
//            // 循环每个字段
//            List<KeyValuePair<string, dynamic>> list = new List<KeyValuePair<string, dynamic>>();
//            foreach (PropertyInfo info in t.GetType().GetProperties())
//            {
//                FieldInfo fi = info.PropertyType.GetField("MinValue");
//                if (info.PropertyType == typeof(DateTime))
//                {
//                    if (info.GetValue(t, null) != null && info.GetValue(t, null).ToString() != System.Data.SqlTypes.SqlDateTime.MinValue.ToSqlString())
//                    {
//                        KeyValuePair<string, dynamic> kp = new KeyValuePair<string, dynamic>(GetFieldName(info), info.GetValue(t, null));
//                        list.Add(kp);
//                    }
//                }
//                else
//                {
//                    if (fi != null && info.GetValue(t, null).ToString() != fi.GetValue(null).ToString())
//                    {
//                        KeyValuePair<string, dynamic> kp = new KeyValuePair<string, dynamic>(GetFieldName(info), info.GetValue(t, null));
//                        list.Add(kp);
//                    }
//                    if (fi == null && info.GetValue(t, null) != null)
//                    {
//                        KeyValuePair<string, dynamic> kp = new KeyValuePair<string, dynamic>(GetFieldName(info), info.GetValue(t, null));
//                        list.Add(kp);
//                    }
//                }
//            }
//            return list;
//        }

//        // 创建保存
//        public static long Save<T>(T t) where T : BaseEntity
//        {
//            if (!t.BeforeSave())
//                return 0;

//            List<KeyValuePair<string, dynamic>> list_fv = getFieldsAndValues(t);
//            SqlCommand cmd = Connection.CreateCommand();

//            string table_name = GetTableName(typeof(T));
//            string sql = "Insert into " + table_name;
//            string fields = "";
//            string values = "";

//            foreach(KeyValuePair<string,dynamic> item in list_fv)
//            {
//                switch (item.Key.ToUpper())
//                {
//                    case "ID":  // 不处理,会自动生成！
//                        break;
//                    case "CREATED_DATE":
//                    case "UPDATED_DATE":
//                        fields += item.Key + ",";
//                        values += "@" + item.Key + ",";
//                        cmd.Parameters.AddWithValue("@" + item.Key, DateTime.Now);
//                        break;
//                    default:
//                        if (item.Value != null)
//                        {
//                            fields += item.Key + ",";
//                            values += "@" + item.Key + ",";
//                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
//                        }
//                        break;
//                }
//            }

//            if (fields.Length > 0)
//            {
//                sql += "(" + fields.Substring(0, fields.Length - 1) + ") ";
//                sql += " values(" + values.Substring(0, values.Length - 1) + ")";
//                sql += "; select @@identity "; 
                
//                cmd.CommandText = sql;
//                Console.WriteLine(sql);
//                SqlTransaction trans = Connection.BeginTransaction();
//                cmd.Transaction = trans;
//                long id = long.Parse(cmd.ExecuteScalar().ToString());
//                trans.Commit();
//                return id;
//            }
//            else
//            {
//                return 0;
//            }
//        }


//        // 更新某对象
//        public static void Update<T>(T t) where T : BaseEntity
//        {
//            if (! t.BeforeUpdate())
//                return;

//            List<KeyValuePair<string, dynamic>> list_fv = getFieldsAndValues(t);
//            SqlCommand cmd = Connection.CreateCommand();

//            string table_name = GetTableName(typeof(T));
//            string sql = "Update " + table_name;
//            string sets = "";
//            foreach (KeyValuePair<string, dynamic> item in list_fv)
//            {
//                switch (item.Key.ToUpper())
//                {
//                    case "ID":  // 不处理
//                    case "CREATED_DATE":
//                        break;
//                    case "UPDATED_DATE":
//                        sets += item.Key + "= @" + item.Key + ",";
//                        cmd.Parameters.AddWithValue("@" + item.Key, DateTime.Now);
//                        break;
//                    default:
//                        if (item.Value != null)
//                        {
//                            sets += item.Key + "= @" + item.Key + ",";
//                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
//                        }
//                        break;
//                }
//            }

//            if (sets.Length > 0)
//            {
//                sql += " Set " + sets.Substring(0, sets.Length - 1);
//                // 加上条件
//                sql += " Where id = @id";
//                cmd.Parameters.AddWithValue("@id",t.ID);
//                cmd.CommandText = sql;

//                Console.WriteLine(sql);
//                SqlTransaction trans = Connection.BeginTransaction();
//                cmd.Transaction = trans;
//                cmd.ExecuteNonQuery();
//                trans.Commit();
//            }
//        }


//        // 删除数据库对象, 必须是真实存在的对象
//        public static void Delete<T>(T t) where T : BaseEntity
//        {
//            if (! t.BeforeDelete())
//                return;

//            string table_name = GetTableName(typeof(User));


//            string sql = "Delete from " + table_name + " where id = @id";
//            Console.WriteLine(sql);
//            SqlCommand cmd = Connection.CreateCommand();
//            cmd.CommandText = sql;
//            cmd.Parameters.AddWithValue("@id", t.ID);
//            SqlTransaction trans = Connection.BeginTransaction();
//            cmd.Transaction = trans;
//            cmd.ExecuteNonQuery();
//            trans.Commit();

//        }

//        /// <summary>
//        /// 生成查询的command
//        /// 这里如果范围查询里面，只出现一个字段的话，就不能判断是等于还是大于（小于），这里都当成大于（小于操作来进行的）
//        /// </summary>
//        /// <param name="from"></param>
//        /// <param name="to"></param>
//        /// <returns></returns>
//        public static DataSet Query<T>(T from = null, T to = null) where T : BaseEntity, new()
//        {
//            SqlCommand cmd = Connection.CreateCommand();
//            string table_name = GetTableName(typeof(T));

//            string sql = "Select * from " + table_name;
//            List<string> whereList = new List<string>();

//            // 如果是单条件查询
//            if (to == null && from != null)
//            {
//                List<KeyValuePair<string, dynamic>> list = getQueryFieldsAndValues(from);
//                foreach (KeyValuePair<string, dynamic> kp in list)
//                {
//                    whereList.Add(kp.Key + " = @" + kp.Key);
//                    cmd.Parameters.AddWithValue("@" + kp.Key, kp.Value);
//                }
//            }

//            // 范围查询
//            if (to != null && from != null)
//            {
//                List<KeyValuePair<string, dynamic>> list_from = getQueryFieldsAndValues(from);
//                List<KeyValuePair<string, dynamic>> list_to = getQueryFieldsAndValues(to); ;

//                foreach (KeyValuePair<string, dynamic> kp in list_from)
//                {
//                    whereList.Add(kp.Key + " >= @" + kp.Key);
//                    cmd.Parameters.AddWithValue("@" + kp.Key, kp.Value);
//                }

//                foreach (KeyValuePair<string, dynamic> kp in list_to)
//                {
//                    whereList.Add(kp.Key + " <= @" + kp.Key);
//                    cmd.Parameters.AddWithValue("@" + kp.Key, kp.Value);
//                }
//            }


//            // 生成SQL语句
//            string where = "";
//            foreach (string item in whereList)
//            {
//                where += item + " and ";
//            }
//            // 把后面的and去掉
//            if (where.Length > 0)
//            {
//                where = where.Substring(0, where.Length - 4);
//                sql += " where " + where;
//            }

//            cmd.CommandText = sql;
//            Console.WriteLine(sql);
//            SqlDataAdapter adap = new SqlDataAdapter(cmd);
//            DataSet ds = new DataSet();
//            adap.Fill(ds); 
//            return ds;
//        }



//        /// <summary>
//        /// 取得属性对应的表的字段
//        /// </summary>
//        /// <param name="info"></param>
//        /// <returns></returns>
//        public static string GetFieldName(PropertyInfo info)
//        {
//            string name = "";
//            foreach (Attribute attr in info.GetCustomAttributes(false))
//            {
//                if (attr is Field)
//                {
//                    Field a = (Field)attr;
//                    name = a.Name;
//                }
//            }
//            return name;
//        }

//        /// <summary>
//        /// 取得类对应的表名
//        /// </summary>
//        /// <param name="t">类的typeof</param>
//        /// <returns>对应的表名，没有找到为空</returns>
//        public static string GetTableName(Type t)
//        {
//            string name = "";
//            foreach (Attribute attr in t.GetCustomAttributes(false))
//            {
//                if (attr is Table)
//                {
//                    Table a = (Table)attr;
//                    name = a.Name;
//                }
//            }
//            return name;
//        }


//        private static SqlConnection getConnection()
//        {
//            string connStr = @"Data Source=R400;Initial Catalog=haimen;User ID=sa;Password=heroes22";
//            if (m_conn == null)
//            {
//                m_conn = new SqlConnection(connStr);
//                m_conn.Open();
//            }
//            return m_conn;
//        }

//    }
//}
