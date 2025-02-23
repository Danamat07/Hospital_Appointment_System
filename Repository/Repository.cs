using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Hospital_Appointment_System.Domain;
using System.Runtime.CompilerServices;

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

    public class PatientRepository
    {
        public List<Patient> GetAllPatients()
        {
            var patients = new List<Patient>();
            string query = "SELECT * FROM Patient";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    patients.Add(new Patient(
                        reader.GetInt32("ID"),
                        reader.GetString("Name"),
                        reader.GetString("Email"),
                        reader.GetString("Phone"),
                        reader.GetString("Password")
                        ));
                }
            }
            return patients;
        }

        public Patient GetPatientById(int id)
        {
            Patient patient = null;
            string query = "SELECT * FROM Patient WHERE ID @Id";

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    patient = new Patient(
                        reader.GetInt32("ID"),
                        reader.GetString("Name"),
                        reader.GetString("Email"),
                        reader.GetString("Phone"),
                        reader.GetString("Password")
                        );
                }
            }
            return patient;
        }

        public void AddPatient(Patient patient)
        {
            string query = "INSERT INTO Patient (Name, Email, Phone, Password) VALUES (@Name, @Email, @Phone, @Password)";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Password", patient.Password);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePatient(Patient patient)
        {
            string query = "UPDATE Patient SET Name = @Name, Email = @Email, Phone = @Phone, Password = @Password WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", patient.Id);
                cmd.Parameters.AddWithValue("@Name", patient.Name);
                cmd.Parameters.AddWithValue("@Email", patient.Email);
                cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                cmd.Parameters.AddWithValue("@Password", patient.Password);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePatient(int id)
        {
            string query = "DELETE FROM Patient WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
