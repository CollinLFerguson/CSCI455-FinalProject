namespace EMRKS
{
    partial class RescheduleAppointment
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
            cancelEdit = new Button();
            saveAppointment = new Button();
            ReschedAppointDTP = new DateTimePicker();
            appointmentDateTime = new Label();
            label5 = new Label();
            newAppointNotes = new TextBox();
            SuspendLayout();
            // 
            // cancelEdit
            // 
            cancelEdit.Location = new Point(90, 72);
            cancelEdit.Name = "cancelEdit";
            cancelEdit.Size = new Size(75, 23);
            cancelEdit.TabIndex = 25;
            cancelEdit.Text = "Cancel";
            cancelEdit.UseVisualStyleBackColor = true;
            cancelEdit.Click += cancelReschedule_Click;
            // 
            // saveAppointment
            // 
            saveAppointment.Location = new Point(9, 72);
            saveAppointment.Name = "saveAppointment";
            saveAppointment.Size = new Size(75, 23);
            saveAppointment.TabIndex = 24;
            saveAppointment.Text = "Save";
            saveAppointment.UseVisualStyleBackColor = true;
            saveAppointment.Click += saveRescheduledAppoint_Click;
            // 
            // ReschedAppointDTP
            // 
            ReschedAppointDTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            ReschedAppointDTP.Format = DateTimePickerFormat.Custom;
            ReschedAppointDTP.Location = new Point(9, 28);
            ReschedAppointDTP.Name = "ReschedAppointDTP";
            ReschedAppointDTP.Size = new Size(155, 23);
            ReschedAppointDTP.TabIndex = 23;
            // 
            // appointmentDateTime
            // 
            appointmentDateTime.AutoSize = true;
            appointmentDateTime.Location = new Point(7, 10);
            appointmentDateTime.Name = "appointmentDateTime";
            appointmentDateTime.Size = new Size(157, 15);
            appointmentDateTime.TabIndex = 22;
            appointmentDateTime.Text = "Appointment Date and Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(187, 10);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 21;
            label5.Text = "Appointment Notes";
            // 
            // newAppointNotes
            // 
            newAppointNotes.AcceptsTab = true;
            newAppointNotes.Location = new Point(187, 28);
            newAppointNotes.Multiline = true;
            newAppointNotes.Name = "newAppointNotes";
            newAppointNotes.Size = new Size(256, 67);
            newAppointNotes.TabIndex = 20;
            // 
            // RescheduleAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(cancelEdit);
            Controls.Add(saveAppointment);
            Controls.Add(ReschedAppointDTP);
            Controls.Add(appointmentDateTime);
            Controls.Add(label5);
            Controls.Add(newAppointNotes);
            Location = new Point(233, 227);
            Name = "RescheduleAppointment";
            Size = new Size(454, 108);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelEdit;
        private Button saveAppointment;
        private DateTimePicker ReschedAppointDTP;
        private Label appointmentDateTime;
        private Label label5;
        private TextBox newAppointNotes;
    }
}
