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
    public class FAccess
    {
        public string Name { get; set; }

        public bool View { get; set; }

        public bool New { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public bool Check { get; set; }

        public long UserID { get; set; }

        public long GroupID { get; set; }
    }

    /// <summary>
    /// 权限记录
    /// </summary>
    [Table("q_access")]
    public class Access : MEntityFunction<Access>
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Field("user_id")]
        public long UserID { get; set; }


        /// <summary>
        /// 业务ID
        /// </summary>
        [Field("fction_id")]
        public long FunctionID { get; set; }

        /// <summary>
        /// 操作ID
        /// </summary>
        [Field("action_id")]
        public long ActionID { get; set; }

        /// <summary>
        /// 用户组
        /// </summary>
        [Field("ugroup_id")]
        public long UserGroupID { get; set; }

        /// <summary>
        /// 是否有权限，0为无权限，其他为有权限
        /// </summary>
        [Field("access")]
        public byte CanAccess { get; set; }


        public static List<FAccess> UserAccess2List(User user)
        {
            List<FAccess> rtn_list = new List<FAccess>();
            foreach (long fction in Enum.GetValues(typeof(FctionEnum)))
            {
                FAccess fa = new FAccess();
                fa.UserID = user.ID;
                fa.GroupID = user.UserGroupID;
                fa.Name = Enum.GetName(typeof(FctionEnum), fction);
                fa.View = getUserAccess(user.ID, user.UserGroupID, fction, (long)ActionEnum.View);
                fa.New = getUserAccess(user.ID, user.UserGroupID, fction, (long)ActionEnum.New);
                fa.Edit = getUserAccess(user.ID, user.UserGroupID, fction, (long)ActionEnum.Edit);
                fa.Delete = getUserAccess(user.ID, user.UserGroupID, fction, (long)ActionEnum.Delete);
                fa.Check = getUserAccess(user.ID, user.UserGroupID, fction, (long)ActionEnum.Check);
                rtn_list.Add(fa);
            }
            return rtn_list;
        }

        public static List<FAccess> UserGroupAccess2List(long usergroup_id)
        {
            List<FAccess> rtn_list = new List<FAccess>();
            foreach (long fction in Enum.GetValues(typeof(FctionEnum)))
            {
                FAccess fa = new FAccess();
                fa.UserID = 0;
                fa.GroupID = usergroup_id;
                fa.Name = Enum.GetName(typeof(FctionEnum), fction);
                fa.View = GetUserGroupAccess(usergroup_id, fction, (long)ActionEnum.View);
                fa.New = GetUserGroupAccess(usergroup_id, fction, (long)ActionEnum.New);
                fa.Edit = GetUserGroupAccess(usergroup_id, fction, (long)ActionEnum.Edit);
                fa.Delete = GetUserGroupAccess(usergroup_id, fction, (long)ActionEnum.Delete);
                fa.Check = GetUserGroupAccess(usergroup_id, fction, (long)ActionEnum.Check);
                rtn_list.Add(fa);
            }
            return rtn_list;
        }


        public static bool getUserAccess(long user_id, long group_id, long ft, long at)
        {
            string sql = " user_id = " + user_id + 
                         " and fction_id = " + ft + 
                         " and action_id = " + (long)at;
            List<Access> list = Access.Query(sql);
            if (list.Count > 0)
                return list[0].CanAccess != 0;
            else
                return GetUserGroupAccess(group_id, ft, at);

        }

        public static bool GetUserGroupAccess(long usergroup_id, long ft, long at)
        {
            string sql = " ugroup_id = " + usergroup_id +
             " and fction_id = " + (long)ft +
             " and action_id = " + (long)at;
            List<Access> list = Access.Query(sql);
            if (list.Count > 0)
                return list[0].CanAccess != 0;
            else
                return false;
        }

        // 保存用户权限
        public static void SaveUserAll(List<FAccess> lists, long user_id, long group_id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string sql = "Delete from q_access where user_id = " + user_id.ToString();
            using (TransactionScope ts = new TransactionScope())
            {
                // 先删除已经存在在权限
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                foreach (FAccess acc in lists)
                {
                    foreach (long fction in Enum.GetValues(typeof(FctionEnum)))
                    {
                        foreach (long action in Enum.GetValues(typeof(ActionEnum)))
                        {
                            bool user_acc = false;
                            if (action == (long)ActionEnum.View && acc.View)
                                user_acc = true;
                            else if (action == (long)ActionEnum.New && acc.New)
                                user_acc = true;
                            else if (action == (long)ActionEnum.Edit && acc.Edit)
                                user_acc = true;
                            else if (action == (long)ActionEnum.Delete && acc.Delete)
                                user_acc = true;
                            else if (action == (long)ActionEnum.Check && acc.Check)
                                user_acc = true;
                            bool group_acc = GetUserGroupAccess(group_id, fction, action);
                            if (user_acc != group_acc)
                                SaveUserAccess(user_id, group_id, fction, action, user_acc);
                        }
                    }
                }

                ts.Complete();
            }
        }


        // 保存用户组权限
        public static void SaveGroupAll(List<FAccess> lists, long group_id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string sql = "Delete from q_access where ugroup_id = " + group_id.ToString();
            using (TransactionScope ts = new TransactionScope())
            {
                // 先删除已经存在在权限
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                // 加上本次赋予的权限
                foreach (FAccess acc in lists)
                {
                    foreach (long fction in Enum.GetValues(typeof(FctionEnum)))
                    {
                        if (acc.Name == Enum.GetName(typeof(FctionEnum), fction))
                        {
                            foreach (long action in Enum.GetValues(typeof(ActionEnum)))
                            {
                                if (action == (long)ActionEnum.View && acc.View)
                                    SaveGroupAccess(group_id, fction, action);
                                else if (action == (long)ActionEnum.New && acc.New)
                                    SaveGroupAccess(group_id, fction, action);
                                else if (action == (long)ActionEnum.Edit && acc.Edit)
                                    SaveGroupAccess(group_id, fction, action);
                                else if (action == (long)ActionEnum.Delete && acc.Delete)
                                    SaveGroupAccess(group_id, fction, action);
                                else if (action == (long)ActionEnum.Check && acc.Check)
                                    SaveGroupAccess(group_id, fction, action);
                            }
                        }
                    }
                }
                ts.Complete();
            }
        }

        public static void SaveGroupAccess(long group_id, long fction, long act)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                Access acc = new Access();
                acc.UserGroupID = group_id;
                acc.FunctionID = fction;
                acc.ActionID = (long)act;
                acc.CanAccess = 1;
                acc.Save();
                ts.Complete();
            }
        }

        public static void SaveUserAccess(long user_id, long group_id, long fction, long act, bool use_acc)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                Access acc = new Access();
                acc.UserID = user_id;
                acc.UserGroupID = group_id;
                acc.FunctionID = fction;
                acc.ActionID = (long)act;
                if (use_acc)
                    acc.CanAccess = 1;
                else
                    acc.CanAccess = 0;
                acc.Save();
                ts.Complete();
            }
        }
    }
}
