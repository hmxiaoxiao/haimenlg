﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
using Haimen.Entity;
using Haimen.Helper;
using System.Transactions;

namespace Haimen.Entity
{
    [Table("t_account")]
    public class Account : TEntityFunction<Account, AccountDetail>
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("money")]
        public decimal Money { get; set; }


        [Field("out_companydetail_id")]
        public long Out_CompanyDetail_ID { get; set; }
        private CompanyDetail m_outCompnay = null;
        public CompanyDetail OutCompanyDetail
        {
            get
            {
                if (Out_CompanyDetail_ID > 0)
                {
                    if (m_outCompnay == null || m_outCompnay.ID != Out_CompanyDetail_ID)
                        m_outCompnay = CompanyDetail.CreateByID(Out_CompanyDetail_ID);
                }
                return m_outCompnay;
            }
        }


        [Field("in_companydetail_id")]
        public long In_CompanyDetail_ID { get; set; }
        private CompanyDetail m_inComanpy = null;
        public CompanyDetail InCompanyDetail
        {
            get
            {
                if (In_CompanyDetail_ID > 0)
                {
                    if (m_inComanpy == null || m_inComanpy.ID != Out_CompanyDetail_ID)
                        m_inComanpy = CompanyDetail.CreateByID(In_CompanyDetail_ID);
                }
                return m_inComanpy;
            }
        }

        [Field("contract_accept_id")]
        public long ContractAcceptID { get; set; }
        private ContractAccept m_accept;
        public ContractAccept ContractAccept
        {
            get
            {
                if (m_accept == null && ContractAcceptID > 0)
                    m_accept = ContractAccept.CreateByID(ContractAcceptID);
                return m_accept;
            }
        }


        [Field("contract_apply_id")]
        public long ContractApplyID { get; set; }
        private ContractApply m_contract_apply = null;
        public ContractApply ContractApply
        {
            get
            {
                if (ContractApplyID > 0)
                {
                    if (m_contract_apply == null || m_contract_apply.ID != ContractApplyID)
                        m_contract_apply = ContractApply.CreateByID(ContractApplyID);
                }
                return m_contract_apply;
            }
        }

        [Field("balance_id")]
        public long BalanceID { get; set; }

        [Field("maker")]
        public long MakerID { get; set; }
        private User m_maker = null;
        public User Applicant
        {
            get
            {
                if (MakerID > 0)
                {
                    if (m_maker == null || m_maker.ID != MakerID)
                        m_maker = User.CreateByID(MakerID);
                }
                return m_maker;
            }
        }

        [Field("reviewer")]
        public long ReviewerID { get; set; }
        private User m_reviewer = null;
        public User Reviewer
        {
            get
            {
                if (ReviewerID > 0)
                {
                    if (m_reviewer == null || m_reviewer.ID != ReviewerID)
                        m_reviewer = User.CreateByID(ReviewerID);
                }
                return m_reviewer;
            }
        }

        [Field("cashier")]
        public long CashierID { get; set; }
        private User m_cashier = null;
        public User Cashier
        {
            get
            {
                if (CashierID > 0)
                {
                    if (m_cashier == null || m_cashier.ID != CashierID)
                        m_cashier = User.CreateByID(CashierID);
                }
                return m_cashier;
            }
        }

        [Field("status")]
        public long Status { get; set; }

        [Field("attachment")]
        public long Attachment { get; set; }

        // 支出签证
        [Field("direct_input")]
        public string DirectInput { get; set; }

        // 支出凭证
        [Field("direct_output")]
        public string DirectOutput { get; set; }

        // 签订日期
        [Field("signed_date")]
        public DateTime SignedDate { get; set; }

        // 备注
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

        /// <summary>
        /// 审核通过
        /// </summary>
        public void CheckPass()
        {
            // 改标志为已审核
            this.ReviewerID = GlobalSet.Current_User.ID;
            this.Status = (long)AccountStatusEnum.审核通过;
            this.Save();
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
        public void CheckFaild()
        {
            this.ReviewerID = GlobalSet.Current_User.ID;
            this.Status = (long)AccountStatusEnum.审核未通过;
            this.Save();
        }

        /// <summary>
        /// 支付
        /// </summary>
        public void Payed()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                this.Status = (long)AccountStatusEnum.已支付;
                this.CashierID = GlobalSet.Current_User.ID;

                // 更新二个单位的数据金额
                CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
                CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
                inCD.Balance += Money;
                outCD.Balance -= Money;

                // 更新合同申请中对应的合同的已付金额
                if (ContractApplyID > 0)
                {
                    Contract c = ContractApply.CreateByID(ContractApplyID).Contract;
                    c.UpdatePay(Money);
                }

                inCD.Save();        // 保存收入单位帐号余额
                outCD.Save();       // 保存支出单位的帐号余额
                this.Save();        // 保存
            }
        }

        /// <summary>
        /// 撤消支付
        /// </summary>
        public void UnPayed()
        {
            using (TransactionScope ts = new TransactionScope())
            {
                this.Status = (long)AccountStatusEnum.审核通过;

                // 更新二个单位的数据金额
                CompanyDetail inCD = CompanyDetail.CreateByID(this.In_CompanyDetail_ID);
                CompanyDetail outCD = CompanyDetail.CreateByID(this.Out_CompanyDetail_ID);
                inCD.Balance -= Money;
                outCD.Balance += Money;

                // 更新合同的已付金额
                if (ContractApplyID > 0)
                {
                    Contract c = ContractApply.CreateByID(ContractApplyID).Contract;
                    c.UpdatePay(-Money);
                }


                inCD.Save();        // 保存收入单位帐号余额
                outCD.Save();       // 保存支出单位的帐号余额
                this.Save();        // 保存
            }
        }

        /// <summary>
        /// 校对对象
        /// </summary>
        /// <returns></returns>
        public override bool Verify()
        {
            Error_Info.Clear();
            if (this.In_CompanyDetail_ID <= 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("In_CompanyDetail_ID", "请选择收入单位帐号！"));
            }

            if (this.Out_CompanyDetail_ID <= 0)
                Error_Info.Add(new KeyValuePair<string, string>("Out_CompanyDetail_ID", "请选择支出单位的帐号"));

            if (ContractApplyID > 0)
            {
                ContractApply cy = ContractApply.CreateByID(ContractApplyID);
                if (cy.Status == (long)ContractApplyStatusEnum.已支付)
                    Error_Info.Add(new KeyValuePair<string, string>("ContractApplyID", "您选择的合同申请号已经支付，无需再生成凭证！"));
            }

            return Error_Info.Count == 0;
        }


        /// <summary>
        /// 新增时，当前用户作为制作 人
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            MakerID = GlobalSet.Current_User.ID;

            // 如果是合同申请生成，则返写一个标志进去
            if (ContractApplyID > 0)
            {
                ContractApply cy = ContractApply.CreateByID(ContractApplyID);
                cy.Status = (long)ContractApplyStatusEnum.已开票;
                cy.Save();
            }

            // 如果是从合同验收生成的，要写到合同验收一个标志
            if (ContractAcceptID > 0)
            {
                ContractAccept c = ContractAccept.CreateByID(ContractAcceptID);
                c.Status = (long)ContractAcceptStatusEnum.已开票;
                c.Save();
            }
            return base.Insert();
        }

        public override bool Update()
        {
            // 如果更新了合同申请，则修改申请的标志
            if (ContractApplyID > 0)
            {
                // 先取得老的数据
                ContractApply old_c = ContractApply.CreateByID( Account.CreateByID(ID).ContractApplyID);
                ContractApply new_c = ContractApply.CreateByID(ContractApplyID);
                if (old_c.ID != ContractApplyID)  // 如果修改了合同申请
                {
                    old_c.Status = (long)ContractApplyStatusEnum.提交申请;
                    new_c.Status = (long)ContractApplyStatusEnum.已开票;
                }
            }
            return base.Update();
        }
    }
}
