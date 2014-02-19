using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.DB;
using Haimen.Helper;

using System.Transactions;
using System.Data.SqlClient;

namespace Haimen.Entity
{
    /// <summary>
    /// 业务列表
    /// </summary>
    public enum FctionEnum : long
    {
        授权资金 = 10,
        非授权资金 = 11,
        合同 = 20,
        合同验收 = 30, 
        贷款 = 40,
        承兑汇票 = 50,
        银行 = 60,
        单位 = 70,
        单位帐户 = 80,
        资金性质 = 90,
        项目 = 100,
        用户 = 110,
        用户组 = 120,
        通知 = 130,
        权限 = 140,
        余额表 = 150,
        月结 = 160,
    }

    /// <summary>
    /// 每个业务的功能
    /// </summary>
    public enum ActionEnum : long
    {
        查看 = 1,
        新增,
        编辑,
        删除,
        审核,
        撤审,
        支付,
        取消支付,
        打印,
        完结,     // 承兑汇票用
        转正式发票,
    }

    /// <summary>
    /// 权限记录
    /// </summary>
    [Table("q_access")]
    public class Access : SingleEntity<Access>
    {
        public Access()
        {
        }

        public Access(string type, long functionid, string functionname,
                      long actionid, string actionname, byte access = 0,
                      long userid = 0, long groupid = 0 )
        {
            UserID = userid;
            UserGroupID = groupid;
            FunctionType = type;
            FunctionID = functionid;
            FunctionName = functionname;
            ActionID = actionid;
            ActionName = actionname;
            CanAccess = access;
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Field("user_id")]
        public long UserID { get; set; }

        /// <summary>
        /// 用户组
        /// </summary>
        [Field("ugroup_id")]
        public long UserGroupID { get; set; }


        /// <summary>
        /// 功能类别
        /// </summary>
        public string FunctionType { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [Field("fction_id")]
        public long FunctionID { get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        public string FunctionName { get; set; }


        /// <summary>
        /// 操作ID
        /// </summary>
        [Field("action_id")]
        public long ActionID { get; set; }

        /// <summary>
        /// 操作名称 
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// 是否有权限，0为无权限，其他为有权限
        /// </summary>
        [Field("access")]
        public byte CanAccess { get; set; }

        /// <summary>
        /// 标志是否要重新载入数据
        /// </summary>
        private static bool m_must_reload = true;
        private static List<Access> m_all_list = Access.Query();


        /// <summary>
        /// 指定用户（用户组）的权限列表
        /// </summary>
        private static List<Access> m_list;

        /// <summary>
        /// 取得指定用户的权限列表
        /// </summary>
        /// <param name="id">用户或者用户组的ID</param>
        /// <param name="is_user">真，ID为用户的ID，假为用户组的ID。默认为真</param>
        /// <returns></returns>
        public static List<Access> GetAccessList(long id, bool is_user = true)
        {
            init_list();        // 初始化列表

            // 从数据库读取数据，如果需要的话
            if (m_must_reload)
            {
                m_all_list = Access.Query();
                m_must_reload = false;
            }

            // 针对用户或者用户组进行处理
            if (is_user)
            {
                foreach (Access a in m_list)
                {
                    a.UserGroupID = 0;
                    a.UserID = id;
                    a.CanAccess = getUserAccess(User.CreateByID(id), a.FunctionID, a.ActionID) ? (byte)1 : (byte)0;
                }
            }
            else
            {
                foreach (Access a in m_list)
                {
                    a.UserGroupID = id;
                    a.UserID = 0;
                    a.CanAccess = getUserGroupAccess(id, a.FunctionID, a.ActionID) ? (byte)1 : (byte)0;
                }
            }
            return m_list;
        }


        /// <summary>
        /// 初始化用户的权限列表
        /// </summary>
        private static void init_list ()
        {
            if (m_list == null)
            {
                m_list = new List<Access>();
                //资金
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));
                m_list.Add(new Access("业务", (long)FctionEnum.授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.授权资金), (long)ActionEnum.转正式发票, Enum.GetName(typeof(ActionEnum), ActionEnum.转正式发票)));

                m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));
                //m_list.Add(new Access("业务", (long)FctionEnum.非授权资金, Enum.GetName(typeof(FctionEnum), FctionEnum.非授权资金), (long)ActionEnum.转正式发票, Enum.GetName(typeof(ActionEnum), ActionEnum.转正式发票)));


