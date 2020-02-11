﻿//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    Verein.cs
//Beschreibung: Verein welche Mannschaften beinhalten kann
//Änderungen:
//11.02.2020:   Entwicklungsbeginn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verberbungsuebung.Models
{
    class Verein
    {
        #region Eigenschaften
        string _name;
        string _sportart;
        #endregion

        #region Accessoren/Modifier
        public string Name { get => _name; set => _name = value; }
        public string Sportart { get => _sportart; set => _sportart = value; }
        #endregion

        #region Konstruktoren

        #endregion

        #region Worker
        public string gebeName()
        {
            string retVal = this.Name;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
