using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    [Table("m_bank")]
    public class Bank : MEntityFunction<Bank>
    {
        /// <summary>
        /// 银行代码
        /// </summary>
        [Field("code")]
        public string Code { get; set; }


        /// <summary>
        /// 银行名称
        /// </summary>
        [Field("name")]
        public string Name { get; set; }



        [Field("parent_id")]
        public long ParentID { get; set; }

        private Bank m_parent_bank;
        public Bank ParentBank
        {
            get
            {
                if (m_parent_bank == null)
                {
                    if (ParentID > 0)
                    {
                        m_parent_bank = Bank.CreateByID(ParentID);
                        return m_parent_bank;
                    }
                    else
                        return null;
                }
                else
                    return m_parent_bank;
            }
        }


        // 取得下属银行
        public static List<Bank> GetChildren(int id)
        {
            List<Bank> list = Bank.Query("parent_id = " + id.ToString());
            return list;
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            // 清空以前的错误信息
            Error_Info.Clear();

            // 判断代码输入的可用性
            string code_errinfo = "";
            List<Bank> list;
            if (string.IsNullOrEmpty(Code))
            {
                code_errinfo += "代码不可以为空!" + Environment.NewLine;
            }
            else
            {
                if (ID == 0)
                    list = Bank.Query("code = '" + Code + "'");
                else
                    list = Bank.Query("code = '" + Code + "' and id <> " + ID.ToString());
                if (list.Count > 0)
                    code_errinfo += "您输入的代码已经存在" + Environment.NewLine;
            }
            if (code_errinfo.Length > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Code", code_errinfo));

            // 判断名称的有效性
            string name_errinfo = "";
            if (string.IsNullOrEmpty(Name))
            {
                name_errinfo += "名称不可以为空!" + Environment.NewLine;
            }
            else
            {
                if (ID == 0)
                    list = Bank.Query("name = '" + Name + "'");
                else
                    list = Bank.Query("name = '" + Name + "' and id <> " + ID.ToString());
                if (list.Count > 0)
                    code_errinfo += "您输入的名称已经存在" + Environment.NewLine;
            }
            if (name_errinfo.Length > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", name_errinfo));

            // 校验上级银行
            if (ParentID > 0)
            {
                if (ParentBank == null)
                    Error_Info.Add(new KeyValuePair<string, string>("parent_id", "设置的上级银行不存在！"));
            }

            // 返回校验成功与否
            return Error_Info.Count == 0;
        }

    }
}
