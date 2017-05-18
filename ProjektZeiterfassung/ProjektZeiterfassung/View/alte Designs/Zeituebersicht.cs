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
    public partial class Zeituebersicht : Form
    {
        public Zeituebersicht()
        {
            InitializeComponent();
        }

        private void Zeituebersicht_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet1.Mitarbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mitarbeiterTableAdapter.Fill(this.zEIT2017DataSet1.Mitarbeiter);

        }
    }
}
