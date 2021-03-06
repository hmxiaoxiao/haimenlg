﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using Haimen.Helper;

namespace Haimen.Entity
{
    [Table("m_attach")]
    public class Attach : SingleEntity<Attach>
    {
        [Field("parent_id")]
        public long ParentID { get; set; }

        [Field("filename")]
        public string FileName { get; set; }

        [Field("filetype")]
        public string FileType { get; set; }


        public override bool DeleteVerify()
        {
            return true;
        }


        public override bool InsertUpdateVerify()
        {
            return true;
        }
    }
}
