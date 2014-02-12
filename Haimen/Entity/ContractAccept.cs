using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;

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

        [Field("accept_unit")]
        public string AcceptUnit { get; set; }

        [Field("accept_date")]
        public DateTime AcceptDate { get; set; }

        [Field("pass")]
        public long Pass { get; set; }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("Memo")]
        public string Memo { get; set; }

        [Field("status")]
        public long Status { get; set; }

        /// <summary>
        /// 验收校验
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
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

        public override bool Insert()
        {
            //  更新状态
            Contract c = Contract.CreateByID(this.ContractID);
            if (Pass > 0)
                c.Status = (long)Contract.ContractStatusEnum.已验收;
            else
                c.Status = (long)Contract.ContractStatusEnum.验收未通过;
            c.Save();
            
            return base.Insert();
        }

        public override bool Update()
        {
            //  更新状态
            Contract c = Contract.CreateByID(this.ContractID);
            if (Pass > 0)
                c.Status = (long)Contract.ContractStatusEnum.已验收;
            else
                c.Status = (long)Contract.ContractStatusEnum.验收未通过;
            c.Save();

            return base.Update();
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
