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
    public partial class Mainpanel : Form
    {
        public Mainpanel()
        {
            InitializeComponent();
        }

        private void Mainpanel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "zEIT2017DataSet.Mitarbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mitarbeiterTableAdapter.Fill(this.zEIT2017DataSet.Mitarbeiter);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mitarbeiterTableAdapter.FillBy(this.zEIT2017DataSet.Mitarbeiter);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mitarbeiterTableAdapter.FillBy1(this.zEIT2017DataSet.Mitarbeiter);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
