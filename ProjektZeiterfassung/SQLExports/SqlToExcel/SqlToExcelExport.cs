using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using SQL = System.Data;




namespace SqlToExcel
{
    class SqlToExcelExport
    {
        static string QueryMitarbeiter
        { get { return "SELECT [dbo].Mitarbeiter.ID AS ID, [dbo].Mitarbeiter.Personalnummer AS Personalnummer, [dbo].Mitarbeiter.Vorname AS Vorname, [dbo].Mitarbeiter.Nachname AS Nachname, [dbo].Mitarbeiter.Eintrittsdatum AS Eintrittsdatum, [dbo].Mitarbeiter.TagesSollZeit AS TagesSollZeit FROM [ZEIT2017].[dbo].[Mitarbeiter] WHERE [dbo].Mitarbeiter.Personalnummer like '1031'"; } }
        static string Query
        { get { return "SELECT [dbo].Zeiterfassung.ID AS ID, [dbo].Zeiterfassung.TagesDatum AS 'Datum', [dbo].Zeiterfassung.ArbeitsAnfang AS 'Arbeitsanfang', [dbo].Zeiterfassung.PauseAnfang AS 'Pausenanfang', [dbo].Zeiterfassung.PauseEnde AS 'Pausenende', [dbo].Zeiterfassung.ArbeitsEnde AS 'Arbeitsende', [dbo].Zeiterfassung.TagesIstZeit AS 'Tages-Ist-Zeit', [dbo].Zeiterfassung.FK_Mitarbeiter_ID AS 'Mitarbeiter-ID', (Arbeitsende-Arbeitsanfang)-([dbo].Zeiterfassung.PauseEnde-[dbo].Zeiterfassung.PauseAnfang) AS Tagesstunden FROM [ZEIT2017].[dbo].[Zeiterfassung] WHERE [dbo].Zeiterfassung.ID like '14'"; } }
        //static string Query
        //{ get { return "SELECT [dbo].Zeiterfassung.ID AS ID, [dbo].Zeiterfassung.TagesDatum AS 'Datum', [dbo].Zeiterfassung.ArbeitsAnfang AS 'Arbeitsanfang', [dbo].Zeiterfassung.PauseAnfang AS 'Pausenanfang', [dbo].Zeiterfassung.PauseEnde AS 'Pausenende', [dbo].Zeiterfassung.ArbeitsEnde AS 'Arbeitsende', [dbo].Zeiterfassung.TagesIstZeit AS 'Tages-Ist-Zeit', [dbo].Zeiterfassung.FK_Mitarbeiter_ID AS 'Mitarbeiter-ID' FROM [ZEIT2017].[dbo].[Zeiterfassung] WHERE [dbo].Zeiterfassung.ID like '14'"; } }
        static string MyTime
        { get { return System.DateTime.Now.ToShortDateString(); } }

        static void Main(string[] args)
        {
            Export();
        }
        private static void Export()
        {
            SqlConnection cnn;
            string connectionstring = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;
            int ci = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;


            xlApp = new Microsoft.Office.Interop.Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkBook = xlApp.Workbooks.Open(@"C:\temp\Export-Vorlage.xls");
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //Hier werden die Kopfdaten der Excel-Datei geschrieben
            using (SqlConnection con = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    SqlDataReader reader;
                    con.ConnectionString = "Data Source=NB01-ZAUNFLOR1\\SQLEXPRESS;Initial Catalog=ZEIT2017;Connection Timeout=15;Integrated Security=true;";
                    cmd.Connection = con;
                    string sSqlQuery = "";
                    con.Open();

                    sSqlQuery = QueryMitarbeiter;
                    cmd.CommandText = sSqlQuery;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string Personalnummer = reader["Personalnummer"].ToString();
                        string Vorname = reader["Vorname"].ToString();
                        string Nachname = reader["Nachname"].ToString();
                        string Eintrittsdatum = reader["Eintrittsdatum"].ToString();
                        // Daten eingeben
                        xlWorkSheet.Cells[3, 1] = "von  " + Eintrittsdatum + " bis " + Eintrittsdatum;
                        xlWorkSheet.Cells[5, 1] = Personalnummer + " " + Vorname + " " + Nachname;
                    }
                    reader.Dispose();
                    con.Close();
                }
            }

            connectionstring = "Data Source=NB01-ZAUNFLOR1\\SQLEXPRESS;Initial Catalog=ZEIT2017;Connection Timeout=15;Integrated Security=true;";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            sql = Query;
            SQL.DataTable dtable = new SQL.DataTable();
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            SQL.DataSet ds = new SQL.DataSet();
            dscmd.Fill(ds);


            //Hier werden die Spaltennamen geschrieben
            for (ci = 0; ci < ds.Tables[0].Columns.Count; ci++)
            { 
                xlWorkSheet.Cells[7, ci + 1] = ds.Tables[0].Columns[ci].ColumnName;
            }
            
            //Hier werden die Werte in die Tabelle geschrieben
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 8, j + 1] = data;
                }
                xlWorkSheet.Cells[i + 8, j + 1] = "=(F8-C8)-(E8-D8)";
                xlWorkSheet.Cells[i + 8, j + 2] = "=I8-G8";
            }


            xlApp.DisplayAlerts = false;
            xlWorkBook.SaveAs(@"C:\temp\Export.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
            xlApp.DisplayAlerts = true;
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            cnn.Close();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}