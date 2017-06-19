using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnections;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Formklasse Mitarbeiter anlegen
    /// </summary>
    public partial class MitarbeiterAnlegen : Form
    {
        //Instanzen von Mitarbeiter und EintrittAustritt erzeugen für die weitere Verwendung
        Mitarbeiter m = new Mitarbeiter();
        EintrittAustritt ea = new EintrittAustritt();
        DbConnections con = new DbConnections();

        /// <summary>
        /// Initalisiert das Fenster "MitarbeiterAnlegen"
        /// </summary>
        public MitarbeiterAnlegen()
        {
            InitializeComponent();
            BtnSpeichern.Enabled = false;
            TxtPersonalnummer.ReadOnly = true;
        }

        /// <summary>
        /// Generiert eine neue Personalnummer anhand der höchsten Personalnummer aus der Datenbank
        /// </summary>
        private void BtnPnGen_Click(object sender, EventArgs e)
        {
            //Aktuell höchste Personalnummer holen
            int Pnr = con.HoleTopPersonalnummer();
            //Personalnummer um 1 erhöhen
            Pnr += 1;
            //zu String machen
            ea.Personalnummer = Pnr.ToString();
            //Personalnummer anzeigen
            TxtPersonalnummer.Text = ea.Personalnummer;
            //Generieren Button disablen
            BtnPnGen.Enabled = false;
            //Speicherbutton enabeln
            BtnSpeichern.Enabled = true;
        }
        /// <summary>
        /// Speichert einen neuen Mitarbeiter
        /// </summary>
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(TxtVorname.Text) && !String.IsNullOrWhiteSpace(TxtNachname.Text) && !String.IsNullOrWhiteSpace(TxtSollStunden.Text))
            {
                m.Vorname = TxtVorname.Text.Trim();
                m.Nachname = TxtNachname.Text.Trim();
                //Standardpasswort vergeben bei neuen Benutzer
                m.KlartextPasswort = "123user!";
                m.Passwort = Helper.GetHash(m.KlartextPasswort);
                //ea.Personalnummer schon vorhanden von generieren
                ea.EintrittsDatum = Convert.ToDateTime(dateTimePickerEintritt.Text);
                ea.TagesSollZeit = Convert.ToDecimal(TxtSollStunden.Text.Trim());
                ea.IsAdmin = ChkIsAdmin.Checked;
                //Speichert die aktuellen Eingaben in die Datenbank
                con.NeuenMitarbeiterSpeichern(m, ea);
                TxtMeldung.Text = String.Format("Mitarbeiter {0} {1} {2} wurde erfolgreich angelegt", ea.Personalnummer, m.Vorname, m.Nachname);
                BtnSpeichern.Enabled = false;
                BtnPnGen.Enabled = true;
                TxtPersonalnummer.Text = String.Empty;
                TxtVorname.Text = String.Empty;
                TxtNachname.Text = String.Empty;
                TxtSollStunden.Text = String.Empty;   
            }
            else
            {
                TxtMeldung.Text = "Fehlende Eingaben!";
            }
        }
    }
}
