using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Haimen.Entity;
using System.Collections.Generic;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestFunds
    {
        [TestMethod]
        public void TestFundsCRUD()
        {
            List<Funds> list = Funds.Query();
            long count = list.Count;

            Funds fs = new Funds();
            fs.Name = "test";
            fs.Save();

            Assert.IsTrue(fs.ID > 0);

            list = Funds.Query();
            Assert.IsTrue(count + 1 == list.Count);

            Funds.Delete(fs.ID);

            list = Funds.Query();
            Assert.IsTrue(count == list.Count);

        }
    }
}
