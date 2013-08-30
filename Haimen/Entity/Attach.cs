using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_attach")]
    public class Attach : MEntityFunction<Attach>
    {
        [Field("parent_id")]
        public long Parent_ID { get; set; }

        [Field("filename")]
        public string FileName { get; set; }

        [Field("filetype")]
        public string FileType { get; set; }
    }
}
