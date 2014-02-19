using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Haimen.Entity;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestUnauth
    {
        [TestMethod]
        public void TestUnauthCUID()
        {
            List<UnAuth> list = UnAuth.Query(string.Format("code = 'testcode'"));
            foreach (UnAuth a in list)
            {
                Assert.IsTrue(a.Destory());
            }

            UnAuth un = new UnAuth();
            un.Code = "testcode";
            CompanyDetail cd = CompanyDetail.Query()[0];
            un.CompanyDetailID = cd.ID;
            un.CompanyID = cd.ParentID;
            un.Money = 11;
            un.SignedDate = DateTime.Now;
            Assert.IsTrue(un.Save());

            un.Destory();
            Assert.IsTrue(UnAuth.Query(string.Format("code = 'testcode'")).Count == 0);
            
        }
    }
}
