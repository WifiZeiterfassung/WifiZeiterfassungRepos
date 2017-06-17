using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//Klassenbibliothek einbinden
using DatabaseConnections;
using DatabaseConnections.Model;

namespace ProjektZeiterfassung.View
{
    /// <summary>
    /// Methode um die Datenbankeinträge für die Zeittypen zu bearbeiten
    /// </summary>
    public partial class ZeittypenBearbeiten : Form
    {
        /// <summary>
        /// Initalisiert das Fenster "Zeittypen bearbeiten"
        /// </summary>
        public ZeittypenBearbeiten()
        {
            InitializeComponent();
        }
        private void ZeittypenBearbeiten_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.Zeittypen". Sie können sie bei Bedarf verschieben oder entfernen.
                this.zeittypenTableAdapter.Fill(this.zEIT2017DataSet3.Zeittypen);
            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                
            }
        }
        
        //private void fillComboBox()
        //{

        //    datatable = con.GetModus();
        //    DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
        //    combo.HeaderText = "Modus";
        //    combo.Name = "combo";
        //    //combo.DataSource = datatable;

        //    ArrayList row = new ArrayList();
        //    foreach (DataRow r in datatable.Rows)
        //    {
        //        combo.Items.Add(r["Modus"].ToString());
        //    }

        //    //ADD THE COMBO TO DATAGRIDVIEW
        //    zeittypenDataGridView.Columns.Add(combo);
        //    combo.DefaultCellStyle.NullValue = datatable.Rows[0][0].ToString();
        //    combo.DefaultCellStyle.DataSourceNullValue = datatable.Rows[0][0].ToString();
        //}
    }
}
