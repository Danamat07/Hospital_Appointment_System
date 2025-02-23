using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine(ex.Message);
            }
        }

        public void AddDoctor(Doctor doctor)
        {
            try
            {
                doctorService.AddDoctor(doctor);
                Console.WriteLine("Doctor added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            try
            {
                doctorService.UpdateDoctor(doctor);
                Console.WriteLine("Doctor updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteDoctor(int id)
        {
            try
            {
                doctorService.DeleteDoctor(id);
                Console.WriteLine("Doctor deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
