using System;
using System.Collections.Generic;
using System.Linq;

using System.Data.SqlClient;
using System.Reflection;
using System.Data;

using Haimen.Entity;

namespace Haimen.DB
{
    /// <summary>
    /// 复杂对象的实体类，
    /// 复杂即指有主从关系之类的对象
    /// T为主表类型，U为明细类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class ComplexEntity<T, U> : SingleEntity<T>
        where T : new()
        where U : SingleEntity<U>, new()
    {
        /// <summary>
        /// 子对象列表
        /// </summary>
        public List<U> DetailList = new List<U>();

        // 附件列表
        private List<Attach> m_attachlist = null;
        public List<Attach> AttachList
        {
            get
            {
                if (m_attachlist == null)
                {
                    m_attachlist = Attach.Query("parent_id = " + ID);
                }
                return m_attachlist;
            }
            set
            {
                m_attachlist = value;
            }
        }


        /// <summary>
        /// 复杂对象的新增
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            try
            {
                bool success = base.Insert();

                // 先保存主数据
                if (success)
                {
                    // 保存明细数据
                    foreach (U u in DetailList)
                    {
                        // 明细类必须有ParentID的属性
                        PropertyInfo info = u.GetType().GetProperty("ParentID");

                        // 设置值
                        info.SetValue(u, this.ID, null);

                        // 保存
                        if (!u.Insert())
                            success = false;
                    }

                    // 保存附件信息
                    foreach (Attach a in AttachList)
                    {
                        a.ParentID = this.ID;
                        a.Save();
                    }
                }
                return success;
            }
            catch (Exception e)
            {
                string msg = string.Format("保存数据出错，原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }

        /// <summary>
        /// 复杂对象的更新
        /// </summary>
        /// <returns></returns>
        public override bool Update()
        {
            try
            {
                // 更新明细不同于新增
                // 新增可以不用判断，直接插入
                // 更新必须判断原明细是否在新的明细里，如果没有就要删除
                List<U> old_detail = new U().Find("parent_id = " + this.ID);
                foreach (U old in old_detail)
                {
                    if (old.ID > 0)
                    {
                        bool finded = false;
                        foreach (U n in DetailList)
                        {
                            if (n.ID == old.ID)
                                finded = true;
                        }
                        if (!finded)
                            old.Destory();
                    }
                }

                // 附件明细的删除
                List<Attach> attaches = Attach.Query("parent_id = " + this.ID);
                foreach (Attach old in attaches)
                {
                    bool finded = false;
                    foreach (Attach b in attaches)
                    {
                        if (b.ID == old.ID)
                            finded = true;
                    }
                    if (!finded)
                        old.Destory();
                }

                bool success = base.Update();
                foreach (U u in DetailList)
                {
                    // 明细类必须有parent_id的属性
                    PropertyInfo info = u.GetType().GetProperty("ParentID");

                    // 设置值
                    info.SetValue(u, this.ID, null);

                    // 保存
                    if (!u.Save())
                        success = false;
                }

                foreach (Attach a in AttachList)
                {
                    a.ParentID = this.ID;
                    if (!a.Save())
                        success = false;
                }

                return success;
            }
            catch (Exception e)
            {
                string msg = string.Format("更新数据时出错，原因如下：{0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }

        /// <summary>
        /// 删除对象
        /// </summary>
        public override void Destory()
        {
            try
            {
                // 先删除明细
                foreach (U u in DetailList)
                {
                    u.Destory();
                }

                // 删除附件
                foreach (Attach a in AttachList)
                {
                    a.Destory();
                }
                // 再删除主记录
                base.Destory();
            }
            catch (Exception e)
            {
                string msg = string.Format("删除数据出错，原因如下： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }

        /// <summary>
        /// 通过ID生成实体类
        /// </summary>
        /// <param name="id">实体ID</param>
        /// <returns>该ID对应的实体类</returns>
        public static new T CreateByID(long id)
        {
            try
            {

                string table_name = GetTableName(typeof(T));
                string sql = String.Format("Select * from {0} where id = {1}", table_name, id);

                SqlCommand cmd = DBConnection.Connection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                List<T> list = ds.toList<T>();
                if (list.Count != 1)
                    return default(T);

                // 取得所有的明细记录
                T t = list[0];
                FieldInfo info = t.GetType().GetField("DetailList");
                List<U> detail = new U().Find("parent_id = " + id);
                info.SetValue(t, detail);

                // 取得所有的附件记录
                PropertyInfo ainfo = t.GetType().GetProperty("AttachList");
                List<Attach> attaches = Attach.Query("parent_id = " + id);
                //ainfo.SetValue(t, attaches);
                ainfo.SetValue(t, attaches, null);

                return t;
            }
            catch (Exception e)
            {
                string msg = string.Format("创建对象出错，原因如下： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }

        /// <summary>
        /// 删除实体类
        /// 静态调用
        /// </summary>
        /// <param name="id">需要删除实体类的ID</param>
        public static new void Delete(long id)
        {
            SqlCommand cmd = DBConnection.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = String.Format("Delete from {0} where id = {1}", table_name, id);
            string detail_sql = String.Format("Delete from {0} where parent_id = {1}", GetTableName(typeof(U)), id);
            string attach_sql = string.Format("Delete from m_attach where parent_id = {0}", id);
            try
            {
                cmd.CommandText = detail_sql;
                cmd.ExecuteNonQuery();

                cmd.CommandText = attach_sql;
                cmd.ExecuteNonQuery();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                string msg = string.Format("删除对象出错，原因如下： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        /// <summary>
        /// 查找符合条件的实体类
        /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
        /// 必须是实例类调用
        /// </summary>
        /// <param name="where"> 除去where以外的where子句</param>
        /// <returns>含实体类的列表</returns>
        public override List<T> Find(string where = "")
        {

            string table_name = GetTableName(typeof(T));
            string sql = "Select * from " + table_name;

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += String.Format(" where {0} and deleted = 0", where);
                else
                    sql += string.Format(" where {0}", where);
            }
            else
            {
                if (!ShowDeleteRecord)
                    sql += " where deleted = 0 ";
            }

            // 按生成的ID降序排列
            sql += " " + OrderBy;

            try
            {
                SqlCommand cmd = DBConnection.Connection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                List<T> list = ds.toList<T>();

                // 取得所有的明细记录
                foreach (T t in list)
                {
                    FieldInfo info = t.GetType().GetField("DetailList");
                    PropertyInfo pro = t.GetType().GetProperty("ID");
                    long id = (long)pro.GetValue(t, null);
                    List<U> detail = new U().Find("parent_id = " + id);
                    info.SetValue(t, detail);

                    FieldInfo ainfo = t.GetType().GetField("AttachList");
                    List<Attach> attaches = Attach.Query("parent_id = " + id);
                    ainfo.SetValue(t, attaches);
                }
                return list;
            }
            catch (Exception e)
            {
                string msg = string.Format("查找对象出错，原因如下： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }


        /// <summary>
        /// 查找符合条件的实体类
        /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
        /// 静态调用
        /// </summary>
        /// <param name="where"> 除去where以外的where子句</param>
        /// <returns>含实体类的列表</returns>
        public static new List<T> Query(string where = "")
        {
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += String.Format(" where {0} and deleted = 0 ", where);
                else
                    sql += " where " + where;
            }
            else
            {
                if (!ShowDeleteRecord)
                    sql += " where deleted = 0 ";
            }

            // 按生成的ID降序排列
            sql += " " + OrderBy;

            try
            {
                SqlCommand cmd = DBConnection.Connection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                List<T> list = ds.toList<T>();

                // 取得所有的明细记录
                foreach (T t in list)
                {
                    FieldInfo info = t.GetType().GetField("DetailList");
                    PropertyInfo pro = t.GetType().GetProperty("ID");
                    long id = (long)pro.GetValue(t, null);
                    List<U> detail = new U().Find("parent_id = " + id);
                    info.SetValue(t, detail);

                    //FieldInfo ainfo = t.GetType().GetField("AttachList");
                    //List<Attach> attaches = Attach.Query("parent_id = " + id.ToString());
                    //ainfo.SetValue(t, attaches);
                }

                return list;
            }
            catch (Exception e)
            {
                string msg = string.Format("查找对象出错，原因如下： {0}{1}", Environment.NewLine, e.Message);
                throw new DBException(msg, e);
            }
        }
    }
}
