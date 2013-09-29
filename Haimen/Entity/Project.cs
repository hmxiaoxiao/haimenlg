using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_project")]
    public class Project : MEntityFunction<Project>
    {
        [Field("name")]
        public string Name { get; set; }
    }
}
