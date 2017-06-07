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

namespace ProjektZeiterfassung.View
{
    public partial class FormZeiterfassung : System.Windows.Forms.Form
    {
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
        }
        //Das Fenster zum PasswortAendern wird geöffnet
        private void BtnPasswortAendern_Click(object sender, EventArgs e)
        {
            PasswortAendern neuespasswort = new PasswortAendern();
            neuespasswort.Personalnummer = TxtPersonalnummer.Text;
            neuespasswort.ShowDialog(this);
        }
        //Das Fenster MitarbeiterBearbeiten wird geöffnet
        private void BtnBenutzerUpdate_Click(object sender, EventArgs e)
        {
            //MitarbeiterAnlegen mitarbeiteranlegen = new MitarbeiterAnlegen();
            //mitarbeiteranlegen.ShowDialog(this);
            MitarbeiterAuswahl mitarbeiterauswaehlen = new MitarbeiterAuswahl();
            mitarbeiterauswaehlen.ShowDialog(this);

        }
        //Das Fenster MitarbeiterAnlegen wird geöffnet
        private void BtnBenutzerNeu_Click(object sender, EventArgs e)
        {
            MitarbeiterBearbeiten mitarbeiterbearbeiten = new MitarbeiterBearbeiten();
            mitarbeiterbearbeiten.ShowDialog(this);
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
            this.PersonalnummerPruefen();
            this.ButtonFreischalten();
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
                        string IsAdmin = reader["IsAdmin"].ToString();
                        string Personalnummer = reader["Personalnummer"].ToString();
                        string Begrüßung = "Guten Tag " + Vorname + " " + Nachname + " es ist der " + Datum;
                        

                        if (Personalnummer == TxtPersonalnummer.Text)
                        {
                            if (Pinint == 1)
                            {
                                BtnPasswortAendern.Enabled = true;
                                TxtBenutzerdaten.Text = Begrüßung;

                                if (IsAdmin == "1")
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
    }
}
