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
                LoadAppointmentsForPatient(patient.Id);
            }
            else if (patientTabs.SelectedTab == tabAddAppointment)
            {
                // to do
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

        private void LoadAppointmentsForPatient(int patientId)
        {
            try
            {
                // get the list of appointments from the controller
                var appointments = appointmentController.GetAppointmentsByPatientId(patientId);
                // bind the appointments list to the DataGridView
                dgvUpcomingAppointments.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
