using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaimenEntity.Interface
{
    public interface IDBSingleFunction<T> where T : new()
    {





            /// <summary>
            /// 保存到数据时，校验数据是否正确
            /// 注意无论是新增还是修改，都视为保存。
            /// </summary>
            /// <returns>true为成功，若失败，可以在Error_Info中查到</returns>
            bool Verify();


            /// <summary>
            /// 取得当前对象对应数据库的字段以及值
            /// </summary>
            /// <returns>返回列表：每个列表的值为一个字典，key为字段名，Value为保存的值</returns>
            List<KeyValuePair<string, dynamic>> GetFieldsAndValues();



            /// <summary>
            /// 取得类对应的表名
            /// </summary>
            /// <returns>对应的表名，没有找到为空</returns>
            string GetTableName(Type t);

            /// <summary>
            /// 保存当前的实体类
            /// </summary>
            /// <returns>保存成功为真，否则出错原因可在Error_Info中找到</returns>
            bool Save();
            /// <summary>
            /// 插入新的实体类
            /// 注意，校验由客户端处理，这里不做校验
            /// </summary>
            /// <returns>成功为真</returns>
            bool Insert();

            /// <summary>
            /// 更新实体类
            /// 注意，校验应由客户端调用，更新里不会去调用
            /// </summary>
            /// <returns>true 为成功</returns>
            bool Update();

            /// <summary>
            /// 查找符合条件的实体类
            /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
            /// 必须是实例类调用
            /// </summary>
            /// <param name="where"> 除去where以外的where子句</param>
            /// <returns>含实体类的列表</returns>
            List<T> Find(string where = "");

            /// <summary>
            /// 查找符合条件的实体类
            /// 其实就是生成SQL语句中的Where语句，所以需要前端调用的人员对数据库有所了解
            /// 静态调用
            /// </summary>
            /// <param name="where"> 除去where以外的where子句</param>
            /// <returns>含实体类的列表</returns>
            List<T> Query(string where = "");

            /// <summary>
            /// 删除实体类,这个只能删除一个实体类，如果要删除含明细的实体类，请使用Destory方法
            /// 静态调用
            /// </summary>
            /// <param name="id">需要删除实体类的ID</param>
            void Delete(long id);

            /// <summary>
            /// 删除实体类
            /// 实例调用
            /// </summary>
            void Destory();

            /// <summary>
            /// 通过ID生成实体类
            /// </summary>
            /// <param name="id">实体ID</param>
            /// <returns>该ID对应的实体类</returns>
            T CreateByID(long id);

    }
}
