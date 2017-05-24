using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashPasswort;

namespace HashPasswort
{    
    class Program
    {
        private string _Klartextpasswort;
        private byte[] _Passwort;
        private int _ID;
        private string _SqlString = "UPDATE [ZEIT2017].[dbo].[Mitarbeiter] SET [Passwort] = @Passwort WHERE [ID] = @ID;";//Hier den SQL String fürs Update

        /// <summary>
        /// schreibt den eingegebenen String als Hashwert in die Datenbank zu den Mitarbeitern mit einer While schleife da 7 Personen
        /// Passwort kann frei gewählt werden einmal für alle 7 das gleiche standardpasswort
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Bitte Klartextpasswort eingeben :");
            p._Klartextpasswort = Console.ReadLine();
            p._Passwort = Helper.GetHash(p._Klartextpasswort);
            p._ID = 1;
            while (p._ID <= 7)
            {
                Datenbankverbindung con = new Datenbankverbindung();
                using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
                {
                    Connection.Open();
                    using (var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                    {
                        Befehl.CommandText = p._SqlString;
                        Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = p._ID;
                        Befehl.Parameters.Add("@Passwort", System.Data.SqlDbType.VarBinary).Value = p._Passwort;
                        Befehl.ExecuteNonQuery();
                    }
                    Connection.Close();
                }
                p._ID += 1;
            }
            Console.ReadLine();
            
            


        }
    }
}
