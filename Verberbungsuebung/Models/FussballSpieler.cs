//Autor:        Kroll
//Datum:        11.02.2020
//Dateiname:    FussballSpieler.cs
//Beschreibung: Klasse für den einzelnen FussballSpieler
//Änderungen:   
//11.02.2020:   Entwicklungsbeginn

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verberbungsuebung.Models
{
    class FussballSpieler : Spieler
    {
        #region Eigenschaften
        string _position;
        int geschosseneTore; //in einem Turnier
        #endregion

        #region Accessoren/Modifier
        public string Position { get => _position; set => _position = value; }
        public int GeschosseneTore { get => geschosseneTore; set => geschosseneTore = value; }
        #endregion

        #region Konstruktoren
        public FussballSpieler() : base()
        {
            Position = null;
            geschosseneTore = -1;
        }
        //Spezialkonstruktor
        public FussballSpieler(string position, int geschosseneTore) : base()
        {
            Position = position;
            GeschosseneTore = geschosseneTore;
        }

        public FussballSpieler(string name, int alter, int erzieltePkte, string position, int geschosseneTore) : base(name, alter, erzieltePkte)
        {
            Position = position;
            GeschosseneTore = geschosseneTore;
        }


        #endregion

        #region Worker
        public string gebePositionsStatistik()
        {
            string retVal = this.Name + " hat in diesem Turnier " + this.geschosseneTore + " Tore erzielt von der Position " + this.Position;
            return retVal;
        }
        #endregion

        #region Schnittstellen
        #endregion
    }
}
