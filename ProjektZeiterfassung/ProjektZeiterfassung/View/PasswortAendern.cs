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
    public partial class PasswortAendern : Form
    {
        private string _Klartextpasswort;
        private byte[] _Passwort;

        public PasswortAendern()
        {
            InitializeComponent();
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            if (TxtNeuesPasswort.TextLength == 6 || TxtNeuesPasswort1.TextLength == 6)
            {
                if (TxtNeuesPasswort.Text == TxtNeuesPasswort1.Text)
                {
                    _Klartextpasswort = TxtNeuesPasswort.Text;
                    _Passwort = Model.Helper.GetHash(_Klartextpasswort);

                    TextBoxPasswort.Text = System.Text.Encoding.UTF8.GetString(_Passwort) + "Ihr Passwort wurde erfolgreich geändert!";
                }
                else
                {
                    TextBoxPasswort.Text = "Die eingegebenen Passwörter sind nicht identisch. Bitte versuchen sie es erneut!";
                }
            }
            else
            {
                TextBoxPasswort.Text = "Das Passwort muss genau 6 Zeichen haben!";
            }
        }
    }
}
