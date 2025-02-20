using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hospital_Appointment_System
{
    internal class DatabaseHelper
    {
        // connection string to connect to MySQL database
        private static string connectionString = "server=localhost;database=HospitalDB;user=root;password=rootpassword;";

        // method to get a MySQL connection
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // method to execute query that returns data
        // ex: SELECT
        public static DataTable ExecuteQuery(string query)
        {
            // datatable to hold result set
            DataTable dt = new DataTable();
            using (var conn = GetConnection())  // open new connection
            {
                try
                {
                    conn.Open();    // open connection
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);   // create data adapter with query and connection
                    adapter.Fill(dt);    // fill datatable with results from query
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing query: " + ex.Message);  // handle errors
                }
            }
            return dt;  // return datatable with query results
        }

        // method to execute query that doesn't return data
        // ex: INSERT, UPDATE, DELETE
        public static void ExecuteNonQuery(string query)
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing non-query: " + ex.Message);
                }
            }
        }
    }
}
