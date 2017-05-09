using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ProjektZeiterfassung.Model
{
    /// <summary>
    /// Stellt eine Klasse zum speichern der Datenbankzugriffseinstellungen bereit
    /// </summary>
    public class SetDbVerbindung
    {

        private string _DataSource = null;
        private string _InitialCatalog = "ZEIT2017";
        private string _IntegratedSecurity = "true";
        private string _Entscheidung = null;
        private string _Benutzername = null;
        private string _Passwort = null;
        private string _ConStringNormal = null;
        private string _ConStringSpezial = null;
        private string _Rueckmeldung;
        private bool _DbVerbindungNichtErfolgreich = true;
        /// <summary>
        /// Stellt eine Eigenschaft bereit die schluß darauf 
        /// zuläst das die Datenbankverbindung nicht erfolgreich war
        /// </summary>
        public bool DbVerbindungNichtErfolgreich
        {
            get { return _DbVerbindungNichtErfolgreich; }
            set { _DbVerbindungNichtErfolgreich = value; }
        }


        /// <summary>
        /// Stellt eine Eigenschaft für die Rückmeldung ob Verbindung zur neu angelegten 
        /// Datenbankverbindung bereit
        /// </summary>
        public string Rueckmeldung
        {
            get { return _Rueckmeldung; }
            set { _Rueckmeldung = value; }
        }


        /// <summary>
        /// Stellt eine Eigenschaft von ConStringSpezial für die SQL-Authentifizierung bereit
        /// </summary>
        public string ConStringSpezial
        {
            get
            {
                return _ConStringSpezial;
            }
            set
            {
                _ConStringSpezial = value;
            }
        }

        /// <summary>
        /// Stellt eine Eigenschaft von ConStringNormal für die Integrierte Authentifizierung bereit
        /// </summary>
        public string ConStringNormal
        {
            get
            {
                return _ConStringNormal;
            }
            set
            {
                _ConStringNormal = value;
            }
        }

        /// <summary>
        /// Stellt die Eigenschaft Passwort für die SQL-Authentifizierung bereit
        /// </summary>
        public string Passwort
        {
            get
            {
                return _Passwort;
            }
            set
            {
                _Passwort = value;
            }
        }

        /// <summary>
        /// Stellt eine Eigenschaft von Benutzername bei für SQl-Authentifizierung bereit
        /// </summary>
        public string Benutzername
        {
            get
            {
                return _Benutzername;
            }
            set
            {
                _Benutzername = value;
            }
        }

        /// <summary>
        /// Stellt eine Eigenschaft von Entscheidung bereit
        /// </summary>
        public string Entscheidung
        {
            get
            {
                return _Entscheidung;
            }
            set
            {
                _Entscheidung = value;
            }
        }
        /// <summary>
        /// Stellt eine schreibgeschützte Eigenschaft von IntegratedSecurity bereit 
        /// </summary>
        protected string IntegratedSecurity
        {
            get
            {
                return _IntegratedSecurity;
            }
        }
        /// <summary>
        /// Stellt eine schreibgeschützte Eigenschaft von InitialCatalog bereit
        /// </summary>
        protected string InitialCatalog
        {
            get
            {
                return _InitialCatalog;
            }
            
        }

        /// <summary>
        /// Stellt eine Eigenschaft von DataSource bereit
        /// </summary>
        public string DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }

        /// <summary>
        /// Methode schreibt die aktuellen Db-Einstellungen in die Configurationsdatei der Anwendung
        /// </summary>
        /// <param name="p">Object von SetDbVerbindung</param>
        public void SchreibeConfiguration(SetDbVerbindung p)
        {
            //Name der Configuration festlegen
            var setting = ConfigurationManager.ConnectionStrings["DbVerbindungZeit2017"];
            
            if (setting == null)
            {
                setting = new ConnectionStringSettings();
                //Namen der Konfiguration schreiben
                setting.Name = "DbVerbindungZeit2017";
                if (p._Entscheidung == "nein")
                {
                    p._ConStringNormal = String.Format(@"Data Source={0};Initial Catalog={1}; Integrated Security={2}"
                                                    , p._DataSource
                                                    , p._InitialCatalog
                                                    , p._IntegratedSecurity
                                                   );
                    setting.ConnectionString = p._ConStringNormal;
                    Properties.Settings.Default.SqlServer = p.DataSource;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Datenbankname = p.InitialCatalog;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    p._ConStringSpezial = String.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}"
                                                       , p._DataSource
                                                       , p._InitialCatalog
                                                       , p._Benutzername
                                                       , p._Passwort
                                                   );
                    setting.ConnectionString = p._ConStringSpezial;
                    Properties.Settings.Default.SqlServer = p.DataSource;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Datenbankname = p.InitialCatalog;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Benutzername = p.Benutzername;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Passwort = p.Passwort;
                    Properties.Settings.Default.Save();
                }

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if(setting.Name == "DbVerbindungZeit2017")
                {
                    config.ConnectionStrings.ConnectionStrings.Remove(setting);
                }
                config.ConnectionStrings.ConnectionStrings.Add(setting);
                config.Save();
                var StringSumme = new StringBuilder();
                StringSumme.AppendLine("Neue Datenbankverbindungseinstellungen erfolgreich angelegt!");
                StringSumme.AppendLine();
                var con = new SqlConnection(setting.ConnectionString);
                try
                {
                    con.Open();
                    StringSumme.AppendLine("Verbindung erfolgreich getestet!");
                    _DbVerbindungNichtErfolgreich = false;
                    con.Close();
                }
                catch (Exception ex)
                {
                    StringSumme.AppendLine("Verbindung nicht erfolgreich!");
#if DEBUG
                    System.Windows.Forms.MessageBox.Show(ex.ToString(),"Fehlerexception"
                                                        ,System.Windows.Forms.MessageBoxButtons.OK
                                                        ,System.Windows.Forms.MessageBoxIcon.Error);
#endif
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                }
                this._Rueckmeldung = StringSumme.ToString();
            }
        }
    }
}
