using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mannschaftsverwaltung;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void InitHandballer()
        {
            HandballSpieler h = new HandballSpieler("Testname", 15, "Verteidigung", 25);
            Assert.AreEqual("Testname", h.Name);
            Assert.AreEqual(15, h.Alter);
            Assert.AreEqual(25, h.GeworfeneTore);
            Assert.AreEqual("Verteidigung", h.Position);
        }

        [TestMethod]
        public void InitFusballer()
        {
            FussballSpieler f = new FussballSpieler("Testname", 15, "Verteidigung", 105);
            Assert.AreEqual("Testname", f.Name);
            Assert.AreEqual(15, f.Alter);
            Assert.AreEqual(105, f.GeschosseneTore);
            Assert.AreEqual("Verteidigung", f.Position);
        }

        [TestMethod]
        public void InitTennisSpieler()
        {
            TennisSpieler t = new TennisSpieler("Testname", 15, "den Guten", 105, 23);
            Assert.AreEqual("Testname", t.Name);
            Assert.AreEqual(15, t.Alter);
            Assert.AreEqual(23, t.GewonneneSpiele);
            Assert.AreEqual("den Guten", t.Schlaeger);
            Assert.AreEqual(105, t.Aufschlaggeschwindigkeit);
        }

        [TestMethod]
        public void PersonenNachNamenSortieren()
        {
            FussballSpieler p1 = new FussballSpieler("A", 15, "Stürmer", 1);
            FussballSpieler p2 = new FussballSpieler("F", 15, "Stürmer", 2);
            FussballSpieler p4 = new FussballSpieler("C", 15, "Stürmer", 3);
            FussballSpieler p5 = new FussballSpieler("D", 15, "Stürmer", 4);
            FussballSpieler p6 = new FussballSpieler("E", 15, "Stürmer", 5);
            Physiotherapeut p7 = new Physiotherapeut(45, "B");
            Trainer t1 = new Trainer(74, "G");

            List<Person> pl = new List<Person>() { p1, p2, p4, p5, p6, p7, t1 };

            Mannschaft m = new Mannschaft(pl);
            m.SortBy = 2; // hier wird erstmal nach Erfolg sortiert

            List<Person> sortierteListe = m.sortiere();

            Assert.AreEqual(t1, sortierteListe[0]);
            Assert.AreEqual(p2, sortierteListe[1]);
            Assert.AreEqual(p6, sortierteListe[2]);
            Assert.AreEqual(p5, sortierteListe[3]);
            Assert.AreEqual(p4, sortierteListe[4]);
            Assert.AreEqual(p7, sortierteListe[5]);
            Assert.AreEqual(p1, sortierteListe[6]);
        }
    }
}
