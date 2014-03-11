using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.DB;
using System.Data.SqlClient;
using System.Data;

namespace Haimen.Entity
{
    /// <summary>
    /// 非授权资金列表
    /// 授权与非授权的区别在于是否需要审核
    /// 非授权的票据，是不需要审核的
    /// </summary>
    [Table("t_unauth")]
    public class UnAuth : SingleEntity<UnAuth>
    {

        public UnAuth()
        {
            Code = UnAuth.GenAutoCode();
        }

        /// <summary>
        /// 票据号
        /// </summary>
        [Field("code")]
        public string Code { get; set; }

        /// <summary>
        /// 发生业务的公司
        /// </summary>
        [Field("company_id")]
        public long CompanyID { get; set; }

        private Company _company = null;
        public Company Company
        {
            get
            {
                if (CompanyID == 0)
                    return null;
                if (_company == null)
                    _company = Company.CreateByID(CompanyID);
                return _company;
            }
        }

        /// <summary>
        /// 公司帐号
        /// </summary>
        [Field("companydetail_id")]
        public long CompanyDetailID { get; set; }

        private CompanyDetail _Detail;
        public CompanyDetail CompanyDetail
        {
            get
            {
                if (CompanyDetailID == 0)
                    return null;
                if (_Detail == null)
                    _Detail = CompanyDetail.CreateByID(CompanyDetailID);
                return _Detail;
            }
        }

        /// <summary>
        /// 是否收入凭证
        /// </summary>
        [Field("input")]
        public string Input { get; set; }


        /// <summary>
        /// 是否支出凭证
        /// </summary>
        [Field("output")]
        public string Output { get; set; }

        /// <summary>
        /// 发生金额
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        [Field("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 发生日期
        /// </summary>
        [Field("signed_date")]
        public DateTime SignedDate { get; set; }


        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        public override bool InsertUpdateVerify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "凭证号不能为空!"));

            if (CompanyID == 0)
                Error_Info.Add(new KeyValuePair<string, string>("CompanyID","单位必须选择"));

            if (CompanyDetailID == 0)
                Error_Info.Add(new KeyValuePair<string, string>("CompanyDetailID", "帐号必须选择"));

            if (Money == 0)
                Error_Info.Add(new KeyValuePair<string, string>("Money","金额不能为0"));

            return Error_Info.Count == 0;
        }


        /// <summary>
        /// 删除时不作判断
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            return true;
        }

        /// <summary>
        /// 删除时更新余额
        /// </summary>
        public override bool Destory(bool hasTrans = false)
        {
            UnAuth old = UnAuth.CreateByID(ID);
            if (old == null)
                return false;

            try
            {
                if (!hasTrans)
                    DBConnection.BeginTrans();

                CompanyDetail cd = CompanyDetail.CreateByID(old.CompanyDetailID);
                if (old.Input == "X") // 如果收入，那么删除时余额要减少
                    cd.Balance -= old.Money;
                else
                    cd.Balance += old.Money;

                bool success = cd.Update(true) && base.Destory(true);
                if (!hasTrans)
                {
                    if (success)
                        DBConnection.CommitTrans();
                    else
                        DBConnection.RollbackTrans();
                }

                return success;
            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("删除非授权凭证时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }


        /// <summary>
        /// 新增时更新余额
        /// </summary>
        public override bool Insert(bool hasTrans = false)
        {
            try
            {
                bool success = true;
                if (!hasTrans)
                    DBConnection.BeginTrans();

                this.Code = UnAuth.GenAutoCode(true);  // 重新生成凭证编号，以防止可能的重复

                if (!base.Insert(true))
                    success = false;

                CompanyDetail cd = CompanyDetail.CreateByID(CompanyDetailID);
                if (Input == "X")
                    cd.Balance += Money;
                else
                    cd.Balance -= Money;
                if (!cd.Update(true))
                    success = false;

                if (!hasTrans)
                {
                    if (success)
                        DBConnection.CommitTrans();
                    else
                        DBConnection.RollbackTrans();
                }
                return success;
            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("新增非授权凭证时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e);
                UnAuth.ExceptionString = msg;
                return false;
            }
        }


        /// <summary>
        /// 修改时，更新余额
        /// </summary>
        public override bool Update(bool hasTrans = false)
        {
            UnAuth old = UnAuth.CreateByID(ID);
            if (old == null)
                return false;

            CompanyDetail cd = CompanyDetail.CreateByID(old.CompanyDetailID);
            if (cd == null)
                return false;

            if (Input == "X")
                cd.Balance += Money;
            else
                cd.Balance -= Money;

            if (old.Input == "X")
                cd.Balance -= old.Money;
            else
                cd.Balance += old.Money;

            try
            {
                if (!hasTrans)
                    DBConnection.BeginTrans();

                bool sucess = cd.Save(true) && base.Update(true);       // 更新余额以及非授权资金

                if (!hasTrans)
                {
                    if (sucess)
                        DBConnection.CommitTrans();
                    else
                        DBConnection.RollbackTrans();
                }

                return sucess;
            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("更新非授权凭证时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e);
                UnAuth.ExceptionString = msg;
                return false;
            }
        }


        public static string GenAutoCode(bool can_save = false)
        {
            string current_doc = SystemSet.GetValue("UnAuthDoc");
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
            if(can_save)
                SystemSet.SetValue("UnAuthDoc", doc);
            return doc;
        }

        /// <summary>
        /// 取得列表界面显示数据
        /// 如果通过ORM来做的话，速度太慢，
        /// 200多条记录要15秒，不是读数据的问题，读数据大概只要1~2秒的时间，是绑定的显示非常慢。
        /// </summary>
        /// <returns></returns>
        public static DataSet GetGUIList()
        {
            string sql = @"
select a.id, a.signed_date, a.code, b.name as companyname, d.name as bankname, c.account, a.output, a.input, a.money, a.memo
from t_unauth a,
     m_company b,
     m_company_detail c,
     m_bank d
where a.company_id = b.id and a.companydetail_id = c.id and
      c.bank_id = d.id
";

            return DBConnection.RunQuerySql(sql);
        }
    }
}
