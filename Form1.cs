using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital_Appointment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // query to fetch data from Test table
            string query = "SELECT * FROM Test";

            // call DatabaseHelper to execute the query
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            // bind the fetched data to DataGridView
            dataGridView1.DataSource = dt;


        }
    }
}
