using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mannschaftsverwaltung;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class MannschaftsTest
    {
        [TestMethod]
        public void SpielerHinzufuegen()
        {
            FussballSpieler p1 = new FussballSpieler(15, "Klaus");
            FussballSpieler p2 = new FussballSpieler(22, "Dennis");
            HandballSpieler p3 = new HandballSpieler(23, "Bernd");
            FussballSpieler p4 = new FussballSpieler(45, "Vergil");
            FussballSpieler p5 = new FussballSpieler(43, "Dante");
            FussballSpieler p6 = new FussballSpieler(85, "Goku");
            Physiotherapeut p7 = new Physiotherapeut(45, "Dr. Bob");
            Trainer t1 = new Trainer(74, "Franz Beckenbauer");

            List<Person> pl = new List<Person>() { p1, p2, p3, p4, p5, p6, p7 };

            Mannschaft m = new Mannschaft(pl);
            m.fuegePersonHinzu(t1);

            Assert.AreEqual(6, m.AnzahlSpieler);
        }

        [TestMethod]
        public void SpielerSortierenNachErfolg()
        {
            FussballSpieler p1 = new FussballSpieler("Klaus", 15, "Stürmer", 1);
            FussballSpieler p2 = new FussballSpieler("Dennis", 15, "Stürmer", 2);
            FussballSpieler p4 = new FussballSpieler("Vergil", 15, "Stürmer", 3);
            FussballSpieler p5 = new FussballSpieler("Dante", 15, "Stürmer", 4);
            FussballSpieler p6 = new FussballSpieler("Goku", 15, "Stürmer", 5);
            Physiotherapeut p7 = new Physiotherapeut(45, "Dr. Bob");
            Trainer t1 = new Trainer(74, "Franz Beckenbauer");

            List<Person> pl = new List<Person>() { p1, p2, p4, p5, p6, p7, t1 };

            Mannschaft m = new Mannschaft(pl);
            m.SortBy = 1; // hier wird erstmal nach Erfolg sortiert

            List<Person> sortierteListe = m.sortiere();

            Assert.AreEqual(p6, sortierteListe[0]);
            Assert.AreEqual(p5, sortierteListe[1]);
            Assert.AreEqual(p4, sortierteListe[2]);
            Assert.AreEqual(p2, sortierteListe[3]);
            Assert.AreEqual(p1, sortierteListe[4]);
        }
    }
}