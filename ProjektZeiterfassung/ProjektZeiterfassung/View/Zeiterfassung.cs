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
    public partial class Zeiterfassung : Form
    {
        public Zeiterfassung()
        {
            InitializeComponent();
        }
        //Das Fenster zum PasswortAendern wird geöffnet
        private void BtnPasswortAendern_Click(object sender, EventArgs e)
        {
            PasswortAendern neuespasswort = new PasswortAendern();
            neuespasswort.ShowDialog(this);
        }
        //Das Fenster MitarbeiterBearbeiten wird geöffnet
        private void BtnBenutzerUpdate_Click(object sender, EventArgs e)
        {
            MitarbeiterBearbeiten mitarbeiterbearbeiten = new MitarbeiterBearbeiten();
            mitarbeiterbearbeiten.ShowDialog();
        }
        //Das Fenster MitarbeiterAnlegen wird geöffnet
        private void BtnBenutzerNeu_Click(object sender, EventArgs e)
        {
            MitarbeiterAnlegen mitarbeiteranlegen = new MitarbeiterAnlegen();
            mitarbeiteranlegen.ShowDialog();
        }
        //Das Fenster Zeitkorrektur wird geöffnet
        private void BtnZeitkorrektur_Click(object sender, EventArgs e)
        {
            Zeitkorrektur zeitkorrigieren = new View.Zeitkorrektur();
            zeitkorrigieren.ShowDialog();
        }
    }
}
