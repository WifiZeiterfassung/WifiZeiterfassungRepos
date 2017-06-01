using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Model usen für die Klassen
using ProjektZeiterfassung.Model;

namespace HashPasswort
{
    class Datenbankverbindung
    {
        //asjf
        //SQL String fürs Update des Passwortes
        private string _SqlString = "UPDATE [ZEIT2017].[dbo].[Mitarbeiter] SET [Passwort] = @Passwort WHERE [ID] = @ID;";
        //Insert statement für Mitarbeiter in der Datenbank
        private string _sqlStringInsertMitarbeiter = "INSERT INTO [ZEIT2017].[dbo].[Mitarbeiter](Vorname,Nachname,Passwort) "+ 
                                                                                        "VALUES (@Vorname,@Nachname,@Passwort);";
        //Insert für Eintrittaustritt tabelle in der Datenbank
        private string _sqlStringInsertEintrittAustritt = "INSERT INTO [ZEIT2017].[dbo].[EintrittAustritt](FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) "+ 
                                                                                                  "VALUES (@ID,@PerNr,@EDatum,@SollZeit,@IsAdmin);";

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
            this._DbConnection = HashPasswort.Properties.Settings.Default.ZEIT2017ConnectionString;
            //this._DbConnection = Properties.Settings.Default.ZEIT2017ConnServer;
            return _DbConnection;
        }
        /// <summary>
        /// Methode ändert das Passwort des Mitarbeiters
        /// </summary>
        /// <param name="id">Id des Mitarbeiters</param>
        /// <param name="pwd">Hashwert des Klartextpassworts</param>
        private void PasswortAendern(int id, byte[] pwd)
        {
            //Später wenn alles in Ortnung einen TRy Catch und finally block einfügen
            using (var Connection = new System.Data.SqlClient.SqlConnection(this._DbConnection))
            {
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandText = this._SqlString;
                    Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = id;
                    Befehl.Parameters.Add("@Passwort", System.Data.SqlDbType.VarBinary).Value = pwd;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }

        /// <summary>
        /// Methode speichert einen neuen Mitarbeiter in die Datenbank nur für Admin. 
        /// Dafür müssen Daten in zwei Tabellen geschrieben werden dbo.Mitarbeiter und dbo.EintrittAustritt
        /// </summary>
        /// <param name="m">Mitarbeiter Objekt</param>
        /// <param name="ea">EintrittAustritt Objekt</param>
        private void NeuenMitarbeiterSpeichern(Mitarbeiter m, EintrittAustritt ea)
        {
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this._DbConnection))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandText = this._sqlStringInsertMitarbeiter;
                    Befehl.Parameters.Add("@Vorname", System.Data.SqlDbType.NVarChar).Value = m.Vorname;
                    Befehl.Parameters.Add("@Nachname", System.Data.SqlDbType.NVarChar).Value = m.Nachname;
                    Befehl.Parameters.Add("@Passwort", System.Data.SqlDbType.VarBinary).Value = m.Passwort;
                    Befehl.ExecuteNonQuery();
                }

                //Tabelle EintrittAustritt mit Id vom Mitarbeiter,Personalnummer,EintrittsDatum,SollZeit und IsAdmin befüllen
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.EintrittAustritt", Connection))
                {
                    Befehl.CommandText = this._sqlStringInsertEintrittAustritt;
                    Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ea.FK_Mitarbeiter;
                    Befehl.Parameters.Add("@PerNr", System.Data.SqlDbType.NVarChar).Value = ea.Personalnummer;
                    Befehl.Parameters.Add("@EDatum", System.Data.SqlDbType.DateTime).Value = ea.EintrittsDatum;
                    Befehl.Parameters.Add("@SollZeit", System.Data.SqlDbType.Decimal).Value = ea.TagesSollZeit;
                    Befehl.Parameters.Add("@IsAdmin", System.Data.SqlDbType.Bit).Value = ea.IsAdmin;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }
    }
}
