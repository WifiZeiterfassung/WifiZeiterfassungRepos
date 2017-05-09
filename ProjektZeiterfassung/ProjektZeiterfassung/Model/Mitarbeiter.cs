using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZeiterfassung.Model
{
    /// <summary>
    /// Stellt eine Klasse für Liste von Mitarbeitern zur Verfügung 
    /// </summary>
    public class ListeMitarbeiter : System.Collections.Generic.List<Mitarbeiter>
    {

    }
    /// <summary>
    /// Klasse Stellt die Eigenschaften für das Mitarbeiter Objekt bereit
    /// </summary>
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
        private string _Personalnummer = String.Empty;
        /// <summary>
        /// Eigenschaft für Personalnummer von Mitarbeiter
        /// </summary>
        public string Personalnummer
        {
            get { return _Personalnummer; }
            set { _Personalnummer = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _EintrittsDatum;
        /// <summary>
        /// Stellt eine Eigenschaft für Eintrittsdatum von Mitarbeiter bereit
        /// </summary>
        public DateTime EintrittsDatum
        {
            get { return _EintrittsDatum; }
            set { _EintrittsDatum = value; }
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
        /// Internes Hilfsfeld
        /// </summary>
        private Decimal _TagesSollZeit;
        /// <summary>
        /// Stellt eine Eigenschaft für Tagessollzeit von Mitarbeiter bereit 
        /// </summary>
        public Decimal TagesSollZeit
        {
            get { return _TagesSollZeit; }
            set { _TagesSollZeit = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private bool _IstAktiv;
        /// <summary>
        /// Stellt eine Eigenschaft für IstAktiv von Mitarbeiter bereit
        /// </summary>
        public bool IstAktiv
        {
            get { return _IstAktiv; }
            set { _IstAktiv = value; }
        }

    }
}
