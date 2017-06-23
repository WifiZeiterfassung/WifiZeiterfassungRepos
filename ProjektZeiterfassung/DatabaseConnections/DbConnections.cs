using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnections.Model;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DatabaseConnections
{
    /// <summary>
    /// Stellt die Verbindungen zur Datenbank bereit
    /// </summary>
    public class DbConnections
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
                if (_DbConnection == String.Empty || _DbConnection == null)
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
        public DbConnections()
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
        //SQL String fürs Update des Passwortes
        private string _SqlString = "UPDATE [ZEIT2017].[dbo].[Mitarbeiter] SET [Passwort] = @Passwort WHERE [ID] = @ID;";
        /// <summary>
        /// Methode ändert das Passwort des Mitarbeiters
        /// </summary>
        /// <param name="id">Id des Mitarbeiters</param>
        /// <param name="pwd">Hashwert des Klartextpassworts</param>
        public void PasswortAendern(int id, byte[] pwd)
        {
            //Später wenn alles in Ortnung einen TRy Catch und finally block einfügen
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand(_SqlString, Connection))
                {
                    //Befehl.CommandText = this._SqlString;
                    Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = id;
                    Befehl.Parameters.Add("@Passwort", System.Data.SqlDbType.VarBinary).Value = pwd;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }

        private string _SqlStringAustritt = "UPDATE [ZEIT2017].[dbo].[EintrittAustritt] SET [AustrittsDatum] = @OutDate " +
                                            "FROM[ZEIT2017].[dbo].[EintrittAustritt] AS ea " +
                                            "JOIN[ZEIT2017].[dbo].[Mitarbeiter] AS m " +
                                             "ON ea.FK_Mitarbeiter = m.ID WHERE ea.Personalnummer = @PNR";
        //SQL String fürs Update des AustrittsDatums
        //private string _SqlStringAustritt = "UPDATE [ZEIT2017].[dbo].[EintrittAustritt] SET [AustrittsDatum] = @OutDate WHERE [FK_Mitarbeiter] = @PNR;";
        /// <summary>
        /// Methode speichert den Austritt eines Mitarbeiters
        /// </summary>
        /// <param name="Personalnummer">Personalnummer des Mitarbeiters</param>
        /// <param name="outdate">Eingestelltes Datum</param>
        public void AustrittMitarbeiter(string Personalnummer, DateTime outdate)
        {
            //Später wenn alles in Ortnung einen TRy Catch und finally block einfügen
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand(_SqlStringAustritt, Connection))
                {
                    Befehl.Parameters.Add("@PNR", System.Data.SqlDbType.NVarChar).Value = Personalnummer;
                    Befehl.Parameters.Add("@OutDate", System.Data.SqlDbType.DateTime).Value = outdate;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }

        //Suche Höchte Mitarbeiter ID
        private string _SucheHoechsteMitarbeiterId = "SELECT TOP(1)m.ID FROM dbo.Mitarbeiter AS m ORDER BY m.ID DESC";
        /// <summary>
        /// Holt aus der Datenbank die höchste Mitarbeiter ID aus der Tabelle Mitarbeiter
        /// </summary>
        /// <returns>Mitarbeiter Id als Integer</returns>
        public int HoleTopMitarbeiterId()
        {
            //Später wenn keine Fehler noch einen Try Catch hinzufügen
            int TopId = 0;
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._SucheHoechsteMitarbeiterId, Connection))
                {
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TopId = reader.GetInt32(reader.GetOrdinal("ID"));
                        }
                    }
                }
                Connection.Close();
            }
            return TopId;
        }


        //Insert statement für Mitarbeiter in der Datenbank
        private string _sqlStringInsertMitarbeiter = "INSERT INTO [ZEIT2017].[dbo].[Mitarbeiter](Vorname,Nachname,Passwort) " +
                                                                                        "VALUES (@Vorname,@Nachname,@Passwort);";
        //Insert für Eintrittaustritt tabelle in der Datenbank
        private string _sqlStringInsertEintrittAustritt = "INSERT INTO [ZEIT2017].[dbo].[EintrittAustritt](FK_Mitarbeiter,Personalnummer,EintrittsDatum,TagesSollZeit,IsAdmin) " +
                                                                                                  "VALUES (@ID,@PerNr,@EDatum,@SollZeit,@IsAdmin);";
        /// <summary>
        /// Methode speichert einen neuen Mitarbeiter in die Datenbank nur für Admin. 
        /// Dafür müssen Daten in zwei Tabellen geschrieben werden dbo.Mitarbeiter und dbo.EintrittAustritt
        /// </summary>
        /// <param name="m">Mitarbeiter Objekt</param>
        /// <param name="ea">EintrittAustritt Objekt</param>
        public void NeuenMitarbeiterSpeichern(Mitarbeiter m, EintrittAustritt ea)
        {
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
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
                //Speichert die Mitarbeiter Id für die weitere Verarbeitung
                ea.FK_Mitarbeiter = this.HoleTopMitarbeiterId();
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

        private string _sqlSucheMitarbeiter = "SELECT  m.ID, " +
                                                     "ea.Personalnummer, " +
                                                     "ea.EintrittsDatum, " +
                                                     "ea.TagesSollZeit, " +
                                                     "m.Vorname, " +
                                                     "m.Nachname, " +
                                                     "ea.IsAdmin " +
                                             "FROM[ZEIT2017].[dbo].[Mitarbeiter] " + "AS m " +
                                               "JOIN[ZEIT2017].[dbo].[EintrittAustritt] " + "AS ea " +
                                                   "ON m.ID = ea.FK_Mitarbeiter " +
                                             "WHERE ea.Personalnummer = @PNR AND m.Passwort = @PWD; ";
        /// <summary>
        /// Sucht den aktuellen Mitarbeiter in der Datenbank für die Anmeldung
        /// </summary>
        /// <param name="m">Passwort des Mitarbeiters</param>
        /// <param name="ea">Personalnummer des Mitrbeiters</param>
        public ListeMitarbeiter MitarbeiterSuchen(byte[] m, string ea)
        {
            ListeMitarbeiter query = new ListeMitarbeiter();
            MitarbeiterListe ml = new MitarbeiterListe();
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._sqlSucheMitarbeiter, Connection))
                {
                    Befehl.Parameters.Add("@PNR", System.Data.SqlDbType.NVarChar).Value = ea;
                    Befehl.Parameters.Add("@PWD", System.Data.SqlDbType.VarBinary).Value = m;
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32(reader.GetOrdinal("ID")).ToString() != null)
                                ml.ID = reader.GetInt32(reader.GetOrdinal("ID")).ToString();
                            if (reader.GetString(reader.GetOrdinal("Vorname")) != null)
                                ml.Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
                            if (reader.GetString(reader.GetOrdinal("Nachname")) != null)
                                ml.Nachname = reader.GetString(reader.GetOrdinal("Nachname"));
                            if (reader.GetString(reader.GetOrdinal("Personalnummer")) != null)
                                ml.Personalnummer = reader.GetString(reader.GetOrdinal("Personalnummer"));
                            ml.EintrittsDatum = reader.GetDateTime(reader.GetOrdinal("EintrittsDatum"));
                            ml.IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            ml.TagesSollZeit = reader.GetDecimal(reader.GetOrdinal("TagesSollZeit"));
                            query.Add(ml);
                        }
                    }
                }
                Connection.Close();
            }
            return query;
        }

        private string _sqlSucheMitarbeiterPersonalnummer = "SELECT  m.ID, " +
                                                            "ea.Personalnummer, " +
                                                            "ea.EintrittsDatum, " +
                                                            "ea.TagesSollZeit, " +
                                                            "m.Vorname, " +
                                                            "m.Nachname, " +
                                                            "ea.IsAdmin " +
                                                            "FROM[ZEIT2017].[dbo].[Mitarbeiter] " + "AS m " +
                                                            "JOIN[ZEIT2017].[dbo].[EintrittAustritt] " + "AS ea " +
                                                            "ON m.ID = ea.FK_Mitarbeiter " +
                                                            "WHERE ea.Personalnummer = @PNR;";
        /// <summary>
        /// Sucht den aktuellen Mitarbeiter mit der Personalnummer in der Datenbank
        /// </summary>
        /// <param name="ea">Personalnummer des Mitrbeiters</param>
        public ListeMitarbeiter MitarbeiterPersonalnummerSuchen(string ea)
        {
            ListeMitarbeiter query = new ListeMitarbeiter();
            MitarbeiterListe ml = new MitarbeiterListe();
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._sqlSucheMitarbeiterPersonalnummer, Connection))
                {
                    Befehl.Parameters.Add("@PNR", System.Data.SqlDbType.NVarChar).Value = ea;
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetInt32(reader.GetOrdinal("ID")).ToString() != null)
                                ml.ID = reader.GetInt32(reader.GetOrdinal("ID")).ToString();
                            if (reader.GetString(reader.GetOrdinal("Vorname")) != null)
                                ml.Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
                            if (reader.GetString(reader.GetOrdinal("Nachname")) != null)
                                ml.Nachname = reader.GetString(reader.GetOrdinal("Nachname"));
                            if (reader.GetString(reader.GetOrdinal("Personalnummer")) != null)
                                ml.Personalnummer = reader.GetString(reader.GetOrdinal("Personalnummer"));
                            ml.EintrittsDatum = reader.GetDateTime(reader.GetOrdinal("EintrittsDatum"));
                            ml.IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            ml.TagesSollZeit = reader.GetDecimal(reader.GetOrdinal("TagesSollZeit"));
                            query.Add(ml);
                        }
                    }
                }
                Connection.Close();
            }
            return query;
        }

        //SQL Speichert eine Arbeitszeit in der Datenbank
        private string _SpeichernArbeitsBeginn = "INSERT INTO [ZEIT2017].[dbo].[Stempelzeiten](FK_Mitarbeiter,Zeitpunkt,ZeitTyp) VALUES (@IdMitarbeiter,@Zeitpunkt,@ZeitTyp);";
        /// <summary>
        /// Methode speichert einen Zeitpunkt in die Datenbank
        /// </summary>
        /// <param name="mbId">Id des Mitarbeiters</param>
        /// <param name="zeit">Zeitpunkt der Stempelung</param>
        /// <param name="typId">ZeitTyp Id für Eroierung</param>
        public void ZeitSpeichern(int mbId, DateTime zeit, int typId)
        {
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(_SpeichernArbeitsBeginn, Connection))
                {
                    //Befehl.CommandText = this._SaveArbeitsBeginn;
                    Befehl.Parameters.Add("@IdMitarbeiter", System.Data.SqlDbType.Int).Value = mbId;
                    Befehl.Parameters.Add("@Zeitpunkt", System.Data.SqlDbType.DateTime).Value = zeit;
                    Befehl.Parameters.Add("@ZeitTyp", System.Data.SqlDbType.TinyInt).Value = typId;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }
        /*SELECT TOP(1)*
          FROM [ZEIT2017].[dbo].[Stempelzeiten] AS s 
          WHERE s.FK_Mitarbeiter = 1
          ORDER BY s.Zeitpunkt DESC;*/
        //sql-String welcher die aktuelle Stempelzeit eines bestimmten Mitarbeiters ausliest aus der Datenbank
        private string _StempelzeitAuslesen = "SELECT TOP(1)* FROM [ZEIT2017].[dbo].[Stempelzeiten] AS s WHERE s.FK_Mitarbeiter = @FkMitarbeiter ORDER BY s.Zeitpunkt DESC;";
        /// <summary>
        /// Methode die eine Liste von stempelzeiten einer bestimmten Person liefert
        /// </summary>
        /// <param name="mbid"> mitarbeiter Id</param>
        /// <returns>Liste von Stempelzeiten eines Mitarbeiters</returns>
        public ListeStempelzeiten StempelzeitMitarbeiter(int mbid)
        {
            ListeStempelzeiten query = new ListeStempelzeiten();
            Stempelzeiten s = new Stempelzeiten();
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._StempelzeitAuslesen, Connection))
                {
                    Befehl.Parameters.Add("@FkMitarbeiter", System.Data.SqlDbType.Int).Value = mbid;
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            s.FK_Mitarbeiter = reader.GetInt32(reader.GetOrdinal("FK_Mitarbeiter"));
                            s.Zeitpunkt = reader.GetDateTime(reader.GetOrdinal("Zeitpunkt"));
                            s.ZeitTyp = reader.GetInt32(reader.GetOrdinal("ZeitTyp"));
                            query.Add(s);
                        }
                    }
                }
                Connection.Close();
            }
            return query;
        }

        //sql-String welcher die höchste Personalnummer aus der Datenbank der Tabelle EintrittAustritt holt
        private string _HoleTopPersonalnummer = "SELECT TOP(1)ea.Personalnummer FROM dbo.EintrittAustritt AS ea ORDER BY ea.Personalnummer DESC;";
        /// <summary>
        /// Holt aus der Datenbank die höchste Personalnummer 
        /// </summary>
        /// <returns>Personalnummer als Integer</returns>
        public int HoleTopPersonalnummer()
        {
            //Später wenn keine Fehler noch einen Try Catch hinzufügen
            int TopPersonalnummer = 0;
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._HoleTopPersonalnummer, Connection))
                {
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                string tmpPersonalnummer = String.Empty;
                                tmpPersonalnummer = reader.GetString(reader.GetOrdinal("Personalnummer")).ToString();
                                TopPersonalnummer = Convert.ToInt32(tmpPersonalnummer);
                            }
                        }
                    }
                }
                Connection.Close();
            }
            return TopPersonalnummer;
        }

        //sql-String welcher den FK_Mitarbeiter auf Grund der Personalnummer aus der Tabelle EintrittAustritt holt
        //private string _HoleFK_Mitarbeiter = "SELECT ea.FK_Mitarbeiter FROM dbo.EintrittAustritt AS ea WHERE ea.Personalnummer = @PNR;";
        private string _HoleFK_Mitarbeiter = "SELECT FK_Mitarbeiter FROM dbo.EintrittAustritt WHERE Personalnummer = @PNR;";
        /// <summary>
        /// Holt aus der Datenbank den FK_Mitarbeiter 
        /// </summary>
        /// <param name="ea">Personalnummer des Mitrbeiters</param>
        /// <returns>Personalnummer als Integer</returns>
        public int HoleFK_Mitarbeiter(string ea)
        {
            //Später wenn keine Fehler noch einen Try Catch hinzufügen
            int FK_Mitarbeiter = 0;

            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();

                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._HoleFK_Mitarbeiter, Connection))
                {
                    Befehl.Parameters.Add("@PNR", System.Data.SqlDbType.NVarChar).Value = ea;
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                FK_Mitarbeiter = reader.GetInt32(reader.GetOrdinal("FK_Mitarbeiter"));
                            }
                        }
                    }
                }
                Connection.Close();
            }
            return FK_Mitarbeiter;
        }
        /// <summary>
        ///sql-String welcher die aktuelle Stempelzeit eines bestimmten Mitarbeiters ausliest aus der Datenbank 
        /// </summary>
        private string _GetModus = "SELECT [Modus] FROM [ZEIT2017].[dbo].[Zeittypen]";
        /// <summary>
        /// Methode die die Zeit-Modi zurück gibt
        /// Wird im Moment nicht verwendet
        /// </summary>
        /// <returns></returns>
        public DataTable GetModus()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._GetModus, Connection))
                {
                    adapter.SelectCommand = Befehl;
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                }
                Connection.Close();
            }
            return table;
        }

        private string _UpdateMitarbeiter = "UPDATE [ZEIT2017].[dbo].[Mitarbeiter] SET [Vorname] = @Vorname, [Nachname]= @Nachname " +
                                            "FROM[ZEIT2017].[dbo].[Mitarbeiter] AS m " +
                                            "JOIN[ZEIT2017].[dbo].[EintrittAustritt] AS ea " +
                                             "ON m.ID = ea.FK_Mitarbeiter WHERE ea.Personalnummer = @PNR";

        private string _UpdateIsAdmin = "UPDATE [ZEIT2017].[dbo].[EintrittAustritt] SET [IsAdmin] = @Admin " +
                                            "FROM[ZEIT2017].[dbo].[Mitarbeiter] AS m " +
                                            "JOIN[ZEIT2017].[dbo].[EintrittAustritt] AS ea " +
                                            "ON m.ID = ea.FK_Mitarbeiter WHERE ea.Personalnummer = @PNR";
        /// <summary>
        /// Methode speichert geänderte Mitarbeiterdaten in die Datenbank nur für Admin. 
        /// Dafür müssen Daten in zwei Tabellen geschrieben werden dbo.Mitarbeiter und dbo.EintrittAustritt
        /// </summary>
        /// <param name="m">Mitarbeiter Objekt</param>
        /// <param name="ea">EintrittAustritt Objekt</param>
        public void MitarbeiterUpdaten(Mitarbeiter m, EintrittAustritt ea)
        {
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandText = this._UpdateMitarbeiter;
                    Befehl.Parameters.Add("@Vorname", System.Data.SqlDbType.NVarChar).Value = m.Vorname;
                    Befehl.Parameters.Add("@Nachname", System.Data.SqlDbType.NVarChar).Value = m.Nachname;
                    Befehl.Parameters.Add("@PNR", System.Data.SqlDbType.Int).Value = ea.Personalnummer;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();
                //Tabelle EintrittAustritt mit IsAdmin wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.EintrittAustritt", Connection))
                {
                    Befehl.CommandText = this._UpdateIsAdmin;
                    Befehl.Parameters.Add("@Admin", System.Data.SqlDbType.Bit).Value = ea.IsAdmin;
                    Befehl.Parameters.Add("@PNR", System.Data.SqlDbType.Int).Value = ea.Personalnummer;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }


        private string _sqlHolePasswort = "SELECT  m.Passwort " +
                                             "FROM[ZEIT2017].[dbo].[Mitarbeiter] " + "AS m " +
                                               "JOIN[ZEIT2017].[dbo].[EintrittAustritt] " + "AS ea " +
                                                   "ON m.ID = ea.FK_Mitarbeiter " +
                                             "WHERE m.ID = @ID; ";

        /// <summary>
        /// Holt aus der Datenbank den FK_Mitarbeiter 
        /// </summary>
        /// <param name="ea">Personalnummer des Mitrbeiters</param>
        /// <returns>Personalnummer als Integer</returns>
        public string HolePasswort(int ea)
        {
            //Später wenn keine Fehler noch einen Try Catch hinzufügen
            string PasswortDB = string.Empty;

            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();

                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._sqlHolePasswort, Connection))
                {
                    Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ea;
                    using (var reader = Befehl.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                PasswortDB = reader.GetValue(reader.GetOrdinal("Passwort")).ToString();
                            }
                        }
                    }
                }
                Connection.Close();
            }
            return PasswortDB;
        }

        /// <summary>
        ///sql-String welcher alle Vor-, Nachnamen und Personalnummern abruft
        /// </summary>
        private string _HoleMitarbeiterDaten = "SELECT [Vorname], [Nachname], [Personalnummer] FROM [ZEIT2017].[dbo].[Mitarbeiter] AS m " +
                                                "JOIN [ZEIT2017].[dbo].[EintrittAustritt] AS ea ON m.ID = ea.FK_Mitarbeiter";
        /// <summary>
        /// DataTable der alle Vor-, Nachnamen und Personalnummern abruft
        /// </summary>
        /// <returns></returns>
        public DataTable HoleMitarbeiterDaten()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Später wenn alles in Ortnung und ohne Fehler läuft mit einen Try Catch und finally block absichern
            //Methode vielleicht noch ändern damit ein Rückgabewert retourniert wird 
            using (var Connection = new System.Data.SqlClient.SqlConnection(this.Con()))
            {
                Connection.Open();

                using (var Befehl = new System.Data.SqlClient.SqlCommand(this._HoleMitarbeiterDaten, Connection))
                {
                    adapter.SelectCommand = Befehl;
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(table);
                }
                Connection.Close();
            }
            return table;
        }
    }
}
