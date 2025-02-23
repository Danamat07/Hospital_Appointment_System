using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Appointment_System.Service;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Repository;
using System.Windows.Forms;

namespace Hospital_Appointment_System.Controller
{
    public class PatientController
    {
        private readonly PatientService patientService;

        public PatientController()
        {
            patientService = new PatientService();
        }

        public void DisplayAllPatients()
        {
            try
            {
                var patients = patientService.GetAllPatients();
                foreach (var patient in patients)
                {
                    Console.WriteLine($"ID: {patient.Id}, Name: {patient.Name}, Email: {patient.Email}, Phone: {patient.Phone}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public bool AddPatient(Patient patient)
        {
            try
            {
                return patientService.AddPatient(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                patientService.UpdatePatient(patient);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void DeletePatient(int id)
        {
            try
            {
                patientService.DeletePatient(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public Patient Authenticate(string email, string password)
        {
            return patientService.GetAllPatients().FirstOrDefault(p => p.Email == email && p.Password == password);
        }
    }
}
