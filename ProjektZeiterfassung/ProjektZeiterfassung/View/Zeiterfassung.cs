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
    public partial class Zeiterfassung : System.Windows.Forms.Form
    {
        private string _SqlString = "SELECT [Vorname] AS Vorname, [Nachname] AS Nachname " + 
                                    "FROM [ZEIT2017].[dbo].[Mitarbeiter] " +
                                    "JOIN [ZEIT2017].[dbo].[EintrittAustritt] " +
                                    "ON [dbo].[Mitarbeiter].ID = FK_Mitarbeiter " + 
                                    "WHERE Personalnummer = ";
        /// <summary>
        /// Initialisiert eine neue Instanz.
        /// </summary>
        public Zeiterfassung()
        {
            InitializeComponent();
        }
        //Das Fenster zum PasswortAendern wird geöffnet
        private void BtnPasswortAendern_Click(object sender, EventArgs e)
        {
            PasswortAendern neuespasswort = new PasswortAendern();
            neuespasswort.ShowDialog(this);
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
            bool DbAdmin = true;
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
                        string Begrüßung = "Guten Tag " + Vorname + " " + Nachname + " es ist der " + Datum;
                        TxtBenutzerdaten.Text = Begrüßung;

                        if (TxtPersonalnummer.Text == "1032")
                        //if (Vorname != null)
                        {
                            if (Pinint == 1)
                            {
                                if (DbAdmin == true)
                                {
                                    PanelAdministrationsbereich.Enabled = true;
                                    LblAdministrationsbereich.Enabled = true;
                                    BtnPasswortAendern.Enabled = true;
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
