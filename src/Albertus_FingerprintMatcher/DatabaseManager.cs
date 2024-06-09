using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Albertus_FingerprintMatcher
{
    internal class DatabaseManager
    {
        private MySqlConnection connection;

        public DatabaseManager()
        {
            string connectionString = "Server=localhost;Database=tubes3_albertus;Uid=root;Pwd=Annisa28_;";
            connection = new MySqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected to SQL Server database");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error while connecting to SQL Server: " + ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    Console.WriteLine("Disconnected from SQL Server database");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error while disconnecting from SQL Server: " + ex.Message);
            }
        }

        public DataTable Execute(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection is not open");
                    return dataTable;
                }

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                Console.WriteLine("Query executed successfully");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            return dataTable;
        }
    }
}