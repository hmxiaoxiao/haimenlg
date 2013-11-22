using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Reflection;
using System.Data.SqlClient;
using System.Transactions;

using Haimen.Qy;

namespace Haimen.Qy
{
    [Serializable]
    public class MEntityFunction<T> where T : new()
    {
        /// <summary>
        /// 每个实体类都有的ID值
        /// </summary>
        [Field("id")]
        public long ID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Field("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Field("updated_date")]
        public DateTime UpdatedDate { get; set; }


        /// <summary>
        /// 删除标记，0 为正常，1为删除
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
        /// 是否显示已经打上删除标记的记录
        /// </summary>
        public static bool ShowDeleteRecord = false;

        /// <summary>
        /// 当前对象指定的排序字段
        /// 默认是后增加的在前面
        /// </summary>
        public static string OrderBy = " Order By ID Desc";

        /// <summary>
        /// 保存到数据时，校验数据是否正确
        /// 注意无论是新增还是修改，都视为保存。
        /// </summary>
        /// <returns>true为成功，若失败，可以在Error_Info中查到</returns>
        public virtual bool Verify()
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
        /// 保存当前的实体类
        /// </summary>
        /// <returns>保存成功为真，否则出错原因可在Error_Info中找到</returns>
        public bool Save()
        {
            if (this.ID > 0)
                return Update();
            else
                return Insert();
        }

        /// <summary>
        /// 插入新的实体类
        /// 注意，校验由客户端处理，这里不做校验
        /// </summary>
        /// <returns>成功为真</returns>
        public virtual bool Insert()
        {
            // 清空错误信息
            Error_Info.Clear();


            // 生成插入的SQL语句
            List<KeyValuePair<string, dynamic>> list_fv = GetFieldsAndValues();
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
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

            using (TransactionScope ts = new TransactionScope())
            {
                cmd.CommandText = sql;
                this.ID = long.Parse(cmd.ExecuteScalar().ToString());

                ts.Complete();
            }
            return true;
        }

        /// <summary>
        /// 更新实体类
        /// 注意，校验应由客户端调用，更新里不会去调用
        /// </summary>
        /// <returns>true 为成功</returns>
        public virtual bool Update()
        {
            List<KeyValuePair<string, dynamic>> list_fv = GetFieldsAndValues();
            SqlCommand cmd = DBFunction.Connection.CreateCommand();

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

                using (TransactionScope ts = new TransactionScope())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    ts.Complete();
                }

            }
            return true;
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
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += " where " + where + " and deleted = 0 ";
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

        /// <summary>
        /// 查找符合条件的实体类
        /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
        /// 静态调用
        /// </summary>
        /// <param name="where"> 除去where以外的where子句</param>
        /// <returns>含实体类的列表</returns>
        public static List<T> Query(string where = "")
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += " where " + where + " and deleted = 0";
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


            cmd.CommandText = sql;
            Console.WriteLine(sql);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            return ds.toList<T>();
        }

        /// <summary>
        /// 删除实体类,这个只能删除一个实体类，如果要删除含明细的实体类，请使用Destory方法
        /// 静态调用,此调用不会判断是否可以删除，需要调用者已经调用判断
        /// </summary>
        /// <param name="id">需要删除实体类的ID</param>
        public static void Delete(long id)
        {


            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Delete from " + table_name + " where id = " + id.ToString();

            using (TransactionScope ts = new TransactionScope())
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                ts.Complete();
            }
        }

        /// <summary>
        /// 删除实体类
        /// 实例调用
        /// </summary>
        public virtual void Destory()
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Delete from " + table_name + " where id = " + this.ID.ToString();

            using (TransactionScope ts = new TransactionScope())
            {
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                ts.Complete();
            }
        }

        /// <summary>
        /// 通过ID生成实体类
        /// </summary>
        /// <param name="id">实体ID</param>
        /// <returns>该ID对应的实体类</returns>
        public static T CreateByID(long id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

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
