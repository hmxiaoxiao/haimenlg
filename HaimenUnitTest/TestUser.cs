using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Reflection;
using System.Xml;

using Haimen.Entity;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestUser
    {
        [TestMethod]
        public void TestUserQuery()
        {
            User t = DBFactory.CreateQueryEntity<User>();
            User from = new User();
            from.ID = 999999;
            //DataSet ds = DBFactory<User>.Query(from);
            DataSet ds = DBFactory.Query<User>(from);

            List<User> list = ds.toList<User>();
            Assert.AreEqual<long>(0, list.Count);

        }

        [TestMethod]
        public void TestUserCreateAndUpdate()
        {
            // 如果有以前的测试数据，先删除之
            User user = DBFactory.CreateQueryEntity<User>();
            user.Code = "Hello";
            user.Name = "World!";
            List<User> list = DBFactory.Query<User>(user).toList<User>();
            if (list.Count > 0)
            {
                DBFactory.Delete(list[0]);
            }

            // 记录当前库里有多少条记录
            list = DBFactory.Query<User>().toList<User>();
            int count = list.Count;

            // 增加一个用户
            user.Code = "Hello";
            user.Name = "World!";
            ulong id = DBFactory.Save<User>(user);// User.Create<User>(user);
            Assert.AreNotEqual<ulong>(0, id);
            //user.Create<User>(user);

            // 已经在数据库里面
            list = DBFactory.Query<User>().toList<User>();
            Assert.AreEqual(list.Count, count + 1);
            
            // 可以找到新增的记录
            User query_user = DBFactory.CreateQueryEntity<User>();
            query_user.Code = "Hello";
            query_user.Name = "World!";
            list = DBFactory.Query<User>(query_user).toList<User>();// User.Query(query_user).toList<User>();
            Assert.AreEqual(list.Count, 1);

            // 删除更新
            list[0].Name = "Changed!";
            DBFactory.Update(list[0]);

            // 查找更新后的记录
            list = DBFactory.Query<User>(list[0]).toList<User>();// User.Query(query_user).toList<User>();
            Assert.AreEqual(1, list.Count);

            // 可以删除了。
            DBFactory.Delete<User>(list[0]);  // User.Delete("Hello");
            list = DBFactory.Query<User>().toList<User>();// User.Query(new User()).toList<User>();
            Assert.IsTrue(list.Count == count);
        }

        [TestMethod]
        public void TestUserSalt()
        {
            User u = new User();
            u.Code = "test1";
            u.Password = "test1";
            ulong id = DBFactory.Save<User>(u);
            Assert.IsTrue(id > 0);

            User q = DBFactory.CreateQueryEntity<User>();
            q.ID = id;
            List<User> list = DBFactory.Query<User>(q).toList<User>();
            Assert.IsTrue(1 == list.Count);
            Assert.IsNotNull(list[0].Salt);
            Assert.IsTrue(User.Verify(u.Code, u.Password) != null);

            DBFactory.Delete<User>(q);
        }
    }
}
