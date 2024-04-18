using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMRKS
{

    public partial class EditAppointmentStatus : UserControl
    {
        private string? currSSN;
        private char status;
        private int appointmentID;
        private string notes;
        private DateTime Date_Time;

        public EditAppointmentStatus()
        {
            InitializeComponent();
        }
        public EditAppointmentStatus(string patientSSN, int appointmentID)
        {
            InitializeComponent();
            this.currSSN = patientSSN;
            this.status = status;
            this.appointmentID = appointmentID;

        }

        private void appointmentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string statusTxt = statusBox.GetItemText(statusBox.SelectedItem);
            status = char.Parse(statusTxt);



            if (!Database.EditPatientAppointmentStatus(currSSN, appointmentID, status))
            {
                MessageBox.Show("unable to update the given status");
            }

            Appointment_Manager.dgv.Update();
            Appointment_Manager.dgv.Refresh();

            Appointment_Manager.dgv.DataSource = Database.ViewPatientAppointments(currSSN);

            if (status == 'R')
            {
                // if the appointment has been rescheduled
                // display the date time picker to create a new appointment
                Appointment_Manager.resched = new RescheduleAppointment(currSSN, notes, Date_Time);
                Appointment_Manager.resched.Parent = rescheduleInfoPanel;
                Appointment_Manager.resched.Location = new Point(0, 0);

                //Appointment_Manager.resched.BringToFront();
                //Appointment_Manager.resched.Show();
                Appointment_Manager.resched.Visible = true;
                Appointment_Manager.editAppoint.SendToBack();

            }
            else
            {
                this.Dispose();
            }
        }
    }
}
