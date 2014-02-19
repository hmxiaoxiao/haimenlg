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


        /// <summary>
        /// 删除时不作校验
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            return true;
        }

        public override bool InsertUpdateVerify()
        {
            Error_Info.Clear();

            if (FundsID == 0)
                Error_Info.Add(new KeyValuePair<string, string>("FundsID", "资金性质不能为空"));

            if (Money == 0)
                Error_Info.Add(new KeyValuePair<string, string>("Money", "金额不能为0"));

            return Error_Info.Count == 0;
        }
    }
}
