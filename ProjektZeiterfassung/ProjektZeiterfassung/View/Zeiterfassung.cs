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
    public partial class Zeiterfassung : Form
    {
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
            MitarbeiterBearbeiten mitarbeiterbearbeiten = new MitarbeiterBearbeiten();
            mitarbeiterbearbeiten.ShowDialog();
        }
        //Das Fenster MitarbeiterAnlegen wird geöffnet
        private void BtnBenutzerNeu_Click(object sender, EventArgs e)
        {
            MitarbeiterAnlegen mitarbeiteranlegen = new MitarbeiterAnlegen();
            mitarbeiteranlegen.ShowDialog();
        }
        //Das Fenster Zeitkorrektur wird geöffnet
        private void BtnZeitkorrektur_Click(object sender, EventArgs e)
        {
            //Zeitkorrektur zeitkorrigieren = new View.Zeitkorrektur();
            //zeitkorrigieren.ShowDialog();
            CheckButton();
        }
        //Überprüft Personalnummer und PIN
        private void BtnAnmelden_Click(object sender, EventArgs e)
        {
            var PersonalNummer = TxtPersonalnummer.Text;
            var Pin = TxtPin.Text;
            int Personalnummerint;
            int Pinint;
            bool parsed = Int32.TryParse(PersonalNummer, out Personalnummerint);
            bool parsed2 = Int32.TryParse(Pin, out Pinint);
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
        /// Überprüft welcher "Zeittyp" kommen muss und schaltet den jeweiligen Button aktiv.
        /// </summary>
        public void CheckButton()
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

            int Typ = 2;

            if (Typ == 2)
            {
                BtnArbeitsbeginn.Enabled = true;
                MessageBox.Show("dsfad");
            }
            else
            {

                if (Typ == 1 || Typ == 4)
                {
                    BtnArbeitsende.Enabled = true;
                    BtnPausenbeginn.Enabled = true;
                }
                if (Typ == 3)
                {
                    BtnPausenende.Enabled = true;
                }
            }


            //switch (Typ)
            //{
            //    case 2:
            //        ButtonAktiv = "Arbeitsbeginn";
            //        break;
            //    case 1:
            //        ButtonAktiv = "Arbeitsende";
            //        break;
            //    case 1:
            //        ButtonAktiv = "Pausenbeginn";
            //        break;
            //    case 4:
            //        ButtonAktiv = "Pausenende";
            //        break;
            //    default:
            //        ButtonAktiv = "Eintragfehlt";
            //        break;
            //}
            //MessageBox.Show(ButtonAktiv);
        }
    }
}
