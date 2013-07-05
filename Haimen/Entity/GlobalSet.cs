using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.Entity
{
    // 全局变量的类，可以理解为全局的设置
    public static class GlobalSet
    {
        // 当前登录的用户
        public static User Current_User { get; set; }
    }
}
