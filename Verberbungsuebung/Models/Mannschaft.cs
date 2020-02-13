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
    class Mannschaft
    {
        #region Eigenschaften
        Verein _verein;
        string _sportart;
        List<Spieler> _spieler;
        #endregion

        #region Accessoren/Modifier
        public string Sportart { get => _sportart; set => _sportart = value; }
        internal Verein Verein { get => _verein; set => _verein = value; }
        internal List<Spieler> Spieler { get => _spieler; set => _spieler = value; }
        #endregion

        #region Konstruktoren
        public Mannschaft()
        {
            Sportart = null;
            Verein = null;
            Spieler = null;
        }
        //Spezialkonstruktor
        public Mannschaft(string sportart, Verein verein, List<Spieler> spieler)
        {
            Sportart = sportart;
            Verein = verein;
            Spieler = spieler;
        }
        #endregion

        #region Worker
        public void fuegeSpielerHinzu(Spieler s)
        {
            this.Spieler.Add(s);
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
