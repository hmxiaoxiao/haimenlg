﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Haimen.Qy;

//namespace HaimenEntity.BaseObject
//{
//    [Table("t_account_attach")]
//    public class AccountAttach : MEntityFunction<AccountAttach>
//    {
//        private long m_account_id;
//        [Field("account_id")]
//        public long AccountID 
//        {
//            get
//            {
//                return m_account_id;
//            }
//            set
//            {
//                m_account_id = value;
//                Account = Account.CreateByID(value);
//            }
//        }

//        public Account Account { get; set; }

//        [Field("filename")]
//        public string FileName { get; set; }

//        [Field("filetype")]
//        public string FileType { get; set; }
//    }
//}