using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

using Haimen.Entity;

namespace Haimen.Entity
{
    // 用户类
    [Table("m_user")]
    public class User : BaseEntity
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("name")]
        public string Name { get; set; }

        [Field("salt")]
        public string Salt { get; set; }
    }
}
