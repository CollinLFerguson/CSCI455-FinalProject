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

        private void save_Click()
        {
            Database.AddPatientAppointment(currSSN, status, Notes, Date_Time);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
