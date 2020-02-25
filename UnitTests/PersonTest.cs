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

        [TestMethod]
        public void InitHandballer()
        {
            HandballSpieler h = new HandballSpieler("Testname", 15, 25, "Verteidigung");
            Assert.AreEqual("Testname", h.Name);
            Assert.AreEqual(15, h.Alter);
            Assert.AreEqual(25, h.ErzieltePkte);
            Assert.AreEqual("Verteidigung", h.Position);
        }

        [TestMethod]
        public void InitFusballer()
        {
            FussballSpieler f = new FussballSpieler("Testname", 15, 25, "Verteidigung", 105);
            Assert.AreEqual("Testname", f.Name);
            Assert.AreEqual(15, f.Alter);
            Assert.AreEqual(25, f.ErzieltePkte);
            Assert.AreEqual("Verteidigung", f.Position);
            Assert.AreEqual(105, f.GeschosseneTore);
        }

        [TestMethod]
        public void InitTennisSpieler()
        {
            TennisSpieler t = new TennisSpieler("Testname", 15, 25, "den Guten", 105);
            Assert.AreEqual("Testname", t.Name);
            Assert.AreEqual(15, t.Alter);
            Assert.AreEqual(25, t.ErzieltePkte);
            Assert.AreEqual("den Guten", t.Schlaeger);
            Assert.AreEqual(105, t.Aufschlaggeschwindigkeit);
        }
    }
}
