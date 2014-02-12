using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;
using System.Data;

namespace Haimen.DB
{
    public static class DataSet2List
    {
        /// <summary>
        /// 给DataSet附件一个转换为List的方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static List<T> toList<T>(this DataSet ds) where T: new()
        {
            DataTable dt = ds.Tables[0];

            //创建一个属性的列表
            List<PropertyInfo> prlist = new List<PropertyInfo>();

            //获取TResult的类型实例  反射的入口
            Type t = typeof(T);

            //获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表
            //Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });
            Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(GetFieldName(p)) != -1) prlist.Add(p); });

            //创建返回的集合
            List<T> list = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                //创建TResult的实例
                T tob = new T();

                //找到对应的数据,并赋值
                prlist.ForEach(p => { if (row[GetFieldName(p)] != DBNull.Value) p.SetValue(tob, row[GetFieldName(p)], null); });
                //放入到返回的集合中.
                list.Add(tob);
            }
            return list;
        }

        /// <summary>
        /// 取得属性对应的表的字段
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private static string GetFieldName(PropertyInfo info)
        {
            string name = "";
            foreach (Attribute attr in info.GetCustomAttributes(false))
            {
                if (attr is Field)
                {
                    Field a = (Field)attr;
                    name = a.Name;
                }
            }
            return name;
        }
    }
}
