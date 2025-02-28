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
            this.patientTabs.SuspendLayout();
            this.tabViewAppontments.SuspendLayout();
            this.tabAddAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddAppointment)).BeginInit();
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
            this.dgvUpcomingAppointments.Size = new System.Drawing.Size(756, 385);
            this.dgvUpcomingAppointments.TabIndex = 0;
            // 
            // dgvAddAppointment
            // 
            this.dgvAddAppointment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAddAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddAppointment.Location = new System.Drawing.Point(6, 6);
            this.dgvAddAppointment.Name = "dgvAddAppointment";
            this.dgvAddAppointment.Size = new System.Drawing.Size(360, 262);
            this.dgvAddAppointment.TabIndex = 0;
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
    }
}