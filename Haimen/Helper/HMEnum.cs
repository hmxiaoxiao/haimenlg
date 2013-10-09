using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.Helper
{
    // 当前窗口的状态
    public enum winStatusEnum
    {
        查看,
        新增,
        编辑,
        审核,
        支付,
        纯查看,
        转正式发票,
    }

    /// <summary>
    /// 在INI中关于数据库的KEY
    /// </summary>
    public enum INIDBKeyEnum
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

    /// <summary>
    /// INI中关于FTP的配置KEY
    /// </summary>
    public enum INIFTPKeyEnum
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

    public enum CheckStatusEnum
    {
        WaitCheck = 1,
        Checked ,
        Paying ,
        Done
    }

    /// <summary>
    /// 用户组
    /// </summary>
    public enum  UserGroupEnum : long 
    {
        /// <summary>
        /// 操作组
        /// </summary>
        Operation = 1,

        /// <summary>
        /// 审核组
        /// </summary>
        Checker,

        /// <summary>
        /// 管理组
        /// </summary>
        Manager

    }


}
