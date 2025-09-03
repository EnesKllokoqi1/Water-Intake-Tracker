using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit_Tests;

namespace Unit_Tests
{

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, 0);
        }
        [TestMethod]
        public void SimpleTest()
        {
            Console.WriteLine("Test is running!");
            Assert.IsTrue(true);
        }



    }
}
