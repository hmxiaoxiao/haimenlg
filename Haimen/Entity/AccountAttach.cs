using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("t_account_attach")]
    public class AccountAttach : EntityFunction<AccountAttach>
    {
        private long m_account_id;
        [Field("account_id")]
        public long AccountID 
        {
            get
            {
                return m_account_id;
            }
            set
            {
                m_account_id = value;
                Account = Account.CreateByID(value);
            }
        }

        public Account Account { get; set; }

        [Field("filename")]
        public string FileName { get; set; }

        [Field("filetype")]
        public string FileType { get; set; }
    }
}
