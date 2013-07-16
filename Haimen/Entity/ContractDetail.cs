using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_contract_detail")]
    public class ContractDetail : EntityFunction<ContractDetail>
    {
        [Field("contract_id")]
        public long ContractID { get; set; }

        [Field("pay_date")]
        public DateTime PayDate { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("account_id")]
        public long AccountID { get; set; }        
    }
}