                m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.合同, Enum.GetName(typeof(FctionEnum), FctionEnum.合同), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.合同验收, Enum.GetName(typeof(FctionEnum), FctionEnum.合同验收), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.贷款, Enum.GetName(typeof(FctionEnum), FctionEnum.贷款), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));
                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.完结, Enum.GetName(typeof(ActionEnum), ActionEnum.完结)));

                m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.银行, Enum.GetName(typeof(FctionEnum), FctionEnum.银行), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位, Enum.GetName(typeof(FctionEnum), FctionEnum.单位), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.单位帐户, Enum.GetName(typeof(FctionEnum), FctionEnum.单位帐户), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.资金性质, Enum.GetName(typeof(FctionEnum), FctionEnum.资金性质), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("基础数据", (long)FctionEnum.项目, Enum.GetName(typeof(FctionEnum), FctionEnum.项目), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户, Enum.GetName(typeof(FctionEnum), FctionEnum.用户), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.用户组, Enum.GetName(typeof(FctionEnum), FctionEnum.用户组), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.通知, Enum.GetName(typeof(FctionEnum), FctionEnum.通知), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

                m_list.Add(new Access("系统管理", (long)FctionEnum.月结, Enum.GetName(typeof(FctionEnum), FctionEnum.月结), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("系统管理", (long)FctionEnum.权限, Enum.GetName(typeof(FctionEnum), FctionEnum.权限), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));


                m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                m_list.Add(new Access("报表", (long)FctionEnum.余额表, Enum.GetName(typeof(FctionEnum), FctionEnum.余额表), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));
            }
        }


        /// <summary>
        /// 删除不作校验
        /// </summary>
        /// <returns></returns>
        public override bool DeleteVerify()
        {
            return true;
        }

        /// <summary>
        /// 增加修改不作校验 
        /// </summary>
        /// <returns></returns>
        public override bool InsertUpdateVerify()
        {
            return true;
        }



        /// <summary>
        /// 保存当前用户权限列表
        /// </summary>
        public static void SaveAccessList()
        {
            // 从数据库读取数据，如果需要的话
            if (m_must_reload)
            {
                m_all_list = Access.Query();
                m_must_reload = false;
            }

            try
            {
                DBConnection.BeginTrans();
                bool success = true;

                // 保存前先删除已经存在的数据
                SqlCommand cmd = DBConnection.getCommand();
                string sql;
                if (m_list[0].UserID > 0)
                    sql = "delete from q_access where user_id = " + m_list[0].UserID;
                else
                    sql = "delete from q_access where ugroup_id = " + m_list[0].UserGroupID;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                // 保存每个权限对象
                if (m_list[0].UserID > 0)       // 如果是用户保存
                {
                    User u = User.CreateByID(m_list[0].UserID);
                    foreach (Access a in m_list)
                    {
                        // 只有用户的权限 与 该用户所属的用户组的权限不一致才会保存
                        if (a.CanAccess != (getUserGroupAccess(u.GroupID, a.FunctionID, a.ActionID) ? (byte)1 : (byte)0))
                            if (!a.Insert(true))
                                success = false;
                    }
                }
                else   // 用户组保存
                {
                    // 用户组只保存有权限的
                    foreach (Access a in m_list)
                    {
                        if (a.CanAccess != 0)
                            if (!a.Insert(true))
                                success = false;
                    }
                }

                // 提交事务
                if (success)
                    DBConnection.CommitTrans();
                else
                    DBConnection.RollbackTrans();

                // 列表必须要更新了。
                m_must_reload = true;
            }
            catch(Exception e)
            {
                if(DBConnection.Transaction != null)
                    DBConnection.RollbackTrans();
                string msg = string.Format("保存权限出现错误，原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new EntityException(msg, e);
            }
        }


        /// <summary>
        /// 判断当前的用户的权限
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="function">业务</param>
        /// <param name="action">行为</param>
        /// <returns>可以使用为真，否则为假</returns>
        public static bool getUserAccess(User user, long function, long action)
        {
            // 如果是超级用户，可以直接使用
            if (user.Admin == "X")
                return true;

            // 从数据库读取数据，如果需要的话
            if (m_must_reload)
            {
                m_all_list = Access.Query();
                m_must_reload = false;
            }

            // 判断权限
            foreach (Access a in m_all_list)
            {
                if (a.UserID == user.ID && a.FunctionID == function && a.ActionID == action)
                    return a.CanAccess != 0;
            }
            return getUserGroupAccess(user.GroupID, function,action);
        }

        /// <summary>
        /// 判断对应用户组的权限
        /// </summary>
        /// <param name="groupid">用户组ID</param>
        /// <param name="function">业务</param>
        /// <param name="action">功能</param>
        /// <returns>可以使用为真，否则为假</returns>
        public static bool getUserGroupAccess(long groupid, long function, long action)
        {
            // 从数据库读取数据，如果需要的话
            if (m_must_reload)
            {
                m_all_list = Access.Query();
                m_must_reload = false;
            }

            foreach (Access a in m_all_list)
            {
                if (a.UserGroupID == groupid && a.FunctionID == function && a.ActionID == action)
                    return a.CanAccess != 0;
            }
            return false;
        }
    }
}
