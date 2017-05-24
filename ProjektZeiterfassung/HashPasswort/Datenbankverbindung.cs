using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashPasswort
{
    class Datenbankverbindung
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

        public Datenbankverbindung()
        {
            DbConnection = _DbConnection;
        }
        /// <summary>
        /// Methode welche den Connection String zur Datenbankverbindung herrstellt
        /// </summary>
        /// <returns></returns>
        private string Con()
        {
            //var ConBauer = new System.Data.SqlClient.SqlConnectionStringBuilder();
            //ConBauer.DataSource = this.SqlServerAdresse;
            //ConBauer.InitialCatalog = Datenbankname;
            //ConBauer.IntegratedSecurity = true;
            //this._DbConnection = ConBauer.ConnectionString;
            //this._DbConnection = HashPasswort.Properties.Settings.Default.ZEIT2017ConnectionString;
            this._DbConnection = Properties.Settings.Default.ZEIT2017ConnServer;
            return _DbConnection;
        }
    }
}
