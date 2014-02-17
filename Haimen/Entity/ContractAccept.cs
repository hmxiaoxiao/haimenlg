using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.DB;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    /// <summary>
    /// 合同验收
    /// </summary>
    [Table("t_contract_accept")]
    public class ContractAccept : SingleEntity<ContractAccept>
    {
        /// <summary>
        /// 验收的合同
        /// </summary>
        [Field("contract_id")]
        public long ContractID { get; set; }

        private Contract m_contract;
        public Contract Contract
        {
            get
            {
                if (m_contract == null && ContractID > 0)
                    m_contract = Contract.CreateByID(ContractID);
                return m_contract;
            }
        }

        /// <summary>
        /// 验收单位
        /// </summary>
        [Field("accept_unit")]
        public string AcceptUnit { get; set; }


        /// <summary>
        /// 验收日期
        /// </summary>
        [Field("accept_date")]
        public DateTime AcceptDate { get; set; }


        /// <summary>
        /// 通过??
        /// </summary>
        [Field("pass")]
        public long Pass { get; set; }


        /// <summary>
        /// 金额
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        [Field("Memo")]
        public string Memo { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        [Field("status")]
        public long Status { get; set; }

        /// <summary>
        /// 验收校验
        /// </summary>
        /// <returns></returns>
        public override bool InsertVerify()
        {
            Error_Info.Clear();

            if (ContractID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("ContractID", "请选择要验收的合同。"));

            if (string.IsNullOrEmpty(AcceptUnit))
                Error_Info.Add(new KeyValuePair<string,string>("AcceptUnit", "验收单位不能为空。"));

            if (string.IsNullOrEmpty(Memo))
                Error_Info.Add(new KeyValuePair<string, string>("Memo", "结果不能为空。"));

            return Error_Info.Count == 0;
        }


        /// <summary>
        /// 新增时,更新合同的状态
        /// </summary>
        /// <returns></returns>
        public override bool Insert(bool hasTrans = false)
        {
            SqlTransaction trans = null;
            try
            {
                trans = DBConnection.BeginTrans();
                //  更新状态
                Contract c = Contract.CreateByID(this.ContractID);
                if (Pass > 0)
                    c.Status = (long)Contract.ContractStatusEnum.已验收;
                else
                    c.Status = (long)Contract.ContractStatusEnum.验收未通过;
                c.Save();

                if (base.Insert())
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

                string msg = string.Format("在新增数据时出错，请与供应商联系，取得支持，错误原因： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }

        /// <summary>
        /// 更新时，同样更新合同的状态
        /// </summary>
        /// <returns></returns>
        public override bool Update(bool hasTrans = false)
        {
            try
            {
                if (!hasTrans)
                    DBConnection.BeginTrans();

                //  更新状态
                Contract c = Contract.CreateByID(this.ContractID);
                if (Pass > 0)
                    c.Status = (long)Contract.ContractStatusEnum.已验收;
                else
                    c.Status = (long)Contract.ContractStatusEnum.验收未通过;
                bool sucess = c.Save(true) && base.Update(true);

                if (sucess)
                    DBConnection.CommitTrans();
                else
                    DBConnection.RollbackTrans();

                return sucess;

            }
            catch (Exception e)
            {
                if (!hasTrans && DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();

                string msg = string.Format("在更新数据时出错，请与供应商联系，取得支持，错误原因： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }

        private static List<Dict> m_accept_status;
        public static List<Dict> AcceptStatus
        {
            get
            {
                if (m_accept_status == null)
                {
                    m_accept_status = new List<Dict>();
                    m_accept_status.Add(new Dict("未开票", 0));
                    m_accept_status.Add(new Dict("已开票", 1));
                }
                return m_accept_status;
            }
        }

        /// <summary>
        /// 合同验收的状态，就是开票未开票
        /// </summary>
        public enum ContractAcceptStatusEnum : long
        {
            未开票 = 0,
            已开票,
        }
    }
}
