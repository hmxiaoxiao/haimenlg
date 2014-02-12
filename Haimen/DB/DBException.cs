using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.DB
{
    /// <summary>
    /// DB目录下的所有的异常都由本异常派生。
    /// </summary>
    public class DBException : ApplicationException
    {
        public DBException() { }

        public DBException(string message)
            : base(message) { }

        public DBException(string message, Exception inner)
            : base(message, inner) { }
    }
}
