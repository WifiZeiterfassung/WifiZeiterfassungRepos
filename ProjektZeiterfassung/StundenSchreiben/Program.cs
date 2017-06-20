using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Hier wird die Klassenbibliothek DatabaseConnections eingebunden
//vorher im Projekt Zeiterfassung unter Verweise die neue DatabaseConnection.dll als Verweis einbinden
using DatabaseConnections;
using DatabaseConnections.Model;
using System.Windows;

namespace StundenSchreiben
{
    class Program
    {
        //Mitarbeiter m = new Mitarbeiter();
        //EintrittAustritt ea = new EintrittAustritt();
        DbConnections con = new DbConnections();
        ////Liste mit allen Werten des Mitarbeiters
        //ListeMitarbeiter suche = new ListeMitarbeiter();
        ////Liste mit Stempelzeit eines Mitarbeiters
        //ListeStempelzeiten stList = new ListeStempelzeiten();

        public static void Main()
        {
            int[] ID = { 1, 2, 3, 4, 5, 6, 7 };
            
            foreach (int id in ID)
            {
                int i = 0;
                while (i < 5)
                {
                    DbConnections con = new DbConnections();
                    DateTime TimeBeginn = DateTime.Now.AddDays(i);
                    DateTime TimeAPause = TimeBeginn.AddHours(1);
                    DateTime TimeEPasue = TimeAPause.AddMinutes(10);
                    DateTime TimeEnd = TimeBeginn.AddHours(2);
                    con.ZeitSpeichern(Convert.ToInt32(id), TimeBeginn, 1);
                    con.ZeitSpeichern(Convert.ToInt32(id), TimeAPause, 3);
                    con.ZeitSpeichern(Convert.ToInt32(id), TimeEPasue, 4);
                    con.ZeitSpeichern(Convert.ToInt32(id), TimeEnd, 2);
                    i++;
                }
            }
        }
    }
}
