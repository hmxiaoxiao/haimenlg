using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_dict")]
    public class Dict : MEntityFunction<Dict>
    {
        [Field("name")]
        public string Name { get; set; }

        [Field("value_int")]
        public long ValueInt { get; set; }

        [Field("value_string")]
        public string ValueString { get; set; }

        [Field("belong")]
        public string Belong { get; set; }
    }
}
