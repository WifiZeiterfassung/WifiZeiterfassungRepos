using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektZeiterfassung.Model;

namespace ProjektZeiterfassung.View
{
    public partial class DatenbankEinstellen : Form
    {
        /// <summary>
        /// Kostruktor erstellt das Windowsfenster Datenbank Einstellen
        /// </summary>
        public DatenbankEinstellen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Methode die beim Button Klick eingegebene Daten in die App.Config schreibt und wieder Zurückgibt
        /// </summary>
        /// <param name="sender">Objekt SetDbVerbindung</param>
        /// <param name="e"></param>
        private void BtnSaveDbSettings_Click(object sender, EventArgs e)
        {
            SetDbVerbindung DbVerbindung = new SetDbVerbindung();
            string tmp = TxtDataSource.Text;
            if (tmp != String.Empty || !String.IsNullOrWhiteSpace(tmp))
            {
                if(TxtDataSource.Text == "localhost" || TxtDataSource.Text == ".")
                {
                    DbVerbindung.DataSource = ".";
                    DbVerbindung.Entscheidung = "nein";
                }
                else
                {
                    DbVerbindung.DataSource = TxtDataSource.Text.Trim();
                    DbVerbindung.Entscheidung = "nein";
                }
            }
            else
            {
                TxtDataSource.ForeColor = Color.Red;
                TxtDataSource.Text = "Eingabe erforderlich!";
                return;
            }
            if (!String.IsNullOrWhiteSpace(TxtUserID.Text) || TxtUserID.Text != String.Empty)
            {
                DbVerbindung.Benutzername = TxtUserID.Text.Trim();
            }

            if (!String.IsNullOrWhiteSpace(TxtPassword.Text) || TxtPassword.Text != String.Empty)
            {
                DbVerbindung.Passwort = TxtPassword.Text.Trim();
                DbVerbindung.Entscheidung = "ja";
            }
            //Speichere die Konfiguration in die App.config Datei mittels einer Methode
            DbVerbindung.SchreibeConfiguration(DbVerbindung);
            //Meldung an View
            TxtMeldung.Text = DbVerbindung.Rueckmeldung;
            if (!DbVerbindung.DbVerbindungNichtErfolgreich)
            {
                BtnSaveDbSettings.Visible = false;
                BtnWeiter.Visible = true;
                TxtDataSource.ForeColor = Color.DarkGreen;
                TxtDataSource.Text = "IP gespeichert";
                if(DbVerbindung.Benutzername != null && DbVerbindung.Passwort != null)
                {
                    TxtUserID.ForeColor = Color.DarkGreen;
                    TxtUserID.Text = "Benutzer gespeichert";
                    TxtPassword.ForeColor = Color.DarkGreen;
                    TxtPassword.Text = "Passwort gespeichert";
                }
                else
                {
                    TxtUserID.ForeColor = Color.DarkGreen;
                    TxtUserID.Text = "Keine Angaben";
                    TxtPassword.ForeColor = Color.DarkGreen;
                    TxtPassword.Text = "Keine Angaben";
                }
            }
            else
            {
                TxtDataSource.ForeColor = Color.Red;
                TxtDataSource.Text = "Falsche IP-Adresse!";
            }            
        }

        private void BtnWeiter_Click(object sender, EventArgs e)
        {
            Mainpanel form = new Mainpanel();
            form.ShowDialog();
            this.Close();
        }
    }
}
