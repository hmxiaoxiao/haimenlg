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

    /// <summary>
    /// 每个业务的功能
    /// </summary>
    public enum ActionEnum : long
    {
        /// <summary>
        /// 查看
        /// </summary>
        View  = 1,

        /// <summary>
        /// 新增
        /// </summary>
        New,

        /// <summary>
        /// 编辑
        /// </summary>
        Edit,

        /// <summary>
        /// 删除
        /// </summary>
        Delete,

        /// <summary>
        /// 审核
        /// </summary>
        Check,
    }


    /// <summary>
    /// 业务列表
    /// </summary>
    public enum FctionEnum : long
    {
        资金往来 = 1,
        合同,
        合同验收,
        贷款,
        银行,
        单位,
        资金性质,
        单位帐户明细,
        项目,
        用户,
        通知,
        承兑汇票,
        权限,
    }

}
