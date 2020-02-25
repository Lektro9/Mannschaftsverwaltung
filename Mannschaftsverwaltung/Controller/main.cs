//Autor:        Kroll
//Datum:        06.02.2020
//Dateiname:    main.cs
//Beschreibung: Hauptausführung
//Änderungen:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    class main
    {
        static void Main(string[] args)
        {
            FussballSpieler p1 = new FussballSpieler("Klaus", 15, 23, "Stürmer", 23);
            FussballSpieler p2 = new FussballSpieler(22, "Dennis");
            HandballSpieler p3 = new HandballSpieler(23, "Bernd");
            FussballSpieler p4 = new FussballSpieler(45, "Vergil");
            FussballSpieler p5 = new FussballSpieler(43, "Dante");
            FussballSpieler p6 = new FussballSpieler(85, "Goku");
            Physiotherapeut p7 = new Physiotherapeut(45, "Dr. Bob");
            Trainer t1 = new Trainer(74, "Franz Beckenbauer");

            List<Person> pl = new List<Person>() { p1, p2, p3, p4, p5, p6, p7, t1 };

            Mannschaft m = new Mannschaft(pl);

            //Frühe Bindung
            string message = ((FussballSpieler) m.Personen[0]).gebePositionsStatistik();

            Console.WriteLine(message);

            //Späte Bindung
            message = ((Spieler)m.Personen[2]).spielen();

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
