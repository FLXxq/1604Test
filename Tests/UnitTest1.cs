using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int One = 14;
            int Two = 34;
            string Result = Code.Sum(One, Two);
            Assert.AreEqual("Сумма равна 48", Result);
        }
    }
}
