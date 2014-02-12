using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using System.Data;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    /// <summary>
    /// 资金性质
    /// </summary>
    [Table("m_funds")]
    public class Funds : SingleEntity<Funds>
    {
        /// <summary>
        /// 资金性质名称 
        /// </summary>
        [Field("name")]
        public string Name { get; set; }


        /// <summary>
        /// 上级资金性质ID
        /// </summary>
        private long m_parentid;
        [Field("parent_id")]
        public long ParentID
        { 
            get
            {
                return m_parentid;   
            }
            set
            {
                if (value > 0)
                {
                    Parent= Funds.CreateByID(value);
                    FullName = String.Format("{0} - {1}", Parent.FullName, Name);
                }
                else
                {
                    FullName = this.Name;
                }
                m_parentid = value;
            } 
        }

        public Funds Parent { get; set; }
        public string FullName { get; set; }        // ??


        /// <summary>
        ///  删除校验
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            Error_Info.Clear();
            if (AccountDetail.Query("funds_id = " + ID.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除资金性质","该性质已经被资金单据中引用，不能删除！"));
                return false;
            }
            return true;
        }

        /// <summary>
        /// 取得下级的资金性质
        /// </summary>
        /// <returns></returns>
        public List<Funds> GetChildren()
        {
            return Funds.Query("parent_id = " + ID.ToString());
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        public override bool SaveVerify()
        {
            Error_Info.Clear();

            string err = "";
            List<Funds> list;
            if (string.IsNullOrEmpty(Name))
            {
                err = "名称不能为空，请填入!";
            }
            else
            {
                if (ID > 0)
                    list = Funds.Query(String.Format("name ='{0}' and ID <> {1}", Name, ID));
                else
                    list = Funds.Query(String.Format("name = '{0}'", Name));

                if (list.Count > 0)
                    err = "您输入的名称已经存在，请检查后重新输入";
            }
            if (err.Length > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", err));

            err = "";
            if (ParentID > 0)
            {
                if (Funds.CreateByID(ParentID) == null)
                    err = "您选择的父资金性质已经被删除，请重新选择！";
            }
            if (err.Length > 0)
                Error_Info.Add(new KeyValuePair<string, string>("ParentID", err));


            return Error_Info.Count == 0;
        }



        ////  显示假的主从关系
        //public static List<Funds> GetLevel()
        //{
        //    string sql1 = "parent_id = 0";
        //    string sql2 = "parent_id in (select id from m_funds where parent_id = 0)";
        //    string sql3 = "parent_id in (Select id from m_funds where parent_id in (select id from m_funds where parent_id = 0))";
        //    List<Funds> level1 = Funds.Query(sql1);
        //    List<Funds> level2 = Funds.Query(sql2);
        //    List<Funds> level3 = Funds.Query(sql3);

        //    List<Funds> list = new List<Funds>();
        //    foreach (Funds f1 in level1)
        //    {
        //        Funds a1 = new Funds();
        //        a1.ID = f1.ID;
        //        a1.Name = f1.Name;
        //        list.Add(a1);
        //        foreach (Funds f2 in level2)
        //        {
        //            if (f2.ParentID == f1.ID)
        //            {
        //                Funds a2 = new Funds();
        //                a2.ID = f2.ID;
        //                a2.Name = "    " + f2.Name;
        //                list.Add(a2);
        //                foreach (Funds f3 in level3)
        //                {
        //                    if (f3.ParentID == f2.ID)
        //                    {
        //                        Funds a3 = new Funds();
        //                        a3.ID = f3.ID;
        //                        a3.Name = "        " + f3.Name;
        //                        list.Add(a3);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return list;
        //}

        ///// <summary>
        ///// 显示主从，不是我想要的。
        ///// </summary>
        ///// <returns></returns>
        //public static DataSet GetLevel_NoUsed()
        //{
        //    string sql1 = "select * from m_funds where parent_id = 0;";
        //    string sql2 = "Select * from m_funds where parent_id in (select id from m_funds where parent_id = 0);";
        //    string sql3 = "Select * from m_funds where parent_id in (Select id from m_funds where parent_id in (select id from m_funds where parent_id = 0));";

        //    SqlDataAdapter d1 = new SqlDataAdapter(sql1, DBConnection.Connection);
        //    SqlDataAdapter d2 = new SqlDataAdapter(sql2, DBConnection.Connection);
        //    SqlDataAdapter d3 = new SqlDataAdapter(sql3, DBConnection.Connection);

        //    DataSet ds = new DataSet();
        //    d1.Fill(ds, "one");
        //    d2.Fill(ds, "two");
        //    d3.Fill(ds, "three");

        //    DataRelation dr1 = new DataRelation("level1", ds.Tables["one"].Columns["id"], ds.Tables["two"].Columns["parent_id"]);
        //    DataRelation dr2 = new DataRelation("level2", ds.Tables["two"].Columns["id"], ds.Tables["three"].Columns["parent_id"]);

        //    ds.Relations.Add(dr1);
        //    ds.Relations.Add(dr2);
        //    return ds;
        //}
    }
}
