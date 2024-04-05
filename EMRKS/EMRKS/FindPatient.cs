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

namespace EMRKS
{
    public partial class FindPatient : Form
    {
        public FindPatient()
        {
            InitializeComponent();
        }

        private void onPatientSearch(object sender, EventArgs e)
        {
            string patientSsn = textBox1.Text;

            var patient = Database.GetPatient(textBox1.Text);

            if (patient != null)
            {
                FillPatientInformation(patient);

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

        private void FillPatientInformation(Patient patient)
        {
            patientInfoSSN.Text = patient.getSsn();
            patientInfoFirstName.Text = patient.getFirstName();
            patientInfoMI.Text = patient.getMiddleInit();
            patientInfoLastName.Text = patient.getLastName();
            patientInfoSex.Text = patient.getSex();
            patientInfoDOB.Text = patient.getDOB();
            patientInfoPhoneNumber.Text = patient.getPhoneNumber();
            patientInfoPrimaryDoctor.Text = patient.getPrimaryDoctor();
        }

        private void onEditPatientPersonalInfo(object sender, EventArgs e)
        {
            //
        }
    }
}
