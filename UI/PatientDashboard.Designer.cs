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
            this.btnBackTab1 = new System.Windows.Forms.Button();
            this.dgvUpcomingAppointments = new System.Windows.Forms.DataGridView();
            this.tabAddAppointment = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAddDocSpecialization = new System.Windows.Forms.ComboBox();
            this.btnBackTab2 = new System.Windows.Forms.Button();
            this.dgvAddAppointment = new System.Windows.Forms.DataGridView();
            this.tabUpdateAppointment = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.dtpUpdateAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpUpdateAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDofAppToUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackTab3 = new System.Windows.Forms.Button();
            this.dgvUpdateAppointment = new System.Windows.Forms.DataGridView();
            this.tabDeleteAppointment = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.txtIDofAppToDelete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackTab4 = new System.Windows.Forms.Button();
            this.dgvCancelAppointment = new System.Windows.Forms.DataGridView();
            this.patientTabs.SuspendLayout();
            this.tabViewAppontments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).BeginInit();
            this.tabAddAppointment.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAppointment)).BeginInit();
            this.tabUpdateAppointment.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateAppointment)).BeginInit();
            this.tabDeleteAppointment.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelAppointment)).BeginInit();
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
            // dgvUpcomingAppointments
            // 
            this.dgvUpcomingAppointments.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUpcomingAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingAppointments.Location = new System.Drawing.Point(6, 6);
            this.dgvUpcomingAppointments.Name = "dgvUpcomingAppointments";
            this.dgvUpcomingAppointments.Size = new System.Drawing.Size(756, 348);
            this.dgvUpcomingAppointments.TabIndex = 0;
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
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.Bisque;
            this.btnAddAppointment.Location = new System.Drawing.Point(128, 276);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(110, 43);
            this.btnAddAppointment.TabIndex = 6;
            this.btnAddAppointment.Text = "Book Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
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
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.CustomFormat = "hh:mm tt";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(87, 220);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentTime.TabIndex = 3;
            this.dtpAppointmentTime.ValueChanged += new System.EventHandler(this.dtpAppointmentTime_ValueChanged);
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
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(87, 147);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentDate.TabIndex = 2;
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
            // dgvAddAppointment
            // 
            this.dgvAddAppointment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAddAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAppointment.Location = new System.Drawing.Point(6, 6);
            this.dgvAddAppointment.Name = "dgvAddAppointment";
            this.dgvAddAppointment.Size = new System.Drawing.Size(360, 345);
            this.dgvAddAppointment.TabIndex = 0;
            // 
            // tabUpdateAppointment
            // 
            this.tabUpdateAppointment.Controls.Add(this.panel2);
            this.tabUpdateAppointment.Controls.Add(this.btnBackTab3);
            this.tabUpdateAppointment.Controls.Add(this.dgvUpdateAppointment);
            this.tabUpdateAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabUpdateAppointment.Name = "tabUpdateAppointment";
            this.tabUpdateAppointment.Size = new System.Drawing.Size(768, 397);
            this.tabUpdateAppointment.TabIndex = 2;
            this.tabUpdateAppointment.Text = "Update Appointment";
            this.tabUpdateAppointment.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.btnUpdateAppointment);
            this.panel2.Controls.Add(this.dtpUpdateAppointmentDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpUpdateAppointmentTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtIDofAppToUpdate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(379, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 345);
            this.panel2.TabIndex = 5;
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdateAppointment.Location = new System.Drawing.Point(120, 262);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(110, 43);
            this.btnUpdateAppointment.TabIndex = 7;
            this.btnUpdateAppointment.Text = "Update Appointment";
            this.btnUpdateAppointment.UseVisualStyleBackColor = false;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // dtpUpdateAppointmentDate
            // 
            this.dtpUpdateAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdateAppointmentDate.Location = new System.Drawing.Point(79, 143);
            this.dtpUpdateAppointmentDate.Name = "dtpUpdateAppointmentDate";
            this.dtpUpdateAppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpUpdateAppointmentDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "New Date:";
            // 
            // dtpUpdateAppointmentTime
            // 
            this.dtpUpdateAppointmentTime.CustomFormat = "hh:mm tt";
            this.dtpUpdateAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateAppointmentTime.Location = new System.Drawing.Point(79, 205);
            this.dtpUpdateAppointmentTime.Name = "dtpUpdateAppointmentTime";
            this.dtpUpdateAppointmentTime.ShowUpDown = true;
            this.dtpUpdateAppointmentTime.Size = new System.Drawing.Size(200, 22);
            this.dtpUpdateAppointmentTime.TabIndex = 4;
            this.dtpUpdateAppointmentTime.ValueChanged += new System.EventHandler(this.dtpUpdateAppointmentTime_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "New Time:";
            // 
            // txtIDofAppToUpdate
            // 
            this.txtIDofAppToUpdate.Location = new System.Drawing.Point(129, 82);
            this.txtIDofAppToUpdate.Name = "txtIDofAppToUpdate";
            this.txtIDofAppToUpdate.Size = new System.Drawing.Size(90, 22);
            this.txtIDofAppToUpdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Choose which appontment you want to update\r\n                            (enter ID" +
    "):";
            // 
            // btnBackTab3
            // 
            this.btnBackTab3.BackColor = System.Drawing.Color.Bisque;
            this.btnBackTab3.Location = new System.Drawing.Point(339, 363);
            this.btnBackTab3.Name = "btnBackTab3";
            this.btnBackTab3.Size = new System.Drawing.Size(75, 31);
            this.btnBackTab3.TabIndex = 4;
            this.btnBackTab3.Text = "Back";
            this.btnBackTab3.UseVisualStyleBackColor = false;
            this.btnBackTab3.Click += new System.EventHandler(this.btnBackTab3_Click);
            // 
            // dgvUpdateAppointment
            // 
            this.dgvUpdateAppointment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUpdateAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateAppointment.Location = new System.Drawing.Point(13, 12);
            this.dgvUpdateAppointment.Name = "dgvUpdateAppointment";
            this.dgvUpdateAppointment.Size = new System.Drawing.Size(360, 345);
            this.dgvUpdateAppointment.TabIndex = 1;
            // 
            // tabDeleteAppointment
            // 
            this.tabDeleteAppointment.Controls.Add(this.panel3);
            this.tabDeleteAppointment.Controls.Add(this.btnBackTab4);
            this.tabDeleteAppointment.Controls.Add(this.dgvCancelAppointment);
            this.tabDeleteAppointment.Location = new System.Drawing.Point(4, 25);
            this.tabDeleteAppointment.Name = "tabDeleteAppointment";
            this.tabDeleteAppointment.Size = new System.Drawing.Size(768, 397);
            this.tabDeleteAppointment.TabIndex = 3;
            this.tabDeleteAppointment.Text = "Cancel Appointment";
            this.tabDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.btnDeleteAppointment);
            this.panel3.Controls.Add(this.txtIDofAppToDelete);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(379, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 345);
            this.panel3.TabIndex = 6;
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.Bisque;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(125, 215);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(110, 43);
            this.btnDeleteAppointment.TabIndex = 8;
            this.btnDeleteAppointment.Text = "Cancel Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // txtIDofAppToDelete
            // 
            this.txtIDofAppToDelete.Location = new System.Drawing.Point(135, 143);
            this.txtIDofAppToDelete.Name = "txtIDofAppToDelete";
            this.txtIDofAppToDelete.Size = new System.Drawing.Size(90, 22);
            this.txtIDofAppToDelete.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Choose which appontment you want to cancel\r\n                            (enter ID" +
    "):";
            // 
            // btnBackTab4
            // 
            this.btnBackTab4.BackColor = System.Drawing.Color.Bisque;
            this.btnBackTab4.Location = new System.Drawing.Point(338, 363);
            this.btnBackTab4.Name = "btnBackTab4";
            this.btnBackTab4.Size = new System.Drawing.Size(75, 31);
            this.btnBackTab4.TabIndex = 4;
            this.btnBackTab4.Text = "Back";
            this.btnBackTab4.UseVisualStyleBackColor = false;
            this.btnBackTab4.Click += new System.EventHandler(this.btnBackTab4_Click);
            // 
            // dgvCancelAppointment
            // 
            this.dgvCancelAppointment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCancelAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancelAppointment.Location = new System.Drawing.Point(13, 13);
            this.dgvCancelAppointment.Name = "dgvCancelAppointment";
            this.dgvCancelAppointment.Size = new System.Drawing.Size(360, 345);
            this.dgvCancelAppointment.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).EndInit();
            this.tabAddAppointment.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAppointment)).EndInit();
            this.tabUpdateAppointment.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateAppointment)).EndInit();
            this.tabDeleteAppointment.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancelAppointment)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvUpdateAppointment;
        private System.Windows.Forms.DataGridView dgvCancelAppointment;
        private System.Windows.Forms.Button btnBackTab3;
        private System.Windows.Forms.Button btnBackTab4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIDofAppToUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.DateTimePicker dtpUpdateAppointmentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpUpdateAppointmentTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDofAppToDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteAppointment;
    }
}