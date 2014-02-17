﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Haimen.Entity
{
    // TODO 这个类是否可以用Directory替换？
    /// <summary>
    ///  字典表，用来显示状态
    /// </summary>
    public class Dict
    {
        public Dict()
        {
        }

        public Dict(string key, long value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// 字典键值
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public long Value { get; set; }
    }

}
