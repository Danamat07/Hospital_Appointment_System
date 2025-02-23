using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Appointment_System.Service;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Repository;

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
                Console.WriteLine(ex.Message);
            }
        }

        public void AddPatient(Patient patient)
        {
            try
            {
                patientService.AddPatient(patient);
                Console.WriteLine("Patient added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                patientService.UpdatePatient(patient);
                Console.WriteLine("Patient updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeletePatient(int id)
        {
            try
            {
                patientService.DeletePatient(id);
                Console.WriteLine("Patient deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Patient Authenticate(string email, string password)
        {
            return patientService.GetAllPatients().FirstOrDefault(p => p.Email == email && p.Password == password);
        }
    }
}
