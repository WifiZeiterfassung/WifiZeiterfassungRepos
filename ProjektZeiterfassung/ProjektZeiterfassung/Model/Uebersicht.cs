using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZeiterfassung.Model
{
    /// <summary>
    /// Stellt die Klasse für eine Übersichtsliste bereit
    /// </summary>
    public class UebersichtsListe : System.Collections.Generic.List<Uebersicht>
    {

    }
    /// <summary>
    /// Klasse für ein Objekt der Übersichtsansicht aus Mitarbeiter und Zeiterfassung
    /// </summary>
    public class Uebersicht : Zeiterfassung
    {
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _Von;
        /// <summary>
        /// Stellt die Eigenschaft für den Suchzeitraum Von für die Auflistung bereit
        /// </summary>
        public DateTime Von
        {
            get { return _Von; }
            set { _Von = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private DateTime _Bis;
        /// <summary>
        /// Stellt die Eigenschaft Bis für den Suchzeitraum für die Auflistung bereit
        /// </summary>
        public DateTime Bis
        {
            get { return _Bis; }
            set { _Bis = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _Personalnummer = String.Empty;
        /// <summary>
        /// Stellt eine Eigenschaft für die Personalnummer bereit von Übersicht
        /// </summary>
        public string Personalnummer
        {
            get { return _Personalnummer; }
            set { _Personalnummer = value; }
        }
        /// <summary>
        /// internes Hilfsfeld
        /// </summary>
        private string _FullName = String.Empty;
        /// <summary>
        /// Stellt eine Eigenschaft für den vollen Namen der Übersicht bereit
        /// </summary>
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private decimal _Wochensumme = 0;
        /// <summary>
        /// Stellt die Eigenschaft für eine Wochensumme/Arbeitszeit von Übersicht bereit
        /// </summary>
        public decimal Wochensumme
        {
            get { return _Wochensumme; }
            set { _Wochensumme = value; }
        }
        /// <summary>
        /// Konstruktor zur Übersichtsliste
        /// </summary>
        /// <param name="m">Mitarbeiter objekt</param>
        public Uebersicht(Mitarbeiter m)
        {
            this.Personalnummer = m.Personalnummer;
            this.FullName = GetFullName(m.Vorname, m.Nachname);
        }
        /// <summary>
        /// Methode zum Verketten von vor und Nachname
        /// </summary>
        /// <param name="vorname"></param>
        /// <param name="nachname"></param>
        /// <returns>Vor und Nachname Verkettet als string</returns>
        private string GetFullName(string vorname,string nachname)
        {
            this._FullName = vorname + " " + nachname;
            return this._FullName;
        }
    }
}
