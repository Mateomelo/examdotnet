using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DSDOTNET;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBooleanToInt()
        {
            bool a = true;
            bool b = false;
            Assert.AreEqual(1, a.ToInt());
            Assert.AreEqual(0, b.ToInt());
        }

    }
}
