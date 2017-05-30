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
                                    "WHERE Personalnummer = ";

        public MitarbeiterBearbeiten()
        {
            InitializeComponent();
            dateTimePickerAustrittsdatum.Format = DateTimePickerFormat.Custom;
            dateTimePickerAustrittsdatum.CustomFormat = " ";
        }
        /// <summary>
        /// Sucht in der Datenbank an Hand der Personalnummer nach den Mitarbeiterdaten
        /// </summary>
        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            Datenbankverbindung con = new Datenbankverbindung();
            using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            {
                string ID = TxtPersonalnummer.Text;
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandText = this._SqlString + ID;
                    //Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = this._ID;
                    //Befehl.ExecuteNonQuery();
                    reader = Befehl.ExecuteReader();
                    while (reader.Read())
                    {
                        string Vorname = reader["Vorname"].ToString();
                        string Nachname = reader["Nachname"].ToString();
                        DateTime Eintrittsdatum = Convert.ToDateTime( reader["Eintrittsdatum"].ToString());

                        textBoxVorname.Text = Vorname;
                        textBoxNachname.Text = Nachname;
                        textBoxEintrittsdatum.Text = Eintrittsdatum.ToShortDateString();
                    }                    
                }
                reader.Close();
                Connection.Close();
            }
        }
    }
}
