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
//Klassenbibliothek einbinden
using DatabaseConnections;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    public partial class MitarbeiterBearbeiten : Form
    {
        //Instanzen erzeugen
        Mitarbeiter m = new Mitarbeiter();
        EintrittAustritt ea = new EintrittAustritt();
        DbConnections con = new DbConnections();
        ListeMitarbeiter suche = new ListeMitarbeiter();
        ListeMitarbeiter ErgebnisSuche = new ListeMitarbeiter();

        /// <summary>
        /// Initalisiert das Fenster "MitarbeiterBearbeiten"
        /// </summary>
        public MitarbeiterBearbeiten()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _PersonalnummerBearbeiten = null;

        /// <summary>
        /// Variable für die Personalnummer
        /// </summary>  
        public string PersonalnummerBearbeiten
        {
            get
            {
                return _PersonalnummerBearbeiten;
            }
            set
            {
                this._PersonalnummerBearbeiten = value;
            }
        }

        /// <summary>
        /// das Fenster "MitarbeiterBearbeiten" wird geladen
        /// </summary>
        private void MitarbeiterBearbeiten_Load(object sender, EventArgs e)
        {
            try
            {
                ErgebnisSuche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
                //Abfrage ob der Mitarbeiter der "Ur-Admin" mit der Personalnummer 1000 ist
                //wenn ja, dann wird die CheckBox "IsAdmin" deaktiviert.
                if (this.PersonalnummerBearbeiten != "1000")
                {
                    ChkIsAdmin.Checked = ErgebnisSuche.FirstOrDefault().IsAdmin;
                }
                else
                {
                    ChkIsAdmin.Enabled = false;
                }                    
                
                textBoxVorname.Text = ErgebnisSuche.FirstOrDefault().Vorname;
                textBoxNachname.Text = ErgebnisSuche.FirstOrDefault().Nachname;
                textBoxEintrittsdatum.Text = ErgebnisSuche.FirstOrDefault().EintrittsDatum.ToShortDateString();
                TxtPersonalnummer.Text = ErgebnisSuche.FirstOrDefault().Personalnummer;

                dateTimePickerAustrittsdatum.ShowCheckBox = true;
                dateTimePickerAustrittsdatum.Checked = false;
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
            }
        }

        /// <summary>
        /// Internes Hilfsfeld
        /// </summary>
        private string _SuchVariable = null;

        /// <summary>
        /// Stellt eine Eigenschaft für die Such-Variable zur Verfügung
        /// </summary>
        public string SuchVariable
        {
            get
            {
                return _SuchVariable;
            }
            set
            {
                this._SuchVariable = value;
            }
        }

        /// <summary>
        /// Setzt das Passwort wieder zurück auf das Standardpasswort 123user!
        /// </summary>
        private void BtnPasswortZuruecksetzen_Click(object sender, EventArgs e)
        {
            try
            {
                suche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
                con.PasswortAendern(Convert.ToInt32(suche.FirstOrDefault().ID), Helper.GetHash("123user!"));
                MessageBox.Show("Passwort wurde zurückgesetzt!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
            }
        }

        /// <summary>
        /// Speichert die Mitarbeiterdaten
        /// </summary>
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                m.Vorname = textBoxVorname.Text.Trim();
                m.Nachname = textBoxNachname.Text.Trim();
                ea.Personalnummer = TxtPersonalnummer.Text.Trim();
                ea.IsAdmin = ChkIsAdmin.Checked; 
                //Führt das SQL-Update für Vor- und Nachname aus
                con.MitarbeiterUpdaten(m, ea);
                //prüft ob díe Checkbox für den DateTimePicker "Austrittsdatum" aktiv ist
                if (dateTimePickerAustrittsdatum.Checked == true)
                {
                    DateTime tmpDate = DateTime.Today;
                    DateTime tmpAkt = Convert.ToDateTime(dateTimePickerAustrittsdatum.Text);
                    dateTimePickerAustrittsdatum.Format = DateTimePickerFormat.Short;
                    //Prüft ob das "Austrittsdatum" nicht in der Vergangenheit liegt
                    if (tmpAkt >= tmpDate)
                    {
                        con.AustrittMitarbeiter(ea.Personalnummer, tmpAkt);
                    }
                    else
                    {
                        MessageBox.Show("Das Austrittsdatum darf nicht in der Vergangenheit liegen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
                MessageBox.Show("Speichern nicht erfolgreich!");
            }
            this.Close();
        }
    }
}
