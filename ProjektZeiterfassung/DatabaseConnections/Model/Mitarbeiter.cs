using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnections.Model
{
    public class Mitarbeiter
    {
        /// <summary>
        /// Internes Hilfsfeld für Id
        /// </summary>
        private int _ID = 0;
        /// <summary>
        /// Eigenschaft für Id von Mitarbeiter
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _Vorname = String.Empty;
        /// <summary>
        /// Stellt eine Eigenschaft für den Vornamen von Mitarbeiter bereit
        /// </summary>
        public string Vorname
        {
            get { return _Vorname; }
            set { _Vorname = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _Nachname = String.Empty;
        /// <summary>
        /// Stellt eine Eigenschaft für Nachname von Mitarbeiter bereit
        /// </summary>
        public string Nachname
        {
            get { return _Nachname; }
            set { _Nachname = value; }
        }
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private string _KlartextPasswort;
        /// <summary>
        /// Stellt die Eigenschaft für das Klartextpasswort bereit
        /// </summary>
        public string KlartextPasswort
        {
            get { return _KlartextPasswort; }
            set { _KlartextPasswort = value; }
        }
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private byte[] _Passwort;
        /// <summary>
        /// Stellt die Eigenschaft Passwort als Hashwert bereit für die Datenbank zum prüfen
        /// </summary>
        public byte[] Passwort
        {
            get { return _Passwort; }
            set { _Passwort = value; }
        }
    }
}
