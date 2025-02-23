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
    public class AppointmentController
    {
        private readonly AppointmentService appointmentService;

        public AppointmentController()
        {
            appointmentService = new AppointmentService();
        }

        public void DisplayAllAppointments()
        {
            try
            {
                var appointments = appointmentService.GetAllAppointments();
                foreach (var appointment in appointments)
                {
                    Console.WriteLine($"ID: {appointment.Id}, PatientID: {appointment.PatientID}, DoctorID: {appointment.DoctorID}, Start: {appointment.StartTime}, End: {appointment.EndTime}, Status: {appointment.Status}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void AddAppointment(Appointment appointment)
        {
            try
            {
                appointmentService.AddAppointment(appointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                appointmentService.UpdateAppointment(appointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void DeleteAppointment(int id)
        {
            try
            {
                appointmentService.DeleteAppointment(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
