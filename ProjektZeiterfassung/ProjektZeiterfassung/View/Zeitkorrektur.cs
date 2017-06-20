using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Klassenbibliothek einbinden
using DatabaseConnections;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Fenster zum korrigieren der Stempelzeiten
    /// </summary>
    public partial class Zeitkorrektur : Form
    {
        /// <summary>
        /// Fenster Zeitkorrektur wird initalisiert
        /// </summary>
        public Zeitkorrektur()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variable für die aktuelle Personalnummer
        /// </summary>
        public string PersonalnummerBearbeiten { get; set; } 
        /// <summary>
        /// Nach den Mitarbeiterdaten in der Datenbank suchen und im Textfeld Vor- und Nachname anzeigen
        /// </summary>
        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            int Personalnummerint;
            bool parsed = Int32.TryParse(TxtPersonalnummer.Text, out Personalnummerint);

            if (Personalnummerint == 1)
            {
                TxtBenutzerdaten.Text = "DbVorname + DbNachname";
            }
            else
            {
                MessageBox.Show("Personalnummer wurde nicht gefunden!");
            }
        }

        DbConnections con = new DbConnections();
        ListeMitarbeiter ErgebnisSuche = new ListeMitarbeiter();

        /// <summary>
        /// Lädt das Fenster Zeitkorrektur mit der gewählten Personalnummer
        /// </summary>
        private void Zeitkorrektur_Load(object sender, EventArgs e)
        {
            //ErgebnisSuche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
            //TxtPersonalnummer.Text = ErgebnisSuche.FirstOrDefault().Personalnummer;
            //TxtBenutzerdaten.Text = string.Format("{0} {1}", ErgebnisSuche.FirstOrDefault().Vorname, ErgebnisSuche.FirstOrDefault().Nachname);

            DataViewUpdater();

            // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.Zeittypen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.zeittypenTableAdapter.Fill(this.zEIT2017DataSet3.Zeittypen);
            //// TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet4.Mitarbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mitarbeiterTableAdapter.Fill(this.zEIT2017DataSet4.Mitarbeiter);
            try
            {
                // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.Stempelzeiten". Sie können sie bei Bedarf verschieben oder entfernen.
                this.stempelzeitenTableAdapter.Fill(this.zEIT2017DataSet3.Stempelzeiten);
                MitarbeiterSuchenZeitkorrektur mitarbeitersuchenzeitkorrektur = new MitarbeiterSuchenZeitkorrektur();
                mitarbeitersuchenzeitkorrektur.Close();
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
        }
        /// <summary>
        /// Bei Klick auf das Symbol werden die Daten in der Datenbank gespeichert
        /// </summary>
        private void stempelzeitenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stempelzeitenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zEIT2017DataSet3);
        }
        /// <summary>
        /// Event für Änderung des Wertes des DateTimePicker, wo das DataGridView aktualisiert wird
        /// </summary>
        private void dateTimePickerDatum_ValueChanged(object sender, EventArgs e)
        {
            DataViewUpdater();
        }
        /// <summary>
        /// Event für Änderung des Wertes des DateTimePicker, wo das DataGridView aktualisiert wird
        /// </summary>
        private void dateTimePickerDatumEnde_ValueChanged(object sender, EventArgs e)
        {
            DataViewUpdater();
        }
        /// <summary>
        /// Aktualisiert das DataGridView
        /// </summary>
        private void DataViewUpdater()
        {
            ErgebnisSuche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
            TxtPersonalnummer.Text = ErgebnisSuche.FirstOrDefault().Personalnummer;
            TxtBenutzerdaten.Text = string.Format("{0} {1}", ErgebnisSuche.FirstOrDefault().Vorname, ErgebnisSuche.FirstOrDefault().Nachname); 
            try
            {
                string DatumBeginn = dateTimePickerDatumBeginn.Value.Date.ToString("MM/dd/yyyy").Replace(".", "/");
                string DatumEnde = dateTimePickerDatumEnde.Value.AddDays(1).Date.ToString("MM/dd/yyyy").Replace(".", "/");
                int FKMitarbeiter = con.HoleFK_Mitarbeiter(TxtPersonalnummer.Text);

                DataView DV = new DataView(this.zEIT2017DataSet3.Stempelzeiten);
                DV.RowFilter = "Zeitpunkt > #" + DatumBeginn + "# And Zeitpunkt < #" + DatumEnde + "# And FK_Mitarbeiter = '" + FKMitarbeiter + "'";
                stempelzeitenDataGridView.DataSource = DV;
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
        }
    }
}
