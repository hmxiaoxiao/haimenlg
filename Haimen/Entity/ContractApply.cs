using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;

namespace Haimen.Entity
{
    /// <summary>
    /// 合同付款申请
    /// </summary>
    [Table("t_contract_apply")]
    public class ContractApply : SingleEntity<ContractApply>
    {
        [Field("apply_date")]
        public DateTime ApplyDate { get; set; }

        
        private long m_contract_id;
        [Field("contract_id")]
        public long ContractID 
        { 
            get
            {
                return m_contract_id;
            }
            set
            {
                m_contract_id = value;
                m_contract = Contract.CreateByID(m_contract_id);
            }
        }
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

        public string ContractName
        {
            get
            {
                return m_contract.Name;
            }
        }

        [Field("money")]
        public decimal Money { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

        [Field("status")]
        public long Status { get; set; }

        public static List<Dict> ApplyStatus
        {
            get
            {
                List<Dict> list = new List<Dict>();
                foreach (string s in Enum.GetNames(typeof(ContractApplyStatusEnum)))
                {
                    list.Add(new Dict(s, long.Parse(Enum.Format(typeof(ContractApplyStatusEnum), Enum.Parse(typeof(ContractApplyStatusEnum), s), "d")))); ;
                }
                return list;
            }
        }

        /// <summary>
        /// 申请校验
        /// </summary>
        /// <returns></returns>
        public override bool SaveVerify()
        {
            Error_Info.Clear();

            if (Money <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("Money", "申请金额不能为空"));

            return Error_Info.Count == 0;
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="status"></param>
        public void UpdateStatus(ContractApplyStatusEnum status)
        {
            this.Status = (long)status;
            this.Save();
        }

        /// <summary>
        /// 取得指定合同的所以已申请的金额（之和）
        /// </summary>
        /// <param name="contract_id">合同ID</param>
        /// <returns></returns>
        public static decimal GetAllPayMoney(long contract_id)
        {
            decimal sum_money = 0;
            List<ContractApply> lists = ContractApply.Query("contract_id = " + contract_id.ToString());
            foreach (ContractApply app in lists)
            {
                sum_money += app.Money;
            }
            return sum_money;
        }
    }

    /// <summary>
    /// 合同付款申请的状态
    /// </summary>
    public enum ContractApplyStatusEnum : long
    {
        提交申请,
        已开票,
        已支付,
    }
}
