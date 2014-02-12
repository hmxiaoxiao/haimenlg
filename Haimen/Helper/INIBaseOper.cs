using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;
using System.IO;

namespace Haimen.Helper
{
    /// <summary>
    /// INI文件的基本操作
    /// </summary>
    public class INIBaseOper
    {
        public string m_inipath;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="INIPath">文件路径</param>
        public INIBaseOper(string INIPath)
        {
            m_inipath = INIPath;
        }
        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        /// <param name="Value">值</param>
        /// <returns>成功为真，不成功为假</returns>
        public bool IniWriteValue(string Section, string Key, string Value)
        {
            return WritePrivateProfileString(Section, Key, Value, this.m_inipath) > 0 ;
        }

        /// <summary>
        /// 读出INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.m_inipath);
            return temp.ToString();
        }
        /// <summary>
        /// 验证文件是否存在
        /// </summary>
        /// <returns>布尔值</returns>
        public bool ExistINIFile()
        {
            return File.Exists(m_inipath);
        }
    }
}
