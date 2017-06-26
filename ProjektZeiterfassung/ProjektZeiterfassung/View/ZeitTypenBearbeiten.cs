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
        DbConnections con = new DbConnections();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        /// <summary>
        /// Initalisiert das Fenster "Zeittypen bearbeiten"
        /// </summary>
        public ZeittypenBearbeiten()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lädt das Fenster ZeittypenBearbeiten
        /// </summary>
        private void ZeittypenBearbeiten_Load(object sender, EventArgs e)
        {
            try
            {
                zeittypenDataGridView.DataSource = bindingSource1;
                GetData(con._GetModus);
                ToolTips();
            }
            catch (Exception ex)
            {
                Helper.LogError(ex.ToString());                
            }
        }
        /// <summary>
        /// Legt die Tooltips und den Modus für die automtische Spalten-Breiten-Anpassung fest.
        /// </summary>
        private void ToolTips()
        {
            DataGridViewColumn firstColumn = zeittypenDataGridView.Columns[0];
            DataGridViewColumn secondColumn = zeittypenDataGridView.Columns[1];
            DataGridViewColumn thirdColumn = zeittypenDataGridView.Columns[2];
            DataGridViewColumn fourthColumn = zeittypenDataGridView.Columns[3];
            DataGridViewColumn fifthColumn = zeittypenDataGridView.Columns[4];
            firstColumn.ToolTipText = "Fortlaufende Nummer.";
            secondColumn.ToolTipText = "Benennung des Zeittyp (max. 50 Zeichen).";
            thirdColumn.ToolTipText = "Gibt an ob es der Anfang oder Ende des Zeittypes ist (A oder E).";
            fourthColumn.ToolTipText = "Gibt die Abhängigkeit zu seinem Gegenstück an (z.B.: Typ 2 zu Typ 1).";
            fifthColumn.ToolTipText = "Ein \"Anfangs-Zeittypen\" muss immer ein Hauptsatz sein." ;
            firstColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            secondColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thirdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fourthColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fifthColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }



        /// <summary>
        /// Ruft die Daten aus der Datenbank ab
        /// </summary>
        /// <param name="selectCommand"></param>
        private void GetData(string selectCommand)
        {
                String connectionString = con.DbConnection;

                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
        }
        /// <summary>
        /// Speichert die Änderungen in der Datenbank
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
