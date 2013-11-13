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
            m_all_list.Add(ss);
            return;
        }
    }
}
