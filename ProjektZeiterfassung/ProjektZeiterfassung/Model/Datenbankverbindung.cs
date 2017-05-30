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
            this.DbConnection = _DbConnection;
            
        }
        /// <summary>
        /// Methode welche den Connection String zur Datenbankverbindung herrstellt
        /// Aufpassen welchen Connectionstring verwendet wird bei dir ZuHause oder Wifi
        /// </summary>
        /// <returns></returns>
        private string Con()
        {
            //var ConBauer = new System.Data.SqlClient.SqlConnectionStringBuilder();
            //ConBauer.DataSource = this.SqlServerAdresse;
            //ConBauer.InitialCatalog = Datenbankname;
            //ConBauer.IntegratedSecurity = true;
            //this._DbConnection = ConBauer.ConnectionString;
            //this._DbConnection = Properties.Settings.Default.ZEIT2017ConnServer; //SqlServerAdresse-SERVER 192.168.1.103
            this._DbConnection = Properties.Settings.Default.ZEIT2017ConnectionString; //In der wifi diese zuweisung verwenden .\SQLEXPRESS
            return _DbConnection;
        }
    }
}
