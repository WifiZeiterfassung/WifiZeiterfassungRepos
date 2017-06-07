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
            dateTimePickerAustrittsdatum.Format = DateTimePickerFormat.Custom;
            dateTimePickerAustrittsdatum.CustomFormat = " ";
        }

        /// <summary>
        /// Sucht in der Datenbank an Hand der Personalnummer, Vorname oder Nachname nach den Mitarbeiterdaten
        /// </summary>
        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            Datenbankverbindung con = new Datenbankverbindung();
            using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            {
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    int i = 0;
                    string Vorname = null;
                    string Nachname = null;
                    //Befehl.CommandText = this._SqlString + textBoxVorname.Text + "%' OR [dbo].[Mitarbeiter].Nachname like '%" + textBoxNachname.Text + "%' OR [dbo].[EintrittAustritt].Personalnummer like '%" + TxtPersonalnummer.Text + "%')";
                    Befehl.CommandText = this._SqlString;
                    reader = Befehl.ExecuteReader();
                    while (reader.Read())
                    {
                        Vorname = reader["Vorname"].ToString();
                        Nachname = reader["Nachname"].ToString();
                        DateTime Eintrittsdatum = Convert.ToDateTime( reader["Eintrittsdatum"].ToString());
                        //textBoxEintrittsdatum.Text = Eintrittsdatum.ToShortDateString();
                        i++;
                    }
                    if (i <= 1)
                    {
                        textBoxVorname.Text = Vorname;
                        textBoxNachname.Text = Nachname;
                        textBoxEintrittsdatum.Text = i.ToString();
                    }
                    else
                    {
                        MessageBox.Show("faskaslöf");
                    }

                }
                reader.Close();
                Connection.Close();
            }
        }
    }
}
