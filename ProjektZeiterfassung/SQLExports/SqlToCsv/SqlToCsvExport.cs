using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlToCsv
{
    class SqlToCsvExport
    {
        //SQL Statement
        static string Query
        { get { return "SELECT ARTIKEL_A.ARTIKEL AS Artikelnummer,ARTIKEL_A.NAME AS Bezeichnung, ARTIKEL_A.EKTEXT AS Einkaufstext, ARTIKEL_A.EKPREIS AS Einkaufspreis,INVENTUR.ISTBESTAND AS Ist_Bestand, INVENTUR.BEWERTUNGSPREIS AS Bewertungspreis FROM ARTIKEL_A JOIN INVENTUR ON ARTIKEL_A.ARTIKEL = INVENTUR.ARTIKEL WHERE ARTIKEL_A.ARTIKEL like '%M-011%'"; } }
        //Speicherort für die CSV-Datei
        static string TargetFile
        { get { return @"C:\temp\Export.csv"; } }

        public static void Main()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Sends SQL-commands to the database
                using (SqlCommand cmd = new SqlCommand())
                {
                    //Holds the result of a database query
                    SqlDataReader reader;
                    //Set the parameters for the connection

                    con.ConnectionString = "Data Source=ngr-sql;Initial Catalog=APplusProd;Connection Timeout=15;User Id=VLDB;Password=P@ssw0rd;";
                    //Set the connection the command is using

                    cmd.Connection = con;
                    //Holds the query string

                    //Open database connection
                    con.Open();
                    cmd.CommandText = Query;
                    reader = cmd.ExecuteReader();

                    using (System.IO.StreamWriter fs = new System.IO.StreamWriter(TargetFile))
                    {
                        // Loop through the fields and add headers
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string name = reader.GetName(i);
                            if (name.Contains(","))
                                name = "\"" + name + "\"";

                            fs.Write(name + ";");
                        }
                        fs.WriteLine();

                        // Loop through the rows and output the data
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string value = reader[i].ToString();
                                if (value.Contains(","))
                                    value = "\"" + value + "\"";

                                fs.Write(value + ";");
                            }
                            fs.WriteLine();
                        }
                        fs.Close();
                    }
                }
            }
        }
    }
}
