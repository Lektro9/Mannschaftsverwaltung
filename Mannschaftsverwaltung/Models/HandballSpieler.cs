//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    HandballSpieler.cs
//Beschreibung: Klasse für den einzelnen Handballspieler
//Änderungen:   
//11.02.2020:   Entwicklungsbeginn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mannschaftsverwaltung
{
    public class HandballSpieler : Spieler
    {
        #region Eigenschaften
        string _position;
        #endregion

        #region Accessoren/Modifier
        public string Position { get => _position; set => _position = value; }
        #endregion

        #region Konstruktoren
        public HandballSpieler() : base()
        {
            Position = null;
        }
        //Spezialkonstruktor
        public HandballSpieler(string position) : base()
        {
            Position = position;
        }

        public HandballSpieler(string name, int alter, int erzieltePkte, string position) : base(name, alter, erzieltePkte)
        {
            Position = position;
        }

        public HandballSpieler(int alter, string name) : base(alter, name)
        {
            Position = null;
        }

        //Kopierkonstruktor
        public HandballSpieler(HandballSpieler h) : base()
        {
            Position = h.Position;
        }
        #endregion

        #region Worker
        public string aenderePosition(string p)
        {
            string retVal = this.Position;
            Position = p;
            return retVal;
        }
        public override string spielen()
        {
            string retVal = "Der Handballer spielt.";
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
