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
    public partial class LoginForm : Form
    {
        private PatientController patientController;
        private const string AdminPassword = "admin123";

        public LoginForm()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        // patient login button click
        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            // get input from textboxes
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            try
            {
                // authenticate the patient
                Patient patient = patientController.Authenticate(email, password);
                if (patient != null)
                {
                    // switch to patient dashboard
                    PatientDashboard dashboard = new PatientDashboard(patient);
                    this.Hide();
                    dashboard.Show();
                    // successful login
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    // invalid email or password
                    MessageBox.Show("Invalid email address or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // admin login button click
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string adminPassword = txtAdminPassword.Text.Trim();
            if (adminPassword == AdminPassword)
            {
                // switch to admin panel
                AdminPanel panel = new AdminPanel();
                this.Hide();
                panel.Show();
                // successful admin login
                MessageBox.Show("Login Successful!");
            }
            else
            {
                // invalid password
                MessageBox.Show("Invalid password.\n(this option is only for admin users)");
            }
        }

        // create account button click
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // switch directly to create account form
            CreateAccountForm form = new CreateAccountForm();
            this.Hide();
            form.Show();
            MessageBox.Show("Account created successfuly!");
        }
    }
}
