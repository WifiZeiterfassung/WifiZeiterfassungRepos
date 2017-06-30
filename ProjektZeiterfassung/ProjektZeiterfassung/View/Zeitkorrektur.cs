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
        //instanzieren der zu verwendenden Klassen
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private ListeMitarbeiter ErgebnisSuche = new ListeMitarbeiter();
        private ListeZeittypen TypenListe = new ListeZeittypen();
        private DbConnections con = new DbConnections();
        private DataTable datatable = new DataTable();

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
            //Aktualisierung des Datagrids
            DataViewUpdater();
            TypenListe = con.GetAlleZeittypen();
            List<string> MyList = new List<string>();
            //Headertext in der ListBox
            MyList.Add("ZeitTyp" + "   " + "Bezeichnung");
            //leerzeile
            MyList.Add("------------------------------------------------------");
            foreach (var item in TypenListe)
            {                
                MyList.Add("     " + item.ID.ToString() + "\t" + item.Bezeichnung);
            }
            listBoxZeitTypen.DataSource = MyList;



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
            //Ermitteln der Daten des gewünschen Mitarbeiters und schreib diese in eine Liste für die Verarbeitung
            this.ErgebnisSuche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
            //holt aus der aktuellen Liste die Personalnummer und schreib diese in die textbox zur Ansicht
            TxtPersonalnummer.Text = ErgebnisSuche.FirstOrDefault().Personalnummer;
            //holt den Vor und Nachnamen aus der liste und zeigt ihn in der Meldungstextbox an
            TxtBenutzerdaten.Text = string.Format("{0} {1}", ErgebnisSuche.FirstOrDefault().Vorname, ErgebnisSuche.FirstOrDefault().Nachname);
            try
            {
                //Datumsbeginn DatTime objekt aus dem Datetimepicker wird im richtigen Format übergeben
                string DatumBeginn = dateTimePickerDatumBeginn.Value.Date.ToString("MM/dd/yyyy").Replace(".", "/");
                //Datumsende
                string DatumEnde = dateTimePickerDatumEnde.Value.AddDays(1).Date.ToString("MM/dd/yyyy").Replace(".", "/");
                //Mitarbeiter Id wird geholt
                int FKMitarbeiter = con.HoleFK_Mitarbeiter(TxtPersonalnummer.Text);
                //sql-Connection string wird geholt 
                string connectionString = con.DbConnection;
                //connection und Sql Command wird übergeben
                dataAdapter = new SqlDataAdapter(con.GetStempelzeiten, connectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                datatable = con.Stempelzeiten();
                bindingSource1.DataSource = datatable;

                DataView DV = new DataView(datatable);
                DV.RowFilter = "Zeitpunkt > #" + DatumBeginn + "# And Zeitpunkt < #" + DatumEnde + "# And FK_Mitarbeiter = '" + FKMitarbeiter + "'";
                dataGridView1.DataSource = DV;

                dataGridView1.Columns[2].Width = 56;



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
            DataGridViewColumn firstColumn = dataGridView1.Columns[0];
            DataGridViewColumn secondColumn = dataGridView1.Columns[1];
            DataGridViewColumn thirdColumn = dataGridView1.Columns[2];

            firstColumn.ToolTipText = "Fortlaufende Nummer.";
            secondColumn.ToolTipText = "Benennung des Zeittyp (max. 50 Zeichen).";
            thirdColumn.ToolTipText = "Gibt an ob es der Anfang oder Ende des Zeittypes ist (A oder E).";

            firstColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            secondColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thirdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
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
        /// <summary>
        /// Methode welche vor dem speicher fragt ob die Änderungen gespeichert werden sollen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zeitkorrektur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Wifi Arbeitszeiterfassung",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
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

        //private void DropDown(string selectCommand)
        //{
        //    //sql-Connection string wird geholt 
        //    string connectionString = con.DbConnection;

        //    dataGridView1.Columns[0].ReadOnly = true;
        //    dataGridView1.Columns.Remove(dataGridView1.Columns[2]);

        //    dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
        //    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
        //    DataTable table = new DataTable();
        //    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //    dataAdapter.Fill(table);

        //    DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
        //    cmb.HeaderText = "Zeit Typ";
        //    cmb.Name = "cmb";
        //    cmb.DataSource = table;
        //    cmb.DataPropertyName = "ZeitTyp";
        //    cmb.DisplayMember = "Bezeichnung";
        //    cmb.ValueMember = "ZeitTyp";

        //    dataGridView1.Columns.Add(cmb);
        //}
    }
}
