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

        public static List<Dict> CheckList = Dict.Query("belong = 'Check'");

    }
}
