using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Appointment_System.Domain
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public Patient(int id, string name, string email, string phone, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
        }
    }

    public enum Specialisation
    {
        General_Practitioner,
        Cardiologist,
        Dermatologist,
        Neurologist,
        Pediatrician,
        Orthopedic,
        Psychiatrist,
        Radiologist,
        Surgeon,
        Dentist
    }

    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Specialisation Specialization { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Doctor(int id, string name, Specialisation specialization, string phone, string email)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
            Phone = phone;
            Email = email;
        }
    }

    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Cancelled,
        Missed
    }

    internal class Appointment
    {
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public AppointmentStatus Status { get; set; }

        public Appointment(int id, int patientID, int doctorID, DateTime startTime, DateTime endTime, AppointmentStatus status)
        {
            Id = id;
            PatientID = patientID;
            DoctorID = doctorID;
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
        }
    }
}
