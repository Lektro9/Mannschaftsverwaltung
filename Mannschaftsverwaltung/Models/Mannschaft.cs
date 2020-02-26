//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    Mannschaft.cs
//Beschreibung: Definition einer Mannschaft in Zusammenhang des Turnieres
//Änderungen:
//11.02.2020:   Entwicklungsbeginn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class Mannschaft
    {
        #region Eigenschaften
        Verein _verein;
        string _sportart;
        List<Person> _personen;
        int _anzahlSpieler;
        int _sortAlg; //1 = BubbleSort
        #endregion

        #region Accessoren/Modifier
        public string Sportart { get => _sportart; set => _sportart = value; }
        public Verein Verein { get => _verein; set => _verein = value; }
        public List<Person> Personen { get => _personen; set => _personen = value; }
        public int AnzahlSpieler { get => _anzahlSpieler; set => _anzahlSpieler = value; }
        public int SortAlg { get => _sortAlg; set => _sortAlg = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Sportart = null;
            Verein = null;
            Personen = null;
            AnzahlSpieler = 0;
            SortAlg = 1;
        }
        //Spezialkonstruktor
        public Mannschaft(string sportart, Verein verein, List<Person> personen)
        {
            Sportart = sportart;
            Verein = verein;
            Personen = personen;
            pruefeListeAufSpieler();
        }
        public Mannschaft(List<Person> personen) : this()
        {
            Personen = personen;
            pruefeListeAufSpieler();
        }
        #endregion

        #region Worker
        public void fuegePersonHinzu(Person p)
        {
            this.Personen.Add(p);
            pruefeListeAufSpieler();
        }

        private void pruefeListeAufSpieler()
        {
            AnzahlSpieler = 0;
            for (int i = 0; i < Personen.Count; i++)
            {
                if (Personen[i] is Spieler)
                {
                    AnzahlSpieler++;
                }
            }
        }
        public string gebeSpielerAus()
        {
            string retVal = "";
            if (Personen != null)
            {
                for (int i = 0; i < Personen.Count; i++)
                {
                    if (Personen[i] is Spieler)
                    {
                        retVal += Personen[i].Name + "\n";
                    }
                }
            }
            return retVal;
        }

        public void gebeSortierteListeAus()
        {
            List<Person> unsortierteListe = new List<Person>(Personen);
            List<Person> sortierteListe = new List<Person>();
            if (SortAlg == 1)
            {
                sortierteListe = useBubbleSort(unsortierteListe);
            }

            for (int i = 0; i < sortierteListe.Count; i++)
            {
                Console.WriteLine(sortierteListe[i]);
            }
        }

        private List<Person> useBubbleSort(List<Person> unsortierteListe)
        {
            List<Person> retVal = new List<Person>();
            bool fertig = false;
            while (fertig == false)
            {
                fertig = true;
                for (int i = 0; i < unsortierteListe.Count - 1; i++)
                {
                    if (unsortierteListe[i] > unsortierteListe[i + 1])
                    {
                        double temp = zahlenArray[i];
                        zahlenArray[i] = zahlenArray[i + 1];
                        zahlenArray[i + 1] = temp;
                        fertig = false;
                    }
                }
            }
            return zahlenArray;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
