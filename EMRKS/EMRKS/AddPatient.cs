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
    public partial class AddPatient : Form
    {
        List<Patient_KnownAllergies> patientAllergies = new List<Patient_KnownAllergies>(); //A list of all allergies. 
        List<Patient_EmergencyContact> patient_EmergencyContacts = new List<Patient_EmergencyContact>(); //List of all emergency contacts associated with the patient
        List<Patient_AddInsurance> patientInsurances = new List<Patient_AddInsurance>();
        List<Patient_Payment> patient_Payments = new List<Patient_Payment>();

        public AddPatient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Validate the info will go cleanly into the DB
            //SQL add commands.


            //If the add is successful, return to landing.
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
