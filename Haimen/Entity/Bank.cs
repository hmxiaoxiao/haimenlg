﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    [Table("m_bank")]
    public class Bank : SingleEntity<Bank>
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
            List<Bank> list = Bank.Query("parent_id = " + id);
            return list;
        }


        // 判断银行是否可以删除
        public override bool DeleteVerify()
        {
            Error_Info.Clear();

            // 如果已经被帐户明细所引用，就不可以删除
            if (CompanyDetail.Query("bank_id = " + ID).Count > 0)
                Error_Info.Add(new KeyValuePair<string,string>("删除银行", "该银行已经被单位明细引用，无法删除！"));

            if (Bank.Query(string.Format("parent_id = {0}", ID)).Count > 0)
                Error_Info.Add(new KeyValuePair<string,string>("删除银行", "该银行有下属银行，请把所有的下属银行删除后，再删除本银行。"));

            return Error_Info.Count == 0;
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        public override bool InsertUpdateVerify()
        {
            // 清空以前的错误信息
            Error_Info.Clear();


            // 判断各字段长度
            if (System.Text.Encoding.Default.GetBytes(Code.ToCharArray()).Length > 50)
                Error_Info.Add(new KeyValuePair<string, string>("Code", "银行代码长度不可以超过50个字节"));

            if (System.Text.Encoding.Default.GetBytes(Name.ToCharArray()).Length > 50)
                Error_Info.Add(new KeyValuePair<string, string>("Code", "银行名称长度不可以超过50个字节"));


            // 判断代码输入的可用性
            string code_errinfo = "";
            List<Bank> list;
            if (string.IsNullOrEmpty(Code))
            {
                code_errinfo += "银行代码不可以为空!" + Environment.NewLine;
            }
            else
            {
                if (ID == 0)
                    list = Bank.Query(String.Format("code = '{0}'", Code));
                else
                    list = Bank.Query(String.Format("code = '{0}' and id <> {1}", Code, ID));
                if (list.Count > 0)
                    code_errinfo += "您输入的银行代码已经存在" + Environment.NewLine;
            }
            if (code_errinfo.Length > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Code", code_errinfo));

            // 判断名称的有效性
            string name_errinfo = "";
            if (string.IsNullOrEmpty(Name))
            {
                name_errinfo += "银行名称不可以为空!" + Environment.NewLine;
            }
            else
            {
                if (ID == 0)
                    list = Bank.Query(String.Format("name = '{0}'", Name));
                else
                    list = Bank.Query(String.Format("name = '{0}' and id <> {1}", Name, ID));
                if (list.Count > 0)
                    code_errinfo += "您输入的银行名称已经存在" + Environment.NewLine;
            }
            if (name_errinfo.Length > 0)
                Error_Info.Add(new KeyValuePair<string, string>("Name", name_errinfo));

            // 校验上级银行
            if (ParentID > 0 && ParentBank == null)
                Error_Info.Add(new KeyValuePair<string, string>("parent_id", "您设置的上级银行不存在！"));
            

            // 返回校验成功与否
            return Error_Info.Count == 0;
        }


        /// <summary>
        /// 合并银行，将老的银行全并到新的银行上，并删除老的银行
        /// </summary>
        /// <param name="old_id">老银行ID</param>
        /// <param name="new_id">新银行Id</param>
        /// <returns></returns>
        public bool Merge(long old_id, long new_id)
        {
            Error_Info.Clear();
            Bank old_bank = Bank.CreateByID(old_id);
            Bank new_bank = Bank.CreateByID(new_id);

            if (old_bank == null || new_bank == null)
            {
                Error_Info.Add(new KeyValuePair<string,string>("Merge","对应的银行信息找不到！"));
                return false;
            }

            if (Bank.Query("parent_id = " + old_id.ToString()).Count > 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("Merge", "被合并的银行不能是别的银行的父结点。"));
                return false;
            }

            SqlTransaction trans = null;
            try
            {
                trans = DBConnection.BeginTrans();
                string sql = String.Format(" Update m_company_detail set bank_id = {0} where bank_id = {1}", new_id, old_id);
                Haimen.DB.DBConnection.RunQuerySql(sql);

                sql = " Delete m_bank where id = " + old_id.ToString();
                Haimen.DB.DBConnection.RunQuerySql(sql);
                trans.Commit();
                return true;
            }
            catch (Exception e)
            {
                if (trans != null)
                    trans.Rollback();

                string msg = string.Format("在合并银行时出错，请与供应商联系，取得支持，错误原因： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        public override string ToString()
        {
            return string.Format("id:{0}, code:{1}, name:{2}, parentid:{3}", ID, Code, Name);
        }
    }
}
