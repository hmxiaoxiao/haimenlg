////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;

////using System.Data;
////using System.Data.SqlClient;

////namespace Haimen.Entity
////{
////    public class BaseEntity
////    {
////        // 创建时间
////        [Field("created_date")]
////        public DateTime CreateDate { get; set; }

////        // 更新时间
////        [Field("updated_date")]
////        public DateTime UpdateDate { get; set; }

////        // 表的ID
////        [Field("ID")]
////        public long ID { get; set; }

////        // 用来返回错误信息
////        // 字段放在key里面，错误信息value里面
////        public List<KeyValuePair<string, string>> Err_Info { get; set; }

////        public static List<T> Where<T>(string filter) where T: BaseEntity, new()
////        {
////            string table_name = DBFactory.GetTableName(typeof(T));
////            string sql = "Select * from " + table_name;
////            if (filter != null && filter != "")
////                sql += " where " + filter;

////            SqlCommand cmd = DBFactory.Connection.CreateCommand();
////            cmd.CommandText = sql;
////            SqlDataAdapter adap = new SqlDataAdapter(cmd);
////            DataSet ds = new DataSet();
////            adap.Fill(ds);

////            return ds.toList<T>();
////        }

////        public static T New<T>(int id) where T : BaseEntity, new()
////        {
////            List<T> list = new List<T>();

////            string table_name = DBFactory.GetTableName(typeof(T));
////            string sql = "Select * from " + table_name + " Where id = " + id.ToString();


////            SqlCommand cmd = DBFactory.Connection.CreateCommand();
////            cmd.CommandText = sql;
////            SqlDataAdapter adap = new SqlDataAdapter(cmd);
////            DataSet ds = new DataSet();
////            adap.Fill(ds);
////            if (ds.Tables[0].Rows.Count == 1)
////                return ds.toList<T>()[0];
////            else
////                return null;
////        }


////        virtual public bool BeforeSave()
////        {
////            return true;
////        }

////        virtual public bool BeforeUpdate()
////        {
////            return true;
////        }

////        virtual public bool BeforeDelete()
////        {
////            return true;
////        }
////    }
////}
