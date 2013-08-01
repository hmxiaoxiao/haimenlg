using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Haimen.Entity;
using System.Collections.Generic;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestAccount
    {
        [TestMethod]
        public void TestAccountCRUD()
        {
            // 删除无用的测试数据
            List<Account> list = Account.Query("code = 'testcode'");
            foreach (Account acc in list)
            {
                acc.Destory();
            }


            // 新增
            Account a = new Account();
            a.Code = "testcode";

            for (int i = 0; i < 10; i ++ )
            {
                AccountDetail d = new AccountDetail();
                d.Money = i;
                d.Usage = i.ToString();
                a.DetailList.Add(d);
            }

            Assert.IsTrue(a.Save());
            Assert.IsTrue(a.ID > 0);

            // 查询
            list = Account.Query("code = 'testcode'");
            Assert.IsTrue(list.Count == 1);
            Assert.IsTrue(list[0].ID == a.ID);
            Assert.IsTrue(list[0].DetailList.Count == 10);

            // 删除
            list[0].Destory();
            list = Account.Query("code = 'testcode'");
            Assert.IsTrue(list.Count == 0);

        }
    }
}
