using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DatabaseConnections;
using DatabaseConnections.Model;

namespace WpfZeitPostgres
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Ausblenden des PasswortButtons beim start
            ButtonPasswortAendern.Visibility = Visibility.Hidden;
            //Fensterhöhe am kleinsten da noch nicht angemeldet
            MaxHeight = 210;
        }

        private void ButtonAnmelden_Click(object sender, RoutedEventArgs e)
        {
            Mitarbeiter m = new Mitarbeiter();
            EintrittAustritt ea = new EintrittAustritt();
            DbConnections con = new DbConnections();
            ListeMitarbeiter suche = new ListeMitarbeiter();
            if (!String.IsNullOrWhiteSpace(TextBoxPersonalnummer.Text.Trim()) && !String.IsNullOrWhiteSpace(PasswortBoxPasswort.Password))
            {
                ea.Personalnummer = TextBoxPersonalnummer.Text.Trim();
                m.KlartextPasswort = PasswortBoxPasswort.Password.Trim();
                m.Passwort = Helper.GetHash(m.KlartextPasswort);
                suche = con.MitarbeiterSuchen(m.Passwort, ea.Personalnummer);
                if(suche.Count > 0 && suche.FirstOrDefault().IsAdmin)
                {
                    TextBoxMeldung.Text = String.Format("Hallo Administrator {1} {2}", suche[0].ID, suche[0].Vorname, suche[0].Nachname);
                    MaxHeight = 490;
                    ButtonPasswortAendern.Visibility = Visibility.Visible;
                    ButtonArbeitsEnde.Visibility = Visibility.Hidden;
                    ButtonPauseBeginn.Visibility = Visibility.Hidden;
                    ButtonArbeitsEnde.Visibility = Visibility.Hidden;
                    ButtonPauseEnde.Visibility = Visibility.Hidden;
                }
                else if (suche.Count > 0)
                {
                    TextBoxMeldung.Text = String.Format("Hallo {1} {2}",suche[0].ID,suche[0].Vorname,suche[0].Nachname);
                    MaxHeight = 320;
                    ButtonPasswortAendern.Visibility = Visibility.Visible;
                    ButtonArbeitsEnde.Visibility = Visibility.Hidden;
                    ButtonPauseBeginn.Visibility = Visibility.Hidden;
                    ButtonArbeitsEnde.Visibility = Visibility.Hidden;
                    ButtonPauseEnde.Visibility = Visibility.Hidden;
                }
                else
                {
                    TextBoxMeldung.Text = "Eingaben falsch oder nicht vorhanden!";
                }

            }
            else
            {
                TextBoxMeldung.Text = "Eingabe Personalnummer oder Passwort fehlen!";
            }
        }
    }
}
