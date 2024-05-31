using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Albertus_FingerprintMatcher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.Connect();
                DataTable results = db.Execute("SELECT * FROM biodata LIMIT 5;");
                foreach (DataRow row in results.Rows)
                {
                    foreach (DataColumn col in results.Columns)
                    {
                        Console.Write(row[col] + "\t");
                    }
                    Console.WriteLine();
                }
                db.Disconnect();
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            */

            //string name = "Nicholas Reymond Sihite";
            //string encrypted = "n1cHl4S ryM0nD 51ht3";

            //string regex = RegEx.generateRegEx(name);

            //Console.WriteLine(regex);

            //if (RegEx.isMatch(encrypted, regex)){
            //    Console.WriteLine("Matched!");
            //} else {
            //    Console.WriteLine("Not match!");
            //}

            Application.Run(new Form());

        }
    }
}

