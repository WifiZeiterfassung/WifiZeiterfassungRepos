using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnections.Model
{
    /// <summary>
    /// Stellt die Klasse für das Objekt einer Zeiterfassung bereit 
    /// </summary>
    public class Zeittypen
    {
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private int _ID;
        /// <summary>
        /// Stellt eine Eigenschaft für den jeweiligen Zeittyp bereit 
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private string _Bezeichnung;
        /// <summary>
        /// Stellt die Eigenschaft für eine Bezeichnung des Zeittyps bereit
        /// </summary>
        public string Bezeichnung
        {
            get { return _Bezeichnung; }
            set { _Bezeichnung = value; }
        }
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private char _Modus;

        /// <summary>
        /// Stellt eine Eigenschaft für den Modus A-Anfang E-Ende bereit
        /// </summary>
        public char Modus
        {
            get { return _Modus; }
            set { _Modus = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private int _Von;
        /// <summary>
        /// Stellt eine Eigenschaft Von welchem Anfang und von welchem Ende bereit
        /// </summary>
        public int Von
        {
            get { return _Von; }
            set { _Von = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private bool _Hauptsatz;

        /// <summary>
        /// Stellt eine Eigenschaft für den Hauptsatz bereit
        /// </summary>
        public bool Hauptsatz
        {
            get { return _Hauptsatz; }
            set { _Hauptsatz = value; }
        }

    }
}
