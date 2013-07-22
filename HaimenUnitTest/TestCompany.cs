using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;

using Haimen.Entity;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestCompany
    {
        [TestMethod]
        public void TestCompanyCRUD()
        {
            List<Company> list = Company.Query();
            long count = list.Count;

            Company com = new Company();
            com.Code = "testcode";
            com.Name = "testname";
            com.Doc = "沪";
            com.Input = "X";
            com.Output = "X";
            com.Save();
            Assert.IsTrue(com.ID > 0);

            list = Company.Query();
            Assert.IsTrue(list.Count == count + 1);

            Company.Delete(com.ID);
            list = Company.Query();
            Assert.IsTrue(list.Count == count);
        }
    }
}
