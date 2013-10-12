using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;

namespace Haimen.Entity
{
    [Table("m_company")]
    public class Company : TEntityFunction<Company, CompanyDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("name")]
        public string Name { get; set; }

        [Field("doc")]
        public string Doc { get; set; }

        [Field("output")]
        public string Output { get; set; }

        [Field("input")]
        public string Input { get; set; }


        [Field("doc_date")]
        public string DocDate { get; set; }

        [Field("gen_doc")]
        public long GenDoc { get; set; }

        /// <summary>
        /// 单位的数据校验
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            Error_Info.Clear();
            List<Company> list;

            // 校验代码
            if (string.IsNullOrEmpty(Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "代码不能为空！"));
            if (ID == 0)
                list = Company.Query("code = '" + Code + "'");
            else
                list = Company.Query("code = '" + Code + "' and id <> " + ID.ToString());
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Code","您输入的代码已经存在，请重新输入"));

            // 校验名称
            if (string.IsNullOrEmpty(Name))
                Error_Info.Add(new KeyValuePair<string, string>("Name", "名称不能为空"));

            list = Company.Query("name = '" + Name + "' and id <> " + ID.ToString()); // 如果ID为0，也没有问题
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", "您输入的名称已经存在，请重新输入"));

            return Error_Info.Count == 0;
        }

        
        /// <summary>
        /// 生成单据字
        /// </summary>
        /// <returns></returns>
        public string NextDoc(bool can_save = false)
        {
            string relVal = "";
            // 如果不需要前缀，则调用通用的单据字生成器（没有前缀）
            if (string.IsNullOrEmpty(this.Doc))
                return GenNextDoc(can_save);


            // 因为在内存的对象可能是很久以前的数据，
            // 所以要重新从数据库里面取一次。
            Company com = Company.CreateByID(this.ID);
            if (string.IsNullOrEmpty(this.DocDate))
            {
                com.DocDate = string.Format("{0:yyyyMMdd}", DateTime.Now);
                com.GenDoc = 1;
            }
            else
            {
                // 如果当天已经生成了，则直接序列号+1
                if (com.DocDate == string.Format("{0:yyyyMMdd}", DateTime.Now))
                {
                    com.GenDoc += 1;
                }
                else
                {
                    // 否则还要生成日期
                    com.DocDate = string.Format("{0:yyyyMMdd}", DateTime.Now);
                    com.GenDoc = 1;
                }
            }
            relVal = com.Doc + com.DocDate + string.Format("{0:000}",com.GenDoc);
            if (can_save)
            {
                com.Save();
            }
            return relVal;
        }

        /// <summary>
        /// 生成通用的单据字
        /// </summary>
        /// <returns>单据字的格式为YYYYMMDD001</returns>
        private string GenNextDoc(bool can_save = false)
        {
            string current_doc = SystemSet.GetValue("Doc");
            string current_date = string.Format("{0:yyyyMMdd}", DateTime.Now);
            string doc = "";            // 本次生成的单据字
            int num = 0;
            // 如果为空，则直接返回
            if (string.IsNullOrEmpty(current_doc))
            {
                doc = current_date + "001";
            }
            else
            {
                string old_doc_date = current_doc.Substring(0, 8);
                if (old_doc_date == current_date)
                {
                    num = int.Parse(current_doc.Substring(8)) + 1;
                    doc = current_date + string.Format("{0:000}", num);
                }
                else
                {
                    doc = current_date + "001";
                }
            }
            if (can_save)
                SystemSet.SetValue("Doc", doc);
            return doc;
        }
    }
}
