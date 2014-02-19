using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.DB;

namespace Haimen.Entity
{
    [Table("q_usergroup")]
    public class UserGroup : SingleEntity<UserGroup>
    {
        [Field("name")]
        public string Name { get; set; }

        /// <summary>
        /// 删除校验
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            Error_Info.Clear();

            if (Access.Query(string.Format("ugroup_id = {0}", ID)).Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("用户组", "该用户组已经被使用，无法删除"));

            return Error_Info.Count == 0;
        }

        public override bool InsertUpdateVerify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(Name))
                Error_Info.Add(new KeyValuePair<string, string>("Name", "用户组名称不可以为空"));

            List<Project> list;
            if (ID == 0)
                list = Project.Query(string.Format("name = '{0}'", Name));
            else
                list = Project.Query(string.Format("name = '{0}' and id <> {1}", Name, ID));
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", "用户组名称已经存在，请确认。"));

            return Error_Info.Count == 0;

        }
    }
}
