namespace Hospital_Appointment_System.UI
{
    partial class AdminPanel
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
            this.tabAdminManageStaff = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIDofDocToUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUpdateDocSpecialization = new System.Windows.Forms.ComboBox();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateDoctorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbAddDocSpecialization = new System.Windows.Forms.ComboBox();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.txtAddDoctorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.txtIDofDocToRemove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Staff = new System.Windows.Forms.DataGridView();
            this.adminTabs = new System.Windows.Forms.TabControl();
            this.tabAdminViewSchedule = new System.Windows.Forms.TabPage();
            this.dataGridView_Schedule = new System.Windows.Forms.DataGridView();
            this.tabAdminManageAppointments = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtApIDforStatusUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbApStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateApStatus = new System.Windows.Forms.Button();
            this.tabAdminManageStaff.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Staff)).BeginInit();
            this.adminTabs.SuspendLayout();
            this.tabAdminViewSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).BeginInit();
            this.tabAdminManageAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdminManageStaff
            // 
            this.tabAdminManageStaff.Controls.Add(this.panel3);
            this.tabAdminManageStaff.Controls.Add(this.panel2);
            this.tabAdminManageStaff.Controls.Add(this.panel1);
            this.tabAdminManageStaff.Controls.Add(this.dataGridView_Staff);
            this.tabAdminManageStaff.Location = new System.Drawing.Point(4, 25);
            this.tabAdminManageStaff.Name = "tabAdminManageStaff";
            this.tabAdminManageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminManageStaff.Size = new System.Drawing.Size(768, 397);
            this.tabAdminManageStaff.TabIndex = 1;
            this.tabAdminManageStaff.Text = "Manage Staff";
            this.tabAdminManageStaff.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.txtIDofDocToUpdate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbUpdateDocSpecialization);
            this.panel3.Controls.Add(this.btnUpdateDoctor);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtUpdateDoctorName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(405, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 184);
            this.panel3.TabIndex = 6;
            // 
            // txtIDofDocToUpdate
            // 
            this.txtIDofDocToUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDofDocToUpdate.Location = new System.Drawing.Point(123, 36);
            this.txtIDofDocToUpdate.Name = "txtIDofDocToUpdate";
            this.txtIDofDocToUpdate.Size = new System.Drawing.Size(104, 22);
            this.txtIDofDocToUpdate.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Choose by ID:";
            // 
            // cmbUpdateDocSpecialization
            // 
            this.cmbUpdateDocSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateDocSpecialization.FormattingEnabled = true;
            this.cmbUpdateDocSpecialization.Items.AddRange(new object[] {
            "Cardiologist",
            "Dentist",
            "Dermatologist",
            "Neurologist",
            "Orthopedist",
            "Pediatrician",
            "Psychiatrist",
            "Radiologist",
            "General_Practitioner"});
            this.cmbUpdateDocSpecialization.Location = new System.Drawing.Point(15, 133);
            this.cmbUpdateDocSpecialization.Name = "cmbUpdateDocSpecialization";
            this.cmbUpdateDocSpecialization.Size = new System.Drawing.Size(227, 24);
            this.cmbUpdateDocSpecialization.TabIndex = 8;
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdateDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDoctor.Location = new System.Drawing.Point(250, 113);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(76, 44);
            this.btnUpdateDoctor.TabIndex = 7;
            this.btnUpdateDoctor.Text = "Update";
            this.btnUpdateDoctor.UseVisualStyleBackColor = false;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Specialization:";
            // 
            // txtUpdateDoctorName
            // 
            this.txtUpdateDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateDoctorName.Location = new System.Drawing.Point(16, 85);
            this.txtUpdateDoctorName.Name = "txtUpdateDoctorName";
            this.txtUpdateDoctorName.Size = new System.Drawing.Size(310, 22);
            this.txtUpdateDoctorName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Full Name:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(363, 18);
            this.panel6.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Update Doctor Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.cmbAddDocSpecialization);
            this.panel2.Controls.Add(this.btnAddDoctor);
            this.panel2.Controls.Add(this.txtAddDoctorName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(405, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 184);
            this.panel2.TabIndex = 5;
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
            this.cmbAddDocSpecialization.Location = new System.Drawing.Point(15, 131);
            this.cmbAddDocSpecialization.Name = "cmbAddDocSpecialization";
            this.cmbAddDocSpecialization.Size = new System.Drawing.Size(227, 24);
            this.cmbAddDocSpecialization.TabIndex = 7;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.Bisque;
            this.btnAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.Location = new System.Drawing.Point(250, 111);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(75, 44);
            this.btnAddDoctor.TabIndex = 5;
            this.btnAddDoctor.Text = "Add";
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // txtAddDoctorName
            // 
            this.txtAddDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDoctorName.Location = new System.Drawing.Point(15, 61);
            this.txtAddDoctorName.Name = "txtAddDoctorName";
            this.txtAddDoctorName.Size = new System.Drawing.Size(310, 22);
            this.txtAddDoctorName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Specialization:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Full Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 18);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add New Doctor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnDeleteDoctor);
            this.panel1.Controls.Add(this.txtIDofDocToRemove);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 83);
            this.panel1.TabIndex = 2;
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.BackColor = System.Drawing.Color.Bisque;
            this.btnDeleteDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor.Location = new System.Drawing.Point(268, 8);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteDoctor.TabIndex = 7;
            this.btnDeleteDoctor.Text = "Delete";
            this.btnDeleteDoctor.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // txtIDofDocToRemove
            // 
            this.txtIDofDocToRemove.BackColor = System.Drawing.SystemColors.Info;
            this.txtIDofDocToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDofDocToRemove.Location = new System.Drawing.Point(148, 15);
            this.txtIDofDocToRemove.Name = "txtIDofDocToRemove";
            this.txtIDofDocToRemove.Size = new System.Drawing.Size(104, 22);
            this.txtIDofDocToRemove.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Doctor:\r\n (choose by id)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danger zone: This employee will be removed!";
            // 
            // dataGridView_Staff
            // 
            this.dataGridView_Staff.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Staff.Location = new System.Drawing.Point(6, 17);
            this.dataGridView_Staff.Name = "dataGridView_Staff";
            this.dataGridView_Staff.Size = new System.Drawing.Size(390, 285);
            this.dataGridView_Staff.TabIndex = 0;
            // 
            // adminTabs
            // 
            this.adminTabs.Controls.Add(this.tabAdminViewSchedule);
            this.adminTabs.Controls.Add(this.tabAdminManageStaff);
            this.adminTabs.Controls.Add(this.tabAdminManageAppointments);
            this.adminTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabs.Location = new System.Drawing.Point(12, 12);
            this.adminTabs.Name = "adminTabs";
            this.adminTabs.SelectedIndex = 0;
            this.adminTabs.Size = new System.Drawing.Size(776, 426);
            this.adminTabs.TabIndex = 0;
            this.adminTabs.SelectedIndexChanged += new System.EventHandler(this.adminTabs_SelectedIndexChanged);
            // 
            // tabAdminViewSchedule
            // 
            this.tabAdminViewSchedule.Controls.Add(this.dataGridView_Schedule);
            this.tabAdminViewSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabAdminViewSchedule.Name = "tabAdminViewSchedule";
            this.tabAdminViewSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminViewSchedule.Size = new System.Drawing.Size(768, 397);
            this.tabAdminViewSchedule.TabIndex = 0;
            this.tabAdminViewSchedule.Text = "View Schedule";
            this.tabAdminViewSchedule.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Schedule
            // 
            this.dataGridView_Schedule.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView_Schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Schedule.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_Schedule.Name = "dataGridView_Schedule";
            this.dataGridView_Schedule.Size = new System.Drawing.Size(756, 385);
            this.dataGridView_Schedule.TabIndex = 0;
            // 
            // tabAdminManageAppointments
            // 
            this.tabAdminManageAppointments.Controls.Add(this.panel5);
            this.tabAdminManageAppointments.Controls.Add(this.dataGridView1);
            this.tabAdminManageAppointments.Location = new System.Drawing.Point(4, 25);
            this.tabAdminManageAppointments.Name = "tabAdminManageAppointments";
            this.tabAdminManageAppointments.Size = new System.Drawing.Size(768, 397);
            this.tabAdminManageAppointments.TabIndex = 2;
            this.tabAdminManageAppointments.Text = "Manage Appointments Status";
            this.tabAdminManageAppointments.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.btnUpdateApStatus);
            this.panel5.Controls.Add(this.cmbApStatus);
            this.panel5.Controls.Add(this.txtApIDforStatusUpdate);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(393, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(372, 391);
            this.panel5.TabIndex = 1;
            // 
            // txtApIDforStatusUpdate
            // 
            this.txtApIDforStatusUpdate.Location = new System.Drawing.Point(120, 91);
            this.txtApIDforStatusUpdate.Name = "txtApIDforStatusUpdate";
            this.txtApIDforStatusUpdate.Size = new System.Drawing.Size(103, 22);
            this.txtApIDforStatusUpdate.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "New Status:";
            // 
            // cmbApStatus
            // 
            this.cmbApStatus.FormattingEnabled = true;
            this.cmbApStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Completed",
            "Canceled",
            "Missed"});
            this.cmbApStatus.Location = new System.Drawing.Point(100, 175);
            this.cmbApStatus.Name = "cmbApStatus";
            this.cmbApStatus.Size = new System.Drawing.Size(143, 24);
            this.cmbApStatus.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Select the appointment whose status you want \r\nto change (enter ID of appointment" +
    "):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateApStatus
            // 
            this.btnUpdateApStatus.BackColor = System.Drawing.Color.Bisque;
            this.btnUpdateApStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateApStatus.Location = new System.Drawing.Point(138, 238);
            this.btnUpdateApStatus.Name = "btnUpdateApStatus";
            this.btnUpdateApStatus.Size = new System.Drawing.Size(76, 44);
            this.btnUpdateApStatus.TabIndex = 8;
            this.btnUpdateApStatus.Text = "Update";
            this.btnUpdateApStatus.UseVisualStyleBackColor = false;
            this.btnUpdateApStatus.Click += new System.EventHandler(this.btnUpdateApStatus_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminTabs);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.tabAdminManageStaff.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Staff)).EndInit();
            this.adminTabs.ResumeLayout(false);
            this.tabAdminViewSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).EndInit();
            this.tabAdminManageAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdminManageStaff;
        private System.Windows.Forms.TabControl adminTabs;
        private System.Windows.Forms.TabPage tabAdminViewSchedule;
        private System.Windows.Forms.DataGridView dataGridView_Schedule;
        private System.Windows.Forms.DataGridView dataGridView_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDofDocToRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddDoctorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateDoctorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.ComboBox cmbUpdateDocSpecialization;
        private System.Windows.Forms.ComboBox cmbAddDocSpecialization;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDofDocToUpdate;
        private System.Windows.Forms.TabPage tabAdminManageAppointments;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtApIDforStatusUpdate;
        private System.Windows.Forms.ComboBox cmbApStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateApStatus;
    }
}