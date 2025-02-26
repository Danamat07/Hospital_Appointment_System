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
            this.adminTabs = new System.Windows.Forms.TabControl();
            this.tabAdminViewSchedule = new System.Windows.Forms.TabPage();
            this.dataGridView_Schedule = new System.Windows.Forms.DataGridView();
            this.adminTabs.SuspendLayout();
            this.tabAdminViewSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdminManageStaff
            // 
            this.tabAdminManageStaff.Location = new System.Drawing.Point(4, 25);
            this.tabAdminManageStaff.Name = "tabAdminManageStaff";
            this.tabAdminManageStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminManageStaff.Size = new System.Drawing.Size(768, 397);
            this.tabAdminManageStaff.TabIndex = 1;
            this.tabAdminManageStaff.Text = "Manage Staff";
            this.tabAdminManageStaff.UseVisualStyleBackColor = true;
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
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminTabs);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.adminTabs.ResumeLayout(false);
            this.tabAdminViewSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAdminManageStaff;
        private System.Windows.Forms.TabControl adminTabs;
        private System.Windows.Forms.TabPage tabAdminViewSchedule;
        private System.Windows.Forms.DataGridView dataGridView_Schedule;
    }
}