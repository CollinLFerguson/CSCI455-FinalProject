namespace EMRKS
{
    partial class Appointment_Manager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            appointmentIDBox = new TextBox();
            searchAppointmentID = new Button();
            label4 = new Label();
            addAppoint = new Button();
            addAppointment1 = new AddAppointment();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            rescheduleAppointment1 = new RescheduleAppointment();
            editAppointmentStatus1 = new EditAppointmentStatus();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(626, 126);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 1;
            label1.Text = "Scheduled Appointments";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 174);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 2;
            label2.Text = "Edit Appointment";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(45, 201);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter an appointment ID number";
            // 
            // appointmentIDBox
            // 
            appointmentIDBox.Location = new Point(233, 198);
            appointmentIDBox.Name = "appointmentIDBox";
            appointmentIDBox.Size = new Size(132, 23);
            appointmentIDBox.TabIndex = 4;
            // 
            // searchAppointmentID
            // 
            searchAppointmentID.Location = new Point(393, 199);
            searchAppointmentID.Name = "searchAppointmentID";
            searchAppointmentID.Size = new Size(75, 23);
            searchAppointmentID.TabIndex = 5;
            searchAppointmentID.Text = "Search";
            searchAppointmentID.UseVisualStyleBackColor = true;
            searchAppointmentID.Click += Edit_Appointment_Click1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 351);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 7;
            label4.Text = "Add Appointment";
            label4.Click += label4_Click;
            // 
            // addAppoint
            // 
            addAppoint.Location = new Point(179, 351);
            addAppoint.Name = "addAppoint";
            addAppoint.Size = new Size(130, 27);
            addAppoint.TabIndex = 17;
            addAppoint.Text = "+ Appointment";
            addAppoint.UseVisualStyleBackColor = true;
            addAppoint.Click += Add_Appointment_Click;
            // 
            // addAppointment1
            // 
            addAppointment1.BackColor = Color.DarkSeaGreen;
            addAppointment1.Location = new Point(43, 384);
            addAppointment1.Name = "addAppointment1";
            addAppointment1.Size = new Size(567, 120);
            addAppointment1.TabIndex = 18;
            addAppointment1.Visible = false;
            // 
            // rescheduleAppointment1
            // 
            rescheduleAppointment1.BackColor = Color.DarkSeaGreen;
            rescheduleAppointment1.Location = new Point(215, 227);
            rescheduleAppointment1.Name = "rescheduleAppointment1";
            rescheduleAppointment1.Size = new Size(454, 108);
            rescheduleAppointment1.TabIndex = 20;
            rescheduleAppointment1.Visible = false;
            // 
            // editAppointmentStatus1
            // 
            editAppointmentStatus1.BackColor = Color.DarkSeaGreen;
            editAppointmentStatus1.Location = new Point(45, 227);
            editAppointmentStatus1.Name = "editAppointmentStatus1";
            editAppointmentStatus1.Size = new Size(630, 108);
            editAppointmentStatus1.TabIndex = 21;
            editAppointmentStatus1.Visible = false;
            // 
            // Appointment_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 167, 119);
            Controls.Add(rescheduleAppointment1);
            Controls.Add(addAppointment1);
            Controls.Add(addAppoint);
            Controls.Add(label4);
            Controls.Add(searchAppointmentID);
            Controls.Add(appointmentIDBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(editAppointmentStatus1);
            Name = "Appointment_Manager";
            Size = new Size(711, 513);
            Load += Appointment_Manager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox appointmentIDBox;
        private Button searchAppointmentID;
        private Label label4;
        private Button addAppoint;
        private AddAppointment addAppointment1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RescheduleAppointment rescheduleAppointment1;
        private EditAppointmentStatus editAppointmentStatus1;
    }
}
