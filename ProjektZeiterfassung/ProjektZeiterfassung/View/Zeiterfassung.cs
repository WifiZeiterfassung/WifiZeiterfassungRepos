using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjektZeiterfassung.Model;
//Hier wird die Klassenbibliothek DatabaseConnections eingebunden
//vorher im Projekt Zeiterfassung unter Verweise die neue DatabaseConnection.dll als Verweis einbinden
using DatabaseConnections;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Windowsfenster wo man Zeiten stempeln kann
    /// </summary>
    public partial class FormZeiterfassung : System.Windows.Forms.Form
    {
        //***************Von Josef Klassen von Klassenbibliothek instanzieren für alle Buttons klickevents******************
        Mitarbeiter m = new Mitarbeiter();
        EintrittAustritt ea = new EintrittAustritt();
        DbConnections con = new DbConnections();
        //Liste mit allen Werten des Mitarbeiters
        ListeMitarbeiter suche = new ListeMitarbeiter();
        //Liste mit Stempelzeit eines Mitarbeiters
        ListeStempelzeiten stList = new ListeStempelzeiten();

        //******************************************************************************************************************



        private string _SqlString = "SELECT [Personalnummer] AS Personalnummer, [Vorname] AS Vorname, [Nachname] AS Nachname, [IsAdmin] AS IsAdmin "+
                                    "FROM[ZEIT2017].[dbo].[Mitarbeiter] "+
                                    "JOIN[ZEIT2017].[dbo].[EintrittAustritt] "+
                                    "ON FK_Mitarbeiter = [ZEIT2017].[dbo].[Mitarbeiter].ID "+
                                    "WHERE Personalnummer = ";
        /// <summary>
        /// Initialisiert eine neue Instanz.
        /// </summary>
        public FormZeiterfassung()
        {
            InitializeComponent();
            this.Height = 255;
        }
        //Das Fenster zum PasswortAendern wird geöffnet
        private void BtnPasswortAendern_Click(object sender, EventArgs e)
        {
            if(suche.Count > 0)
            {
                //Daten in den Einstellungen zwischenspeichern für neues Fenster
                Properties.Settings.Default.FKMitarbeiter = Convert.ToInt32(suche[0].ID);
                Properties.Settings.Default.KlartextPasswort = m.KlartextPasswort;
                PasswortAendern neuespasswort = new PasswortAendern();
                //neuespasswort.Personalnummer = TxtPersonalnummer.Text;
                neuespasswort.ShowDialog(this);
               
            }else
            {
                TxtBenutzerdaten.Text = "Bitte nochmal anmelden zum Passwort ändern!";
            }
            
        }
        //Das Fenster MitarbeiterBearbeiten wird geöffnet
        private void BtnBenutzerUpdate_Click(object sender, EventArgs e)
        {
            MitarbeiterAnlegen mitarbeiteranlegen = new MitarbeiterAnlegen();
            mitarbeiteranlegen.ShowDialog(this);
        }
        //Das Fenster MitarbeiterAnlegen wird geöffnet
        private void BtnBenutzerNeu_Click(object sender, EventArgs e)
        {
            MitarbeiterSuchen mitarbeitersuchen = new MitarbeiterSuchen();
            mitarbeitersuchen.ShowDialog(this);
        }
        //Das Fenster Zeitkorrektur wird geöffnet
        private void BtnZeitkorrektur_Click(object sender, EventArgs e)
        {
            Zeitkorrektur zeitkorrigieren = new View.Zeitkorrektur();
            zeitkorrigieren.ShowDialog();
        }
        /// <summary>
        ///Überprüft Personalnummer und PIN und schaltet dann die Schaltflächen frei.
        /// </summary>
        private void BtnAnmelden_Click(object sender, EventArgs e)
        {
            //von Josef mit Klassenbibliothek **********************************************************************************
            if (!String.IsNullOrWhiteSpace(TxtPersonalnummer.Text.Trim()) && !String.IsNullOrWhiteSpace(TxtPin.Text.Trim()))
            {
                ea.Personalnummer = TxtPersonalnummer.Text.Trim();
                m.KlartextPasswort = TxtPin.Text.Trim();
                m.Passwort = Helper.GetHash(m.KlartextPasswort);
                suche = con.MitarbeiterSuchen(m.Passwort, ea.Personalnummer);
                //Absicherung wenn 0 bei Id daherkommt
                if (suche.Count > 0)
                {
                    stList = con.StempelzeitMitarbeiter(Convert.ToInt32(suche.FirstOrDefault().ID));
                }
                //Fälle für den Benutzer mit Admin rechten besser währe Fallentscheidung weniger wiederholungen
                if (suche.Count > 0 && suche.FirstOrDefault().IsAdmin)
                {
                    TxtBenutzerdaten.Text = String.Format("Hallo Administrator {1} {2}", suche[0].ID, suche[0].Vorname, suche[0].Nachname);
                    if (stList.Count > 0 && stList[0].ZeitTyp == 1)
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = false;
                        BtnPausenbeginn.Enabled = true;
                        BtnArbeitsende.Enabled = true;
                        BtnPausenende.Enabled = false;
                        this.Height = 360;
                    }
                    else if (stList.Count > 0 && stList[0].ZeitTyp == 3)
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = false;
                        BtnPausenbeginn.Enabled = false;
                        BtnArbeitsende.Enabled = false;
                        BtnPausenende.Enabled = true;
                        this.Height = 360;
                    }
                    else if (stList.Count > 0 && stList[0].ZeitTyp == 4)
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = false;
                        BtnPausenbeginn.Enabled = true;
                        BtnArbeitsende.Enabled = true;
                        BtnPausenende.Enabled = false;
                        this.Height = 360;
                    }
                    else
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = true;
                        BtnPausenbeginn.Enabled = false;
                        BtnArbeitsende.Enabled = false;
                        BtnPausenende.Enabled = false;
                        this.Height = 360;
                    }
                }
                //Fälle für den Benutzer ohne Admin rechte
                else if (suche.Count > 0)
                {
                    TxtBenutzerdaten.Text = String.Format("Hallo {1} {2}", suche[0].ID, suche[0].Vorname, suche[0].Nachname);
                    if (stList.Count > 0 && stList[0].ZeitTyp == 1)
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = false;
                        BtnPausenbeginn.Enabled = true;
                        BtnArbeitsende.Enabled = true;
                        BtnPausenende.Enabled = false;
                        this.Height = 255;
                    }
                    else if (stList.Count > 0 && stList[0].ZeitTyp == 3)
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = false;
                        BtnPausenbeginn.Enabled = false;
                        BtnArbeitsende.Enabled = false;
                        BtnPausenende.Enabled = true;
                        this.Height = 255;
                    }
                    else if (stList.Count > 0 && stList[0].ZeitTyp == 4)
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = false;
                        BtnPausenbeginn.Enabled = true;
                        BtnArbeitsende.Enabled = true;
                        BtnPausenende.Enabled = false;
                        this.Height = 255;
                    }
                    else
                    {
                        BtnPasswortAendern.Enabled = true;
                        BtnArbeitsbeginn.Enabled = true;
                        BtnPausenbeginn.Enabled = false;
                        BtnArbeitsende.Enabled = false;
                        BtnPausenende.Enabled = false;
                        this.Height = 255;
                    }
                }
                else
                {
                    TxtBenutzerdaten.Text = "Eingaben falsch oder nicht vorhanden!";
                }
            }
            else
            {
                TxtBenutzerdaten.Text = "Eingabe Personalnummer oder Passwort fehlen!";
            }
            //************************Josef Ende * **********************************************************************************
            //this.PersonalnummerPruefen();
            //this.ButtonFreischalten();
        }
        /// <summary>
        /// Überprüft Personalnummer und PIN
        /// </summary>
        public void PersonalnummerPruefen()
        {
            int Personalnummerint;
            int Pinint;
            bool parsed = Int32.TryParse(TxtPersonalnummer.Text, out Personalnummerint);
            bool parsed2 = Int32.TryParse(TxtPin.Text, out Pinint);
            var Datum = System.DateTime.Now.ToString();


            SqlDataReader reader;
            Datenbankverbindung con = new Datenbankverbindung();
            using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            {
                string ID = TxtPersonalnummer.Text;
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandText = this._SqlString + ID;
                    reader = Befehl.ExecuteReader();
                    while (reader.Read())
                    {
                        string Vorname = reader["Vorname"].ToString();
                        string Nachname = reader["Nachname"].ToString();
                        bool IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                        string Personalnummer = reader["Personalnummer"].ToString();
                        string Begrüßung = "Guten Tag " + Vorname + " " + Nachname + " es ist der " + Datum;
                        

                        if (Personalnummer == TxtPersonalnummer.Text)
                        {
                            if (Pinint == 1)
                            {
                                BtnPasswortAendern.Enabled = true;
                                TxtBenutzerdaten.Text = Begrüßung;

                                if (IsAdmin)
                                {
                                    this.Height = 360;
                                    BtnPasswortAendern.Enabled = true;
                                }
                                else
                                {
                                    this.Height = 255;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Das Passwort ist falsch!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Personalnummer wurde nicht gefunden!");
                        }
                    }
                }
                reader.Close();
                Connection.Close();
            }
        }

        /// <summary>
        /// Überprüft den letzten Datenbankeintrag 
        /// und Schaltet die zulässigen Button frei.
        /// </summary>
        public void ButtonFreischalten()
        {
            //SELECT[ZeitTyp]
            //FROM[ZEIT2017V4].[dbo].[Stempelzeiten]
            //WHERE[FK_Mitarbeiter] = 1
            //ORDER BY[Zeitpunkt] ASC

            //var Typ = [ZeitTyp].ToString();

            //Stempeltypen:
            //Arbeitsbeginn = 1
            //Arbeitsende = 2
            //Pausenbeginn = 3
            //Pausenende = 4
            int Typ = 3;

            switch (Typ)
            {
                case 1:
                    BtnPausenbeginn.Enabled = true;
                    BtnArbeitsende.Enabled = true;
                    break;
                case 2:
                    BtnArbeitsbeginn.Enabled = true;
                    break;
                case 3:
                    BtnPausenende.Enabled = true;
                    break;
                case 4:
                    BtnPausenbeginn.Enabled = true;
                    BtnArbeitsende.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Eintrag fehlt");
                    break;
            }
        }
        /// <summary>
        /// Event Speichert den Arbeitsbeginn in die Datenbank in die Tabelle Stempelzeiten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnArbeitsbeginn_Click(object sender, EventArgs e)
        {
            if (suche.Count > 0)
            {

                con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 1);
                TxtBenutzerdaten.Text = String.Format("Arbeitsbeginn {0} gespeichert!", DateTime.Now);
                BtnArbeitsbeginn.Enabled = false;
                BtnArbeitsende.Enabled = true;
                BtnPausenbeginn.Enabled = true;
                BtnPausenende.Enabled = false;
            
            }
        }
        /// <summary>
        /// Event das den Pausebeginn in die Datenbank schreibt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPausenbeginn_Click(object sender, EventArgs e)
        {
            if (suche.Count > 0)
            {
                con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 3);
                TxtBenutzerdaten.Text = String.Format("Pausebeginn {0} gespeichert!", DateTime.Now);
                BtnArbeitsbeginn.Enabled = false;
                BtnArbeitsende.Enabled = false;
                BtnPausenbeginn.Enabled = false;
                BtnPausenende.Enabled = true;
            }
        }
        /// <summary>
        /// Speichert das PauseEnde in die Datenbank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPausenende_Click(object sender, EventArgs e)
        {
            if (suche.Count > 0)
            {
                con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 4);
                TxtBenutzerdaten.Text = String.Format("Pauseende {0} gespeichert!", DateTime.Now);
                BtnPausenende.Enabled = false;
                BtnPausenbeginn.Enabled = true;
                BtnArbeitsende.Enabled = true;
                BtnArbeitsbeginn.Enabled = false;
            }
        }
        /// <summary>
        /// Speichert das Arbeitsende in die Datenbank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnArbeitsende_Click(object sender, EventArgs e)
        {
            if (suche.Count > 0)
            {
                con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 2);
                TxtBenutzerdaten.Text = String.Format("Pausebeginn {0} gespeichert!", DateTime.Now);
                BtnArbeitsende.Enabled = false;
                BtnArbeitsbeginn.Enabled = true;
                BtnPausenbeginn.Enabled = false;
                BtnPausenende.Enabled = false;
            }
        }
    }
}
