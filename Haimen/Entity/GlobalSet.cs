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

        private static List<Dict> m_list;
        public static List<Dict> CheckList
        {
            get
            {
                if (m_list == null)
                {
                    m_list = new List<Dict>();
                    m_list.Add(new Dict("未审核", 0));
                    m_list.Add(new Dict("审核通过", 1));
                    m_list.Add(new Dict("审核未通过", 2));
                    m_list.Add(new Dict("再次审核", 3));
                    m_list.Add(new Dict("支付中", 4));
                    m_list.Add(new Dict("关闭", 5));
                }
                return m_list;
            }
        }
    }

    /// <summary>
    /// 审核进度的状态
    /// </summary>
    public enum MyCheckStatus :long
    {
        /// <summary>
        /// 未审核
        /// </summary>
        Uncheck = 0,

        /// <summary>
        /// 审核通过
        /// </summary>
        Checked,

        /// <summary>
        /// 审核未通过
        /// </summary>
        Unpass,

        /// <summary>
        /// 再次审核
        /// </summary>
        ReCheck,

        /// <summary>
        /// 支付中
        /// </summary>
        Paying,

        /// <summary>
        /// 已关闭
        /// </summary>
        Close
    }
}
