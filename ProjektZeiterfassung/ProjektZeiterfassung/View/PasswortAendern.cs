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
//Klassenbibliothek DatabaseConnection einbinden
using DatabaseConnections;
using DatabaseConnections.Model;


namespace ProjektZeiterfassung.View
{
    public partial class PasswortAendern : Form
    {
        //Instanzen erzeugen für Windows Form
        Mitarbeiter m = new Mitarbeiter();
        DbConnections con = new DbConnections();
        //**********************************
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
            //© by Josef
            // Id des Benutzers aus Einstellungsdatei sprich Zwischenspeicher holen für Formübergreifende Daten 
            m.ID = Properties.Settings.Default.FKMitarbeiter;
            //prüfe ob auf Id ein Wert ungleich 0 steht
            if(m.ID != 0)
            {
                //Um das Passwort zu ändern müssen erst die Wert in den Textboxen gegengeprüft werden
                //Lokale temporäre Hilfsvariablen anlegen
                string tmpAltesPasswort = string.Empty;
                string tmpHauptfensterPasswort = String.Empty;
                string tmpPasswortvergleich = String.Empty;
                string tmpNeuesPasswort = String.Empty;
                //Abfrage/Vergleich mit Eingabe Altes Passwort
                //Klartextpasswort aus Hauptfenster übernehmen
                tmpHauptfensterPasswort = Properties.Settings.Default.KlartextPasswort;
                //Prüfen ob Textboxen befüllt sind
                if (!String.IsNullOrWhiteSpace(TxtAltesPasswort.Text)&&!String.IsNullOrWhiteSpace(TxtNeuesPasswort.Text)&&!String.IsNullOrWhiteSpace(TxtNeuesPasswort1.Text))
                {
                    //Mappen der Textboxdaten auf lokale Variable
                    tmpAltesPasswort = TxtAltesPasswort.Text.Trim();
                    //Prüfe ob gleiche Eingaben
                    if (tmpAltesPasswort == tmpHauptfensterPasswort)
                    {
                        //Mappen der Textboxdaten auf die lokale Hilfsvariablen
                        tmpNeuesPasswort = TxtNeuesPasswort.Text.Trim();
                        tmpPasswortvergleich = TxtNeuesPasswort1.Text.Trim();
                        //Prüfen ob Eingaben übereinstimmen
                        if(tmpNeuesPasswort == tmpPasswortvergleich)
                        {
                            //KlartextPasswort Hashen für Datenbank
                            m.Passwort = Helper.GetHash(tmpNeuesPasswort);
                            //Methode zum speichern der Daten in der Datenbank sprich Passwort des angemeldeten Benutzers
                            con.PasswortAendern(m.ID, m.Passwort);
                            //Meldung an Benutzer
                            TextBoxPasswort.Text = "Passwort erfolgreich geändert!";
                        }
                        else
                        {
                            TextBoxPasswort.Text = "Neues Passwort stimmt nicht mit Passwortvergleich überein!";
                        }
                    }
                    else
                    {
                        TextBoxPasswort.Text = "Altes Passwort falsch!";
                    }
                }
                else
                {
                    TextBoxPasswort.Text = "Eingaben fehlen!";
                }                
            }
        // End of My ***********************************************************************************************************************    
        //    SqlDataReader reader;
        //    DbConnections con = new DbConnections();
        //    using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
        //    {
        //        Connection.Open();
        //        using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
        //        {
        //            Befehl.CommandText = this._SqlString + Personalnummer;
        //            reader = Befehl.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                string DBAltesPasswort = reader["Passwort"].ToString();
        //                if (TxtAltesPasswort.Text == DBAltesPasswort)
        //                {
        //                    if (TxtNeuesPasswort.TextLength == 6 || TxtNeuesPasswort1.TextLength == 6)
        //                    {
        //                        if (TxtNeuesPasswort.Text == TxtNeuesPasswort1.Text)
        //                        {
        //                            _Klartextpasswort = TxtAltesPasswort.Text;
        //                            _Passwort = Helper.GetHash(_Klartextpasswort);

        //                            TextBoxPasswort.Text = this.Personalnummer;
        //                        }
        //                        else
        //                        {
        //                            TextBoxPasswort.Text = "Die eingegebenen Passwörter sind nicht identisch. Bitte versuchen sie es erneut!";
        //                        }
        //                    }
        //                    else
        //                    {
        //                        TextBoxPasswort.Text = "Das Passwort muss genau 6 Zeichen haben!";
        //                    }
        //                }
        //                else
        //                {
        //                    TextBoxPasswort.Text = "Das aktuelle Passwort ist nicht korrekt!";
        //                }
        //            }
        //            reader.Close();
        //            Connection.Close();
        //        }
        //    }
        }
    }
}
