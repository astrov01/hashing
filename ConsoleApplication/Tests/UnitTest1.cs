using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string word = "leepadg";
            Int64 result = 680131659347;

            Assert.AreEqual(result,Program.Hashing(word));
        }
    }
}
