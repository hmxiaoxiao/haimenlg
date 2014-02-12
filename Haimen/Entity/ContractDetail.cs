using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.DB;

namespace Haimen.Entity
{
    // 合同明细
    [Table("t_contract_detail")]
    public class ContractDetail : SingleEntity<ContractDetail>
    {
        [Field("parent_id")]
        public long ParentID { get; set; }

        [Field("pay_date")]
        public DateTime PayDate { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("account_id")]
        public long AccountID { get; set; }        
    }
}
