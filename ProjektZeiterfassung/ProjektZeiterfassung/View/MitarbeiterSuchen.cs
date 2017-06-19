using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Das Formular zum Suchen des Mitarbeiters für die Mitarbeiterbearbeitung
    /// </summary>
    public partial class MitarbeiterSuchen : Form
    {
        /// <summary>
        /// Initialisiert das Fenster für die Suche des Mitarbeiters für die Mitarbeiterbearbeitung
        /// </summary>
        public MitarbeiterSuchen()
        {
            InitializeComponent();
            textBoxSuche.Focus();
        }
        /// <summary>
        /// das Fenster für die Suche des Mitarbeiters für die Mitarbeiterbearbeitung wird geladen
        /// </summary>
        private void MitarbeiterSuchen_Load(object sender, EventArgs e)
        {
            try
            {
                // Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.View_1". Sie können sie bei Bedarf verschieben oder entfernen.
                this.view_1TableAdapter.Fill(this.zEIT2017DataSet3.View_1);
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                
            }
        }
        /// <summary>
        /// Dynamischer Filter für den Datagridview
        /// </summary>
        private void textBoxSuche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView DV = new DataView(this.zEIT2017DataSet3.View_1);
                DV.RowFilter = string.Format("Personalnummer + Vorname + Nachname LIKE '%{0}%'", textBoxSuche.Text);
                view_1DataGridView.DataSource = DV;
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
            }
        }
        /// <summary>
        /// Doppelklickevent um die Personalnummer an das Fenster MitarbeiterBearbeiten zu übergeben
        /// </summary>
        private void view_1DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Personalnummer = view_1DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            MitarbeiterBearbeiten mitarbeiterbearbeiten = new MitarbeiterBearbeiten();
            mitarbeiterbearbeiten.PersonalnummerBearbeiten = Personalnummer;
            mitarbeiterbearbeiten.Show();
            this.Close();
        }
    }
}
