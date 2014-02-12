using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.DB
{
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
