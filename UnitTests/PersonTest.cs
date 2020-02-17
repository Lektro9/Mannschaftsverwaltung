using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mannschaftsverwaltung;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestPerson()
        {
            Person p = new Person();
            Assert.AreEqual("niemand",p.Name);
        }
    }
}
