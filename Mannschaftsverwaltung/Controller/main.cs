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
            FussballSpieler p1 = new FussballSpieler("Klaus", 15, "Stürmer", 23);
            FussballSpieler p2 = new FussballSpieler("Dennis", 15, "Stürmer", 25);
            FussballSpieler p4 = new FussballSpieler("Vergil", 15, "Stürmer", 857);
            FussballSpieler p5 = new FussballSpieler("Dante", 15, "Stürmer", 900);
            FussballSpieler p6 = new FussballSpieler("Goku", 15, "Stürmer", 1010);
            Trainer t1 = new Trainer("TrainerTom", 84);

            HandballSpieler h1 = new HandballSpieler("Bernd", 12, "Verteidiger", 3);
            HandballSpieler h3 = new HandballSpieler("Harry", 15, "Stürmer", 25);
            HandballSpieler h2 = new HandballSpieler("Henry", 15, "Stürmer", 16);
            HandballSpieler h4 = new HandballSpieler("Holly", 15, "Mittelfeld", 17);

            List<Person> pl1 = new List<Person>() { p1, p2, p4, p5, p6, t1, };
            List<Person> pl2 = new List<Person>() { h1, h2, h3, h4, };

            Mannschaft m = new Mannschaft(pl1);
            Mannschaft m2 = new Mannschaft(pl2);

            //Frühe Bindung
            //string message = ((FussballSpieler) m.Personen[0]).gebePositionsStatistik();

            //Console.WriteLine(message);

            //Späte Bindung
            //message = ((Spieler)m.Personen[2]).spielen();

            //Console.WriteLine(message);
            //Console.ReadKey();
            m.SortBy = 1;
            gebeSortierteListeAus(m.sortiere());
            m2.SortBy = 1;
            gebeSortierteListeAus(m2.sortiere());
            Console.ReadKey();
        }
        public static void gebeSortierteListeAus(List<Person> sortierteListe)
        {
            //TODO: gebe alle Typen mit Eigenschaften aus
            Console.WriteLine("\n\tName \t\tSportArt \t\tPunkte");
            Console.WriteLine();
            for (int i = 0; i < sortierteListe.Count; i++)
            {
                Console.WriteLine("\t" + sortierteListe[i].Name);
            }
        }
    }
}
