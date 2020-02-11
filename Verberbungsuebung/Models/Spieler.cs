//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    Spieler.cs
//Beschreibung: Klasse zur Identifizierung der einzelnen Spieler
//Änderungen:
//11.02.2020:   Entwicklungsbeginn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verberbungsuebung.Models
{
    class Spieler : Person
    {
        #region Eigenschaften
        int _erzieltePkte; //in einem Jahr
        #endregion

        #region Accessoren/Modifier
        public int ErzieltePkte { get => _erzieltePkte; set => _erzieltePkte = value; }
        #endregion

        #region Konstruktoren

        #endregion

        #region Worker
        public string zeigeSpielerProfil()
        {
            string retVal = this.Name + " " + this.Alter + " " + this.ErzieltePkte;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
