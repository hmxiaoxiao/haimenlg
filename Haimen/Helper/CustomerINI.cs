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
        private static FTPClient m_ftp;

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

        /// <summary>
        /// 将数据库的联接参数写入配置文件
        /// </summary>
        /// <param name="host">服务器地址</param>
        /// <param name="db_name">数据库名</param>
        /// <param name="user_name">用户名</param>
        /// <param name="password">密码</param>
        public static void WriteDBConfig(string host, string db_name, string user_name, string password)
        {
            m_ini.IniWriteValue("connection", "host", host);
            m_ini.IniWriteValue("connection", "db", db_name);
            m_ini.IniWriteValue("connection", "user", user_name);
            m_ini.IniWriteValue("connection", "password", password);
        }

        /// <summary>
        /// 根据配置文件生成数据库的联接字符串
        /// </summary>
        /// <returns>数据库的联接字符串</returns>
        public static string GetConnectionString()
        {
            string host = m_ini.IniReadValue("connection", "host");
            string db = m_ini.IniReadValue("connection", "db");
            string user = m_ini.IniReadValue("connection", "user");
            string password = m_ini.IniReadValue("connection", "password");
            string connStr = @"Data Source=" + host + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + password;
            return connStr;
        }

        /// <summary>
        /// 写入FTP的配置文件
        /// </summary>
        /// <param name="host"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public static void WriteFTPConfig(string host, string user, string password)
        {
            m_ini.IniWriteValue("FTP", "host", host);
            m_ini.IniWriteValue("FTP", "user", user);
            m_ini.IniWriteValue("FTP", "password", password);
        }


        /// <summary>
        /// 从配置文件中取得已经配置好的FTPClient类
        /// </summary>
        /// <returns>已经配置好的FTPClient类</returns>
        public static FTPClient GetFTPClient()
        {
            if (m_ftp == null)
            {
                m_ftp = new FTPClient(m_ini.IniReadValue("FTP", "host"),
                                      m_ini.IniReadValue("FTP", "user"),
                                      m_ini.IniReadValue("FTP", "password"));
            }
            return m_ftp;
        }

        /// <summary>
        /// 取得<B>数据库配置文件</B>中配置的值
        /// </summary>
        /// <param name="key">配置</param>
        /// <returns>值</returns>
        public static string GetDBConfigValue(INIDBKeyEnum key)
        {
            string val = "";
            switch (key)
            {
                case INIDBKeyEnum.Host:
                    val = m_ini.IniReadValue("connection", "host");
                    break;
                case INIDBKeyEnum.DB:
                    val = m_ini.IniReadValue("connection", "db");
                    break;
                case INIDBKeyEnum.User:
                    val = m_ini.IniReadValue("connection", "user");
                    break;
                case INIDBKeyEnum.Password:
                    val = m_ini.IniReadValue("connection", "password");
                    break;
            }
            return val;
        }

        /// <summary>
        /// 取得<B>FTP配置文件</B>中配置的值
        /// </summary>
        /// <param name="key">配置</param>
        /// <returns>值</returns>
        public static string GetFTPConfigValue(INIFTPKeyEnum key)
        {
            string val = "";
            switch (key)
            {
                case INIFTPKeyEnum.Host:
                    val = m_ini.IniReadValue("FTP", "host");
                    break;
                case INIFTPKeyEnum.User:
                    val = m_ini.IniReadValue("FTP", "user");
                    break;
                case INIFTPKeyEnum.Password:
                    val = m_ini.IniReadValue("FTP", "password");
                    break;
            }
            return val;
        }
    }
}
