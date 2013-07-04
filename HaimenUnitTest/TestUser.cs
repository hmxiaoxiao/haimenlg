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
        public void TestUserCreate()
        {
            List<User> list = DBFactory.Query<User>().toList<User>();
            int count = list.Count;

            User user = new User();
            user.Code = "Hello";
            user.Name = "World!";
            int id = DBFactory.Create<User>(user);// User.Create<User>(user);
            Assert.AreNotEqual<int>(0, id);
            //user.Create<User>(user);

            User query_user = DBFactory.CreateQueryEntity<User>();
            query_user.Code = "Hello";
            query_user.Name = "World!";
            list = DBFactory.Query<User>(query_user).toList<User>();// User.Query(query_user).toList<User>();
            Assert.IsTrue(list.Count == count + 1);

            DBFactory.Delete<User>(list[0]);  // User.Delete("Hello");
            list = DBFactory.Query<User>(query_user).toList<User>();// User.Query(new User()).toList<User>();
            Assert.IsTrue(list.Count == count);
        }

        [TestMethod]
        public void TestUserSalt()
        {
            User u = new User();
            u.Code = "test1";
            u.Password = "test1";
            int id = DBFactory.Create<User>(u);
            Assert.IsTrue(id > 0);

            User q = DBFactory.CreateQueryEntity<User>();
            q.ID = id;
            List<User> list = DBFactory.Query<User>(q).toList<User>();
            Assert.IsTrue(1 == list.Count);
            Assert.IsNotNull(list[0].Salt);
            Assert.IsTrue(list[0].Verify(u.Code, u.Password));

            DBFactory.Delete<User>(q);
        }
    }
}
