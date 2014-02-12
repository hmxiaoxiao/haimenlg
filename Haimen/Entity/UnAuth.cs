using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.DB;
using System.Data.SqlClient;

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
        public override bool SaveVerify()
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
        /// 删除时更新余额
        /// </summary>
        public override void Destory()
        {
            UnAuth old = UnAuth.CreateByID(ID);
            if (old == null)
                return;

            SqlTransaction trans = null;
            try
            {
                trans = DBConnection.BeginTrans();
                CompanyDetail cd = CompanyDetail.CreateByID(old.CompanyDetailID);
                if (old.Input == "X") // 如果收入，那么删除时余额要减少
                    cd.Balance -= old.Money;
                else
                    cd.Balance += old.Money;
                cd.SaveNoTrans();
                base.DestoryNoTrans();
                trans.Commit();
            }
            catch (Exception e)
            {
                if (trans != null)
                    trans.Rollback();

                string msg = string.Format("删除非授权凭证时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }


        /// <summary>
        /// 新增时更新余额
        /// </summary>
        public override bool Insert()
        {
            SqlTransaction trans = null;
            try
            {
                trans = DBConnection.BeginTrans();

                if (!base.InsertNoTrans())
                {
                    trans.Rollback();
                    return false;
                }

                CompanyDetail cd = CompanyDetail.CreateByID(CompanyDetailID);
                if (Input == "X")
                    cd.Balance += Money;
                else
                    cd.Balance -= Money;
                cd.SaveNoTrans();
                trans.Commit();

                return true;
            }
            catch (Exception e)
            {
                if (trans != null)
                    trans.Rollback();

                string msg = string.Format("新增非授权凭证时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }


        /// <summary>
        /// 修改时，更新余额
        /// </summary>
        public override bool Update()
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

            SqlTransaction trans = null;
            try
            {
                trans = DBConnection.BeginTrans();
                cd.Save();

                if (base.Update())
                {
                    trans.Commit();
                    return true;
                }
                else
                {
                    trans.Rollback();
                    return false;
                }
            }
            catch (Exception e)
            {
                if (trans != null)
                    trans.Rollback();

                string msg = string.Format("更新非授权凭证时出现错误，错误原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }
    }
}
