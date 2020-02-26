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

namespace Mannschaftsverwaltung
{
    public abstract class Spieler : Person
    {
        #region Eigenschaften
        int _erzieltePkte; //in einem Jahr

        
        #endregion

        #region Accessoren/Modifier
        public int ErzieltePkte { get => _erzieltePkte; set => _erzieltePkte = value; }
        #endregion

        #region Konstruktoren
        public Spieler() : base()
        {
            ErzieltePkte = -1;
        }
        //Spezialkonstruktor
        public Spieler(int erzieltePkte) : base()
        {
            ErzieltePkte = erzieltePkte;
        }
        public Spieler(string name, int alter, int erzieltePkte) : base(name, alter)
        {
            ErzieltePkte = erzieltePkte;
        }
        public Spieler(string name, int alter) : base(name, alter)
        {
            ErzieltePkte = -1;
        }
        public Spieler(int alter, string name) : base(alter, name)
        {
            ErzieltePkte = -1;
        }
        //Kopierkonstruktor
        public Spieler(Spieler s) : base(s)
        {
            ErzieltePkte = s.ErzieltePkte;
        }
        #endregion

        #region Worker
        public string zeigeSpielerProfil()
        {
            string retVal = this.Name + " " + this.Alter + " " + this.ErzieltePkte;
            return retVal;
        }

        public abstract string spielen();

        public abstract int compareByErfolg(Spieler s);
        #endregion

        #region Schnittstellen
        #endregion
    }
}
