using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Reflection;
using System.Transactions;
using System.Data;

using Haimen.Entity;

namespace Haimen.DB
{
    // T为主表类型，U为明细类型
    public class TEntityFunction<T, U> : MEntityFunction<T>
        where T : new()
        where U : MEntityFunction<U>, new()
    {

        // 明细列表
        //private List<U> m_detaillist = null;
        //public List<U> DetailList
        //{
        //    get
        //    {
        //        if (m_detaillist == null)
        //            m_
        //    }
        //    set
        //    {
        //        m_detaillist = value;
        //    }
        //}

        public List<U> DetailList = new List<U>();

        // 附件列表
        private List<Attach> m_attachlist = null;
        public List<Attach> AttachList
        {
            get
            {
                if (m_attachlist == null)
                {
                    m_attachlist = Attach.Query("parent_id = " + ID.ToString());
                }
                return m_attachlist;
            }
            set
            {
                m_attachlist = value;
            }
        }

        public override bool Insert()
        {
            bool returnVale;

            // 使用范围事务
            using (TransactionScope ts = new TransactionScope())
            {
                // 先保存主数据
                returnVale = base.Insert();
                if (this.ID > 0)
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
                            returnVale = false;
                    }

                    // 保存附件信息
                    foreach (Attach a in AttachList)
                    {
                        a.ParentID = this.ID;
                        a.Save();
                    }
                }

                ts.Complete();
            }
            return returnVale;
        }

        public override bool Update()
        {
            bool returnVale;
            using (TransactionScope ts = new TransactionScope())
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
                foreach(Attach old in attaches)
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

                returnVale = base.Update();
                foreach (U u in DetailList)
                {
                    // 明细类必须有parent_id的属性
                    PropertyInfo info = u.GetType().GetProperty("ParentID");

                    // 设置值
                    info.SetValue(u, this.ID, null);

                    // 保存
                    if (!u.Save())
                        returnVale = false;
                }

                foreach (Attach a in AttachList)
                {
                    a.ParentID = this.ID;
                    if (!a.Save())
                        returnVale = false;
                }

                ts.Complete();
            }
            return returnVale;
        }

        /// <summary>
        /// 删除对象
        /// </summary>
        public override void Destory()
        {
            using (TransactionScope ts = new TransactionScope())
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
                ts.Complete();
            }
        }

        /// <summary>
        /// 通过ID生成实体类
        /// </summary>
        /// <param name="id">实体ID</param>
        /// <returns>该ID对应的实体类</returns>
        public static new T CreateByID(long id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();

            sql += " where id = " + id.ToString();

            cmd.CommandText = sql;
            Console.WriteLine(sql);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            List<T> list = ds.toList<T>();
            if (list.Count != 1)
                return default(T);

            // 取得所有的明细记录
            T t = list[0];
            FieldInfo info = t.GetType().GetField("DetailList");
            List<U> detail = new U().Find("parent_id = " + id.ToString());
            info.SetValue(t, detail);

            // 取得所有的附件记录
            PropertyInfo ainfo = t.GetType().GetProperty("AttachList");
            List<Attach> attaches = Attach.Query("parent_id = " + id.ToString());
            //ainfo.SetValue(t, attaches);
            ainfo.SetValue(t, attaches, null);

            return t;
        }

        /// <summary>
        /// 删除实体类
        /// 静态调用
        /// </summary>
        /// <param name="id">需要删除实体类的ID</param>
        public static new void Delete(long id)
        {
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Delete from " + table_name + " where id = " + id.ToString();
            string detail_sql = "Delete from " + GetTableName(typeof(U)) + " where parent_id = " + id.ToString();
            string attach_sql = "Delete from m_attach where parent_id = " + id.ToString();
            using (TransactionScope ts = new TransactionScope())
            {
                cmd.CommandText = detail_sql;
                cmd.ExecuteNonQuery();

                cmd.CommandText = attach_sql;
                cmd.ExecuteNonQuery();

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                ts.Complete();
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
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += " where " + where + " and deleted = 0";
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
                List<U> detail = new U().Find("parent_id = " + id.ToString());
                info.SetValue(t, detail);

                FieldInfo ainfo = t.GetType().GetField("AttachList");
                List<Attach> attaches = Attach.Query("parent_id = " + id.ToString());
                ainfo.SetValue(t, attaches);
            }
            return list;
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
            SqlCommand cmd = DBFunction.Connection.CreateCommand();
            string table_name = GetTableName(typeof(T));

            string sql = "Select * from " + table_name;
            List<string> whereList = new List<string>();

            // 生成SQL语句
            if (where.Length > 0)
            {
                if (!ShowDeleteRecord)
                    sql += " where " + where + " and deleted = 0 ";
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
                List<U> detail = new U().Find("parent_id = " + id.ToString());
                info.SetValue(t, detail);

                //FieldInfo ainfo = t.GetType().GetField("AttachList");
                //List<Attach> attaches = Attach.Query("parent_id = " + id.ToString());
                //ainfo.SetValue(t, attaches);
            }

            return list;
        }
    }
}
