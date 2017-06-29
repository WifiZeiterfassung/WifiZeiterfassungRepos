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
//Hier wird die Klassenbibliothek DatabaseConnections eingebunden
//vorher im Projekt Zeiterfassung unter Verweise die neue DatabaseConnection.dll als Verweis einbinden
using DatabaseConnections;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Windowsfenster wo man Zeiten stempeln kann
    /// </summary>
    public partial class FormZeiterfassung : System.Windows.Forms.Form
    {
        //***************Von Josef Klassen von Klassenbibliothek instanzieren für alle Buttons klickevents******************
        Mitarbeiter m = new Mitarbeiter();
        EintrittAustritt ea = new EintrittAustritt();
        DbConnections con = new DbConnections();
        //Liste mit allen Werten des Mitarbeiters
        ListeMitarbeiter suche = new ListeMitarbeiter();
        //Liste mit Stempelzeit eines Mitarbeiters
        ListeStempelzeiten stList = new ListeStempelzeiten();

        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        //******************************************************************************************************************

        /// <summary>
        /// Initialisiert eine neue Instanz.
        /// </summary>
        public FormZeiterfassung()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lädt das Fenster für die Zeiterfasssung
        /// </summary>
        private void FormZeiterfassung_Load(object sender, EventArgs e)
        {
            this.Height = 255;
            cmbWeiterZeittypen.Enabled = false;
        }

        /// <summary>
        /// Öffnet das Fenster zum Ändern des Mitarbeiterpasswort
        /// </summary>
        private void BtnPasswortAendern_Click(object sender, EventArgs e)
        {
            ea.Personalnummer = TxtPersonalnummer.Text.Trim();
            m.KlartextPasswort = TxtPin.Text.Trim();
            m.Passwort = Helper.GetHash(m.KlartextPasswort);
            suche = con.MitarbeiterSuchen(m.Passwort, ea.Personalnummer);

            if (suche.Count > 0)
            {
                //Daten in den Einstellungen zwischenspeichern für neues Fenster
                Properties.Settings.Default.FKMitarbeiter = Convert.ToInt32(suche[0].ID);
                Properties.Settings.Default.KlartextPasswort = m.KlartextPasswort;
                PasswortAendern neuespasswort = new PasswortAendern();
                neuespasswort.ShowDialog();
            }
            else
            {
                TxtBenutzerdaten.Text = "Bitte erneut mit dem geänderten Passwort anmelden!";
            }

        }
        /// <summary>
        /// Öffnet das Fenster zum Bearbeiten der Mitarbeiterdaten
        /// </summary>
        private void BtnBenutzerUpdate_Click(object sender, EventArgs e)
        {
            MitarbeiterAnlegen mitarbeiteranlegen = new MitarbeiterAnlegen();
            mitarbeiteranlegen.Show();
        }
        /// <summary>
        /// Öffnet das Fenster zum Anlegen neuer Mitarbeiter
        /// </summary>
        private void BtnBenutzerNeu_Click(object sender, EventArgs e)
        {
            MitarbeiterSuchen mitarbeitersuchen = new MitarbeiterSuchen();
            mitarbeitersuchen.Show();
        }
        /// <summary>
        /// Öffnet das Fenster für die Zeitkorrektur
        /// </summary>
        private void BtnZeitkorrektur_Click(object sender, EventArgs e)
        {
            MitarbeiterSuchenZeitkorrektur mitarbeitersuchenzeitkorrektur = new MitarbeiterSuchenZeitkorrektur();
            mitarbeitersuchenzeitkorrektur.Show();
        }
        /// <summary>
        /// Öffnet das Fenster für die Bearbeitung der Zeittypen
        /// </summary>
        private void BtnZeittypenBearbeiten_Click(object sender, EventArgs e)
        {
            ZeittypenBearbeiten zeittypenbearbeiten = new ZeittypenBearbeiten();
            zeittypenbearbeiten.Show();
        }
        /// <summary>
        ///Überprüft Personalnummer und PIN und schaltet dann die Schaltflächen frei.
        /// </summary>
        private void BtnAnmelden_Click(object sender, EventArgs e)
        {
            //von Josef mit Klassenbibliothek **********************************************************************************
            try
            {
                if (!String.IsNullOrWhiteSpace(TxtPersonalnummer.Text.Trim()) && !String.IsNullOrWhiteSpace(TxtPin.Text.Trim()))
                {
                    ea.Personalnummer = TxtPersonalnummer.Text.Trim();
                    m.KlartextPasswort = TxtPin.Text.Trim();
                    m.Passwort = Helper.GetHash(m.KlartextPasswort);
                    suche = con.MitarbeiterSuchen(m.Passwort, ea.Personalnummer);
                    //Absicherung wenn 0 bei Id daherkommt
                    if (suche.Count > 0 && suche.FirstOrDefault().EintrittsDatum <= DateTime.Now)
                    {
                        stList = con.StempelzeitMitarbeiter(Convert.ToInt32(suche.FirstOrDefault().ID));
                    }
                    //Fälle für den Benutzer mit Admin rechten
                    //Fallentscheidung wäre vielleicht besser
                    if (suche.Count > 0 && suche.FirstOrDefault().IsAdmin && suche.FirstOrDefault().EintrittsDatum <= DateTime.Now)
                    {
                        TxtBenutzerdaten.Text = String.Format("Hallo Administrator {1} {2}", suche[0].ID, suche[0].Vorname, suche[0].Nachname);
                        if (stList.Count > 0 && stList[0].ZeitTyp == 1)
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = false;
                            BtnPausenbeginn.Enabled = true;
                            BtnArbeitsende.Enabled = true;
                            BtnPausenende.Enabled = false;
                            this.Height = 360;
                        }
                        else if (stList.Count > 0 && stList[0].ZeitTyp == 3)
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = false;
                            BtnPausenbeginn.Enabled = false;
                            BtnArbeitsende.Enabled = false;
                            BtnPausenende.Enabled = true;
                            this.Height = 360;
                        }
                        else if (stList.Count > 0 && stList[0].ZeitTyp == 4)
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = false;
                            BtnPausenbeginn.Enabled = true;
                            BtnArbeitsende.Enabled = true;
                            BtnPausenende.Enabled = false;
                            this.Height = 360;
                        }
                        else
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = true;
                            BtnPausenbeginn.Enabled = false;
                            BtnArbeitsende.Enabled = false;
                            BtnPausenende.Enabled = false;
                            this.Height = 360;
                        }
                        cmbWeiterZeittypen.Enabled = true;
                        breiteAnpassen(cmbWeiterZeittypen);
                        GetData(con._GetZeittypen);
                    }
                    //Fälle für den Benutzer ohne Admin rechte
                    else if (suche.Count > 0 && suche.FirstOrDefault().EintrittsDatum <= DateTime.Now)
                    {
                        TxtBenutzerdaten.Text = String.Format("Hallo {1} {2}", suche[0].ID, suche[0].Vorname, suche[0].Nachname);
                        if (stList.Count > 0 && stList[0].ZeitTyp == 1)
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = false;
                            BtnPausenbeginn.Enabled = true;
                            BtnArbeitsende.Enabled = true;
                            BtnPausenende.Enabled = false;
                            this.Height = 255;
                        }
                        else if (stList.Count > 0 && stList[0].ZeitTyp == 3)
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = false;
                            BtnPausenbeginn.Enabled = false;
                            BtnArbeitsende.Enabled = false;
                            BtnPausenende.Enabled = true;
                            this.Height = 255;
                        }
                        else if (stList.Count > 0 && stList[0].ZeitTyp == 4)
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = false;
                            BtnPausenbeginn.Enabled = true;
                            BtnArbeitsende.Enabled = true;
                            BtnPausenende.Enabled = false;
                            this.Height = 255;
                        }
                        else
                        {
                            BtnPasswortAendern.Enabled = true;
                            BtnArbeitsbeginn.Enabled = true;
                            BtnPausenbeginn.Enabled = false;
                            BtnArbeitsende.Enabled = false;
                            BtnPausenende.Enabled = false;
                            this.Height = 255;
                        }
                        cmbWeiterZeittypen.Enabled = true;
                        breiteAnpassen(cmbWeiterZeittypen);
                        GetData(con._GetZeittypen);
                    }
                    else
                    {
                        TxtBenutzerdaten.Text = "Eingaben falsch oder nicht vorhanden oder Benutzer noch nicht aktiv!";
                    }
                }
                else
                {
                    TxtBenutzerdaten.Text = "Eingabe Personalnummer oder Passwort fehlen!";
                }
                //leert die Liste mit den Stempelzeiten Mitarbeiter
                stList = null;
            }
            catch (Exception ex)
            {                
                Helper.LogError(ex.ToString());
                MessageBox.Show("Fehler mit der Datenbankverbindung");
            }
            //************************Josef Ende * **********************************************************************************
            //this.PersonalnummerPruefen();
            //this.ButtonFreischalten();
        }
        /// <summary>
        /// Event Speichert den Arbeitsbeginn in die Datenbank in die Tabelle Stempelzeiten
        /// </summary>
        private void BtnArbeitsbeginn_Click(object sender, EventArgs e)
        {
            try
            {
                if (suche.Count > 0)
                {

                    con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 1);
                    TxtBenutzerdaten.Text = String.Format("Arbeitsbeginn {0} gespeichert!", DateTime.Now);
                    BtnArbeitsbeginn.Enabled = false;
                    BtnArbeitsende.Enabled = true;
                    BtnPausenbeginn.Enabled = true;
                    BtnPausenende.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
                TxtBenutzerdaten.Text = "Arbeitsbeginn konnte nicht gespeichert werden!";
            }
        }
        /// <summary>
        /// Event das den Pausebeginn in die Datenbank schreibt
        /// </summary>
        private void BtnPausenbeginn_Click(object sender, EventArgs e)
        {
            try
            {
                if (suche.Count > 0)
                {
                    con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 3);
                    TxtBenutzerdaten.Text = String.Format("Pausebeginn {0} gespeichert!", DateTime.Now);
                    BtnArbeitsbeginn.Enabled = false;
                    BtnArbeitsende.Enabled = false;
                    BtnPausenbeginn.Enabled = false;
                    BtnPausenende.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
                TxtBenutzerdaten.Text = "Pausebeginn konnte nicht gespeichert werden!";
            }
        }
        /// <summary>
        /// Speichert das PauseEnde in die Datenbank
        /// </summary>
        private void BtnPausenende_Click(object sender, EventArgs e)
        {
            try
            {
                if (suche.Count > 0)
                {
                    con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 4);
                    TxtBenutzerdaten.Text = String.Format("Pauseende {0} gespeichert!", DateTime.Now);
                    BtnPausenende.Enabled = false;
                    BtnPausenbeginn.Enabled = true;
                    BtnArbeitsende.Enabled = true;
                    BtnArbeitsbeginn.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                TxtBenutzerdaten.Text = "Pauseende konnte nicht gespeichert werden!";
            }
        }
        /// <summary>
        /// Speichert das Arbeitsende in die Datenbank
        /// </summary>
        private void BtnArbeitsende_Click(object sender, EventArgs e)
        {
            try
            {
                if (suche.Count > 0)
                {
                    con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, 2);
                    TxtBenutzerdaten.Text = String.Format("Pausebeginn {0} gespeichert!", DateTime.Now);
                    BtnArbeitsende.Enabled = false;
                    BtnArbeitsbeginn.Enabled = true;
                    BtnPausenbeginn.Enabled = false;
                    BtnPausenende.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                TxtBenutzerdaten.Text = "Arbeitsende konnte nicht gespeichert werden!";
            }
        }


        /// <summary>
        /// Ruft die Daten aus der Datenbank ab
        /// </summary>
        /// <param name="selectCommand"></param>
        private void GetData(string selectCommand)
        {
            String connectionString = con.DbConnection;
            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                cmbWeiterZeittypen.DataSource = table.DefaultView;
                cmbWeiterZeittypen.DisplayMember = "Bezeichnung";
            }
            else
            {
                cmbWeiterZeittypen.Enabled = false;
            }
        }

        private void breiteAnpassen (ComboBox cmbWeiterZeittypen)
        {
            Graphics g = cmbWeiterZeittypen.CreateGraphics();
            float breite, maxBreite = 0F;
            foreach (Object element in cmbWeiterZeittypen.Items)
            {
                breite = g.MeasureString(element.ToString(), cmbWeiterZeittypen.Font).Width;
                if (breite > maxBreite) maxBreite = breite;
            }
            cmbWeiterZeittypen.Width = (int)maxBreite + 20;
        }

        /// <summary>
        /// Wird ein neuer Wert im Drop-Down ausgewählt,
        /// wird der neue Zeiteintrag gespeichert.
        /// </summary>
        private void cmbWeiterZeittypen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Zeittyp = cmbWeiterZeittypen.Text;
            //Ruft die ID der Zeittype anhand der Bezeichnung ab
            int IdZeittyp = con.GetZeittypenByBezeichnung(Zeittyp);

            if (!String.IsNullOrWhiteSpace(Zeittyp.Trim()))
            {
                con.ZeitSpeichern(Convert.ToInt32(suche[0].ID), DateTime.Now, IdZeittyp);
                TxtBenutzerdaten.Text = String.Format(Zeittyp + " {0} gespeichert!", DateTime.Now);
            }

        }


        /// <summary>
        /// Überprüft Personalnummer und PIN
        /// </summary>
        //public void PersonalnummerPruefen()
        //{
        //    int Personalnummerint;
        //    int Pinint;
        //    bool parsed = Int32.TryParse(TxtPersonalnummer.Text, out Personalnummerint);
        //    bool parsed2 = Int32.TryParse(TxtPin.Text, out Pinint);
        //    var Datum = System.DateTime.Now.ToString();


        //    SqlDataReader reader;
        //    Datenbankverbindung con = new Datenbankverbindung();
        //    using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
        //    {
        //        string ID = TxtPersonalnummer.Text;
        //        Connection.Open();
        //        using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
        //        {
        //            Befehl.CommandText = this._SqlString + ID;
        //            reader = Befehl.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                string Vorname = reader["Vorname"].ToString();
        //                string Nachname = reader["Nachname"].ToString();
        //                bool IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
        //                string Personalnummer = reader["Personalnummer"].ToString();
        //                string Begrüßung = "Guten Tag " + Vorname + " " + Nachname + " es ist der " + Datum;


        //                if (Personalnummer == TxtPersonalnummer.Text)
        //                {
        //                    if (Pinint == 1)
        //                    {
        //                        BtnPasswortAendern.Enabled = true;
        //                        TxtBenutzerdaten.Text = Begrüßung;

        //                        if (IsAdmin)
        //                        {
        //                            this.Height = 360;
        //                            BtnPasswortAendern.Enabled = true;
        //                        }
        //                        else
        //                        {
        //                            this.Height = 255;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Das Passwort ist falsch!");
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Personalnummer wurde nicht gefunden!");
        //                }
        //            }
        //        }
        //        reader.Close();
        //        Connection.Close();
        //    }
        //}

        /// <summary>
        /// Überprüft den letzten Datenbankeintrag 
        /// und Schaltet die zulässigen Button frei.
        /// </summary>
        //public void ButtonFreischalten()
        //{
        //    //SELECT[ZeitTyp]
        //    //FROM[ZEIT2017V4].[dbo].[Stempelzeiten]
        //    //WHERE[FK_Mitarbeiter] = 1
        //    //ORDER BY[Zeitpunkt] ASC

        //    //var Typ = [ZeitTyp].ToString();

        //    //Stempeltypen:
        //    //Arbeitsbeginn = 1
        //    //Arbeitsende = 2
        //    //Pausenbeginn = 3
        //    //Pausenende = 4
        //    int Typ = 3;

        //    switch (Typ)
        //    {
        //        case 1:
        //            BtnPausenbeginn.Enabled = true;
        //            BtnArbeitsende.Enabled = true;
        //            break;
        //        case 2:
        //            BtnArbeitsbeginn.Enabled = true;
        //            break;
        //        case 3:
        //            BtnPausenende.Enabled = true;
        //            break;
        //        case 4:
        //            BtnPausenbeginn.Enabled = true;
        //            BtnArbeitsende.Enabled = true;
        //            break;
        //        default:
        //            MessageBox.Show("Eintrag fehlt");
        //            break;
        //    }
        //}

        /// <summary>
        /// Überprüft den letzten Datenbankeintrag 
        /// und Schaltet die zulässigen Button frei.
        /// </summary>
        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.zeittypenTableAdapter.FillBy(this.zEIT2017DataSet3.Zeittypen);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
        /// <summary>
        /// Überprüft den letzten Datenbankeintrag 
        /// und Schaltet die zulässigen Button frei.
        /// </summary>
        //private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.zeittypenTableAdapter.FillBy1(this.zEIT2017DataSet3.Zeittypen);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

    }
}
