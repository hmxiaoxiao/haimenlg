using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_contract_attach")]
    public class ContractAttach : EntityFunction<ContractAttach>
    {
        [Field("contract_id")]
        public long ContractID { get; set; }

        [Field("filename")]
        public string FileName { get; set; }

        [Field("filetype")]
        public string FileType { get; set; }

    }
}
