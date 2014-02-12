using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.Entity
{
    /// <summary>
    /// Entity目录下的所有的异常都由本异常派生。
    /// </summary>
    class EntityException : ApplicationException
    {
        public EntityException() { }

        public EntityException(string message)
            : base(message) { }

        public EntityException(string message, Exception inner)
            : base(message, inner) { }
    }
}
