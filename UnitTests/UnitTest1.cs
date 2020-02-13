using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mannschaftsverwaltung;
using System.Collections.Generic;

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
        [TestMethod]
        public void TestMannschaft()
        {
            FussballSpieler p1 = new FussballSpieler("Klaus", 15);
            FussballSpieler p2 = new FussballSpieler("Dennis", 22);
            FussballSpieler p3 = new FussballSpieler("Bernd", 23);
            FussballSpieler p4 = new FussballSpieler("Vergil", 45);
            FussballSpieler p5 = new FussballSpieler("Dante", 43);
            FussballSpieler p6 = new FussballSpieler("Goku", 85);
            Physiotherapeut p7 = new Physiotherapeut("Dr. Bob", 45);
            Trainer t1 = new Trainer("Franz Beckenbauer", 74);

            List<Person> pl = new List<Person>() { p1, p2, p3, p4, p5, p6, p7, t1 };

            Mannschaft m = new Mannschaft(pl);

            Assert.AreEqual(6, m.AnzahlSpieler);
        }
    }
}
