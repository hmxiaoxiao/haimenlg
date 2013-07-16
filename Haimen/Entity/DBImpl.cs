//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Haimen.Entity
//{
//    public class DBImpl<T> : IDB<T> where T : new()
//    {
//        [Field("ID")]
//        long ID { get; set; }

//        [Field("created_date")]
//        DateTime CreateDate { get; set; }

//        public virtual long Save()
//        {
//            string name = "";
//            foreach (Attribute attr in typeof(T).GetCustomAttributes(false))
//            {
//                if (attr is Table)
//                {
//                    Table a = (Table)attr;
//                    name = a.Name;
//                }
//            }
//            Console.WriteLine(name);
//            return 0;
//        }
//    }
//}
