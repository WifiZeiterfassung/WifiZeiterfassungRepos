using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjektZeiterfassung.View
{
    public partial class MitarbeiterUpdate : Form
    {
        public MitarbeiterUpdate()
        {
            InitializeComponent();
        }

        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ZEIT2017;Integrated Security=True";
        string Query;
        DataSet dataset;
        DataTable datatable;
        SqlDataAdapter sqladapter;

        private void MitarbeiterUpdate_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.View_1". Sie können sie bei Bedarf verschieben oder entfernen.
            this.view_1TableAdapter.Fill(this.zEIT2017DataSet3.View_1);
            //sqlconnection = new SqlConnection(ConnectionString);
            //Query = "SELECT dbo.EintrittAustritt.Personalnummer, dbo.Mitarbeiter.Vorname, dbo.Mitarbeiter.Nachname, dbo.EintrittAustritt.EintrittsDatum, dbo.EintrittAustritt.AustrittsDatum, dbo.EintrittAustritt.TagesSollZeit, dbo.EintrittAustritt.IsAdmin FROM dbo.EintrittAustritt INNER JOIN dbo.Mitarbeiter ON dbo.EintrittAustritt.FK_Mitarbeiter = dbo.Mitarbeiter.ID";
            //sqlcommand = new SqlCommand(Query, sqlconnection);
            //sqladapter = new SqlDataAdapter();
            //datatable = new DataTable();
            //sqladapter.SelectCommand = sqlcommand;
            //sqladapter.Fill(datatable);
            //view_1DataGridView.DataSource = datatable;

        }
        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(datatable);
            DataView DV = new DataView(this.zEIT2017DataSet3.View_1);
            DV.RowFilter = string.Format("Vorname + Nachname + Personalnummer LIKE '%{0}%'", TextBoxSearch.Text);
            view_1DataGridView.DataSource = DV;
        }

        private void view_1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.view_1BindingSource.EndEdit();
            zEIT2017DataSet3.AcceptChanges();
            this.tableAdapterManager.UpdateAll(this.zEIT2017DataSet3);
        }
    }
}
