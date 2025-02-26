using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Service;

namespace Hospital_Appointment_System.Controller
{
    public class DoctorController
    {
        private readonly DoctorService doctorService;

        public DoctorController()
        {
            doctorService = new DoctorService();
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctorService.GetAllDoctors();
        }

        public Doctor GetDoctorById(int id)
        {
            return doctorService.GetDoctorById(id);
        }

        public void DisplayAllDoctors()
        {
            try
            {
                var doctors = doctorService.GetAllDoctors();
                foreach (var doctor in doctors)
                {
                    Console.WriteLine($"ID: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            try
            {
                doctorService.AddDoctor(doctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            try
            {
                doctorService.UpdateDoctor(doctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void DeleteDoctor(int id)
        {
            try
            {
                doctorService.DeleteDoctor(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
