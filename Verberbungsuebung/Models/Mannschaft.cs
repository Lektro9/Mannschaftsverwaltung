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
        #endregion

        #region Accessoren/Modifier
        public string Sportart { get => _sportart; set => _sportart = value; }
        public Verein Verein { get => _verein; set => _verein = value; }
        public List<Person> Personen { get => _personen; set => _personen = value; }
        public int AnzahlSpieler { get => _anzahlSpieler; set => _anzahlSpieler = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Sportart = null;
            Verein = null;
            Personen = null;
            AnzahlSpieler = 0;
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
        }

        public void pruefeListeAufSpieler()
        {
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
        #endregion

        #region Schnittstellen
        #endregion
    }
}
