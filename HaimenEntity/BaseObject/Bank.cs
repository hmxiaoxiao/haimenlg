//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Haimen.Qy;

//namespace HaimenEntity.BaseObject
//{
//    [Table("m_bank")]
//    public class Bank : MEntityFunction<Bank>
//    {
//        [Field("code")]
//        public string Code { get; set; }

//        [Field("name")]
//        public string Name { get; set; }


//        private long m_parentid;
//        public Bank ParentBank { get; set; }
//        [Field("parent_id")]
//        public long ParentID 
//        {
//            get
//            {
//                return m_parentid;
//            }
//            set 
//            {
//                m_parentid = value;
//                ParentBank = Bank.CreateByID(m_parentid);
//            }
//        }


//        // 取得下属银行
//        public static List<Bank> GetChildren(int id)
//        {
//            List<Bank> list = Bank.Query("parent_id = " + id.ToString());
//            return list;
//        }

//        public override bool Verify()
//        {
//            Error_Info.Clear();

//            string code_errinfo = "";
//            List<Bank> list;
//            if (Code == "")
//            {
//                code_errinfo += "代码不可以为空!" + Environment.NewLine;
//            }
//            else
//            {
//                if (ID == 0)
//                    list = Bank.Query("code = '" + Code + "'");
//                else
//                    list = Bank.Query("code = '" + Code + "' and id <> " + ID.ToString());
//                if (list.Count > 0)
//                    code_errinfo += "您输入的代码已经存在" + Environment.NewLine;
//            }
//            if (code_errinfo.Length > 0)
//                Error_Info.Add(new KeyValuePair<string, string>("Code", code_errinfo));


//            string name_errinfo = "";
//            if (Name == "")
//            {
//                name_errinfo += "名称不可以为空!" + Environment.NewLine;
//            }
//            else
//            {
//                if (ID == 0)
//                    list = Bank.Query("name = '" + Name + "'");
//                else
//                    list = Bank.Query("name = '" + Name + "' and id <> " + ID.ToString());
//                if (list.Count > 0)
//                    code_errinfo += "您输入的名称已经存在" + Environment.NewLine;
//            }
//            if (name_errinfo.Length > 0)
//                Error_Info.Add(new KeyValuePair<string, string>("Name", name_errinfo));

//            if (m_parentid > 0)
//            {
//                ParentBank = Bank.CreateByID(m_parentid);
//                if (ParentBank == null)
//                    Error_Info.Add(new KeyValuePair<string, string>("parent_id", "设置的上级银行不存在！"));
//            }

//            // return
//            if (Error_Info.Count > 0)
//                return false;
//            else
//                return true;
//        }

//    }
//}
