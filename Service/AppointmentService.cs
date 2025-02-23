using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Appointment_System.Domain;
using Hospital_Appointment_System.Repository;

namespace Hospital_Appointment_System.Service
{
    public class AppointmentService
    {
        private readonly AppointmentRepository appointmentRepository;

        public AppointmentService()
        {
            appointmentRepository = new AppointmentRepository();
        }

        public List<Appointment> GetAllAppointments()
        {
            try
            {
                return appointmentRepository.GetAllAppointments();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving appointments.", ex);
            }
        }

        public Appointment GetAppointmentById(int id)
        {
            try
            {
                return appointmentRepository.GetAppointmentById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the appointment with ID {id}.", ex);
            }
        }

        public void AddAppointment(Appointment appointment)
        {
            try
            {
                appointmentRepository.AddAppointment(appointment);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the appointment.", ex);
            }
        }

        public void UpdateAppointment(Appointment appointment)
        {
            try
            {
                appointmentRepository.UpdateAppointment(appointment);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while updating the appointment with ID {appointment.Id}.", ex);
            }
        }

        public void DeleteAppointment(int id)
        {
            try
            {
                appointmentRepository.DeleteAppointment(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the appointment with ID {id}.", ex);
            }
        }
    }
}
