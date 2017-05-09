using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZeiterfassung.Model
{
    /// <summary>
    /// Stellt eine Klasse für die Datenbankverbindung bereit
    /// </summary>
    public class Datenbankverbindung
    {
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _Datenbankname = String.Empty;
        /// <summary>
        /// Stellt eine Eigenschaft für den Datenbanknamen bereit
        /// </summary>
        public string Datenbankname
        {
            get { return _Datenbankname; }
            set { _Datenbankname = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _SqlServerAdresse = String.Empty;
        /// <summary>
        /// Stellt die Eigenschaft von der SqlServerAdresse bereit
        /// </summary>
        public string SqlServerAdresse
        {
            get { return _SqlServerAdresse; }
            set { _SqlServerAdresse = value; }
        }
        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _DbConnection = String.Empty;
        /// <summary>
        /// Stellt eine Eigenschaft für die DBConnection bereit
        /// </summary>
        public string DbConnection
        {
            get
            {
                if (_DbConnection == String.Empty || _DbConnection == null )
                {
                    _DbConnection = Con();
                }
                return _DbConnection;
            }
            set { _DbConnection = value; }
        }
        /// <summary>
        /// Konstruktor in dem aus den Einstellungen des Projekts die Datenbankverbindungsdaten geholt werden
        /// </summary>
        public Datenbankverbindung()
        {
            this.Datenbankname = Properties.Settings.Default.Datenbankname;
            this.SqlServerAdresse = Properties.Settings.Default.SqlServer;
            this.DbConnection = _DbConnection;
            
        }
        /// <summary>
        /// Methode welche den Connection String zur Datenbankverbindung herrstellt
        /// </summary>
        /// <returns></returns>
        private string Con()
        {
            var ConBauer = new System.Data.SqlClient.SqlConnectionStringBuilder();
            ConBauer.DataSource = this.SqlServerAdresse;
            ConBauer.InitialCatalog = Datenbankname;
            ConBauer.IntegratedSecurity = true;
            this._DbConnection = ConBauer.ConnectionString;
            return _DbConnection;
        }
    }
}
