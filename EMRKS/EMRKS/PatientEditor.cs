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
    public partial class PatientEditor : UserControl
    {
        public PatientEditor()
        {
            InitializeComponent();
        }

        Patient patient;

        string Ssn;

        public void FillInformation(List<string> patientInformation)
        {
            patient = new Patient(patientInformation[0], patientInformation[5], char.Parse(patientInformation[4]), patientInformation[1], char.Parse(patientInformation[2]), patientInformation[3], patientInformation[6], patientInformation[7]);

            Ssn = patientInformation[0]; //Save Ssn incase they chagne it on update so we can still find who we want to update

            textBox1.Text = patientInformation[0];
            textBox2.Text = patientInformation[1];
            textBox3.Text = patientInformation[2];
            textBox4.Text = patientInformation[3];
            textBox5.Text = patientInformation[4];
            textBox6.Text = patientInformation[5];
            textBox7.Text = patientInformation[6];
            textBox8.Text = patientInformation[7];

            textBox9.Text = patientInformation[8];

            if (patientInformation[9] != "NULL")
            {
                textBox10.Text = patientInformation[9];
            }

            textBox11.Text = patientInformation[10];
            textBox12.Text = patientInformation[11];
            textBox13.Text = patientInformation[12];
        }

        private void GrabNewInformation()
        {
            patient = new Patient(textBox1.Text, textBox6.Text, char.Parse(textBox5.Text), textBox2.Text, char.Parse(textBox3.Text), textBox4.Text, textBox8.Text, textBox7.Text);
        }

        private void onSaveInfo(object sender, EventArgs e)
        {
            GrabNewInformation();
            //check all fields valid
            if (!Database.UpdatePatient(patient, Ssn))
            {
                MessageBox.Show("UPDATE FAILED SOMETHING WENT WRONG");
            }
            else
            {
                MessageBox.Show("UPDATE SUCCESS");
            }
        }
    }
}
