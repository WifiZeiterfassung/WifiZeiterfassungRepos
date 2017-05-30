using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZeiterfassung.View
{
    public partial class Zeiterfassung : System.Windows.Forms.Form
    {
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

            //Sql Statement
            //SELECT    Personalnummer AS DbPersonalnummer
            //            ,Pin AS DbPin
            //            ,IsAdmin AS DbAdmin
            //            ,Vorname AS DbVorname
            //            ,Nachname AS DbNachname
            //            FROM dbo.Mitarbeiter WHERE Personalnummer = 'PersonalNummer'

            if (Personalnummerint == 1)
            {
                if (Pinint == 1)
                {
                    if (DbAdmin == true)
                    {
                        PanelAdministrationsbereich.Enabled = true;
                        LblAdministrationsbereich.Enabled = true;
                        BtnPasswortAendern.Enabled = true;
                    }
                    else
                    {

                    }
                    //BtnArbeitsbeginn.Enabled = true;
                    TxtBenutzerdaten.Text = "Guten Tag + DbVorname + DbNachname + es ist " + Datum;

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
