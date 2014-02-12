using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.DB;

namespace Haimen.Entity
{
    /// <summary>
    /// 项目实体类
    /// </summary>
    [Table("m_project")]
    public class Project : SingleEntity<Project>
    {
        /// <summary>
        /// 项目名称
        /// </summary>
        [Field("name")]
        public string Name { get; set; }


        /// <summary>
        /// 删除校验
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            Error_Info.Clear();
            if (Account.Query("project_id = " + ID.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("删除项目", "该项目已经被资金单据引用，不能删除！"));
                return false;
            }

            if (Contract.Query("project_id = " + ID.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("删除项目", "该项目已经被合同引用，不能删除！"));
                return false;
            }
            return true;
        }
    }
}
