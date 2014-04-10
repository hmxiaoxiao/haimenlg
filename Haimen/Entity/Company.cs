using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using Haimen.Entity;

using System.Data;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    [Table("m_company")]
    public class Company : ComplexEntity<Company, CompanyDetail>
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

        [Field("parent_id")]
        public long ParentID { get; set; }


        /// <summary>
        /// 删除校验
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            Error_Info.Clear();

            if (Contract.Query("out_company_id = " + ID.ToString()).Count > 0 ||
                Contract.Query("in_company_id = " + ID.ToString()).Count > 0 ||
                Contract.Query("partya = " + ID.ToString()).Count > 0 ||
                Contract.Query("partyb = " + ID.ToString()).Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("删除单位", "该单位已经被合同引用，不能删除！"));

            if (UnAuth.Query(string.Format("company_id = {0}", ID)).Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("删除单位", "该单位已经被非授权资金单据使用，不能删除！"));

            return Error_Info.Count == 0;
        }

        /// <summary>
        /// 单位的数据校验
        /// </summary>
        /// <returns></returns>
        public override bool InsertUpdateVerify()
        {
            Error_Info.Clear();
            List<Company> list;

            // 校验代码
            if (string.IsNullOrEmpty(Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "代码不能为空！"));

            if (ID == 0)
                list = Company.Query(String.Format("code = '{0}'", Code));
            else
                list = Company.Query(String.Format("code = '{0}' and id <> {1}", Code, ID));
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Code","您输入的代码已经存在，请重新输入"));

            // 校验名称
            if (string.IsNullOrEmpty(Name))
                Error_Info.Add(new KeyValuePair<string, string>("Name", "名称不能为空"));

            list = Company.Query(String.Format("name = '{0}' and id <> {1}", Name, ID)); // 如果ID为0，也没有问题
            if (list.Count > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", "您输入的名称已经存在，请重新输入"));

            if (this.ParentID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("ParentID", "请选择所属的单位(个人，本单位，外单位)"));

            // 如果收入单位，支出单位没有选 ，则也不行
            if (this.Input == "" && this.Output == "")
                Error_Info.Add(new KeyValuePair<string, string>("Input", "请选中收入单位，还是支出单位！"));

            if (!string.IsNullOrEmpty(this.Output ) && string.IsNullOrEmpty(this.Doc))
                Error_Info.Add(new KeyValuePair<string,string>("Doc", "支出单位的凭证号不能为空！"));

            return Error_Info.Count == 0;
        }

        
        /// <summary>
        /// 生成凭证号
        /// </summary>
        /// <returns></returns>
        public string NextDoc(bool can_save = false, bool is_cash = false)
        {
            string relVal = "";

            // 如果是现金，有另外的规则
            if (is_cash)
                return "现金" + GenNextDoc(can_save);


            // 如果不需要前缀，则调用通用的凭证号生成器（没有前缀）
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
                if (DBConnection.Transaction != null)   // 如果已经有事务了，就不需要启动事务了。
                    com.Save(true);
                else
                    com.Save();
            }
            return relVal;
        }

        /// <summary>
        /// 生成通用的凭证号
        /// </summary>
        /// <returns>凭证号的格式为YYYYMMDD001</returns>
        private string GenNextDoc(bool can_save = false)
        {
            string current_doc = SystemSet.GetValue("Doc");
            string current_date = string.Format("{0:yyyyMMdd}", DateTime.Now);
            string doc = "";            // 本次生成的凭证号
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

        public override string ToString()
        {
            return string.Format("id:{0}, code:{1}, name:{2}, doc:{3}, output:{4}, " +
                                 "input:{5}, docdate:{6}, gendoc:{7}, parentid:{8}",
                                 ID, Code, Name, Doc, Output, Input, DocDate, GenDoc, ParentID);
        }

    }
}
