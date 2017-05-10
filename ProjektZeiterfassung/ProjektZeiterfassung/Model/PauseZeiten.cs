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
    public class PauseZeiten
    {
        private int _ID;
          
        /// <summary>
        /// Stellt die Eigenschaft Id bereit
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private DateTime _PauseAnfang;
        /// <summary>
        /// Stellt die Eigenschaft PauseAnfang bereit
        /// </summary>
        public DateTime PauseAnfang
        {
            get { return _PauseAnfang; }
            set { _PauseAnfang = value; }
        }
        private DateTime _PauseEnde;
        /// <summary>
        /// Stellt die Eigenschaft PauseEnde bereit
        /// </summary>
        public DateTime PauseEnde
        {
            get { return _PauseEnde; }
            set { _PauseEnde = value; }
        }
        private int _FK_Mitarbeiter;
        /// <summary>
        /// Stellt die Eigenschaft FK_Mitarbeiter bereit
        /// </summary>
        public int FK_Mitarbeiter
        {
            get { return _FK_Mitarbeiter; }
            set { _FK_Mitarbeiter = value; }
        }

    }
}
