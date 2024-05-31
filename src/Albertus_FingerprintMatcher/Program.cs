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

            Application.Run(new Form());

            // print "Hello World"

        }
    }
}

