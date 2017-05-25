using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZeiterfassung.Model
{
    /// <summary>
    /// Klasse stellt Methoden und Eigenschaften bereit
    /// </summary>
    public class Stempelzeiten
    {
        private int _FK_Mitarbeiter;
          
        /// <summary>
        /// Stellt die Eigenschaft Id bereit
        /// </summary>
        public int FK_Mitarbeiter
        {
            get { return _FK_Mitarbeiter; }
            set { _FK_Mitarbeiter = value; }
        }
        private DateTime _Zeitpunkt;
        /// <summary>
        /// Stellt die Eigenschaft PauseAnfang bereit
        /// </summary>
        public DateTime Zeitpunkt
        {
            get { return _Zeitpunkt; }
            set { _Zeitpunkt = value; }
        }
        private DateTime _ZeitTyp;
        /// <summary>
        /// Stellt die Eigenschaft PauseEnde bereit
        /// </summary>
        public DateTime ZeitTyp
        {
            get { return _ZeitTyp; }
            set { _ZeitTyp = value; }
        }

    }
}
