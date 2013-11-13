using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    /// <summary>
    /// 系统设置
    /// </summary>
    [Table("m_systemset")]
    class SystemSet : MEntityFunction<SystemSet>
    {
        public static string MONTHLY_YEAR = "MONTHLY_YEAR";
        public static string MONTHLY_MONTH = "MONTHLY_MONTH";

        private static long _year;
        private static long _month;

        private static void getYearMonth()
        {
            if (string.IsNullOrEmpty(GetValue(MONTHLY_YEAR)))
            {
                _year = 0;
                _month = 0;
            }
            else
            {
                _year = long.Parse(GetValue(MONTHLY_YEAR));
                _month = long.Parse(GetValue(MONTHLY_MONTH));

                if (_month == 12)
                {
                    _year += 1;
                    _month = 1;
                }
                else
                {
                    _month += 1;
                }
            }
        }

        static SystemSet()
        {
            getYearMonth();
        }

        [Field("name")]
        public string Name { get; set; }

        [Field("value")]
        public string Value { get; set; }

        /// <summary>
        /// 当前设置表中的所有数据
        /// </summary>
        private static List<SystemSet> m_all_list = SystemSet.Query();

        /// <summary>
        /// 取得指定的键的值
        /// </summary>
        /// <param name="name">键的名称</param>
        /// <returns>值</returns>
        public static string GetValue(string name)
        {
            //先查找值
            m_all_list = SystemSet.Query();
            foreach (SystemSet s in m_all_list)
            {
                if (s.Name == name)
                    return s.Value;
            }

            // 这里没有找到的处理,自动新增一个键值
            SystemSet ss = new SystemSet();
            ss.Name = name;
            ss.Value = "";
            ss.Save();
            m_all_list.Add(ss);
            return ss.Value;
        }


        /// <summary>
        /// 保存要设置的键值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetValue(string name, string value)
        {
            foreach (SystemSet s in m_all_list)
            {
                if (s.Name == name)
                {
                    s.Value = value;
                    s.Save();
                    return;
                }
            }

            SystemSet ss = new SystemSet();
            ss.Name = name;
            ss.Value = value;
            ss.Save();
            m_all_list = SystemSet.Query();

            return;
        }

        /// <summary>
        /// 取得当前帐期
        /// </summary>
        /// <returns>年月，如果没有则显示尚未结过帐</returns>
        public static string CurrentAccount()
        {
            getYearMonth();
            if (_year == 0)
                return "尚未结过帐";
            return _year.ToString() + "年" + _month.ToString() + "月";
        }


        public static long GetAccountMonth()
        { 
            getYearMonth(); 
            return _month;
        }

        public static long GetAccountYear()
        {
            getYearMonth();
            return _year;
        }
    }
}
