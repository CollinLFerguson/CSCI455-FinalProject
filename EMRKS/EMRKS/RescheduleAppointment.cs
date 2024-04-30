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
    public partial class RescheduleAppointment : UserControl
    {
        private string? currSSN;
        private string Notes;
        private DateTime Date_Time;
        public RescheduleAppointment()
        {
            InitializeComponent();
        }
        public RescheduleAppointment( string patientSSN, string notes, DateTime Date_Time)
        {
            InitializeComponent();
            this.currSSN = patientSSN;
            this.Notes = notes;
            this.Date_Time = Date_Time;
        }

        private void saveRescheduledAppoint_Click(object sender, EventArgs e)
        {
            char status = 'A';
            Notes = newAppointNotes.Text;
            Date_Time = ReschedAppointDTP.Value;

            // automatically setting status to active upon appointment creation
            if (!Database.AddPatientAppointment(currSSN, status, Notes, Date_Time))
            {
                MessageBox.Show("this did not update");
            }
            else
            {
                this.Dispose();
            }

            Appointment_Manager.dgv.Update();
            Appointment_Manager.dgv.Refresh();

            Appointment_Manager.dgv.DataSource = Database.ViewPatientAppointments(currSSN);

        }
        private void cancelReschedule_Click(object sender, EventArgs e)
        {
            this.Dispose();


        }

    }
}
