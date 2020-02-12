using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Verberbungsuebung;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerson()
        {
            Person p = new Person();
            Assert.AreEqual("niemand",p.Name);
        }
    }
}
