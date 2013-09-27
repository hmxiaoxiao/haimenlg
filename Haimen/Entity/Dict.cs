﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Haimen.Qy;

namespace Haimen.Entity
{
    // 字典表，用来显示状态
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

        // 状态名称
        public string Name { get; set; }

        // 状态值 
        public long ValueInt { get; set; }
    }

}
