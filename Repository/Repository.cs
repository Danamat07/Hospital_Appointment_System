using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Hospital_Appointment_System.Domain;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public bool AddPatient(Patient patient)
        {
            try
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
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
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

    public class DoctorRepository
    {
        public List<Doctor> GetAllDoctors()
        {
            var doctors = new List<Doctor>();
            string query = "SELECT * FROM Doctor";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctors.Add(new Doctor(
                        reader.GetInt32("ID"),
                        reader.GetString("Name"),
                        (Specialisation)Enum.Parse(typeof(Specialisation), reader.GetString("Specialization"))
                    ));
                }
            }
            return doctors;
        }

        public Doctor GetDoctorById(int id)
        {
            Doctor doctor = null;
            string query = "SELECT * FROM Doctor WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    doctor = new Doctor(
                        reader.GetInt32("ID"),
                        reader.GetString("Name"),
                        (Specialisation)Enum.Parse(typeof(Specialisation), reader.GetString("Specialization"))
                    );
                }
            }
            return doctor;
        }

        public void AddDoctor(Doctor doctor)
        {
            string query = "INSERT INTO Doctor (Name, Specialization) VALUES (@Name, @Specialization)";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            string query = "UPDATE Doctor SET Name = @Name, Specialization = @Specialization WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", doctor.Id);
                cmd.Parameters.AddWithValue("@Name", doctor.Name);
                cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int id)
        {
            string query = "DELETE FROM Doctor WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // finds the first available doctor based on given specialization and appointment start time
        public Doctor GetAvailableDoctor(string specialization, DateTime startTime)
        {
            Doctor availableDoctor = null;
            string query = @"
                SELECT d.ID, d.Name, d.Specialization 
                FROM Doctor d
                WHERE d.Specialization = @Specialization 
                AND NOT EXISTS (
                    SELECT 1 FROM Appointment a
                    WHERE a.DoctorID = d.ID 
                    AND @StartTime BETWEEN a.StartTime AND a.EndTime
                )
                LIMIT 1"; // get the first available doctor
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Specialization", specialization);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    availableDoctor = new Doctor(
                        reader.GetInt32("ID"),
                        reader.GetString("Name"),
                        (Specialisation)Enum.Parse(typeof(Specialisation), reader.GetString("Specialization"))
                    );
                }
            }
            return availableDoctor;
        }
    }

    

    public class AppointmentRepository
    {
        public List<Appointment> GetAllAppointments()
        {
            var appointments = new List<Appointment>();
            string query = @"
                SELECT 
                    a.ID, a.PatientID, p.Name AS PatientName, 
                    a.DoctorID, d.Name AS DoctorName, 
                    a.StartTime, a.EndTime, a.Status
                FROM Appointment a
                JOIN Patient p ON a.PatientID = p.ID
                JOIN Doctor d ON a.DoctorID = d.ID";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    appointments.Add(new Appointment(
                        reader.GetInt32("ID"),
                        reader.GetInt32("PatientID"),
                        reader.GetInt32("DoctorID"),
                        reader.GetDateTime("StartTime"),
                        reader.GetDateTime("EndTime"),
                        (AppointmentStatus)Enum.Parse(typeof(AppointmentStatus), reader.GetString("Status"))
                    ));
                }
            }
            return appointments;
        }

        public Appointment GetAppointmentById(int id)
        {
            Appointment appointment = null;
            string query = "SELECT * FROM Appointment WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    appointment = new Appointment(
                        reader.GetInt32("ID"),
                        reader.GetInt32("PatientID"),
                        reader.GetInt32("DoctorID"),
                        reader.GetDateTime("StartTime"),
                        reader.GetDateTime("EndTime"),
                        (AppointmentStatus)Enum.Parse(typeof(AppointmentStatus), reader.GetString("Status"))
                    );
                }
            }
            return appointment;
        }

        public List<Appointment> GetAppointmentByPatientId(int patientId)
        {
            var appointments = new List<Appointment>();
            string query = @"
                SELECT 
                    Appointment.StartTime,
                    Appointment.EndTime,
                    Appointment.Status,
                    Patient.Name AS PatientName,
                    Doctor.Name AS DoctorName
                FROM 
                    Appointment
                JOIN 
                    Patient ON Appointment.PatientID = Patient.ID
                JOIN 
                    Doctor ON Appointment.DoctorID = Doctor.ID
                WHERE 
                    Appointment.PatientID = @PatientId";

            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var appointment = new Appointment(
                        reader.GetInt32("ID"),
                        reader.GetInt32("PatientID"),
                        reader.GetInt32("DoctorID"),
                        reader.GetDateTime("StartTime"),
                        reader.GetDateTime("EndTime"),
                        (AppointmentStatus)Enum.Parse(typeof(AppointmentStatus), reader.GetString("Status"))
                    );
                    if (appointment.Status == AppointmentStatus.Scheduled)
                    {
                        appointments.Add(appointment);
                    }
                }
            }
            return appointments;
        }


        public void AddAppointment(Appointment appointment)
        {
            string query = "INSERT INTO Appointment (PatientID, DoctorID, StartTime, EndTime, Status) VALUES (@PatientID, @DoctorID, @StartTime, @EndTime, @Status)";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", appointment.EndTime);
                cmd.Parameters.AddWithValue("@Status", appointment.Status.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            string query = "UPDATE Appointment SET PatientID = @PatientID, DoctorID = @DoctorID, StartTime = @StartTime, EndTime = @EndTime, Status = @Status WHERE ID = @Id";
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = DatabaseHelper.CreateCommand(query, connection);
                cmd.Parameters.AddWithValue("@Id", appointment.Id);
                cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@StartTime", appointment.StartTime);
                cmd.Parameters.AddWithValue("@EndTime", appointment.EndTime);
                cmd.Parameters.AddWithValue("@Status", appointment.Status.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAppointment(int id)
        {
            string query = "DELETE FROM Appointments WHERE ID = @Id";
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
