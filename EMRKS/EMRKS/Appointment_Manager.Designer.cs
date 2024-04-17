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
            textBox2 = new TextBox();
            appointmentStatusBox = new Label();
            label5 = new Label();
            appointmentDateTime = new Label();
            appointStatusComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            saveAppointment = new Button();
            addAppoint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(626, 143);
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
            label2.Location = new Point(43, 188);
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
            label3.Location = new Point(43, 218);
            label3.Name = "label3";
            label3.Size = new Size(181, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter an appointment ID number";
            // 
            // appointmentIDBox
            // 
            appointmentIDBox.Location = new Point(231, 215);
            appointmentIDBox.Name = "appointmentIDBox";
            appointmentIDBox.Size = new Size(132, 23);
            appointmentIDBox.TabIndex = 4;
            // 
            // searchAppointmentID
            // 
            searchAppointmentID.Location = new Point(391, 216);
            searchAppointmentID.Name = "searchAppointmentID";
            searchAppointmentID.Size = new Size(75, 23);
            searchAppointmentID.TabIndex = 5;
            searchAppointmentID.Text = "Search";
            searchAppointmentID.UseVisualStyleBackColor = true;
            searchAppointmentID.Click += Edit_Appointment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(41, 381);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 7;
            label4.Text = "Add Appointment";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.Location = new Point(269, 267);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(377, 67);
            textBox2.TabIndex = 9;
            // 
            // appointmentStatusBox
            // 
            appointmentStatusBox.AutoSize = true;
            appointmentStatusBox.Location = new Point(43, 249);
            appointmentStatusBox.Name = "appointmentStatusBox";
            appointmentStatusBox.Size = new Size(113, 15);
            appointmentStatusBox.TabIndex = 11;
            appointmentStatusBox.Text = "Appointment Status";
            appointmentStatusBox.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 249);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 12;
            label5.Text = "Appointment Notes";
            // 
            // appointmentDateTime
            // 
            appointmentDateTime.AutoSize = true;
            appointmentDateTime.Location = new Point(41, 293);
            appointmentDateTime.Name = "appointmentDateTime";
            appointmentDateTime.Size = new Size(157, 15);
            appointmentDateTime.TabIndex = 13;
            appointmentDateTime.Text = "Appointment Date and Time";
            appointmentDateTime.Click += label6_Click;
            // 
            // appointStatusComboBox
            // 
            appointStatusComboBox.FormattingEnabled = true;
            appointStatusComboBox.Items.AddRange(new object[] { "C", "M", "R", " " });
            appointStatusComboBox.Location = new Point(43, 267);
            appointStatusComboBox.MaxDropDownItems = 4;
            appointStatusComboBox.Name = "appointStatusComboBox";
            appointStatusComboBox.Size = new Size(121, 23);
            appointStatusComboBox.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(43, 311);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // saveAppointment
            // 
            saveAppointment.Location = new Point(306, 349);
            saveAppointment.Name = "saveAppointment";
            saveAppointment.Size = new Size(75, 23);
            saveAppointment.TabIndex = 16;
            saveAppointment.Text = "Save";
            saveAppointment.UseVisualStyleBackColor = true;
            // 
            // addAppoint
            // 
            addAppoint.Location = new Point(44, 405);
            addAppoint.Name = "addAppoint";
            addAppoint.Size = new Size(130, 27);
            addAppoint.TabIndex = 17;
            addAppoint.Text = "+ Appointment";
            addAppoint.UseVisualStyleBackColor = true;
            addAppoint.Click += button1_Click;
            // 
            // Appointment_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(addAppoint);
            Controls.Add(saveAppointment);
            Controls.Add(dateTimePicker1);
            Controls.Add(appointStatusComboBox);
            Controls.Add(appointmentDateTime);
            Controls.Add(label5);
            Controls.Add(appointmentStatusBox);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(searchAppointmentID);
            Controls.Add(appointmentIDBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
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
        private TextBox textBox2;
        private Label appointmentStatusBox;
        private Label label5;
        private Label appointmentDateTime;
        private ComboBox appointStatusComboBox;
        private DateTimePicker dateTimePicker1;
        private Button saveAppointment;
        private Button addAppoint;
    }
}
