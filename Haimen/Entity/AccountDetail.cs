using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using Haimen.Entity;

namespace Haimen.Entity
{
    [Table("t_account_detail")]
    public class AccountDetail : SingleEntity<AccountDetail>
    {
        [Field("parent_id")]
        public long ParentID { get; set; }

        [Field("funds_id")]
        public long FundsID { get; set; }
        private Funds m_funds = null;
        public Funds Funds
        {
            get
            {
                if (FundsID > 0)
                {
                    if (m_funds == null || m_funds.ID != FundsID)
                        m_funds = Funds.CreateByID(FundsID);
                }
                return m_funds;
            }
        }

        [Field("usage")]
        public string Usage { get; set; }

        [Field("money")]
        public Decimal Money { get; set; }
    }
}
