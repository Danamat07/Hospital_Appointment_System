using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Repository;

namespace Hospital_Appointment_System.Service
{
    public class DoctorService
    {
        private readonly DoctorRepository doctorRepository;

        public DoctorService()
        {
            doctorRepository = new DoctorRepository();
        }

        public List<Doctor> GetAllDoctors()
        {
            try
            {
                return doctorRepository.GetAllDoctors();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving doctors.", ex);
            }
        }

        public Doctor GetDoctorById(int id)
        {
            try
            {
                return doctorRepository.GetDoctorById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the doctor with ID {id}.", ex);
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            try
            {
                doctorRepository.AddDoctor(doctor);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the doctor.", ex);
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            try
            {
                doctorRepository.UpdateDoctor(doctor);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while updating the doctor with ID {doctor.Id}.", ex);
            }
        }

        public void DeleteDoctor(int id)
        {
            try
            {
                doctorRepository.DeleteDoctor(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the doctor with ID {id}.", ex);
            }
        }
    }
}
