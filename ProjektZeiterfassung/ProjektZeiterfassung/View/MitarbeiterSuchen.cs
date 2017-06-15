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
    public partial class MitarbeiterSuchen : Form
    {
        DataTable datatable;
        public MitarbeiterSuchen()
        {
            InitializeComponent();
            textBoxSuche.Focus();
        }

        private void MitarbeiterSuchen_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.View_1". Sie können sie bei Bedarf verschieben oder entfernen.
                this.view_1TableAdapter.Fill(this.zEIT2017DataSet3.View_1);
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                
            }
        }

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

        private void view_1DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Personalnummer;
                Personalnummer = view_1DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                MitarbeiterBearbeiten mitarbeiterbearbeiten = new MitarbeiterBearbeiten();
                mitarbeiterbearbeiten.PersonalnummerBearbeiten = Personalnummer;
                mitarbeiterbearbeiten.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());
            }
        }
    }
}
