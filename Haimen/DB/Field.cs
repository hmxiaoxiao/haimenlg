using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.DB
{
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
