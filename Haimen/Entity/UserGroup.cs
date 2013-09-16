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
        [Field("code")]
        public long Code { get; set; }

        [Field("name")]
        public string Name { get; set; }
    }
}
