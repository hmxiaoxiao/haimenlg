using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("q_usergroup")]
    public class UserGroup : MEntityFunction<UserGroup>
    {
        [Field("name")]
        public string Name { get; set; }
    }
}
