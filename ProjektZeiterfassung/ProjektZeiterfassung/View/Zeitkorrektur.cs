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
    public partial class Zeitkorrektur : Form
    {
        public string Korrekturdatum
        {
            get { return dateTimePickerDatum.Text; }
        }
        public string Korrekturzeit
        {
            get { return dateTimePickerUhrzeit.Text; }
        }

        public Zeitkorrektur()
        {
            InitializeComponent();
        }

        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            int Personalnummerint;
            bool parsed = Int32.TryParse(TxtPersonalnummer.Text, out Personalnummerint);

            //Sql Statement
            //SELECT    Personalnummer AS DbPersonalnummer
            //            ,Pin AS DbPin
            //            ,IsAdmin AS DbAdmin
            //            ,Vorname AS DbVorname
            //            ,Nachname AS DbNachname
            //            FROM dbo.Mitarbeiter WHERE Personalnummer = 'PersonalNummer'

            if (Personalnummerint == 1)
            {
                TxtBenutzerdaten.Text = "DbVorname + DbNachname";
            }
            else
            {
                MessageBox.Show("Personalnummer wurde nicht gefunden!");
            }
        }

        private void BtnArbeitsbeginn_Click(object sender, EventArgs e)
        {
            TextBoxPasswort.Text = "Folgende Zeitkorrektur wurde durchgeführt: " + Korrekturdatum + ": Arbeitsbeginn: " + Korrekturzeit;
        }

        private void BtnPausenbeginn_Click(object sender, EventArgs e)
        {
            TextBoxPasswort.Text = "Folgende Zeitkorrektur wurde durchgeführt: " + Korrekturdatum + ": Pausenbeginn: " + Korrekturzeit;
        }

        private void BtnPausenende_Click(object sender, EventArgs e)
        {
            TextBoxPasswort.Text = "Folgende Zeitkorrektur wurde durchgeführt: " + Korrekturdatum + ": Pausenende: " + Korrekturzeit;
        }

        private void BtnArbeitsende_Click(object sender, EventArgs e)
        {
            TextBoxPasswort.Text = "Folgende Zeitkorrektur wurde durchgeführt: " + Korrekturdatum + ": Arbeitsende: " + Korrekturzeit;
        }
    }
}
