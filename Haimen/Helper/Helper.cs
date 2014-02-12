using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace Haimen.Helper
{
    /// <summary>
    /// 常用的函数放在这里
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// 将数字转换为货币大写
        /// </summary>
        /// <param name="x">货币</param>
        /// <returns>大写的货币</returns>
        public static string ConvertToChinese(double x)
        {
            string s = x.ToString("#L#E#D#C#K#E#D#C#J#E#D#C#I#E#D#C#H#E#D#C#G#E#D#C#F#E#D#C#.0B0A");
            string d = Regex.Replace(s, @"((?<=-|^)[^1-9]*)|((?'z'0)[0A-E]*((?=[1-9])|(?'-z'(?=[F-L\.]|$))))|((?'b'[F-L])(?'z'0)[0A-L]*((?=[1-9])|(?'-z'(?=[\.]|$))))", "${b}${z}");
            string v = Regex.Replace(d, ".", m => "负元空零壹贰叁肆伍陆柒捌玖空空空空空空空分角拾佰仟万亿兆京垓秭穰"[m.Value[0] - '-'].ToString());
            if (v.Length > 0 && v.Substring(v.Length-1) == "元")
                v += "整";
            return v;
        }

        /// <summary>
        /// 取得二个时间的差值
        /// </summary>
        /// <param name="dtBegin">开始时间</param>
        /// <param name="dtEnd">结束时间</param>
        /// <returns>二个时间的跨度，用中文表示</returns>
        public static string DateDiff(DateTime dtBegin, DateTime dtEnd)
        {
            string dateDiff = null;
            TimeSpan tsBegin = new TimeSpan(dtBegin.Ticks);
            TimeSpan tsEnd = new TimeSpan(dtEnd.Ticks);
            TimeSpan ts = tsBegin.Subtract(tsEnd).Duration();
            dateDiff = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒" + ts.Milliseconds.ToString() + "毫秒";
            return dateDiff;
        }
    }
}
