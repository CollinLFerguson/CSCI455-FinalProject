﻿using Org.BouncyCastle.Utilities;
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
    
    public partial class Appointment_Manager : UserControl
    {
        private string? currSSN;
        private char status;
        private string Notes;
        private DateTime Date_Time;
        public static DataGridView dgv = new DataGridView();
        int appointmentID;
        public static RescheduleAppointment resched = new RescheduleAppointment();
        public static EditAppointmentStatus editAppoint = new EditAppointmentStatus();




        public Appointment_Manager()
        {
            InitializeComponent();
            //addAppointm.Hide();
        }
        public Appointment_Manager(string currentSsn)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
            //addAppointm.Hide();
        }

        private void Appointment_Manager_Load(object sender, EventArgs e)
        {
            // this will populate the datagridview for the scheduled appoinments for a specific patient
            dgv = dataGridView1;
            dgv.DataSource = Database.ViewPatientAppointments(currSSN);

        }
        private void Edit_Appointment_Click(object sender, EventArgs e)
        {
            // this will search for an appointment with a given Appoinment ID and allow the user to change the appointment values



        }
        private void Add_Appointment_Click(object sender, EventArgs e)
        {
            // this will add an appoinment for a specific patient

            // will trigger the panel with the text fields to add appointment information
            AddAppointment addAppointm = new AddAppointment(currSSN, status, Notes, Date_Time);
            addAppointm.Parent = this;
            addAppointm.Location = new Point(43, 375);
            addAppointm.BringToFront();
            addAppointm.Show();


        }
        private void Edit_Appointment_Click1(object sender, EventArgs e)
        {
            // this will add an appoinment for a specific patient

            // will trigger the panel with the text fields to add appointment information
            // edit appointment status

            try
            {
                appointmentID = int.Parse(appointmentIDBox.Text);
                editAppoint = new EditAppointmentStatus(currSSN, appointmentID);
                editAppoint.Parent = this;
                editAppoint.Location = new Point(45, 227);
                editAppoint.BringToFront();
                editAppoint.Show();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An appointment ID must be specified.");
            }
            appointmentIDBox.ResetText();
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

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
