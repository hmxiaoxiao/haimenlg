using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using Haimen.Entity;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    /// <summary>
    /// 合同实体类
    /// </summary>
    [Table("t_contract")]
    public class Contract : ComplexEntity<Contract, ContractDetail>
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Field("code")]
        public string Code { get; set; }

        /// <summary>
        /// 付款单位
        /// </summary>
        [Field("out_company_id")]
        public long OutCompanyID { get; set; }
        private Company m_out_company = null;
        public Company OutCompany
        {
            get
            {
                if (OutCompanyID > 0)
                {
                    if (m_out_company == null || m_out_company.ID != OutCompanyID)
                        m_out_company = Company.CreateByID(OutCompanyID);
                }
                return m_out_company;
            }
        }


        /// <summary>
        /// 收款单位
        /// </summary>
        [Field("in_company_id")]
        public long InCompanyID { get; set; }
        private Company m_in_company = null;
        public Company InCompany
        {
            get
            {
                if (InCompanyID > 0)
                {
                    if (m_in_company == null || m_in_company.ID != InCompanyID)
                        m_in_company = Company.CreateByID(InCompanyID);
                }
                return m_in_company;
            }
        }

        /// <summary>
        /// 甲方
        /// </summary>
        [Field("partya")]
        public long PartyAID { get; set; }
        private Company m_partya = null;
        public Company PartyA
        {
            get
            {
                if (PartyAID > 0)
                {
                    if (m_partya == null || m_partya.ID != PartyAID)
                        m_partya = Company.CreateByID(PartyAID);
                }
                return m_partya;
            }
        }

        // 以下二个属性，只为lue控件使用
        public string PartyAName
        {
            get
            {
                if (PartyAID > 0)
                {
                    if (m_partya == null || m_partya.ID != PartyAID)
                        m_partya = Company.CreateByID(PartyAID);
                }
                return m_partya.Name;
            }
        }
        public string PartyBName
        {
            get
            {
                if (PartyBID > 0)
                {
                    if (m_partyb == null || m_partyb.ID != PartyBID)
                        m_partyb = Company.CreateByID(PartyBID);
                }
                return m_partyb.Name;
            }
        }

        /// <summary>
        /// 乙方
        /// </summary>
        [Field("partyb")]
        public long PartyBID { get; set; }
        private Company m_partyb = null;
        public Company PartyB
        {
            get
            {
                if (PartyBID > 0)
                {
                    if (m_partyb == null || m_partyb.ID != PartyBID)
                        m_partyb = Company.CreateByID(PartyBID);
                }
                return m_partyb;
            }
        }



        [Field("signed_date")]
        public DateTime SignedDate { get; set; }

        [Field("begin_date")]
        public DateTime BeginDate { get; set; }

        [Field("end_date")]
        public DateTime EndDate { get; set; }

        [Field("name")]
        public string Name { get; set; }

        /// <summary>
        /// 合同金额
        /// </summary>
        [Field("money")]
        public decimal Money { get; set; }

        /// <summary>
        /// 审计价
        /// </summary>
        [Field("checkmoney")]
        public decimal CheckMoney { get; set; }

        /// <summary>
        /// 决算价
        /// </summary>
        [Field("cost")]
        public decimal Cost { get; set; }

        /// <summary>
        /// 最终决定价
        /// </summary>
        [Field("finalmoney")]
        public decimal FinalMoney { get; set; }

        /// <summary>
        /// 保证金
        /// </summary>
        [Field("security")]
        public decimal Security { get; set; }

        [Field("payment_ratio")]
        public decimal PaymentRatio { get; set; }

        [Field("attachment")]
        public long Attachment { get; set; }

        [Field("pay")]
        public decimal Pay { get; set; }

        [Field("explanation")]
        public string Explanation { get; set; }

        [Field("typist")]
        public long TypUserID { get; set; }
        private User m_typist = null;
        public User Typist
        {
            get
            {
                if (TypUserID > 0)
                {
                    if (m_typist == null || m_typist.ID != TypUserID)
                        m_typist = User.CreateByID(TypUserID);
                }
                return m_typist;
            }
        }


        [Field("status")]
        public long Status { get; set; }

        [Field("memo")]
        public string Memo { get; set; }

        [Field("project_id")]
        public long ProjectID { get; set; }
        private Project m_project;
        public Project Project
        {
            get
            {
                if (m_project == null && ProjectID > 0)
                    m_project = Project.CreateByID(ProjectID);
                return m_project;
            }
        }

        // 审核通过
        public void CheckPassed()
        {
            this.Status = (long)ContractStatusEnum.审核通过;
            this.Save();
        }

        // 审核不通过
        public void CheckFaild()
        {
            this.Status = (long)ContractStatusEnum.审核未通过;
            this.Save();
        }

        /// <summary>
        /// 校验数据是否正确
        /// </summary>
        /// <returns></returns>
        public override bool SaveVerify()
        {
            Error_Info.Clear();

            if (string.IsNullOrEmpty(this.Code))
                Error_Info.Add(new KeyValuePair<string, string>("Code", "代码不能为空"));

            if (this.OutCompanyID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("OutCompanyID", "请选择签合同的付款单位!"));

            if (this.InCompanyID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("IntCompanyID", "请选择签合同的收款单位!"));
            
            if (this.PartyAID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("PartyA_ID", "请选择签合同的甲方!"));

            if (this.PartyBID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("PartyB_ID", "请选择签合同的乙方!"));


            if (Error_Info.Count > 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 更新已付的金额
        /// </summary>
        /// <param name="money"></param>
        public void UpdatePay(decimal money)
        {
            Pay += money;
            Status = (long)ContractStatusEnum.付款中;
            Save();
        }

        /// <summary>
        /// 更新决算金额
        /// </summary>
        /// <param name="money"></param>
        public void SetCost(decimal money)
        {
            Cost = money;       // 决算金额为传入金额
            // 如果已经有审计价了，则最终价一定为审计价
            if (CheckMoney == 0)
            {
                FinalMoney = Cost;  // 合同最终金额为决算金额
            }
            Save();
        }

        /// <summary>
        /// 更新审计价
        /// </summary>
        /// <param name="money"></param>
        public void SetCheckMoney(decimal money)
        {
            CheckMoney = money;
            FinalMoney = CheckMoney;        // 合同最终金额为审核价
            Save();
        }

        /// <summary>
        /// 新增时，对最终价进行设置
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            FinalMoney = Money;         
            if (Cost > 0)
                FinalMoney = Cost;
            if (CheckMoney > 0)
                FinalMoney = CheckMoney;
            return base.Insert();
        }


        /// <summary>
        /// 更新时，同样须对最终价进行设置
        /// </summary>
        /// <returns></returns>
        public override bool Update()
        {
            FinalMoney = Money;
            if (Cost > 0)
                FinalMoney = Cost;
            if (CheckMoney > 0)
                FinalMoney = CheckMoney;
            return base.Update();
        }

        private static List<Dict> m_contract_status;
        public static List<Dict> ContractStatus
        {
            get
            {
                if (m_contract_status == null)
                {
                    m_contract_status = new List<Dict>();
                    m_contract_status.Add(new Dict("未审核", 0));
                    m_contract_status.Add(new Dict("审核通过", 1));
                    m_contract_status.Add(new Dict("审核未通过", 2));
                    m_contract_status.Add(new Dict("再次审核", 3));
                    m_contract_status.Add(new Dict("付款中", 4));
                    m_contract_status.Add(new Dict("已验收", 5));
                    m_contract_status.Add(new Dict("验收未通过", 6));
                    m_contract_status.Add(new Dict("已中止", 7));
                }
                return m_contract_status;
            }
        }

        /// <summary>
        /// 打开合同界面的不同状态
        /// </summary>
        public enum ContractFromEnum : long
        {
            查看 = 0,
            新增,
            编辑,
            审核,
            撤审,
            付款申请,
            设置决算价,
            设置审计价,
        }

        /// <summary>
        /// 合同的状态
        /// </summary>
        public enum ContractStatusEnum : long
        {
            未审核 = 0,
            审核通过,
            审核未通过,
            再次审核,
            付款中,
            已验收,
            验收未通过,
            已中止,
        }
    }
}
