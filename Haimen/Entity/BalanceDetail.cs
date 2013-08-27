﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_balance_detail")]
    public class BalanceDetail : MEntityFunction<BalanceDetail>
    {
        [Field("parent_id")]
        public long Parent_ID { get; set; }

        [Field("pay_date")]
        public DateTime PayDate { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("account_id")]
        public long AccountID { get; set; }        
    }
}