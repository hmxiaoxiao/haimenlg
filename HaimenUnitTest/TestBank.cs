using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Haimen.Entity;

namespace HaimenUnitTest
{
    [TestClass]
    public class TestBank
    {
        [TestMethod]
        public void TestBankCUID()
        {
            // 增加一个新银行
            Bank bank = new Bank();
            bank.Code = "CCB";
            bank.Name = "中国建设银行";
            bank.Save();
            Assert.AreNotEqual(0, bank.ID);

            Bank.Delete(bank.ID);

            bank = Bank.CreateByID(bank.ID);
            Assert.IsNull(bank);

            //// 查找是否已经找到
            //Bank.Where<Bank>("id = " + id.ToString());
        }
    }
}
