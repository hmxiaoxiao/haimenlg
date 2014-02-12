using System;
using System.Collections.Generic;
using System.Linq;

using Haimen.Entity;

namespace Haimen.Helper
{
    /// <summary>
    /// 自定义配置文件
    /// 含配置文件中的皮肤，数据库，FTP的读取与写入
    /// </summary>
    public static class  INICustomer
    {
        private static INIBaseOper m_ini;       // INI配置文件的文件名
        private static FTPClient m_ftp;     // FTP的配置

        // 构造函数，对配置文件进行初始化
        static INICustomer()
        {
            m_ini = new INIBaseOper(GlobalSet.INIFile);
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
            if (!m_ini.ExistINIFile())
                return "";
            else
                return m_ini.IniReadValue("skin", "name");
        }

        /// <summary>
        /// 设置当前窗口的皮肤
        /// </summary>
        public static void SetFormSkin()
        {
            // TODO: 这个方法放在里面不太好
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
        /// <returns>数据库的联接字符串，如果字符串为空的话，就说明取值出问题了</returns>
        public static string GetConnectionString()
        {
            if (!m_ini.ExistINIFile())
            {
                throw new HelperException("配置文件config.ini不存在，无法取得数据库联接参数！");
            }
            string host = GetDBConfigValue(INIDBKeyEnum.Host);
            string db = GetDBConfigValue(INIDBKeyEnum.DB);
            string user = GetDBConfigValue(INIDBKeyEnum.User);
            string password = GetDBConfigValue(INIDBKeyEnum.Password);
            string connStr = String.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}", host, db, user, password);
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
            if (!m_ini.ExistINIFile())
            {
                throw new HelperException("配置文件config.ini不存在，无法取得FTP的配置。");
            }

            try
            {
                if (m_ftp == null)
                {
                    m_ftp = new FTPClient(GetFTPConfigValue(INIFTPKeyEnum.Host),
                                          GetFTPConfigValue(INIFTPKeyEnum.User),
                                          GetFTPConfigValue(INIFTPKeyEnum.Password));
                }
                return m_ftp;
            }
            catch (Exception)
            {
                throw new HelperException("创建FTP出错");
            }
        }

        /// <summary>
        /// 取得<B>数据库配置文件</B>中配置的值
        /// </summary>
        /// <param name="key">配置</param>
        /// <returns>值</returns>
        public static string GetDBConfigValue(INIDBKeyEnum key)
        {
            // 判断INI是否存在
            if (!m_ini.ExistINIFile())
            {
                return "";
            }

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
            if (!m_ini.ExistINIFile())
            {
                return "";
            }

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
