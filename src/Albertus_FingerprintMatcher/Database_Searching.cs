using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;

namespace Albertus_FingerprintMatcher
{
    public class Database_Searching
    {
        public DataTable results;
        List<String> path;
        List<String> name;
        public Database_Searching()
        {
            DatabaseManager db = new DatabaseManager();
            try
            {
                db.Connect();
                results = db.Execute("select * from sidik_jari");

                path = new List<String>();
                name = new List<String>();
                foreach (DataRow row in results.Rows)
                {
                    path.Add((String)row[0]);
                    name.Add((String)row[1]);
                    //Console.WriteLine(row[0]);
                }
                db.Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public List<String> GetPath()
        {
            return path;
        }
        public List<String> GetName() {
            return name;
        }
    }

    //public class testing
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Create a test driver for database searching
    //        Database_Searching db = new Database_Searching();
    //        List<String> path = db.GetPath();
    //        foreach (String s in path) { 
    //            Console.WriteLine(s);
    //        }
    //    }
    //}
}
