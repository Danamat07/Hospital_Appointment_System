using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital_Appointment_System.Repository
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=sql7.freesqldatabase.com;Database=sql7764122;Uid=sql7764122;Pwd=PlffmynkE8;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static MySqlCommand CreateCommand(string query, MySqlConnection connection)
        {
            return new MySqlCommand(query, connection);
        }
    }
}
