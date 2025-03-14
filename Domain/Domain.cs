﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Appointment_System.Domain
{
    public class Patient
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
        Cardiologist,
        Dentist,
        Dermatologist,
        Neurologist,
        Orthopedist,
        Pediatrician,
        Psychiatrist,
        Radiologist,
        General_Practitioner
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Specialisation Specialization { get; set; }

        public Doctor(int id, string name, Specialisation specialization)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
        }
    }

    public enum AppointmentStatus
    {
        Scheduled,
        Completed,
        Cancelled,
        Missed
    }

    public class Appointment
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
