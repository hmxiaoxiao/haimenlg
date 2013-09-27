using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    /// <summary>
    /// 合同验收
    /// </summary>
    public class ContractAccept : MEntityFunction<ContractAccept>
    {
        /// <summary>
        /// 验收的合同
        /// </summary>
        [Field("contract_id")]
        public long ContractID { get; set; }

        [Field("accept_unit")]
        public string AcceptUnit { get; set; }

        [Field("accept_date")]
        public DateTime AcceptDate { get; set; }

        [Field("pass")]
        public long Pass { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("Memo")]
        public string Memo { get; set; }
    }
}
