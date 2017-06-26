using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        ListeMitarbeiter ErgebnisSuche = new ListeMitarbeiter();
        DbConnections con = new DbConnections();
        DataTable datatable = new DataTable();

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
        /// Lädt das Fenster Zeitkorrektur mit der gewählten Personalnummer
        /// </summary>
        private void Zeitkorrektur_Load(object sender, EventArgs e)
        {
                DataViewUpdater();
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

                String connectionString = con.DbConnection;
                dataAdapter = new SqlDataAdapter(con.GetStempelzeiten, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                datatable = con.Stempelzeiten();
                bindingSource1.DataSource = datatable;

                DataView DV = new DataView(datatable);
                DV.RowFilter = "Zeitpunkt > #" + DatumBeginn + "# And Zeitpunkt < #" + DatumEnde + "# And FK_Mitarbeiter = '" + FKMitarbeiter + "'";
                dataGridView1.DataSource = DV;
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
        }
        /// <summary>
        /// Bei Klick auf das Symbol werden die Daten in der Datenbank gespeichert
        /// </summary>
        private void stempelzeitenBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bindingSource1.EndEdit();
                dataAdapter.Update((DataTable)bindingSource1.DataSource);
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
            }
}
    }
}
