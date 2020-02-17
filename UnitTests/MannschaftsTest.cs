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
    }
}