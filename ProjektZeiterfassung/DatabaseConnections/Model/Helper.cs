using System;
using System.Security.Cryptography;
using System.Text;
//errorLog
using System.IO;

namespace DatabaseConnections.Model
{
    /// <summary>
    /// Hilfsklasse für spezielle Methoden
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Methode um einen String konform für MS-SQL Server 2012 'sha2_512' zu hashen
        /// </summary>
        /// <param name="text">der text zum hashen</param>
        /// <returns>Gibt ein ByteArray des gehashten Strings zurück</returns>
        public static Byte[] GetHash(string text)
        {
            //Damit der Hashwert auch richtig generiert wird MUSS auf Encoding 1252 gestellt werden
            // Erst nachdem das Bytearray mit einem encodierten string nach 1252 erstellt wurde
            // wird dieser mittels ComputeHash gehasht. Danach ist dieser Wert mit
            // MS-SQL Server 2012 VARBINARY(HashByte('sha2_512','HashText')) konform.
            Byte[] hashbytes = null;
            SHA512 alg = SHA512.Create();
            Encoding windows1252 = Encoding.GetEncoding(1252);
            Byte[] result = windows1252.GetBytes(text);
            hashbytes = alg.ComputeHash(result);
            return hashbytes;

        }
        /// <summary>
        /// Methode welche die Errormessage eines catchblocks in eine Datei schreibt oder erweitert um einen Log Eintrag
        /// </summary>
        /// <param name="message">Fehlermeldung als string</param>
        public static void LogError(string message)
        {
            try
            {
                string path = @"LogFile.txt";
                //Überprüfe ob der Dateipfad existiert wenn nicht wird er erzeugt
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        string error = "\r\nLog geschrieben um : " + DateTime.Now.ToString() + "\r\nError in :\n" + message;
                        sw.WriteLine(error);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {

                        StringBuilder sb = new StringBuilder();
                        sb.Append("-------------------------------------------------------------------");
                        sb.Append(Environment.NewLine);
                        sb.Append(DateTime.Now);
                        sb.Append(" \t");
                        sb.Append(message);
                        sb.Append("----------------------------Ende-----------------------------------");
                        sb.Append(Environment.NewLine);
                        sw.WriteLine(sb);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
