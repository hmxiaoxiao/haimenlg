using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_funds")]
    public class Funds : EntityFunction<Funds>
    {
        [Field("name")]
        public string Name { get; set; }

        [Field("parent_id")]
        public long Parent_ID { get; set; }

        public List<Funds> GetChildren()
        {
            return Funds.Query("parent_id = " + ID.ToString());
        }
    }
}
