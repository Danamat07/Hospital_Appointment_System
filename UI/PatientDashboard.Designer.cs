namespace Hospital_Appointment_System.UI
{
    partial class PatientDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientTabs = new System.Windows.Forms.TabControl();
            this.tabViewAppontments = new System.Windows.Forms.TabPage();
            this.tabAddAppointment = new System.Windows.Forms.TabPage();
            this.tabUpdateAppointment = new System.Windows.Forms.TabPage();
            this.tabDeleteAppointment = new System.Windows.Forms.TabPage();
            this.dgvUpcomingAppointments = new System.Windows.Forms.DataGridView();
            this.dgvAddAppointment = new System.Windows.Forms.DataGridView();
            this.btnBackTab1 = new System.Windows.Forms.Button();
            this.btnBackTab2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAddDocSpecialization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.patientTabs.SuspendLayout();
            this.tabViewAppontments.SuspendLayout();
            this.tabAddAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAppointment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientTabs
            // 
            this.patientTabs.Controls.Add(this.tabViewAppontments);
            this.patientTabs.Controls.Add(this.tabAddAppointment);
            this.patientTabs.Controls.Add(this.tabUpdateAppointment);
            this.patientTabs.Controls.Add(this.tabDeleteAppointment);
            this.patientTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTabs.Location = new System.Drawing.Point(12, 12);
            this.patientTabs.Name = "patientTabs";
            this.patientTabs.SelectedIndex = 0;
            this.patientTabs.Size = new System.Drawing.Size(776, 426);
            this.patientTabs.TabIndex = 0;
            this.patientTabs.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabViewAppontments
            // 
            this.tabViewAppontments.Controls.Add(this.btnBackTab1);
            this.tabViewAppontments.Controls.Add(this.dgvUpcomingAppointments);
            this.tabViewAppontments.Location = new System.Drawing.Point(4, 25);
            this.tabViewAppontments.Name = "tabViewAppontments";
            this.tabViewAppontments.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAppontments.Size = new System.Drawing.Size(768, 397);
            this.tabViewAppontments.TabIndex = 0;
            this.tabViewAppontments.Text = "View Upcoming Appointments";
            this.tabViewAppontments.UseVisualStyleBackColor = true;
            // 
            // tabAddAppointment
            // 
            this.tabAddAppointment.Controls.Add(this.panel1);
            this.tabAddAppointment.Controls.Add(this.btnBackTab2);
            this.tabAddAppointment.Controls.Add(this.dgvAddAppointment);
            this.tabAddAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabAddAppointment.Name = "tabAddAppointment";
            this.tabAddAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAppointment.Size = new System.Drawing.Size(768, 397);
            this.tabAddAppointment.TabIndex = 1;
            this.tabAddAppointment.Text = "Schedule New Appoinment";
            this.tabAddAppointment.UseVisualStyleBackColor = true;
            // 
            // tabUpdateAppointment
            // 
            this.tabUpdateAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabUpdateAppointment.Name = "tabUpdateAppointment";
            this.tabUpdateAppointment.Size = new System.Drawing.Size(768, 397);
            this.tabUpdateAppointment.TabIndex = 2;
            this.tabUpdateAppointment.Text = "Update Appointment";
            this.tabUpdateAppointment.UseVisualStyleBackColor = true;
            // 
            // tabDeleteAppointment
            // 
            this.tabDeleteAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabDeleteAppointment.Name = "tabDeleteAppointment";
            this.tabDeleteAppointment.Size = new System.Drawing.Size(768, 397);
            this.tabDeleteAppointment.TabIndex = 3;
            this.tabDeleteAppointment.Text = "Cancel Appointment";
            this.tabDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // dgvUpcomingAppointments
            // 
            this.dgvUpcomingAppointments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUpcomingAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingAppointments.Location = new System.Drawing.Point(6, 6);
            this.dgvUpcomingAppointments.Name = "dgvUpcomingAppointments";
            this.dgvUpcomingAppointments.Size = new System.Drawing.Size(756, 348);
            this.dgvUpcomingAppointments.TabIndex = 0;
            // 
            // dgvAddAppointment
            // 
            this.dgvAddAppointment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAddAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAppointment.Location = new System.Drawing.Point(6, 6);
            this.dgvAddAppointment.Name = "dgvAddAppointment";
            this.dgvAddAppointment.Size = new System.Drawing.Size(360, 345);
            this.dgvAddAppointment.TabIndex = 0;
            // 
            // btnBackTab1
            // 
            this.btnBackTab1.Location = new System.Drawing.Point(356, 360);
            this.btnBackTab1.Name = "btnBackTab1";
            this.btnBackTab1.Size = new System.Drawing.Size(75, 31);
            this.btnBackTab1.TabIndex = 2;
            this.btnBackTab1.Text = "Back";
            this.btnBackTab1.UseVisualStyleBackColor = true;
            this.btnBackTab1.Click += new System.EventHandler(this.btnBackTab1_Click);
            // 
            // btnBackTab2
            // 
            this.btnBackTab2.BackColor = System.Drawing.Color.Bisque;
            this.btnBackTab2.Location = new System.Drawing.Point(337, 357);
            this.btnBackTab2.Name = "btnBackTab2";
            this.btnBackTab2.Size = new System.Drawing.Size(75, 31);
            this.btnBackTab2.TabIndex = 3;
            this.btnBackTab2.Text = "Back";
            this.btnBackTab2.UseVisualStyleBackColor = false;
            this.btnBackTab2.Click += new System.EventHandler(this.btnBackTab2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.btnAddAppointment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpAppointmentTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpAppointmentDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbAddDocSpecialization);
            this.panel1.Location = new System.Drawing.Point(382, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 345);
            this.panel1.TabIndex = 4;
            // 
            // cmbAddDocSpecialization
            // 
            this.cmbAddDocSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAddDocSpecialization.FormattingEnabled = true;
            this.cmbAddDocSpecialization.Items.AddRange(new object[] {
            "Cardiologist",
            "Dentist",
            "Dermatologist",
            "Neurologist",
            "Orthopedist",
            "Pediatrician",
            "Psychiatrist",
            "Radiologist",
            "General_Practitioner"});
            this.cmbAddDocSpecialization.Location = new System.Drawing.Point(99, 68);
            this.cmbAddDocSpecialization.Name = "cmbAddDocSpecialization";
            this.cmbAddDocSpecialization.Size = new System.Drawing.Size(179, 24);
            this.cmbAddDocSpecialization.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the type of doctor for your appointment:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(87, 147);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentDate.TabIndex = 2;
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.CustomFormat = "hh:mm tt";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(87, 220);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentTime.TabIndex = 3;
            this.dtpAppointmentTime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a date for your appointment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select preferred time for your appointment:";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.Bisque;
            this.btnAddAppointment.Location = new System.Drawing.Point(128, 276);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(110, 43);
            this.btnAddAppointment.TabIndex = 6;
            this.btnAddAppointment.Text = "Book Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // PatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.patientTabs);
            this.Name = "PatientDashboard";
            this.Text = "PatientDashboard";
            this.patientTabs.ResumeLayout(false);
            this.tabViewAppontments.ResumeLayout(false);
            this.tabAddAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAppointment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl patientTabs;
        private System.Windows.Forms.TabPage tabViewAppontments;
        private System.Windows.Forms.TabPage tabAddAppointment;
        private System.Windows.Forms.TabPage tabUpdateAppointment;
        private System.Windows.Forms.TabPage tabDeleteAppointment;
        private System.Windows.Forms.DataGridView dgvUpcomingAppointments;
        private System.Windows.Forms.DataGridView dgvAddAppointment;
        private System.Windows.Forms.Button btnBackTab1;
        private System.Windows.Forms.Button btnBackTab2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAddDocSpecialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAppointment;
    }
}