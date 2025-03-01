using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Appointment_System.Controller;
using Hospital_Appointment_System.Domain;

namespace Hospital_Appointment_System.UI
{
    public partial class PatientDashboard : Form
    {
        private AppointmentController appointmentController;
        private DoctorController doctorController;
        private Patient patient;

        public PatientDashboard(Patient loggedPatient)
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            doctorController = new DoctorController();
            patient = loggedPatient;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (patientTabs.SelectedTab == tabViewAppontments)
            {
                LoadAppointmentsForPatient(patient.Id, dgvUpcomingAppointments);
            }
            else if (patientTabs.SelectedTab == tabAddAppointment)
            {
                LoadAppointmentsForPatient(patient.Id, dgvAddAppointment);
            }
            else if (patientTabs.SelectedTab == tabUpdateAppointment)
            {
                // to do
            }
            else if (patientTabs.SelectedTab == tabDeleteAppointment)
            {
                // to do
            }
        }

        private void LoadAppointmentsForPatient(int patientId, DataGridView dgv)
        {
            try
            {
                // get the list of appointments from the controller
                var appointments = appointmentController.GetAppointmentsByPatientId(patientId);
                // bind the appointments list to the DataGridView
                dgv.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBackTab1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnBackTab2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // get selected date and time
                DateTime selectedDate = dtpAppointmentDate.Value.Date;
                DateTime selectedTime = dtpAppointmentTime.Value;
                // combine date and time for appointment startTime
                DateTime startTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                    selectedDate.Hour, selectedDate.Minute, 0);
                // set endTime 30 min after startTime
                DateTime endTime = startTime.AddMinutes(30);
                // get selected doctor specialization
                string specialization = cmbAddDocSpecialization.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(specialization))
                {
                    MessageBox.Show("Please select a doctor specialization.");
                    return;
                }
                // get available doctor based on specialization
                Doctor doctor = doctorController.GetAvailableDoctor(specialization, startTime);
                if (doctor == null)
                {
                    MessageBox.Show("No available doctor found for the selected specialization and time.");
                    return;
                }
                // create new appointment object
                Appointment appointment = new Appointment(0, patient.Id, doctor.Id, startTime, endTime, AppointmentStatus.Scheduled);
                appointmentController.AddAppointment(appointment);
                MessageBox.Show("Appointment booked successfully!");
                // refresh appointment list
                LoadAppointmentsForPatient(patient.Id, dgvAddAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
