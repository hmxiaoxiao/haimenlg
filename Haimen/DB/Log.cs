using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

namespace Haimen.DB
{
    [Table("m_log")]
    public class Log 
    {
        //[Field("oper_date")]
        //public string OperDate { get; set; }

        //[Field("model_name")]
        //public string ModelName { get; set; }

        //[Field("user_name")]
        //public string UserName { get; set; }

        //[Field("oper")]
        //public string Oper { get; set; }

        //[Field("object")]
        //public string OperObject { get; set; }

        //public override bool InsertUpdateVerify()
        //{
        //    return true;
        //}

        public static void log(Object a, string user_name, string oper)
        {
            try
            {
                SqlCommand com = DBConnection.getCommand();
                string sql = string.Format(@"Insert into m_log(oper_date, model_name, user_name, oper, object,deleted,created_date, updated_date) 
                                                    values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}');",
                              DateTime.Now.ToString(),
                              a.GetType().ToString(),
                              user_name,
                              oper,
                              a.ToString(),
                              0,
                              DateTime.Now.ToString(),
                              DateTime.Now.ToString());
                com.CommandText = sql;
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
