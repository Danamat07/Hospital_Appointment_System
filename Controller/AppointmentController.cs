using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Service;

namespace Hospital_Appointment_System.Controller
{
    public class AppointmentController
    {
        private readonly AppointmentService _appointmentService;

        public AppointmentController()
        {
            _appointmentService = new AppointmentService();
        }

        public void DisplayAllAppointments()
        {
            try
            {
                var appointments = _appointmentService.GetAllAppointments();
                foreach (var appointment in appointments)
                {
                    Console.WriteLine($"ID: {appointment.Id}, PatientID: {appointment.PatientID}, DoctorID: {appointment.DoctorID}, Start: {appointment.StartTime}, End: {appointment.EndTime}, Status: {appointment.Status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void AddAppointment(Appointment appointment)
        {
            try
            {
                _appointmentService.AddAppointment(appointment);
                Console.WriteLine("Appointment added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                _appointmentService.UpdateAppointment(appointment);
                Console.WriteLine("Appointment updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteAppointment(int id)
        {
            try
            {
                _appointmentService.DeleteAppointment(id);
                Console.WriteLine("Appointment deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
