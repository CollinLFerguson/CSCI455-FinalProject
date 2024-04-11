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

        public void FillInformation(List<string> patientInformation)
        {
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
    }
}
