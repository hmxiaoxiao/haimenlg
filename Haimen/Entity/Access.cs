using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;
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
        资金 = 10,
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
    }

    /// <summary>
    /// 权限记录
    /// </summary>
    [Table("q_access")]
    public class Access : MEntityFunction<Access>
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
        /// 所有用户、用户组的权限列表
        /// </summary>
        private static List<Access> AllAccess {
            get {
                if (m_must_reload)
                {
                    m_all_list = Access.Query();
                    m_must_reload = false;
                }
                return m_all_list;
            }
        }

        

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

            // 针对用户或者用户组进行处理
            foreach (Access a in m_list)
            {
                a.UserGroupID = 0;
                a.UserID = id;
                a.CanAccess = getUserAccess(id, a.FunctionID, a.ActionID, is_user) ? (byte)1 : (byte)0;
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
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.查看, Enum.GetName(typeof(ActionEnum), ActionEnum.查看)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.新增, Enum.GetName(typeof(ActionEnum), ActionEnum.新增)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.编辑, Enum.GetName(typeof(ActionEnum), ActionEnum.编辑)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.删除, Enum.GetName(typeof(ActionEnum), ActionEnum.删除)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                m_list.Add(new Access("业务", (long)FctionEnum.资金, Enum.GetName(typeof(FctionEnum), FctionEnum.资金), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

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
                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.审核, Enum.GetName(typeof(ActionEnum), ActionEnum.审核)));
                m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.撤审, Enum.GetName(typeof(ActionEnum), ActionEnum.撤审)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.支付, Enum.GetName(typeof(ActionEnum), ActionEnum.支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.取消支付, Enum.GetName(typeof(ActionEnum), ActionEnum.取消支付)));
                //m_list.Add(new Access("业务", (long)FctionEnum.承兑汇票, Enum.GetName(typeof(FctionEnum), FctionEnum.承兑汇票), (long)ActionEnum.打印, Enum.GetName(typeof(ActionEnum), ActionEnum.打印)));

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
        /// 保存当前用户权限列表
        /// </summary>
        public static void SaveAccessList()
        {
            // 保存前先删除已经存在的数据
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string sql;
            if (m_list[0].UserID > 0)
                sql = "delete from q_access where user_id = " + m_list[0].UserID.ToString();
            else
                sql = "Delete from q_access where ugroup_id = " + m_list[0].UserGroupID.ToString();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            // 保存每个权限对象

            if (m_list[0].UserID > 0)       // 如果是用户保存
            {
                User u = User.CreateByID(m_list[0].UserID);
                foreach (Access a in m_list)
                {
                    // 只有用户的权限 与 该用户所属的用户组的权限不一致才会保存
                    if (a.CanAccess != (getUserAccess(u.UserGroupID, a.FunctionID, a.ActionID, false) ? (byte)1 : (byte)0))
                        a.Save();
                }
            }
            else   // 用户组保存
            {
                // 用户组只保存有权限的
                foreach(Access a in m_list)
                {
                    if (a.CanAccess != 0)
                        a.Save();
                }
            }
            m_must_reload = true; 
        }

        /// <summary>
        /// 取得指定用户的业务权限
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <param name="ft">业务</param>
        /// <param name="at">操作</param>
        /// <param name="is_user">是否为用户，真为用户，假为用户组</param>
        /// <returns></returns>
        public static bool getUserAccess(long id, long ft, long at, bool is_user = true)
        {
            // 如果是超级用户，可以直接使用
            User u;
            if (is_user)
            {
                u = User.CreateByID(id);
                if (u.Admin == "X") return true;
            }


            // 先判断是否要重新调用
            if (m_must_reload)
            {
                m_all_list = Access.Query();
                m_must_reload = false;
            }

            // 判断权限
            if (is_user)
            {
                foreach (Access a in m_all_list)
                {
                    if (a.UserID == id && a.FunctionID == ft && a.ActionID == at)
                        return a.CanAccess != 0;
                }
            }
            else
            {
                foreach (Access a in m_all_list)
                {
                    if (a.UserGroupID == id && a.FunctionID == ft && a.ActionID == at)
                        return a.CanAccess != 0;
                }
            }
            return false;
        }
    }
}
