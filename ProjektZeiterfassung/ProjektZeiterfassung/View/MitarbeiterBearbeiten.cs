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
    public partial class MitarbeiterBearbeiten : Form
    {
        
        private string _SqlString = "SELECT [Vorname] AS Vorname, [Nachname] AS Nachname, [EintrittsDatum] AS Eintrittsdatum " +
                                    "FROM [ZEIT2017].[dbo].[Mitarbeiter] JOIN [ZEIT2017].[dbo].[EintrittAustritt] " +
                                    "ON [dbo].[Mitarbeiter].ID = FK_Mitarbeiter " +
                                    "WHERE ([dbo].[Mitarbeiter].Vorname like '%Hans%' " +
                                    "OR [dbo].[Mitarbeiter].Nachname like '%Moser%' " +
                                    "OR [dbo].[EintrittAustritt].Personalnummer like '%1030%')";
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
            dateTimePickerAustrittsdatum.Format = DateTimePickerFormat.Custom;
            dateTimePickerAustrittsdatum.CustomFormat = " ";
        }

        /// <summary>
        /// Sucht in der Datenbank an Hand der Personalnummer, Vorname oder Nachname nach den Mitarbeiterdaten
        /// </summary>
        private void BtnSuchen_Click(object sender, EventArgs e)
        {


            //if (!string.IsNullOrEmpty(textBoxVorname.Text))
            //{
            //    SuchVariable = "Vorname = " + textBoxVorname.Text;
            //}
            //if (!string.IsNullOrEmpty(textBoxNachname.Text))
            //{
            //    SuchVariable = "Nachname = " + textBoxNachname.Text;
            //}
            //if (!string.IsNullOrEmpty(TxtPersonalnummer.Text))
            //{
            //    SuchVariable = "Personalnummer = " + TxtPersonalnummer.Text;
            //}


            SqlDataReader reader;
            Datenbankverbindung con = new Datenbankverbindung();
            using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            {
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    int i = 1;
                    Befehl.CommandText = this._SqlString + textBoxVorname.Text + "%' OR [dbo].[Mitarbeiter].Nachname like '%" + textBoxNachname.Text + "%' OR [dbo].[EintrittAustritt].Personalnummer like '%" + TxtPersonalnummer.Text + "%')";
                    reader = Befehl.ExecuteReader();
                    while (reader.Read())
                    {
                        string Vorname = reader["Vorname"].ToString();
                        string Nachname = reader["Nachname"].ToString();
                        DateTime Eintrittsdatum = Convert.ToDateTime( reader["Eintrittsdatum"].ToString());

                        textBoxVorname.Text = Vorname;
                        textBoxNachname.Text = Nachname;
                        //textBoxEintrittsdatum.Text = Eintrittsdatum.ToShortDateString();
                        i++;
                    }
                    textBoxEintrittsdatum.Text = i.ToString();
                }
                reader.Close();
                Connection.Close();
            }
        }
    }
}
