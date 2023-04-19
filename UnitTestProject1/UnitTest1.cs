using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyTest;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expectation = 1;
            int result = UnitTest.MathAllPrice();
            Assert.AreEqual(expectation,result);
 
        }
    }
}
