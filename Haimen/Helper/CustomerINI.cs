using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Entity;

namespace Haimen.Helper
{
    public static class  CustomerINI
    {
        private static INIFile m_ini;

        static CustomerINI()
        {
            m_ini = new INIFile(GlobalSet.INIFile);
        }

        /// <summary>
        /// 记录当前选择的皮肤名称
        /// </summary>
        /// <param name="name">名称</param>
        public static void WriteSkinName(string name)
        {
            m_ini.IniWriteValue("skin", "name", name);
        }

        /// <summary>
        /// 读取上次选择的皮肤名称
        /// </summary>
        /// <returns>皮肤名称</returns>
        public static string ReadSkinName()
        {
            return m_ini.IniReadValue("skin", "name");
        }

        /// <summary>
        /// 设置当前窗口的皮肤
        /// </summary>
        public static void SetFormSkin()
        {
            string skin_name = ReadSkinName();
            if (!(skin_name == null || skin_name == ""))
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skin_name);
        }

        public static void WriteDBConfig(string host, string db_name, string user_name, string password)
        {
            m_ini.IniWriteValue("connection", "host", host);
            m_ini.IniWriteValue("connection", "db", db_name);
            m_ini.IniWriteValue("connection", "user", user_name);
            m_ini.IniWriteValue("connection", "password", password);
        }

        public static string GetConnectionString()
        {
            string host = m_ini.IniReadValue("connection", "host");
            string db = m_ini.IniReadValue("connection", "db");
            string user = m_ini.IniReadValue("connection", "user");
            string password = m_ini.IniReadValue("connection", "password");
            string connStr = @"Data Source=" + host + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + password;
            return connStr;
        }

    }
}
