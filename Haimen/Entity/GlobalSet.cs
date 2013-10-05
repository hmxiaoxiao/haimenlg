using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Haimen.Entity
{
    // 全局变量的类，可以理解为全局的设置
    public static class GlobalSet
    {
        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static User Current_User { get; set; }
        

        /// <summary>
        /// 系统的名称，用作所有登录窗口以及主窗口的名称
        /// </summary>
        public static String SystemName { get; set; }

        /// <summary>
        /// 系统配置文件的名称
        /// </summary>
        public static string INIFile 
        { 
            get 
            {
                string path = System.Environment.CurrentDirectory;
                return Path.Combine(path, "config.ini");
            } 
        }

        private static List<Dict> m_account_status;
        public static List<Dict> AccountStatus
        {
            get
            {
                if (m_account_status == null)
                {
                    m_account_status = new List<Dict>();
                    m_account_status.Add(new Dict("未审核", 0));
                    m_account_status.Add(new Dict("审核通过", 1));
                    m_account_status.Add(new Dict("审核未通过", 2));
                    m_account_status.Add(new Dict("再次审核", 3));
                    m_account_status.Add(new Dict("已支付", 4));
                    m_account_status.Add(new Dict("关闭", 5));
                }
                return m_account_status;
            }
        }

        private static List<Dict> m_contract_status;
        public static List<Dict> ContractStatus
        {
            get
            {
                if (m_contract_status == null)
                {
                    m_contract_status = new List<Dict>();
                    m_contract_status.Add(new Dict("未审核",0));
                    m_contract_status.Add(new Dict("审核通过",1));
                    m_contract_status.Add(new Dict("审核未通过",2));
                    m_contract_status.Add(new Dict("再次审核",3));
                    m_contract_status.Add(new Dict("付款中",4));
                    m_contract_status.Add(new Dict("已验收", 5));
                    m_contract_status.Add(new Dict("验收未通过", 6));
                    m_contract_status.Add(new Dict("已中止", 7));
                }
                return m_contract_status;
            }
        }

        public static List<Dict> m_accept_status;
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
    }

    /// <summary>
    /// 合同验收的状态，就是开票未开票
    /// </summary>
    public enum ContractAcceptStatusEnum : long
    {
        未开票 = 0,
        已开票,
    }

    /// <summary>
    /// 资金的状态
    /// </summary>
    public enum AccountStatusEnum :long
    {
        未审核 = 0,
        审核通过,
        审核未通过,
        再次审核,
        已支付,
        已关闭
    }
}
