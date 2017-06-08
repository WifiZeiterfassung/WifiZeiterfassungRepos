using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnections.Model
{
    /// <summary>
    /// Stellt eine Liste für die MitarbeiterListe bereit
    /// </summary>
    public class ListeMitarbeiter : System.Collections.Generic.List<MitarbeiterListe>
    {

    }
    /// <summary>
    /// Klasse stellt Eigenschaften für eine Mitarbeiter suche bereit
    /// </summary>
    public class MitarbeiterListe
    {
        private string _ID;
        /// <summary>
        /// Bereitstellen der Eigenschaft Id
        /// </summary>
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Vorname;
        /// <summary>
        /// Bereitstellen der Eigenschaft Vorname
        /// </summary>
        public string Vorname
        {
            get { return _Vorname; }
            set { _Vorname = value; }
        }
        private string _Nachname;
        /// <summary>
        /// Bereitstellen der Eigenschaft Nachname
        /// </summary>
        public string Nachname
        {
            get { return _Nachname; }
            set { _Nachname = value; }
        }

        private string _Personalnummer;
        /// <summary>
        /// Bereitstellen der Eigenschaft Personalnummer
        /// </summary>
        public string Personalnummer
        {
            get { return _Personalnummer; }
            set { _Personalnummer = value; }
        }
        private DateTime _EintrittsDatum;
        /// <summary>
        /// Bereitstellen der Eigenschaft EintrittsDatum
        /// </summary>
        public DateTime EintrittsDatum
        {
            get { return _EintrittsDatum; }
            set { _EintrittsDatum = value; }
        }
        private DateTime _AustrittsDatum;
        /// <summary>
        /// Bereitstellen der Eigenschaft AustrittsDatum
        /// </summary>
        public DateTime AustrittsDatum
        {
            get { return _AustrittsDatum; }
            set { _AustrittsDatum = value; }
        }
        private bool _IsAdmin;
        /// <summary>
        /// Bereitstellen der Eigenschaft IsAdmin
        /// </summary>
        public bool IsAdmin
        {
            get { return _IsAdmin; }
            set { _IsAdmin = value; }
        }
        private decimal _TagesSollZeit;
        /// <summary>
        /// Bereitstellen der Eigenschaft TagesIstZeit
        /// </summary>
        public decimal TagesSollZeit
        {
            get { return _TagesSollZeit; }
            set { _TagesSollZeit = value; }
        }

    }
}
