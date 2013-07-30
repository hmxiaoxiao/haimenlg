using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Reflection;
using System.Transactions;

namespace Haimen.Qy
{
    // T为主表类型，U为明细类型
    public class TEntityFunction<T, U> : MEntityFunction<T>
        where T : new()
        where U : MEntityFunction<U>, new()
    {

        // 明细列表
        public List<U> m_detail = new List<U>();

        public override bool Insert()
        {
            // 使用范围事务
            using (TransactionScope ts = new TransactionScope())
            {
                this.Insert();
                if (this.ID > 0)
                {
                    foreach (U u in m_detail)
                    {
                        // 明细类必须有parent_id的属性
                        PropertyInfo info = u.GetType().GetProperty("Parent_ID");

                        // 设置值
                        info.SetValue(u, this.ID, null);

                        // 保存
                        u.Insert();
                    }
                }
            }
            return true;
        }

        public override bool Update()
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
                    foreach (U n in m_detail)
                    {
                        if (n.ID == old.ID)
                            finded = true;
                    }
                    if (!finded)
                        old.Destory();
                }
            }

            this.Update();
            foreach (U u in m_detail)
            {
                // 明细类必须有parent_id的属性
                PropertyInfo info = u.GetType().GetProperty("Parent_ID");

                // 设置值
                info.SetValue(u, this.ID, null);

                // 保存
                u.Save();
            }
            return true;
        }

        public override void Destory()
        {
            this.Destory();
            foreach (U u in m_detail)
            {
                u.Destory();
            }
        }
    }
}
