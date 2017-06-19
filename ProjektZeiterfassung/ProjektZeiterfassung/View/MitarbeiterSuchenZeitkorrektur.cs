using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Das Formular zum Suchen des Mitarbeiters für die Zeitkorrektur
    /// </summary>
    public partial class MitarbeiterSuchenZeitkorrektur : Form
    {
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
            // Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.View_1". Sie können sie bei Bedarf verschieben oder entfernen.
            this.view_1TableAdapter.Fill(this.zEIT2017DataSet3.View_1);
        }
        /// <summary>
        /// Dynamischer Filter für den Datagridview
        /// </summary>
        private void textBoxSuche_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(this.zEIT2017DataSet3.View_1);
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
            this.Close();
        }
    }
}
