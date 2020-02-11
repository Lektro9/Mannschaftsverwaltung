﻿//Autor:        Kroll
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

namespace Verberbungsuebung.Models
{
    class HandballSpieler : Spieler
    {
        #region Eigenschaften
        string _position;
        #endregion

        #region Accessoren/Modifier
        public string Position { get => _position; set => _position = value; }
        #endregion

        #region Konstruktoren

        #endregion

        #region Worker
        public string aenderePosition(string p)
        {
            string retVal = this.Position;
            Position = p;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
