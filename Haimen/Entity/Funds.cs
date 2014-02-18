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
                Error_Info.Add(new KeyValuePair<string,string>("删除资金性质","该资金性质已经被资金单据中引用，不能删除！"));

            if(Funds.Query(string.Format("parent_id = {0}", ID)).Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("删除资金性质", "该资金性质已经有下级资金性质，不能删除！"));

            return Error_Info.Count == 0;
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
        public override bool InsertUpdateVerify()
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
    }
}
