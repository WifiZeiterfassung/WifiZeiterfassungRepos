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

        private string _SqlString = "SELECT [Vorname] AS Vorname, [Nachname] AS Nachname, [EintrittsDatum] AS Eintrittsdatum " +
                                    "FROM [ZEIT2017].[dbo].[Mitarbeiter] JOIN [ZEIT2017].[dbo].[EintrittAustritt] " +
                                    "ON [dbo].[Mitarbeiter].ID = FK_Mitarbeiter " +
                                    "WHERE ([dbo].[Mitarbeiter].Vorname like '%1000%' " +
                                    "OR [dbo].[Mitarbeiter].Nachname like '%1000%' " +
                                    "OR [dbo].[EintrittAustritt].Personalnummer like '%1032%')";
        //private string _SqlString = "SELECT [Vorname] AS Vorname, [Nachname] AS Nachname, [EintrittsDatum] AS Eintrittsdatum " +
        //                    "FROM [ZEIT2017].[dbo].[Mitarbeiter] JOIN [ZEIT2017].[dbo].[EintrittAustritt] " +
        //                    "ON [dbo].[Mitarbeiter].ID = FK_Mitarbeiter " +
        //                    "WHERE ([dbo].[Mitarbeiter].Vorname like '%";
        /// <summary>
        /// Privates Hilfsfeld
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
        /// Initalisiert das Fenster "MitarbeiterBearbeiten"
        /// </summary>
        public MitarbeiterBearbeiten()
        {
            InitializeComponent();
            //dateTimePickerAustrittsdatum.Format = DateTimePickerFormat.Custom;
            //dateTimePickerAustrittsdatum.CustomFormat = " ";
            //BtnPasswortZuruecksetzen.Enabled = false;
            //BtnSpeichern.Enabled = false;
        }
        //Instanzen erzeugen
        Mitarbeiter m = new Mitarbeiter();
        EintrittAustritt ea = new EintrittAustritt();
        DbConnections con = new DbConnections();        
        ListeMitarbeiter suche = new ListeMitarbeiter();
        public string PersonalnummerBearbeiten { get; set; }

        /// <summary>
        /// Sucht in der Datenbank an Hand der Personalnummer, Vorname oder Nachname nach den Mitarbeiterdaten
        /// </summary>
        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            MitarbeiterSuchen mitarbeitersuchen = new MitarbeiterSuchen();
            mitarbeitersuchen.ShowDialog();

            ////Prüfe ob Textbox befüllt ist
            //if (!String.IsNullOrWhiteSpace(TxtPersonalnummer.Text.Trim()))
            //{
            //    ea.Personalnummer = TxtPersonalnummer.Text.Trim();
            //    suche = con.MitarbeiterPersonalnummerSuchen(ea.Personalnummer);
            //    if(suche.Count > 0)
            //    {
            //        textBoxVorname.Text = suche.FirstOrDefault().Vorname;
            //        textBoxNachname.Text = suche.FirstOrDefault().Nachname;
            //        textBoxEintrittsdatum.Text = suche.FirstOrDefault().EintrittsDatum.ToShortDateString();
            //        //BtnSuchen.Enabled = false;
            //        //BtnPasswortZuruecksetzen.Enabled = true;
            //        //BtnSpeichern.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Personalnummer nicht existent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        TxtPersonalnummer.BackColor = Color.Yellow;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Bitte eine Personalnummer eingeben!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    TxtPersonalnummer.BackColor = Color.Yellow;
            //}


            //SqlDataReader reader;
            //Datenbankverbindung con = new Datenbankverbindung();
            //using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            //{
            //    Connection.Open();
            //    using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
            //    {
            //        int i = 0;
            //        string Vorname = null;
            //        string Nachname = null;
            //        //Befehl.CommandText = this._SqlString + textBoxVorname.Text + "%' OR [dbo].[Mitarbeiter].Nachname like '%" + textBoxNachname.Text + "%' OR [dbo].[EintrittAustritt].Personalnummer like '%" + TxtPersonalnummer.Text + "%')";
            //        Befehl.CommandText = this._SqlString;
            //        reader = Befehl.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Vorname = reader["Vorname"].ToString();
            //            Nachname = reader["Nachname"].ToString();
            //            DateTime Eintrittsdatum = Convert.ToDateTime( reader["Eintrittsdatum"].ToString());
                        
            //            //textBoxEintrittsdatum.Text = Eintrittsdatum.ToShortDateString();
            //            i++;
            //        }
            //        if (i <= 1)
            //        {
            //            textBoxVorname.Text = Vorname;
            //            textBoxNachname.Text = Nachname;
            //            textBoxEintrittsdatum.Text = i.ToString();
            //        }
            //        else
            //        {
            //            var t = new DataTable();
                        
            //            MessageBox.Show("faskaslöf");
            //        }

            //    }
            //    reader.Close();
            //    Connection.Close();
            //}
        }
        //Setzt das Passwort wieder zurück auf das Standardpasswort 123user!
        private void BtnPasswortZuruecksetzen_Click(object sender, EventArgs e)
        {
            try
            {
                con.PasswortAendern(Convert.ToInt32(suche.FirstOrDefault().ID), Helper.GetHash("123user!"));
                MessageBox.Show("Passwort wurde zurückgesetzt!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
        }
        /// <summary>
        /// Speichert das Austrittsdatum des Mitarbeiters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                //Hilfsvariablen erzeugen
                //Aktuelles Datum 
                DateTime tmpDate = DateTime.Now;
                //Eingegebenes Datum
                DateTime tmpAkt = Convert.ToDateTime(dateTimePickerAustrittsdatum.Text);
                //Wenn eingegebenes Datum Gleich oder grösser Aktuellem Datum ist dann 
                //Da Mitarbeiter nicht in der Vergangenheit gekündigt werden kann
                if (tmpAkt >= tmpDate)
                {
                    con.AustrittMitarbeiter(Convert.ToInt32(suche.FirstOrDefault().ID), tmpAkt);
                    MessageBox.Show("Austrittsdatum wurde gespeichert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Austrittsdatum muß Heute oder in der Zukunft sein!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                MessageBox.Show("Speichern nicht erfolgreich!");
            }
        }
        ListeMitarbeiter ErgebnisSuche = new ListeMitarbeiter();
        private void MitarbeiterBearbeiten_Load(object sender, EventArgs e)
        {
            try
            {
                MitarbeiterSuchen mitarbeitersuchen = new MitarbeiterSuchen();
                mitarbeitersuchen.Close();

                ErgebnisSuche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
                textBoxVorname.Text = ErgebnisSuche.FirstOrDefault().Vorname;
                textBoxNachname.Text = ErgebnisSuche.FirstOrDefault().Nachname;
                textBoxEintrittsdatum.Text = ErgebnisSuche.FirstOrDefault().EintrittsDatum.ToShortDateString();
                TxtPersonalnummer.Text = ErgebnisSuche.FirstOrDefault().Personalnummer;
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
        }
    }
}
