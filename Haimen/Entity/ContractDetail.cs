using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;

namespace Haimen.Entity
{
    [Table("t_contract_detail")]
    public class ContractDetail : MEntityFunction<ContractDetail>
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
