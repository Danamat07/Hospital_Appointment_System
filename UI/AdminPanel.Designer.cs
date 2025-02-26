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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminTabs = new System.Windows.Forms.TabControl();
            this.tabAdminViewSchedule = new System.Windows.Forms.TabPage();
            this.dataGridView_Schedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDofDocToRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddDoctorName = new System.Windows.Forms.TextBox();
            this.clbAddDocSpecialisation = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateDoctorName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clbUpdateDocSpecialisation = new System.Windows.Forms.CheckedListBox();
            this.tabAdminManageStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.adminTabs.SuspendLayout();
            this.tabAdminViewSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdminManageStaff
            // 
            this.tabAdminManageStaff.Controls.Add(this.panel3);
            this.tabAdminManageStaff.Controls.Add(this.panel2);
            this.tabAdminManageStaff.Controls.Add(this.panel1);
            this.tabAdminManageStaff.Controls.Add(this.dataGridView1);
            this.tabAdminManageStaff.Location = new System.Drawing.Point(4, 25);
            this.tabAdminManageStaff.Name = "tabAdminManageStaff";
            this.tabAdminManageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminManageStaff.Size = new System.Drawing.Size(768, 397);
            this.tabAdminManageStaff.TabIndex = 1;
            this.tabAdminManageStaff.Text = "Manage Staff";
            this.tabAdminManageStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // adminTabs
            // 
            this.adminTabs.Controls.Add(this.tabAdminViewSchedule);
            this.adminTabs.Controls.Add(this.tabAdminManageStaff);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.txtIDofDocToRemove);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 83);
            this.panel1.TabIndex = 2;
            // 
            // txtIDofDocToRemove
            // 
            this.txtIDofDocToRemove.BackColor = System.Drawing.SystemColors.Info;
            this.txtIDofDocToRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDofDocToRemove.Location = new System.Drawing.Point(149, 12);
            this.txtIDofDocToRemove.Name = "txtIDofDocToRemove";
            this.txtIDofDocToRemove.Size = new System.Drawing.Size(216, 22);
            this.txtIDofDocToRemove.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.clbAddDocSpecialisation);
            this.panel2.Controls.Add(this.txtAddDoctorName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(405, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 184);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.clbUpdateDocSpecialisation);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtUpdateDoctorName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(405, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 184);
            this.panel3.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Update Doctor Info";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Full Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Specialization:";
            // 
            // txtAddDoctorName
            // 
            this.txtAddDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDoctorName.Location = new System.Drawing.Point(15, 49);
            this.txtAddDoctorName.Name = "txtAddDoctorName";
            this.txtAddDoctorName.Size = new System.Drawing.Size(310, 22);
            this.txtAddDoctorName.TabIndex = 3;
            // 
            // clbAddDocSpecialisation
            // 
            this.clbAddDocSpecialisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAddDocSpecialisation.FormattingEnabled = true;
            this.clbAddDocSpecialisation.Items.AddRange(new object[] {
            "Cardiologist",
            "Dentist",
            "Dermatologist",
            "Neurologist",
            "Orthopedist",
            "Pediatrician",
            "Psychiatrist",
            "Radiologist",
            "General_Practitioner"});
            this.clbAddDocSpecialisation.Location = new System.Drawing.Point(15, 102);
            this.clbAddDocSpecialisation.Name = "clbAddDocSpecialisation";
            this.clbAddDocSpecialisation.Size = new System.Drawing.Size(227, 72);
            this.clbAddDocSpecialisation.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Full Name:";
            // 
            // txtUpdateDoctorName
            // 
            this.txtUpdateDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateDoctorName.Location = new System.Drawing.Point(15, 52);
            this.txtUpdateDoctorName.Name = "txtUpdateDoctorName";
            this.txtUpdateDoctorName.Size = new System.Drawing.Size(310, 22);
            this.txtUpdateDoctorName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Specialization:";
            // 
            // clbUpdateDocSpecialisation
            // 
            this.clbUpdateDocSpecialisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUpdateDocSpecialisation.FormattingEnabled = true;
            this.clbUpdateDocSpecialisation.Items.AddRange(new object[] {
            "Cardiologist",
            "Dentist",
            "Dermatologist",
            "Neurologist",
            "Orthopedist",
            "Pediatrician",
            "Psychiatrist",
            "Radiologist",
            "General_Practitioner"});
            this.clbUpdateDocSpecialisation.Location = new System.Drawing.Point(15, 105);
            this.clbUpdateDocSpecialisation.Name = "clbUpdateDocSpecialisation";
            this.clbUpdateDocSpecialisation.Size = new System.Drawing.Size(227, 72);
            this.clbUpdateDocSpecialisation.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.adminTabs.ResumeLayout(false);
            this.tabAdminViewSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdminManageStaff;
        private System.Windows.Forms.TabControl adminTabs;
        private System.Windows.Forms.TabPage tabAdminViewSchedule;
        private System.Windows.Forms.DataGridView dataGridView_Schedule;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.CheckedListBox clbAddDocSpecialisation;
        private System.Windows.Forms.TextBox txtAddDoctorName;
        private System.Windows.Forms.CheckedListBox clbUpdateDocSpecialisation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateDoctorName;
        private System.Windows.Forms.Label label7;
    }
}