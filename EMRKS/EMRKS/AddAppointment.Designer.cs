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
            dateTimePicker1 = new DateTimePicker();
            appointmentDateTime = new Label();
            saveAppointment = new Button();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(14, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 17;
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
            saveAppointment.Location = new Point(51, 73);
            saveAppointment.Name = "saveAppointment";
            saveAppointment.Size = new Size(66, 32);
            saveAppointment.TabIndex = 20;
            saveAppointment.Text = "Save";
            saveAppointment.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.AcceptsTab = true;
            textBox2.Location = new Point(185, 29);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 76);
            textBox2.TabIndex = 18;
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(saveAppointment);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(appointmentDateTime);
            Name = "AddAppointment";
            Size = new Size(567, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label appointmentDateTime;
        private Button saveAppointment;
        private Label label5;
        private TextBox textBox2;
    }
}
