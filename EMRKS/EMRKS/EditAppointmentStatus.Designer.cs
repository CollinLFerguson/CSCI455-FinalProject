namespace EMRKS
{
    partial class EditAppointmentStatus
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
            statusBox = new ComboBox();
            appointmentStatusBox = new Label();
            rescheduleInfoPanel = new Panel();
            SuspendLayout();
            // 
            // statusBox
            // 
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "A", "F", "C", "R", "M" });
            statusBox.Location = new Point(13, 23);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(113, 23);
            statusBox.TabIndex = 0;
            statusBox.SelectedIndexChanged += appointmentStatus_SelectedIndexChanged;
            // 
            // appointmentStatusBox
            // 
            appointmentStatusBox.AutoSize = true;
            appointmentStatusBox.Location = new Point(13, 5);
            appointmentStatusBox.Name = "appointmentStatusBox";
            appointmentStatusBox.Size = new Size(113, 15);
            appointmentStatusBox.TabIndex = 12;
            appointmentStatusBox.Text = "Appointment Status";
            // 
            // rescheduleInfoPanel
            // 
            rescheduleInfoPanel.Location = new Point(145, 5);
            rescheduleInfoPanel.Name = "rescheduleInfoPanel";
            rescheduleInfoPanel.Size = new Size(468, 105);
            rescheduleInfoPanel.TabIndex = 13;
            // 
            // EditAppointmentStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(rescheduleInfoPanel);
            Controls.Add(appointmentStatusBox);
            Controls.Add(statusBox);
            Location = new Point(45, 238);
            Name = "EditAppointmentStatus";
            Size = new Size(630, 113);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox statusBox;
        private Label appointmentStatusBox;
        private Panel rescheduleInfoPanel;
    }
}
