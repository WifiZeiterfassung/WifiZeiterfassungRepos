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
    /// Das Formular zum Suchen des Mitarbeiters für die Zeitkorrektur
    /// </summary>
    public partial class MitarbeiterSuchenZeitkorrektur : Form
    {
        DbConnections con = new DbConnections();
        DataTable datatable = new DataTable();
        /// <summary>
        /// dsjfkljdkasjadskf
        /// </summary>
        DbConnections con = new DbConnections();
        DataTable datatable = new DataTable();
        /// <summary>
        /// Initialisiert das Fenster für die Suche des Mitarbeiters für die Zeitkorrektur
        /// </summary>
        public MitarbeiterSuchenZeitkorrektur()
        {
            InitializeComponent();
            textBoxSuche.Focus();
        }
        /// <summary>
        /// das Fenster für die Suche des Mitarbeiters für die Zeitkorrektur wird geladen
        /// </summary>
        private void MitarbeiterSuchen_Load(object sender, EventArgs e)
        {
            DataGridFüllen();
        }
        /// <summary>
        /// Dynamischer Filter für den Datagridview
        /// </summary>
        private void textBoxSuche_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(datatable);
            DV.RowFilter = string.Format("Personalnummer + Vorname + Nachname LIKE '%{0}%'", textBoxSuche.Text);
            view_1DataGridView.DataSource = DV;
        }
        /// <summary>
        /// Doppelklickevent um die Personalnummer an das Fenster Zeitkorrektur zu übergeben
        /// </summary>
        private void view_1DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Personalnummer = view_1DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Zeitkorrektur zeitkorrektur = new Zeitkorrektur();
            zeitkorrektur.PersonalnummerBearbeiten = Personalnummer;
            zeitkorrektur.Show();
            MessageBox.Show("dssfa");
            this.Close();
        }
        /// <summary>
        /// Ruft den DataTable für das DataGridView ab
        /// </summary>
        private void DataGridFüllen()
        {
            datatable = con.HoleMitarbeiterDaten();
            view_1BindingSource.DataSource = datatable;
        }
    }
}
