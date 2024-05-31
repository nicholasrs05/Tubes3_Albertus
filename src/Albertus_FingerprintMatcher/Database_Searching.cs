using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albertus_FingerprintMatcher
{
    public class Database_Searching
    {
        public Database_Searching()
        {
            try
            {
                DatabaseManager db = new DatabaseManager();
                db.Connect();
                DataTable results = db.Execute("Select * from sidik_jari");

                List<String> path = new List<String>();
                foreach (DataRow row in results.Rows)
                {
                    path.Add((String)row[0]);
                    Console.WriteLine(row[1]);
                }
                db.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

    public class testing
    {
        static void main(string[] args)
        {
            // Buatlah test driver untuk database searching

            Database_Searching db = new Database_Searching();

        }
    }
}