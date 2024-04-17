using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMRKS
{
    public partial class AddAppointment : UserControl
    {
        private string? currSSN;
        private char status;
        private string Notes;
        private DateTime Date_Time;

        public AddAppointment()
        {
            InitializeComponent();
        }
        public AddAppointment(string patientSSN, char status, string notes, DateTime Date_Time)
        {
            InitializeComponent();
            this.currSSN = patientSSN;
            this.status = status;
            this.Notes = notes;
            this.Date_Time = Date_Time;

        }

        private void save_Click(object sender, EventArgs e)
        {
            status = 'A';
            Notes = AppointNotes.Text;
            Date_Time = AddAppointDTP.Value;
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
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
