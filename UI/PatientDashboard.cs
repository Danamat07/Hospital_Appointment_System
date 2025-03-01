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
        private Patient patient;

        public PatientDashboard(Patient loggedPatient)
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
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

        //ScheduleNewAppointment()
        //{
        //    try
        //    {
        //        // Get selected date
        //        DateTime selectedDate = dtpAppointmentDate.Value.Date;
        //        // Get selected time
        //        DateTime selectedTime = dtpAppointmentTime.Value;
        //        // Combine date and time into one DateTime object
        //        DateTime appointmentStartDateTime = new DateTime(
        //            selectedDate.Year, selectedDate.Month, selectedDate.Day,
        //            selectedTime.Hour, selectedTime.Minute, 0
        //        );
        //        int patientId = patient.Id;
        //        // -------------------------------------------------------------------------
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}");
        //    }
        //}

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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
