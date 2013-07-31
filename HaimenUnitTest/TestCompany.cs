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
            List<Company> list = Company.Query("code = 'testcode'");
            foreach (Company c in list)
            {
                c.Destory();
            }

            list = Company.Query();
            long count = list.Count;

            Company com = new Company();
            com.Code = "testcode";
            com.Name = "testname";
            com.Doc = "沪";
            com.Input = "X";
            com.Output = "X";

            for (int i = 0; i < 10; i++)
            {
                CompanyDetail d = new CompanyDetail();
                d.Account = i.ToString();
                d.Balance = i;
                d.Credit = i;
                com.DetailList.Add(d);
            }
            com.Save();
            Assert.IsTrue(com.ID > 0);

            Company q = Company.CreateByID(com.ID);
            Assert.IsTrue(q.ID == com.ID);
            Assert.IsTrue(q.DetailList.Count == 10);
            q.DetailList.RemoveAt(0);
            q.Save();

            

            list = Company.Query();
            Assert.IsTrue(list.Count == count + 1);

            com.Destory();
            list = Company.Query();
            Assert.IsTrue(list.Count == count);
        }
    }
}
