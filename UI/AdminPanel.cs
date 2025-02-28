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
using Mysqlx;

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
                LoadDoctors();
            }
            else if (adminTabs.SelectedTab == tabAdminManageAppointments)
            {
                UpdateAppointmentStatus();
            }
        }

        private void UpdateAppointmentStatus()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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

        // method to load all doctors from the dadabase and display in DataGridView
        private void LoadDoctors()
        {
            try
            {
                var doctors = doctorController.GetAllDoctors();
                dataGridView_Staff.DataSource = doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                string doctorName = txtAddDoctorName.Text.Trim();
                // check input for doctor name
                if (string.IsNullOrEmpty(doctorName))
                {
                    MessageBox.Show("Please enter doctor name.");
                    return;
                }
                if (doctorName.Length < 3 || doctorName.Any(char.IsDigit))
                {
                    MessageBox.Show("Name must be at least 3 letters long and contain no numbers.");
                    return;
                }
                // get selected specialization from comboBox
                var selectedSpecialization = cmbAddDocSpecialization.SelectedItem?.ToString();
                // check input for specialization
                if (string.IsNullOrEmpty(selectedSpecialization))
                {
                    MessageBox.Show("Please select a specialization.");
                    return;
                }
                // convert specialization to enum type
                var specialization = (Specialisation)Enum.Parse(typeof(Specialisation), selectedSpecialization);
                // add doctor
                doctorController.AddDoctor(new Doctor(0, doctorName, specialization));
                MessageBox.Show("Doctor added successfully!");
                // refresh staff list
                LoadDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}");
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                // get the doctor ID entered by the user
                string doctorIdText = txtIDofDocToUpdate.Text.Trim();
                // check user input
                if (string.IsNullOrEmpty(doctorIdText))
                {
                    MessageBox.Show("Please enter a doctor ID.");
                    return;
                }
                // parse the ID to an integer
                if (!int.TryParse(doctorIdText, out int doctorId))
                {
                    MessageBox.Show("Please enter a valid doctor ID.");
                    return;
                }
                // get the doctor from the controller by ID
                var doctorToUpdate = doctorController.GetDoctorById(doctorId);
                if (doctorToUpdate == null)
                {
                    MessageBox.Show("Doctor not found.");
                    return;
                }
                // get the updated name from the textBox
                string updatedDoctorName = txtUpdateDoctorName.Text.Trim();
                // check user input for doctor name
                if (string.IsNullOrEmpty(updatedDoctorName))
                {
                    MessageBox.Show("Please enter doctor name.");
                    return;
                }
                if (updatedDoctorName.Length < 3 || updatedDoctorName.Any(char.IsDigit))
                {
                    MessageBox.Show("Name must be at least 3 letters long and contain no numbers.");
                    return;
                }
                // get selected specialization from comboBox
                var selectedSpecialization = cmbUpdateDocSpecialization.SelectedItem?.ToString();
                // check input for specialization
                if (string.IsNullOrEmpty(selectedSpecialization))
                {
                    MessageBox.Show("Please select a specialization.");
                    return;
                }
                // convert specialization to enum type
                var updatedSpecialization = (Specialisation)Enum.Parse(typeof(Specialisation), selectedSpecialization);
                // update doctor
                doctorToUpdate.Name = updatedDoctorName;
                doctorToUpdate.Specialization = updatedSpecialization;
                doctorController.UpdateDoctor(doctorToUpdate);
                MessageBox.Show("Doctor updated successfully!");
                // refresh staff list
                LoadDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating doctor: {ex.Message}");
            }
        }

        private void btnUpdateApStatus_Click(object sender, EventArgs e)
        {
            // get ID of appointment entered by user
            string appointmentIdText = txtApIDforStatusUpdate.Text.Trim();
            // check user input
            if (string.IsNullOrEmpty(appointmentIdText))
            {
                MessageBox.Show("Please enter an appointment ID.");
                return;
            }
            // parse string ID to integer ID
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
            // get selected status from comboBox
            var selectedStatus = cmbApStatus.SelectedItem?.ToString();
            // check input for status
            if (string.IsNullOrEmpty(selectedStatus))
            {
                MessageBox.Show("Please select a status.");
                return;
            }
            // convert status to enum type
            var updatedStatus = (AppointmentStatus)Enum.Parse(typeof(AppointmentStatus), selectedStatus);
            // update appointment
            appointmentToUpdate.Status = updatedStatus;
            appointmentController.UpdateAppointment(appointmentToUpdate);
            MessageBox.Show("Appointment updated successfully!");
            // refresh appointment list
            LoadAppointments();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                // get the doctor ID entered by the user
                string doctorIdText = txtIDofDocToRemove.Text.Trim();
                // check user input
                if (string.IsNullOrEmpty(doctorIdText))
                {
                    MessageBox.Show("Please enter a doctor ID.");
                    return;
                }
                // parse the ID to an integer
                if (!int.TryParse(doctorIdText, out int doctorId))
                {
                    MessageBox.Show("Please enter a valid doctor ID.");
                    return;
                }
                // check if the doctor exists
                var doctorToDelete = doctorController.GetDoctorById(doctorId);

                if (doctorToDelete == null)
                {
                    MessageBox.Show("Doctor not found.");
                    return;
                }
                // delete the doctor
                doctorController.DeleteDoctor(doctorToDelete.Id);
                MessageBox.Show("Doctor deleted successfully!");
                // refresh staff list
                LoadDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting doctor: {ex.Message}");
            }
        }

        // method to return to login/main page
        private void btnBackTab1_Click(object sender, EventArgs e)
        {
            // Hide current form
            this.Hide();
            // Create a new instance of the LoginForm
            LoginForm loginForm = new LoginForm();
            // Show the login form
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
    }
}
