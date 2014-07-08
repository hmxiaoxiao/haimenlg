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
        public ulong ID { get; set; }

        // 用来返回错误信息
        // 字段放在key里面，错误信息value里面
        public List<KeyValuePair<string, string>> Err_Info { get; set; }

        virtual public bool BeforeCreate()
        {
            return true;
        }

        virtual public bool BeforeUpdate()
        {
            return true;
        }

        virtual public bool BeforeDelete()
        {
            return true;
        }
    }
}
