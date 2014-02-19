using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;

namespace Haimen.Entity
{
    /// <summary>
    /// 系统设置
    /// </summary>
    [Table("m_systemset")]
    class SystemSet : SingleEntity<SystemSet>
    {
        // TODO : 这里可以做成ENUM
        public static string MONTHLY_YEAR = "MONTHLY_YEAR";     // 已经结帐的帐期的年份
        public static string MONTHLY_MONTH = "MONTHLY_MONTH";   // 已经结帐的帐期的月份

        private static long m_year;     // 当前帐期年份
        private static long m_month;    // 当前帐期月份


        static SystemSet()
        {
            getYearMonth();
        }


        /// <summary>
        /// 系统的key
        /// </summary>
        [Field("name")]
        public string Name { get; set; }


        /// <summary>
        /// 系统key的值
        /// </summary>
        [Field("value")]
        public string Value { get; set; }

        /// <summary>
        /// 取得当前的帐期
        /// 为已经结帐年月+1月
        /// </summary>
        private static void getYearMonth()
        {
            if (string.IsNullOrEmpty(GetValue(MONTHLY_YEAR)))
            {
                m_year = 0;
                m_month = 0;
            }
            else
            {
                m_year = long.Parse(GetValue(MONTHLY_YEAR));
                m_month = long.Parse(GetValue(MONTHLY_MONTH));

                if (m_month == 12)
                {
                    m_year += 1;
                    m_month = 1;
                }
                else
                {
                    m_month += 1;
                }
            }
        }


        /// <summary>
        /// 当前设置表中的所有数据
        /// </summary>
        private static List<SystemSet> m_all_list = SystemSet.Query();

        /// <summary>
        /// 取得指定的键的值
        /// </summary>
        /// <param name="key">键的名称</param>
        /// <returns>值</returns>
        public static string GetValue(string key)
        {
            //先查找值
            m_all_list = SystemSet.Query();
            foreach (SystemSet s in m_all_list)
            {
                if (s.Name == key)
                    return s.Value;
            }

            // 这里没有找到的处理,自动新增一个键值
            SystemSet ss = new SystemSet();
            ss.Name = key;
            ss.Value = "";
            if (DBConnection.Transaction != null)
                ss.Save(true);
            else
                ss.Save();
            m_all_list.Add(ss);
            return ss.Value;
        }


        /// <summary>
        /// 保存要设置的键值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValue(string key, string value)
        {
            // 如果已经存在键，则更新
            foreach (SystemSet s in m_all_list)
            {
                if (s.Name == key)
                {
                    s.Value = value;
                    if (DBConnection.Transaction != null)
                        s.Save(true);
                    else
                        s.Save();
                    return;
                }
            }

            // 没有找到，则新增
            SystemSet ss = new SystemSet() { Name = key, Value = value };
            if (DBConnection.Transaction != null)
                ss.Save(true);
            else
                ss.Save();
            m_all_list = SystemSet.Query();
        }

        /// <summary>
        /// 取得当前帐期
        /// </summary>
        /// <returns>年月，如果没有则显示尚未结过帐</returns>
        public static string CurrentAccount()
        {
            getYearMonth();     // 再计算一次，以防已经结过帐了。
            if (m_year == 0)
                return "尚未结过帐";
            return String.Format("{0}年{1}月", m_year, m_month);
        }

        /// <summary>
        /// 取得当前的帐期月份
        /// </summary>
        /// <returns></returns>
        public static long GetAccountMonth()
        { 
            getYearMonth();     //更新一下
            return m_month;
        }


        /// <summary>
        /// 取得当前的帐期年份
        /// </summary>
        /// <returns></returns>
        public static long GetAccountYear()
        {
            getYearMonth();    // 更新一下。
            return m_year;
        }


        /// <summary>
        /// 这里删除，不作校验。
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            return true;
        }

        /// <summary>
        /// 这里增加，更新数据不作校验
        /// </summary>
        /// <returns></returns>
        public override bool InsertUpdateVerify()
        {
            return true;
        }
    }
}
