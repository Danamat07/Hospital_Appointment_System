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
                LoadAppointmentsForPatient(patient.Id, dgvUpdateAppointment);
            }
            else if (patientTabs.SelectedTab == tabDeleteAppointment)
            {
                LoadAppointmentsForPatient(patient.Id, dgvCancelAppointment);
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

        private void btnBackTab3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void patientTabs_Click(object sender, EventArgs e)
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
                // check if a valid date and time has been selected
                if (selectedTime == null || selectedDate == null)
                {
                    MessageBox.Show("Please select a valid appointment date/time.");
                    return;
                }
                // combine date and time for appointment startTime
                DateTime startTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                    selectedDate.Hour, selectedDate.Minute, 0);
                // check if user selected a valid time
                if (startTime < DateTime.Now)
                {
                    MessageBox.Show("Please select a future date and time.");
                    return;
                }
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

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // get the appointment ID entered by the user
                string appointmentIdText = txtIDofAppToUpdate.Text.Trim();
                // check user input
                if (string.IsNullOrEmpty(appointmentIdText))
                {
                    MessageBox.Show("Please enter an appointment ID.");
                    return;
                }
                // parse the ID to an integer
                if (!int.TryParse(appointmentIdText, out int appointmentId))
                {
                    MessageBox.Show("Please enter a valid appointment ID.");
                    return;
                }
                // get the appointment from the controller by ID
                var appointmentToUpdate = appointmentController.GetAppointmentById(appointmentId);
                if (appointmentToUpdate == null)
                {
                    MessageBox.Show("Appointment not found.");
                    return;
                }
                // get selected date and time
                DateTime selectedDate = dtpUpdateAppointmentDate.Value.Date;
                DateTime selectedTime = dtpUpdateAppointmentTime.Value;
                // check if a valid date and time has been selected
                if (selectedTime == null || selectedDate == null)
                {
                    MessageBox.Show("Please select a valid appointment date/time.");
                    return;
                }
                // combine date and time for appointment startTime
                DateTime startTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                    selectedDate.Hour, selectedDate.Minute, 0);
                // check if user selected a valid time
                if (startTime < DateTime.Now)
                {
                    MessageBox.Show("Please select a future date and time.");
                    return;
                }
                // set endTime 30 min after startTime
                DateTime endTime = startTime.AddMinutes(30);
                var idOfDoc = appointmentToUpdate.DoctorID;
                Doctor previousDoctor = doctorController.GetDoctorById(idOfDoc);
                var specialization = previousDoctor.Specialization.ToString();
                Doctor newDoctor = doctorController.GetAvailableDoctor(specialization, startTime);
                int doctorId = newDoctor.Id;
                // update appointment
                appointmentToUpdate.StartTime = startTime;
                appointmentToUpdate.EndTime = endTime;
                appointmentToUpdate.DoctorID = doctorId;
                appointmentController.UpdateAppointment(appointmentToUpdate);
                MessageBox.Show("Appointment updated successfully!");
                // refresh appointment list
                LoadAppointmentsForPatient(patient.Id, dgvAddAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // get the appointment ID entered by the user
                string appointmentIdText = txtIDofAppToDelete.Text.Trim();
                // check user input
                if (string.IsNullOrEmpty(appointmentIdText))
                {
                    MessageBox.Show("Please enter an appointment ID.");
                    return;
                }
                // parse the ID to an integer
                if (!int.TryParse(appointmentIdText, out int appointmentId))
                {
                    MessageBox.Show("Please enter a valid appointment ID.");
                    return;
                }
                // check if appointment exists
                var appointmentToDelete = appointmentController.GetAppointmentById(appointmentId);
                if (appointmentToDelete == null)
                {
                    MessageBox.Show("Appointment not found.");
                    return;
                }
                // delete appointment
                appointmentController.DeleteAppointment(appointmentId);
                MessageBox.Show("Appointment deleted successfully!");
                // refresh appointment list
                LoadAppointmentsForPatient(patient.Id, dgvCancelAppointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dtpAppointmentTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dtpAppointmentTime.Value;
            int hour = selectedTime.Hour;
            // restrict selection between 8:00 AM and 5:00 PM
            if (hour < 8)
            {
                dtpAppointmentTime.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 8, 0, 0);
            }
            else if (hour >= 17) // 5 PM is the last valid slot
            {
                dtpAppointmentTime.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 16, 30, 0);
            }
        }

        private void dtpUpdateAppointmentTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedTime = dtpAppointmentTime.Value;
            int hour = selectedTime.Hour;
            if (hour < 8)
            {
                dtpAppointmentTime.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 8, 0, 0);
            }
            else if (hour >= 17)
            {
                dtpAppointmentTime.Value = new DateTime(selectedTime.Year, selectedTime.Month, selectedTime.Day, 16, 30, 0);
            }
        }
    }
}
