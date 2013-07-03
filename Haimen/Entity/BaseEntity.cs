using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.Entity
{
    public class BaseEntity
    {
        // 创建时间
        [Field("create_date")]
        public DateTime CreateDate { get; set; }

        // 更新时间
        [Field("update_date")]
        public DateTime UpdateDate { get; set; }

        // 表的ID
        [Field("ID")]
        public long ID { get; set; }


        public bool BeforeCreate()
        {
            return true;
        }

        public bool AfterCreate()
        {
            return true;
        }

        public bool BeforeUpdate()
        {
            return true;
        }

        public bool AfterUpdate()
        {
            return true;
        }

        public bool BeforeDelete()
        {
            return true;
        }

        public bool AfterDelete()
        {
            return true;
        }
    }
}
