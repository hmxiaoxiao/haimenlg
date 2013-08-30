using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.Helper
{
    // 当前窗口的状态
    public enum winStatus
    {
        /// <summary>
        /// 查看
        /// </summary>
        View,

        /// <summary>
        ///  新增
        /// </summary>
        New,

        /// <summary>
        /// 编辑
        /// </summary>
        Edit,
    }

    public enum INIDBKey
    {
        /// <summary>
        /// 服务器地址
        /// </summary>
        Host,

        /// <summary>
        /// 数据库名
        /// </summary>
        DB,

        /// <summary>
        /// 用户名
        /// </summary>
        User,

        /// <summary>
        /// 密码
        /// </summary>
        Password,
    }

    public enum INIFTPKey
    {
        /// <summary>
        /// FTP服务器地址
        /// </summary>
        Host,

        /// <summary>
        /// 用户名
        /// </summary>
        User,

        /// <summary>
        /// 密码
        /// </summary>
        Password,
    }
}
