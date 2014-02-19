using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Haimen.Entity;
using System.Collections.Generic;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestBalance
    {
        //[TestMethod]
        //public void TestBalanceCRUD()
        //{
        //    // 删除无用的测试数据
        //    List<Balance> list = Balance.Query("code = 'testcode'");
        //    foreach (Balance acc in list)
        //    {
        //        acc.Destory();
        //    }


        //    // 新增
        //    Balance a = new Balance();
        //    a.Code = "testcode";
        //    a.BeginDate = DateTime.Now;
        //    a.EndDate = DateTime.Now;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        BalanceDetail d = new BalanceDetail();
        //        d.Money = i;
        //        d.PayDate = DateTime.Now;
        //        a.DetailList.Add(d);
        //    }

        //    Assert.IsTrue(a.Save());
        //    Assert.IsTrue(a.ID > 0);

        //    // 查询
        //    list = Balance.Query("code = 'testcode'");
        //    Assert.IsTrue(list.Count == 1);
        //    Assert.IsTrue(list[0].ID == a.ID);
        //    Assert.IsTrue(list[0].DetailList.Count == 10);

        //    // 删除
        //    list[0].Destory();
        //    list = Balance.Query("code = 'testcode'");
        //    Assert.IsTrue(list.Count == 0);
        //}
    }
}
