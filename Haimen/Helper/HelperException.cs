using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.Helper
{
    /// <summary>
    /// Helper目录下的所有的异常都由本异常派生。
    /// </summary>
    public class HelperException : ApplicationException
    {
        public HelperException() { }

        public HelperException(string message)
            : base(message) { }

        public HelperException(string message, Exception inner)
            : base(message, inner) { }
    }
}
