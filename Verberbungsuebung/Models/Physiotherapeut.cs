//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    Physiotherapeut.cs
//Beschreibung: Definierung eines Tunieres im Sport
//Änderungen:
//11.02.2020:   Entwicklungsbeginn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verberbungsuebung.Models
{
    class Physiotherapeut : Person
    {
        #region Eigenschaften
        List<string> _anerkennungen; //Ärztliche Annerkennungen, Erfolge, etc.
        #endregion

        #region Accessoren/Modifier
        public List<string> Anerkennungen { get => _anerkennungen; set => _anerkennungen = value; }
        #endregion

        #region Konstruktoren

        #endregion

        #region Worker
        public string stelleAttestAus(Spieler s)
        {
            string retVal = "Der Physiotherapeut " + this.Name + " stellt ein Attest aus für den Spieler " + s.Name;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
