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
using System.Threading;
//Klassenbibliothek DatabaseConnection einbinden
using DatabaseConnections;
using DatabaseConnections.Model;


namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Klasse für die Form in der der User das passwort ändern kann
    /// </summary>
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
        /// Speichert das neue Passwort in die Datenbank
        /// </summary>
        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Id des Benutzers aus Einstellungsdatei sprich Zwischenspeicher holen für Formübergreifende Daten 
                m.ID = Properties.Settings.Default.FKMitarbeiter;
                string aktuellesPasswort = string.Empty;
                aktuellesPasswort= Properties.Settings.Default.KlartextPasswort;

                //prüfe ob auf Id ein Wert ungleich 0 steht
                if (m.ID != 0)
                {
                    string tmpAltesPasswort = string.Empty;
                    string tmpNeuesPasswort = string.Empty;
                    string tmpNeuesPasswort1 = string.Empty;
                    tmpAltesPasswort = TxtAltesPasswort.Text.Trim();
                    tmpNeuesPasswort = TxtNeuesPasswort.Text.Trim();
                    tmpNeuesPasswort1 = TxtNeuesPasswort1.Text.Trim();

                    //Prüfen ob alle Eingaben gemacht wurden
                    if (!String.IsNullOrWhiteSpace(TxtAltesPasswort.Text) && !String.IsNullOrWhiteSpace(TxtNeuesPasswort.Text) && !String.IsNullOrWhiteSpace(TxtNeuesPasswort1.Text))
                    {
                        //Prüfen ob das alte Passwort korrekt ist
                        if (tmpAltesPasswort == aktuellesPasswort)
                        {
                            //Prüfe ob die neuen Passwörter identisch sind
                            if (tmpNeuesPasswort == tmpNeuesPasswort1)
                            {
                                //KlartextPasswort Hashen für Datenbank
                                m.Passwort = Helper.GetHash(tmpNeuesPasswort);
                                //Methode zum speichern der Daten in der Datenbank sprich Passwort des angemeldeten Benutzers
                                con.PasswortAendern(m.ID, m.Passwort);
                                //Meldung an Benutzer
                                TextBoxPasswort.Text = "Passwort erfolgreich geändert!";
                                //Die Form refreshen, da sonst der Text in der Textbox nicht angezeigt wird
                                this.Refresh();                                
                                //2 Sekunden warten und dann das Fenster schließen.
                                Thread.Sleep(1000);                                                                
                                this.Close();
                            }
                            else
                            {
                                errorProviderNeuesPasswort.SetError(TxtNeuesPasswort, "Die neuen Passwörter stimmen nicht überein!");
                                //errorProviderNeuesPasswort1.SetError(TxtNeuesPasswort1, "Die neuen Passwörter stimmen nicht überein!");
                                TextBoxPasswort.Text = "Die neuen Passwörter stimmen nicht überein!";
                            }
                        }
                        else
                        {
                            errorProviderAltesPasswort.SetError(TxtAltesPasswort, "Das alte Passwort ist nicht korrekt!");
                            TextBoxPasswort.Text = "Das alte Passwort ist nicht korrekt!";
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
