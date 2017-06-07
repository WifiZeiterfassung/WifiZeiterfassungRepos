﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnections.Model;

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
            this._DbConnection = Properties.Settings.Default.ZEIT2017ConnServer; //SqlServerAdresse-SERVER 192.168.1.103
            //this._DbConnection = Properties.Settings.Default.ZEIT2017ConnectionString; //In der wifi diese zuweisung verwenden .\SQLEXPRESS
            return _DbConnection;
        }
        //SQL String fürs Update des Passwortes
        private string _SqlString = "UPDATE [ZEIT2017].[dbo].[Mitarbeiter] SET [Passwort] = @Passwort WHERE [ID] = @ID;";
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
        /// Sucht den aktuellen Mitarbeiter in der Datenbank
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
                            if(reader.GetInt32(reader.GetOrdinal("ID")).ToString() != null)
                                ml.ID = reader.GetInt32(reader.GetOrdinal("ID")).ToString();
                            if(reader.GetString(reader.GetOrdinal("Vorname")) != null)
                                ml.Vorname = reader.GetString(reader.GetOrdinal("Vorname"));
                            if(reader.GetString(reader.GetOrdinal("Nachname")) != null)
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
        private string _SaveArbeitsBeginn = "INSERT INTO [ZEIT2017].[dbo].[Stempelzeiten](FK_Mitarbeiter,Zeitpunkt,ZeitTyp) VALUES (@IdMitarbeiter,@Zeitpunkt,@ZeitTyp);";
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
            using (var Connection = new System.Data.SqlClient.SqlConnection(this._DbConnection))
            {
                Connection.Open();
                //Tabelle Mitarbeiter mit Vorname Nachnam und Passwort das übergeben wird befüllen 
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Stempelzeiten", Connection))
                {
                    Befehl.CommandText = this._SaveArbeitsBeginn;
                    Befehl.Parameters.Add("@IdMitarbeiter", System.Data.SqlDbType.Int).Value = mbId;
                    Befehl.Parameters.Add("@Zeitpunkt", System.Data.SqlDbType.DateTime).Value = zeit;
                    Befehl.Parameters.Add("@ZeitTyp", System.Data.SqlDbType.TinyInt).Value = typId;
                    Befehl.ExecuteNonQuery();
                }
                Connection.Close();
            }
        }
    }
}
