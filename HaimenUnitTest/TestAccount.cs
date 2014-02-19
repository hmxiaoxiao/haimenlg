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

            GlobalSet.Current_User = User.Query()[0];

            // 新增
            Account a = new Account();
            a.In_CompanyDetail_ID = CompanyDetail.Query("parent_id in (select id from m_company where input = 'X')")[0].ID;
            a.Out_CompanyDetail_ID = CompanyDetail.Query("parent_id in (select id from m_company where output = 'X')")[0].ID;
            a.Money = 12345;
            a.SignedDate = DateTime.Now;

            for (int i = 1; i < 10; i ++ )
            {
                AccountDetail d = new AccountDetail();
                d.FundsID = Funds.Query()[0].ID;
                d.Money = i;
                d.Usage = i.ToString();
                a.DetailList.Add(d);
            }

            Assert.IsTrue(a.Save());
            Assert.IsTrue(a.ID > 0);

            // 查询
            list = Account.Query(string.Format("id = {0}", a.ID));
            Assert.IsTrue(list.Count == 1);
            Assert.IsTrue(list[0].ID == a.ID);
            Assert.IsTrue(list[0].DetailList.Count == 9);

            // 删除
            list[0].Destory();
            list = Account.Query("code = 'testcode'");
            Assert.IsTrue(list.Count == 0);

        }
    }
}
