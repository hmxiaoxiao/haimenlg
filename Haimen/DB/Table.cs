using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.DB
{
    /// <summary>
    /// 反射用的，通过此属性取得某类对应的数据库表名
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class |
                           System.AttributeTargets.Struct,
                           AllowMultiple = true)]
    public class Table : System.Attribute
    {
        public string Name { get; set; }

        public Table(string name)
        {
            this.Name = name;
        }
    }
}
