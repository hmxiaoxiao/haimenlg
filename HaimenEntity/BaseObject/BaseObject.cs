using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HaimenEntity.Function;

namespace HaimenEntity.BaseObject
{
    public class BaseObject
    {
        /// <summary>
        /// 每个实体类都有的ID值
        /// </summary>
        [Field("id")]
        public long ID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Field("created_date")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [Field("Updated_date")]
        public DateTime UpdatedDate { get; set; }


        /// <summary>
        /// 用于保存错误信息
        /// 如果与字段有关，则key为字段
        /// 否则与调用的函数名有关，比如Verify等
        /// 另外，每次调用方法后，都可能会改为上次的信息，故需及时处理
        /// </summary>
        public List<KeyValuePair<string, string>> Error_Info = new List<KeyValuePair<string, string>>();
    }
}
