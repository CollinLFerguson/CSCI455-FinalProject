namespace EMRKS
{
    partial class AddAppointment
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
            AddAppointDTP = new DateTimePicker();
            appointmentDateTime = new Label();
            saveAppointment = new Button();
            label5 = new Label();
            AppointNotes = new TextBox();
            CancelNewAppointment = new Button();
            SuspendLayout();
            // 
            // AddAppointDTP
            // 
            AddAppointDTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            AddAppointDTP.Format = DateTimePickerFormat.Custom;
            AddAppointDTP.Location = new Point(14, 29);
            AddAppointDTP.Name = "AddAppointDTP";
            AddAppointDTP.Size = new Size(146, 23);
            AddAppointDTP.TabIndex = 17;
            // 
            // appointmentDateTime
            // 
            appointmentDateTime.AutoSize = true;
            appointmentDateTime.Location = new Point(12, 11);
            appointmentDateTime.Name = "appointmentDateTime";
            appointmentDateTime.Size = new Size(157, 15);
            appointmentDateTime.TabIndex = 16;
            appointmentDateTime.Text = "Appointment Date and Time";
            // 
            // saveAppointment
            // 
            saveAppointment.Location = new Point(14, 73);
            saveAppointment.Name = "saveAppointment";
            saveAppointment.Size = new Size(49, 32);
            saveAppointment.TabIndex = 20;
            saveAppointment.Text = "Save";
            saveAppointment.UseVisualStyleBackColor = true;
            saveAppointment.Click += save_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 11);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 19;
            label5.Text = "Appointment Notes";
            // 
            // AppointNotes
            // 
            AppointNotes.AcceptsTab = true;
            AppointNotes.Location = new Point(185, 29);
            AppointNotes.Multiline = true;
            AppointNotes.Name = "AppointNotes";
            AppointNotes.Size = new Size(368, 76);
            AppointNotes.TabIndex = 18;
            // 
            // CancelNewAppointment
            // 
            CancelNewAppointment.Location = new Point(88, 73);
            CancelNewAppointment.Name = "CancelNewAppointment";
            CancelNewAppointment.Size = new Size(56, 32);
            CancelNewAppointment.TabIndex = 21;
            CancelNewAppointment.Text = "Cancel";
            CancelNewAppointment.UseVisualStyleBackColor = true;
            CancelNewAppointment.Click += cancel_Click;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(CancelNewAppointment);
            Controls.Add(saveAppointment);
            Controls.Add(label5);
            Controls.Add(AppointNotes);
            Controls.Add(AddAppointDTP);
            Controls.Add(appointmentDateTime);
            Location = new Point(20, 20);
            Name = "AddAppointment";
            Size = new Size(567, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker AddAppointDTP;
        private Label appointmentDateTime;
        private Button saveAppointment;
        private Label label5;
        private TextBox AppointNotes;
        private Button CancelNewAppointment;
    }
}
