using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SetDbVerbindung
{
    
    public class Abeitszeiten
    {
        #region Felder und Eigenschaften
        private DateTime _Anfangsdatum;
        public DateTime Anfangsdatum
        {
            get
            {
                return _Anfangsdatum;
            }
            set
            {
                _Anfangsdatum = value;
            }

        }
        private DateTime _EndDatum;
        public DateTime EndDatum
        {
            get
            {
                return _EndDatum;
            }
            set
            {
                _EndDatum = value;
            }
        }
        private TimeSpan _Berechnung;
        public TimeSpan Berechnung
        {
            get
            {
                return _Berechnung;
            }
            set
            {
                _Berechnung = value;
            }
        }
        private Decimal _Ergebnis;

        public Decimal Ergebnis
        {
            get { return _Ergebnis; }
            set { _Ergebnis = value; }
        }
        private DateTime _PauseAnfang;

        public DateTime PauseAnfang
        {
            get { return _PauseAnfang; }
            set { _PauseAnfang = value; }
        }
        private DateTime _PauseEnde;

        public DateTime PauseEnde
        {
            get { return _PauseEnde; }
            set { _PauseEnde = value; }
        }
        private decimal _PauseZeitraum;

        public decimal PauseZeitraum
        {
            get { return _PauseZeitraum; }
            set { _PauseZeitraum = value; }
        } 
        #endregion

        /// <summary>
        /// Methode tut nur was und berechnet die aktuelle Pausezeit am Tag und die Effektive Arbeitszeit als Decimal
        /// </summary>
        /// <param name="a">Objekt übergabe der DateTime Werte</param>
        public void BerechneZeit(Abeitszeiten a)
        {
            if(a.Anfangsdatum != null && a.PauseAnfang != null && a.PauseEnde != null && a._EndDatum != null)
            {
                TimeSpan tmpPause = a.PauseEnde - a.PauseAnfang;
                PauseZeitraum = Convert.ToDecimal(tmpPause.TotalHours);
                Berechnung = a._EndDatum - tmpPause - a.Anfangsdatum;
                Ergebnis = Convert.ToDecimal(Berechnung.TotalHours);
            }           
        }
    }
    class Program 
    {
        private string _DataSource = null;
        private string _InitialCatalog = "ZEIT2017";
        private string _IntegratedSecurity = "true";
        private string _Entscheidung = null;
        private string _Benutzername = null;

        private string _Passwort = null;
        private string _ConStringNormal = null;
        private string _ConStringSpezial = null;
        static void Main(string[] args)
        {
            //Program p = new Program();
            //Console.WriteLine("Willkommen beim anlegen Ihrer Datenbakverbindung für die Anwendung Zeiterfassung");
            //Console.WriteLine();
            //Console.Write("Geben Sie die IP-Adresse Ihres SQL-Servers ein! (Standard localhost keine Eingabe) :");
            //p._DataSource = Console.ReadLine();
            //Console.WriteLine();
            //if (p._DataSource == null && p._DataSource == "localhost" && p._DataSource == ".")
            //{
            //    p._DataSource = ".";
            //}
            //Console.Write("Verwenden Sie SQL-Authentifizierung (Standard ist nein ansonsten ja eingeben) :");
            //p._Entscheidung = Console.ReadLine().ToLower();
            //if (p._Entscheidung == String.Empty || p._Entscheidung == null)
            //    p._Entscheidung = "nein";
            //Console.WriteLine();
            //if (p._Entscheidung == "ja")
            //{
            //    Console.Write("Bitte Benutzernamen eingeben :");
            //    p._Benutzername = Console.ReadLine();
            //    Console.WriteLine();
            //    Console.Write("Bitte Passwort eingeben :");
            //    p._Passwort = Console.ReadLine();
            //    p._ConStringSpezial = String.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}"
            //                                            ,p._DataSource
            //                                            ,p._InitialCatalog
            //                                            ,p._Benutzername
            //                                            ,p._Passwort
            //                                        );
            //    p.SchreibeConfiguration(p);
            //    Console.WriteLine(String.Format("Der Name der Datenbank lautet {0}!", p._InitialCatalog));                
            //}
            //else
            //{
            //    p._ConStringNormal = String.Format(@"Data Source={0};Initial Catalog={1}; Integrated Security={2}"
            //                                        ,p._DataSource
            //                                        ,p._InitialCatalog
            //                                        ,p._IntegratedSecurity
            //                                       );
            //    p.SchreibeConfiguration(p);
            //    Console.WriteLine(String.Format("Der Name der Datenbank lautet {0}!", p._InitialCatalog));
            //    Console.WriteLine();
            //    Console.WriteLine("Es wurde standard Autentifizierung gewählt!");
            //}

            //Hier gehts weiter zur Zeit Berechnung
            //*****************************************************************************************************
            //********Test zum berechnen einer Tageszeit mit abgezogener Pause als Decimalwert als Rückgabe*********
            //*****************************************************************************************************
            Abeitszeiten a = new Abeitszeiten();
            Console.WriteLine("Datumsberechnungstest mit Timespan");

            //Eingabe Arbeitsbeginn
            Console.Write("Anfangsdatum eingeben (z.B TT/MM/YYYY HH:MM eingeben) :");
            string date = Console.ReadLine();
            if (date == null || date == String.Empty)
                a.Anfangsdatum = DateTime.Now;
            else
                a.Anfangsdatum = Convert.ToDateTime(date);
            Console.WriteLine();

            //Eingabe Pause Beginn        
            string pause = String.Empty;
            Console.Write("Pause Anfang eingeben (TT/MM/YYYY HH:MM),wenn Aktuelle Zeit verwenden nur ENTER :");
            pause = Console.ReadLine();
            Console.WriteLine();            
            if (pause != "")
            {                  
                a.PauseAnfang = Convert.ToDateTime(pause);
            }
            else
            {
                a.PauseAnfang = DateTime.Now;
            }

            //Engabe Pause Ende
            Console.Write("Für Pause Ende eingeben (TT/MM/YYYY HH:MM),wenn aktuelle Zeit verwenden mit ENTER bestätigen :");
            string pauseEnde = String.Empty;
            pauseEnde = Console.ReadLine();
            Console.WriteLine();
            if (pauseEnde != "")
            {
                a.PauseEnde = Convert.ToDateTime(pauseEnde);
            }
            else
            {
                a.PauseEnde = DateTime.Now;
            }

            //Arbeits Ende Eingeben
            string endDate = String.Empty;
            do
            {
                Console.Write("Enddatum eingeben (z.B TT/MM/YYYY HH:MM eingeben) :");
                endDate = Console.ReadLine();
                Console.WriteLine(); 
            } while (endDate == "");
            a.EndDatum = Convert.ToDateTime(endDate);            
                
            Console.WriteLine();
            //Berechnung des Zeitraumes pro Tag in extra Klasse Arbeitzeiten übergabe vom Objekt
            a.BerechneZeit(a);
            Console.WriteLine(String.Format("Die Pause am heutigen Tag beträgt {0} Stunden",a.PauseZeitraum.ToString("#.00")));
            Console.Write(String.Format("Ergebnis Arbeitszeit minus Pause ergibt : {0} Stunden", a.Ergebnis.ToString("#.00")));
            Console.WriteLine();
            Console.ReadLine();
        }

        private void SchreibeConfiguration(Program p)
        {
            var setting = ConfigurationManager.ConnectionStrings["DbVerbindungZeit2017"];
            if (setting == null)
            {
                setting = new ConnectionStringSettings();
                setting.Name = "DbVerbindungZeit2017";
                if(p._Entscheidung == "nein")
                {
                    setting.ConnectionString = p._ConStringNormal;
                }
                else
                {
                    setting.ConnectionString = p._ConStringSpezial;
                }
                
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings.Add(setting);
                config.Save();
                Console.WriteLine();
                Console.WriteLine("Neue Datenbankverbindungseinstellungen erfolgreich angelegt!");
                Console.ReadKey();
                var con = new SqlConnection(setting.ConnectionString);
                try
                {
                    con.Open();
                    Console.WriteLine();
                    Console.WriteLine("Verbindung erfolgreich getestet!");
                    Console.WriteLine();
                    Console.WriteLine("Verbindung erfolgreich geschlossen!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.Write(ex.ToString());
                    
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                }               
                
                Console.ReadKey();
            }
        }
    }
}
