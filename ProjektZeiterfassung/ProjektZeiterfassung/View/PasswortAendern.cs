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
            try
            {
                //© by Josef
                // Id des Benutzers aus Einstellungsdatei sprich Zwischenspeicher holen für Formübergreifende Daten 
                m.ID = Properties.Settings.Default.FKMitarbeiter;
                string PasswortDB = con.HolePasswort(m.ID);
                //prüfe ob auf Id ein Wert ungleich 0 steht
                if (m.ID != 0)
                {
                    string tmpAltesPasswort = string.Empty;
                    string tmpNeuesPasswort = string.Empty;
                    string tmpNeuesPasswort1 = string.Empty;

                    //Abfrage/Vergleich mit Eingabe Altes Passwort
                    //Klartextpasswort aus Hauptfenster übernehmen
                    //Prüfen ob Textboxen befüllt sind
                    if (!String.IsNullOrWhiteSpace(TxtAltesPasswort.Text) && !String.IsNullOrWhiteSpace(TxtNeuesPasswort.Text) && !String.IsNullOrWhiteSpace(TxtNeuesPasswort1.Text))
                    {
                        //Mappen der Textboxdaten auf lokale Variable
                        tmpAltesPasswort = TxtAltesPasswort.Text.Trim();
                        tmpNeuesPasswort = TxtNeuesPasswort.Text.Trim();
                        tmpNeuesPasswort1 = TxtNeuesPasswort1.Text.Trim();
                        //Prüfe ob gleiche Eingaben
                        if (tmpNeuesPasswort == tmpNeuesPasswort1)
                        {
                            errorProviderAltesPasswort.SetError(TxtAltesPasswort, "Die neuen Passwörter stimmen nicht überein!!");
                            //KlartextPasswort Hashen für Datenbank
                            m.Passwort = Helper.GetHash(tmpNeuesPasswort);
                            //Methode zum speichern der Daten in der Datenbank sprich Passwort des angemeldeten Benutzers
                            con.PasswortAendern(m.ID, m.Passwort);
                            //Meldung an Benutzer
                            TextBoxPasswort.Text = "Passwort erfolgreich geändert!";
                        }
                        else
                        {
                            TextBoxPasswort.Text = "Die neuen Passwörter stimmen nicht überein!";
                        }
                    }

                    else
                    {
                        TextBoxPasswort.Text = "Eingaben fehlen!";
                    }
                }
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
        }

        /// <summary>
        /// Speichert das neue Passwort in die Datenbank
        /// </summary>
        //private void BtnSpeichern_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //© by Josef
        //        // Id des Benutzers aus Einstellungsdatei sprich Zwischenspeicher holen für Formübergreifende Daten 
        //        m.ID = Properties.Settings.Default.FKMitarbeiter;
        //        //prüfe ob auf Id ein Wert ungleich 0 steht
        //        if (m.ID != 0)
        //        {
        //            //Um das Passwort zu ändern müssen erst die Wert in den Textboxen gegengeprüft werden
        //            //Lokale temporäre Hilfsvariablen anlegen
        //            string tmpAltesPasswort = string.Empty;
        //            string tmpHauptfensterPasswort = String.Empty;
        //            string tmpPasswortvergleich = String.Empty;
        //            string tmpNeuesPasswort = String.Empty;
        //            //Abfrage/Vergleich mit Eingabe Altes Passwort
        //            //Klartextpasswort aus Hauptfenster übernehmen
        //            tmpHauptfensterPasswort = Properties.Settings.Default.KlartextPasswort;
        //            //Prüfen ob Textboxen befüllt sind
        //            if (!String.IsNullOrWhiteSpace(TxtAltesPasswort.Text) && !String.IsNullOrWhiteSpace(TxtNeuesPasswort.Text) && !String.IsNullOrWhiteSpace(TxtNeuesPasswort1.Text))
        //            {
        //                //Mappen der Textboxdaten auf lokale Variable
        //                tmpAltesPasswort = TxtAltesPasswort.Text.Trim();
        //                //Prüfe ob gleiche Eingaben
        //                if (tmpAltesPasswort == tmpHauptfensterPasswort)
        //                {
        //                    //Mappen der Textboxdaten auf die lokale Hilfsvariablen
        //                    tmpNeuesPasswort = TxtNeuesPasswort.Text.Trim();
        //                    tmpPasswortvergleich = TxtNeuesPasswort1.Text.Trim();
        //                    //Prüfen ob Eingaben übereinstimmen
        //                    if (tmpNeuesPasswort == tmpPasswortvergleich)
        //                    {
        //                        //KlartextPasswort Hashen für Datenbank
        //                        m.Passwort = Helper.GetHash(tmpNeuesPasswort);
        //                        //Methode zum speichern der Daten in der Datenbank sprich Passwort des angemeldeten Benutzers
        //                        con.PasswortAendern(m.ID, m.Passwort);
        //                        //Meldung an Benutzer
        //                        TextBoxPasswort.Text = "Passwort erfolgreich geändert!";
        //                    }
        //                    else
        //                    {
        //                        TextBoxPasswort.Text = "Neues Passwort stimmt nicht mit Passwortvergleich überein!";
        //                    }
        //                }
        //                else
        //                {
        //                    TextBoxPasswort.Text = "Altes Passwort falsch!";
        //                }
        //            }
        //            else
        //            {
        //                TextBoxPasswort.Text = "Eingaben fehlen!";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Helper.LogError(ex.ToString());
        //    }
        //}
    }
}
