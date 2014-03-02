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
    public class TestProject
    {
        [TestMethod]
        public void TestProjectCRUD()
        {
            // 如果有以前的测试数据，先删除之
            List<Project> list = Project.Query("name = 'Changed!' ");
            if (list.Count > 0)
            {
                Project.Delete(list[0].ID);
            }

            // 记录当前库里有多少条记录
            list = Project.Query();
            int count = list.Count;

            // 增加
            Project project = new Project();
            project.Name = "Test";
            Assert.IsTrue(project.Insert());
            Assert.AreNotEqual(0, project.ID);

            // 已经在数据库里面
            list = Project.Query();
            Assert.AreEqual(list.Count, count + 1);

            // 可以找到新增的记录
            list = Project.Query("name = 'Test' ");
            Assert.AreEqual(list.Count, 1);

            // 删除更新
            list[0].Name = "Changed!";
            list[0].Update();

            // 查找更新后的记录
            list = Project.Query("name = 'Changed!'");
            Assert.AreEqual(1, list.Count);

            // 可以删除了。
            Project.Delete(list[0].ID);
            list = Project.Query();
            Assert.IsTrue(list.Count == count);
        }
    }
}
