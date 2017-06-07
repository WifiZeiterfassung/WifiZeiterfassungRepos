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
    public partial class PasswortAendern : Form
    {
        private string _SqlString = "SELECT[Passwort] AS Passwort FROM[ZEIT2017].[dbo].[Mitarbeiter] "+
                                    "JOIN[ZEIT2017].[dbo].[EintrittAustritt] " +
                                    "ON[ZEIT2017].[dbo].[EintrittAustritt].FK_Mitarbeiter = [ZEIT2017].[dbo].[Mitarbeiter].ID " +
                                    "WHERE Personalnummer = ";
        private string _Klartextpasswort;
        private byte[] _Passwort;
        /// <summary>
        /// Initialisiert das Fenster "PasswortAendern"
        /// </summary>
        public PasswortAendern()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Stellt die aktuell eingloggte Personalnummer zur Verfügung
        /// </summary>
        public string Personalnummer { get; internal set; }
        /// <summary>
        /// Speichert das neue Passwort in die Datenbank
        /// </summary>
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            Datenbankverbindung con = new Datenbankverbindung();
            using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            {
                Connection.Open();
                using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandText = this._SqlString + Personalnummer;
                    reader = Befehl.ExecuteReader();
                    while (reader.Read())
                    {
                        string DBAltesPasswort = reader["Passwort"].ToString();
                        if (TxtAltesPasswort.Text == DBAltesPasswort)
                        {
                            if (TxtNeuesPasswort.TextLength == 6 || TxtNeuesPasswort1.TextLength == 6)
                            {
                                if (TxtNeuesPasswort.Text == TxtNeuesPasswort1.Text)
                                {
                                    _Klartextpasswort = TxtAltesPasswort.Text;
                                    _Passwort = Model.Helper.GetHash(_Klartextpasswort);

                                    TextBoxPasswort.Text = this.Personalnummer;
                                }
                                else
                                {
                                    TextBoxPasswort.Text = "Die eingegebenen Passwörter sind nicht identisch. Bitte versuchen sie es erneut!";
                                }
                            }
                            else
                            {
                                TextBoxPasswort.Text = "Das Passwort muss genau 6 Zeichen haben!";
                            }
                        }
                        else
                        {
                            TextBoxPasswort.Text = "Das aktuelle Passwort ist nicht korrekt!";
                        }
                    }
                    reader.Close();
                    Connection.Close();
                }
            }
        }
    }
}
