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
        private string _Connection;
        private string _SqlString = "";//Hier den SQL String fürs Update

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Id des Mitarbeiters eingeben :");
            p._ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte Klartextpasswort eingeben :");
            p._Klartextpasswort = Console.ReadLine();
            p._Passwort = Helper.GetHash(p._Klartextpasswort);

            Datenbankverbindung con = new Datenbankverbindung();
            using (var Connection = new System.Data.SqlClient.SqlConnection(con.DbConnection))
            {
                using(var Befehl = new System.Data.SqlClient.SqlCommand("dbo.Mitarbeiter", Connection))
                {
                    Befehl.CommandType = System.Data.CommandType.TableDirect;
                    Befehl.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = p._ID;
                    Befehl.Parameters.Add("@Passwort", System.Data.SqlDbType.VarBinary).Value = p._Passwort;

                }
            }
            


        }
    }
}
