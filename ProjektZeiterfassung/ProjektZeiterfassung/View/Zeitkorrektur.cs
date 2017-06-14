﻿using System;
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
    public partial class Zeitkorrektur : Form
    {
        public string Korrekturdatum
        {
            get { return dateTimePickerDatumBeginn.Text; }
        }

        public Zeitkorrektur()
        {
            InitializeComponent();
        }

        public string PersonalnummerBearbeiten { get; set; } 

        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            int Personalnummerint;
            bool parsed = Int32.TryParse(TxtPersonalnummer.Text, out Personalnummerint);

            //Sql Statement
            //SELECT    Personalnummer AS DbPersonalnummer
            //            ,Pin AS DbPin
            //            ,IsAdmin AS DbAdmin
            //            ,Vorname AS DbVorname
            //            ,Nachname AS DbNachname
            //            FROM dbo.Mitarbeiter WHERE Personalnummer = 'PersonalNummer'

            if (Personalnummerint == 1)
            {
                TxtBenutzerdaten.Text = "DbVorname + DbNachname";
            }
            else
            {
                MessageBox.Show("Personalnummer wurde nicht gefunden!");
            }
        }

        DbConnections con = new DbConnections();
        ListeMitarbeiter ErgebnisSuche = new ListeMitarbeiter();

        /// <summary>
        /// Lädt das Fenster Zeitkorrektur mit der gewählten Personalnummer
        /// </summary>
        private void Zeitkorrektur_Load(object sender, EventArgs e)
        {
            //string Datum = dateTimePickerDatumBeginn.Value.Date.ToString("MM/dd/yyyy").Replace(".", "/");

            // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet3.Stempelzeiten". Sie können sie bei Bedarf verschieben oder entfernen.
            this.stempelzeitenTableAdapter.Fill(this.zEIT2017DataSet3.Stempelzeiten);
            MitarbeiterSuchenZeitkorrektur mitarbeitersuchenzeitkorrektur = new MitarbeiterSuchenZeitkorrektur();
            mitarbeitersuchenzeitkorrektur.Close();

            //DataView DV = new DataView(this.zEIT2017DataSet3.Stempelzeiten);
            //DV.RowFilter = "Zeitpunkt >= #" + Datum + "#";
            //stempelzeitenDataGridView.DataSource = DV;
            DataViewUpdater();


            ErgebnisSuche = con.MitarbeiterPersonalnummerSuchen(this.PersonalnummerBearbeiten);
            TxtPersonalnummer.Text = ErgebnisSuche.FirstOrDefault().Personalnummer;
            TxtBenutzerdaten.Text = string.Format("{0} {1}", ErgebnisSuche.FirstOrDefault().Vorname, ErgebnisSuche.FirstOrDefault().Nachname);
            


        }

        private void stempelzeitenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stempelzeitenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zEIT2017DataSet3);

        }

        private void dateTimePickerDatum_ValueChanged(object sender, EventArgs e)
        {
            DataViewUpdater();
        }

        private void dateTimePickerDatumEnde_ValueChanged(object sender, EventArgs e)
        {
            DataViewUpdater();
        }

        private void DataViewUpdater()
        {
            string DatumBeginn = dateTimePickerDatumBeginn.Value.Date.ToString("MM/dd/yyyy").Replace(".", "/");
            string DatumEnde = dateTimePickerDatumEnde.Value.AddDays(1).Date.ToString("MM/dd/yyyy").Replace(".", "/");
            int FKMitarbeiter = con.HoleFK_Mitarbeiter(TxtPersonalnummer.Text);

            DataView DV = new DataView(this.zEIT2017DataSet3.Stempelzeiten);
            DV.RowFilter = "Zeitpunkt > #" + DatumBeginn + "# And Zeitpunkt < #" + DatumEnde + "# And FK_Mitarbeiter = '"  + FKMitarbeiter + "'";
            stempelzeitenDataGridView.DataSource = DV;
        }
    }
}
