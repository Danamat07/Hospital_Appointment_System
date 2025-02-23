using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Repository;

namespace Hospital_Appointment_System.Service
{
    public class PatientService
    {
        private readonly PatientRepository patientRepository;

        public PatientService()
        {
            patientRepository = new PatientRepository();
        }

        public List<Patient> GetAllPatients()
        {
            try
            {
                return patientRepository.GetAllPatients();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving patients.", ex);
            }
        }

        public Patient GetPatientById(int id)
        {
            try
            {
                return patientRepository.GetPatientById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the patient with ID {id}.", ex);
            }
        }

        public bool AddPatient(Patient patient)
        {
            try
            {
                return patientRepository.AddPatient(patient);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the patient.", ex);
            }
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                patientRepository.UpdatePatient(patient);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while updating the patient with ID {patient.Id}.", ex);
            }
        }

        public void DeletePatient(int id)
        {
            try
            {
                patientRepository.DeletePatient(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the patient with ID {id}.", ex);
            }
        }
    }
}
