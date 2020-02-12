//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    TennisSpieler.cs
//Beschreibung: Klasse für den einzelnen TennisSpieler
//Änderungen:   
//11.02.2020:   Entwicklungsbeginn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verberbungsuebung
{
    class TennisSpieler : Spieler
    {
        #region Eigenschaften
        string _schlaeger; //welcher Schläger nutzt der Tennisspieler?
        int _aufschlaggeschwindigkeit; //Durchschnittl. Aufschlaggeschw. in km/h

        
        #endregion

        #region Accessoren/Modifier
        public string Schlaeger { get => _schlaeger; set => _schlaeger = value; }
        public int Aufschlaggeschwindigkeit { get => _aufschlaggeschwindigkeit; set => _aufschlaggeschwindigkeit = value; }
        #endregion

        #region Konstruktoren
        public TennisSpieler() : base()
        {
            Schlaeger = null;
            Aufschlaggeschwindigkeit = -1;
        }
        //Spezialkonstruktor
        public TennisSpieler(string name, int alter, int erzieltePkte, string schlaeger, int aufschlaggeschwindigkeit) : base(name, alter, erzieltePkte)
        {
            Schlaeger = schlaeger;
            Aufschlaggeschwindigkeit = aufschlaggeschwindigkeit;
        }
        #endregion

        #region Worker
        public string wechselSchlaeger(string s)
        {
            string retVal = this.Schlaeger;
            this.Schlaeger = s;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
