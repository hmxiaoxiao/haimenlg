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
    }
}
