﻿using System;
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
            User user = User.CreateByID(999999);
            Assert.IsNull(user);
        }

        [TestMethod]
        public void TestUserCreateAndUpdate()
        {
            // 如果有以前的测试数据，先删除之
            List<User> list = User.Query("code = 'Hello' ");
            if (list.Count > 0)
            {
                User.Delete(list[0].ID);
            }

            // 记录当前库里有多少条记录
            list = User.Query();
            int count = list.Count;

            // 增加一个用户
            User user = new User();
            user.Code = "Hello";
            user.Name = "World";
            user.GroupID = UserGroup.Query()[0].ID;
            Assert.IsTrue(user.Insert());// User.Create<User>(user);
            Assert.AreNotEqual(0, user.ID);
            //user.Create<User>(user);

            // 已经在数据库里面
            list = User.Query();
            Assert.AreEqual(list.Count, count + 1);

            // 可以找到新增的记录
            list = User.Query("code = 'Hello' and name = 'World'");
            Assert.AreEqual(list.Count, 1);

            // 删除更新
            list[0].Name = "Changed!";
            list[0].Update();

            // 查找更新后的记录
            list = User.Query("code = 'Hello' and name = 'Changed!'");
            Assert.AreEqual(1, list.Count);

            // 可以删除了。
            User.Delete(list[0].ID);  // User.Delete("Hello");
            list = User.Query();
            Assert.IsTrue(list.Count == count);
        }

        [TestMethod]
        public void TestUserLogin()
        {
            Assert.IsNotNull(User.Login("admin", "qwer1234"));
            Assert.IsNull(User.Login("admin", "12345678"));
        }

        [TestMethod]
        public void TestUserSalt()
        {
            List<User> list = User.Query("code = 'test1'");
            if (list.Count > 0)
            {
                foreach (User s in list)
                {
                    s.Destory();
                }
            }
            User u = new User();
            u.Code = "test1";
            u.Name = "test1";
            u.GroupID = UserGroup.Query()[0].ID;
            u.Password = "abcde";
            Assert.IsTrue(u.Insert());
            Assert.IsTrue(u.ID > 0);

            User dbUser = User.CreateByID(u.ID);
            Assert.IsTrue(u.ID == dbUser.ID);
            Assert.IsNotNull(User.Login(u.Code, u.Password));
            Assert.IsTrue(User.Login(u.Code, u.Password) != null);

            Assert.IsTrue(User.Delete(u.ID));
        }
    }
}
