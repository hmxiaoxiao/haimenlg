using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    /// <summary>
    /// 资金性质
    /// </summary>
    [Table("m_funds")]
    public class Funds : MEntityFunction<Funds>
    {
        [Field("name")]
        public string Name { get; set; }

        [Field("parent_id")]
        public long ParentID { get; set; }

        public bool CanDelete(long id)
        {
            Error_Info.Clear();
            if (AccountDetail.Query("funds_id = " + id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除资金性质","该性质已经被资金单据中引用，不能删除！"));
                return false;
            }
            return true;
        }

        //  取得下级的资金性质
        public List<Funds> GetChildren()
        {
            return Funds.Query("parent_id = " + ID.ToString());
        }

        // 校验
        public override bool Verify()
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
                    list = Funds.Query("name ='" + Name + "' and ID <> " + ID.ToString());
                else
                    list = Funds.Query("name = '" + Name + "'");

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
