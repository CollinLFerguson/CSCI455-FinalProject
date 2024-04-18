using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMRKS
{
    public partial class FindPatient : Form
    {
        private string? staffID;

        public FindPatient(string staffID)
        {
            InitializeComponent();
            HideSubControls();
            this.staffID = staffID;
        }

        private Patient patient;

        private Medication_Manager medManager;
        private Financial_Manager financialManager;
        private Appointment_Manager appointmentManager;

        private void HideSubControls()
        {
            patientEditor1.Hide();

            if (medManager != null)
            {
                medManager.Hide();
            }

            if (financialManager != null)
            {
                financialManager.Hide();
            }

            if (appointmentManager != null)
            {
                appointmentManager.Hide();
            }
        }

        private void onPatientSearch(object sender, EventArgs e)
        {
            string patientSsn = textBox1.Text;

            var patient = Database.GetPatient(textBox1.Text);

            if (patient != null)
            {
                this.patient = patient;

                FillPatientInformation();

                patientSearchPanel.Visible = false;
                patientInfoPanel.Visible = true;
                patientOptionsPanel.Visible = true;
                goodPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("CANT FIND PATIENT");
            }
        }

        private void FillPatientInformation()
        {
            patientInfoSSN.Text = patient.getSsn();
            patientInfoFirstName.Text = patient.getFirstName();
            patientInfoMI.Text = patient.getMiddleInit();
            patientInfoLastName.Text = patient.getLastName();
            patientInfoSex.Text = patient.getSex();
            patientInfoDOB.Text = patient.getDOB();
            patientInfoPhoneNumber.Text = patient.getPhoneNumber();
            patientInfoPrimaryDoctor.Text = patient.getPrimaryDoctor();

            var address = patient.getAddress();

            if (address != null)
            {
                string line1 = address.getLine1();
                string? line2 = address.getLine2();

                if (line2 != "NULL")
                {
                    patientInfoAddress.Text = line1 + " " + line2;
                }
                else
                {
                    patientInfoAddress.Text = line1;
                }

                patientInfoCity.Text = address.getCity();
                patientInfoState.Text = address.getState();
                patientInfoZip.Text = address.getZip();
            }
        }

        private void onEditPatientPersonalInfo(object sender, EventArgs e)
        {
            HideSubControls();
            patientEditor1.Show();

            List<string> patientInformation = new List<string>();
            patientInformation.Add(patient.getSsn());
            patientInformation.Add(patient.getFirstName());
            patientInformation.Add(patient.getMiddleInit());
            patientInformation.Add(patient.getLastName());
            patientInformation.Add(patient.getSex());
            patientInformation.Add(patient.getDOB());
            patientInformation.Add(patient.getPhoneNumber());
            patientInformation.Add(patient.getPrimaryDoctor());

            var address = patient.getAddress();

            if (address != null)
            {
                string line1 = address.getLine1();
                string? line2 = address.getLine2();

                patientInformation.Add(line1);
                patientInformation.Add(line2);

                patientInformation.Add(address.getCity());
                patientInformation.Add(address.getState());
                patientInformation.Add(address.getZip());
            }

            patientEditor1.FillInformation(patientInformation);
            patientEditor1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Medication Manager Button

            HideSubControls();

            medManager = new Medication_Manager(patient.getSsn(), staffID);
            medManager.Parent = goodPanel;
            medManager.Location = new Point(0, 0);
            medManager.BringToFront();
            medManager.Show();
        }

        private void appointmentManager_Click(object sender, EventArgs e)
        {
            // Appointment Manager Button

            HideSubControls();

            appointmentManager = new Appointment_Manager(patient.getSsn());
            appointmentManager.Parent = goodPanel;
            appointmentManager.Location = new Point(0, 0);
            appointmentManager.BringToFront();
            appointmentManager.Show();
        }

        private void financialManager_Click(object sender, EventArgs e)
        {
            // Appointment Manager Button
            HideSubControls();


            financialManager = new Financial_Manager(patient.getSsn());
            financialManager.Parent = goodPanel;
            financialManager.Location = new Point(0, 0);
            financialManager.BringToFront();
            financialManager.Show();
        }
    }
}
