using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;

namespace Haimen.Entity
{
    [Table("m_project")]
    public class Project : SingleEntity<Project>
    {
        [Field("name")]
        public string Name { get; set; }

        public bool CanDelete(long id)
        {
            Error_Info.Clear();
            if (Account.Query("project_id = " + id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除项目","该项目已经被资金单据引用，不能删除！"));
                return false;
            }

            if (Contract.Query("project_id = " + id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string,string>("删除项目","该项目已经被合同引用，不能删除！"));
                return false;
            }
            return true;
        }
    }
}
