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
    public partial class ZeittypenBearbeiten : Form
    {
        DataTable datatable;
        DbConnections con = new DbConnections();
        ListeZeittypen stList = new ListeZeittypen();
        public ZeittypenBearbeiten()
        {
            InitializeComponent();
        }
        private void ZeittypenBearbeiten_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.Zeittypen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.zeittypenTableAdapter.Fill(this.zEIT2017DataSet3.Zeittypen);
            fillComboBox();
            try
            {

            }
            catch (Exception ex)
            {

                Helper.LogError(ex.ToString());
                
            }
        }
        //private void fillComboBox()
        //{
        //    DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

        //    combo.HeaderText = "Modus";
        //    combo.Name = "Modus";
        //    combo.Items.Add("A");
        //    combo.Items.Add("E");
        //    combo.DisplayMember = "A";
        //    combo.ValueMember = "E";

        //    zeittypenDataGridView.Columns.Add(combo);
        //}

        private void fillComboBox()
        {

            datatable = con.GetModus();
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Modus";
            combo.Name = "combo";
            //combo.DataSource = datatable;


            ArrayList row = new ArrayList();

            foreach (DataRow r in datatable.Rows)
            {
                //    row.Add(r["Modus"].ToString());
                combo.Items.Add(r["Modus"].ToString());
                //MessageBox.Show(r["Modus"].ToString());
            }
            ////ADD TO COMBO
            //combo.Items.AddRange(row.ToArray());



            //ADD THE COMBO TO DATAGRIDVIEW
            zeittypenDataGridView.Columns.Add(combo);
            combo.DefaultCellStyle.NullValue = datatable.Rows[0][0].ToString();
            combo.DefaultCellStyle.DataSourceNullValue = datatable.Rows[0][0].ToString();
        }
    }
}
