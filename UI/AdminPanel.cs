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

namespace Hospital_Appointment_System.UI
{
    public partial class AdminPanel : Form
    {
        private AppointmentController appointmentController;
        private DoctorController doctorController;

        public AdminPanel()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            doctorController = new DoctorController();
        }

        private void adminTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load appointments into the DataGridView when the View Schedule tab is clicked
            if (adminTabs.SelectedTab == tabAdminViewSchedule)
            {
                LoadAppointments();
            }
            else if (adminTabs.SelectedTab == tabAdminManageStaff)
            {
                // to do
            }
        }

        // method to load all appointments from the database and display in DataGridView
        private void LoadAppointments()
        {
            try
            {
                // get the list of appointments from the controller
                var appointments = appointmentController.GetAllAppointments();
                // bind the appointments list to the DataGridView
                dataGridView_Schedule.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
