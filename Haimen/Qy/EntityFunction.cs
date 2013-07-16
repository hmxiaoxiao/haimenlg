using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Reflection;
using System.Data.SqlClient;

using Haimen.Qy;

namespace Haimen.Qy
{
    public class EntityFunction<T> where T : new()
    {
        [Field("id")]
        public long ID { get; set; }

        [Field("created_date")]
        public DateTime CreatedDate { get; set; }

        [Field("Updated_date")]
        public DateTime UpdatedDate { get; set; }


        // 保存错误信息
        public List<KeyValuePair<string, string>> Error_Info = new List<KeyValuePair<string, string>>();

        // 保存时校验
        public virtual bool Verify()
        {
            return true;
        }

        // 返回当前对象对应数据库的字段以及值
        private List<KeyValuePair<string, dynamic>> getFieldsAndValues()
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
        /// <param name="info"></param>
        /// <returns></returns>
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
        /// <param name="t">类的typeof</param>
        /// <returns>对应的表名，没有找到为空</returns>
        private static string GetTableName()
        {
            string name = "";
            foreach (Attribute attr in typeof(T).GetCustomAttributes(false))
            {
                if (attr is Table)
                {
                    Table a = (Table)attr;
                    name = a.Name;
                }
            }
            return name;
        }

        public void Save(bool hasTrans = false, bool needVerify = true)
        {
            if (this.ID > 0)
                Update();
            else
                Insert();
        }

        public void Insert(bool hasTrans = false, bool needVerify = true)
        {
            if (needVerify && !Verify())
                return;

            List<KeyValuePair<string, dynamic>> list_fv = getFieldsAndValues();
            SqlCommand cmd = DBFunction.Connection.CreateCommand();

            string table_name = GetTableName();
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
                        values += "@" + item.Key + ",";
                        cmd.Parameters.AddWithValue("@" + item.Key, DateTime.Now);
                        break;
                    default:
                        if (item.Value != null)
                        {
                            fields += item.Key + ",";
                            values += "@" + item.Key + ",";
                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                        }
                        break;
                }
            }


            sql += "(" + fields.Substring(0, fields.Length - 1) + ") ";
            sql += " values(" + values.Substring(0, values.Length - 1) + ")";
            sql += "; select @@identity ";

            cmd.CommandText = sql;
            Console.WriteLine(sql);
            SqlTransaction trans = DBFunction.Connection.BeginTransaction();
            cmd.Transaction = trans;
            this.ID = long.Parse(cmd.ExecuteScalar().ToString());
            trans.Commit();
        }

        public void Update(bool hasTrans = false, bool needVerify = true)
        {
            if (needVerify && !Verify())
                return;

            List<KeyValuePair<string, dynamic>> list_fv = getFieldsAndValues();
            SqlCommand cmd = DBFunction.Connection.CreateCommand();

            string table_name = GetTableName();
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
                        sets += item.Key + "= @" + item.Key + ",";
                        cmd.Parameters.AddWithValue("@" + item.Key, DateTime.Now);
                        break;
                    default:
                        if (item.Value != null)
                        {
                            sets += item.Key + "= @" + item.Key + ",";
                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                        }
                        break;
                }
            }

            if (sets.Length > 0)
            {
                sql += " Set " + sets.Substring(0, sets.Length - 1);
                // 加上条件
                sql += " Where id = @id";
                cmd.Parameters.AddWithValue("@id", this.ID);
                cmd.CommandText = sql;

                Console.WriteLine(sql);
                SqlTransaction trans = DBFunction.Connection.BeginTransaction();
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                trans.Commit();
            }
        }

        public static List<T> Query(string where = "")
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName();

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();



            // 生成SQL语句
            if (where.Length > 0)
                sql += " where " + where;

            cmd.CommandText = sql;
            Console.WriteLine(sql);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds.toList<T>();
        }

        public static void Delete(long id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName();

            string sql = "Delete from " + table_name + " where id = " + id.ToString();
            SqlTransaction trans = DBFunction.Connection.BeginTransaction();
            cmd.Transaction = trans;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            trans.Commit();
        }

        public static T CreateByID( long id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName();

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();

            sql += " where id = " + id.ToString();

            cmd.CommandText = sql;
            Console.WriteLine(sql);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            List<T> list = ds.toList<T>();
            if (list.Count == 1)
                return list[0];
            else
                return default(T);
        }
    }
}
