using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.DB
{
    /// <summary>
    /// 反射用的，通过此属性取得某类属生对应的数据库字段名
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property ,
                           AllowMultiple = true)]
    public class Field : System.Attribute
    {
        public string Name { get; set; }

        public Field(string name)
        {
            this.Name = name;
        }
    }
}
