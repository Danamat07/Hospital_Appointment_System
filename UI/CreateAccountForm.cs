using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Appointment_System.Controller;
using Hospital_Appointment_System.Domain;

namespace Hospital_Appointment_System.UI
{
    public partial class CreateAccountForm : Form
    {
        private PatientController patientController;
        public CreateAccountForm()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        // create new account button click
        private void btnCreateNewAccount_Click(object sender, EventArgs e)
        {
            string name = txtNewName.Text.Trim();
            string email = txtNewEmail.Text.Trim();
            string phone = txtNewPhone.Text.Trim();
            string password = txtNewPassword.Text.Trim();

            // validate input
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password){
                MessageBox.Show("Please fill in the required fields.");
                return;
            }
            // validate name
            if (name.Length < 3 || name.Any(char.IsDigit))
            {
                MessageBox.Show("Name must be at least 3 letters long and contain no numbers.");
                return;
            }
            // validate password
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }
            // validate email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            try
            {
                // create new patient object
                Patient newPatient = new Patient(0, name, email, phone, password);
                // save patient to database
                bool isCreated = patientController.AddPatient(newPatient);
                if (isCreated)
                {
                    // switch to login form
                    MessageBox.Show("Account created successfully!");
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("An error occurred while creating the account. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
