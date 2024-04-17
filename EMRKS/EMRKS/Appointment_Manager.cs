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
    public partial class Appointment_Manager : UserControl
    {
        private string? currSSN;
        public Appointment_Manager()
        {
            InitializeComponent();
        }
        public Appointment_Manager(string currentSsn)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
        }

        private void Appointment_Manager_Load(object sender, EventArgs e)
        {
            // this will populate the datagridview for the scheduled appoinments for a specific patient

            dataGridView1.DataSource = Database.ViewPatientAppointments(currSSN);

        }
        private void Edit_Appointment_Click(object sender, EventArgs e)
        {
            // this will search for an appointment with a given Appoinment ID and allow the user to change the appointment values



        }
        private void Add_Appointment_Click(object sender, EventArgs e)
        {
            // this will add an appoinment for a specific patient

            //Financial_Manager finManager = new Financial_Manager(currSSN);
            //finManager.Parent = goodPanel;
            //finManager.Location = new Point(0, 0);
            //finManager.BringToFront();
            //finManager.Show();

            //Database.AddPatientAppointment(currSSN, status, Notes, Date_Time);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
