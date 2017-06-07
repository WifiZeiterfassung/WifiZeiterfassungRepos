using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnections.Model
{
    /// <summary>
    /// Stellt eine Klasse für EintritAustritt der Datenabk bereit
    /// </summary>
    public class EintrittAustritt
    {
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private int _ID;
        /// <summary>
        /// Stellt eine Eigenschaft für die Id bereit
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private int _FK_Mitarbeiter;
        /// <summary>
        /// stellt eine Eigenschaft für FK_Mitarbeiter bereit
        /// </summary>
        public int FK_Mitarbeiter
        {
            get { return _FK_Mitarbeiter; }
            set { _FK_Mitarbeiter = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private string _Personalnummer;
        /// <summary>
        /// Stellt eine Eigenschaft für die Personalnummer bereit
        /// </summary>
        public string Personalnummer
        {
            get { return _Personalnummer; }
            set { _Personalnummer = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private DateTime _EintrittsDatum;
        /// <summary>
        /// Stellt eine Eigenschaft für das EintrittsDatum der jeweiligen Person bereit
        /// </summary>
        public DateTime EintrittsDatum
        {
            get { return _EintrittsDatum; }
            set { _EintrittsDatum = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private DateTime _AustrittsDatum;
        /// <summary>
        /// Stellt eine Eigenschaft für den Austritt der jeweiligen Person bereit
        /// </summary>
        public DateTime AustrittsDatum
        {
            get { return _AustrittsDatum; }
            set { _AustrittsDatum = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private Decimal _TagesSollZeit;
        /// <summary>
        /// Stellt eine Eigenschaft für die jeweilige Tages Soll Zeit eines Mitarbeiters bereit
        /// </summary>
        public Decimal TagesSollZeit
        {
            get { return _TagesSollZeit; }
            set { _TagesSollZeit = value; }
        }

        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private bool _IsAdmin;
        /// <summary>
        /// Stellt eine Eigenschaft für den jeweiligen Administrator bereit 
        /// </summary>
        public bool IsAdmin
        {
            get { return _IsAdmin; }
            set { _IsAdmin = value; }
        }
    }
}
