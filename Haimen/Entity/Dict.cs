using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{

    public class Dict
    {
        public Dict()
        {
        }

        public Dict(string name, long value)
        {
            Name = name;
            ValueInt = value;
        }

        public string Name { get; set; }

        public long ValueInt { get; set; }
    }

}
