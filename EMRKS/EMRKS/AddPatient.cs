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
        List<Patient_KnownAllergies>   patientAllergies = new List<Patient_KnownAllergies>(); //A list of all allergies. 
        List<Patient_EmergencyContact> patientEmergencyContacts = new List<Patient_EmergencyContact>(); //List of all emergency contacts associated with the patient
        List<Patient_AddInsurance>     patientInsurances = new List<Patient_AddInsurance>();
        List<Patient_Payment>          patientPayments = new List<Patient_Payment>();

        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            
            Database database = new Database();



            String sqlStatement;
            sqlStatement = "'" + txtSSN.Text +    "',";
            sqlStatement += "'" + dtpDOB.Text +   "',";
            sqlStatement += "'" + comboSex.Text + "',";
            sqlStatement += "'" + txtFName.Text + "',";
            sqlStatement += "'" + txtMInit.Text + "',";
            sqlStatement += "'" + txtLName.Text + "',";

            if (comboBoxDoctor.Text == " ")
            {
                sqlStatement += "NULL,";
            }
            else
            {
                sqlStatement += "'" + txtLName.Text + "',";
            }

            sqlStatement += "'" + txtPhoneNumber.Text + "'";

            Console.WriteLine(sqlStatement);
            Console.WriteLine(Database.addPatient(sqlStatement));

            //Validate the info will go cleanly into the DB
            //validateSQL();
            
            
            //SQL add commands.


            //If the add is successful, return to landing.
            //if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }


        private void btnAddInsurance_Click(object sender, EventArgs e)
        {
            Patient_AddInsurance currentControl = new Patient_AddInsurance();
            patientInsurances.Add(currentControl);
            groupBoxInsurance.Controls.Add(currentControl);

            currentControl.parentForm = this;

            currentControl.Location = new Point(5, 50 + (currentControl.Height) * (patientInsurances.Count - 1));
        }

        private void btnAddPatientAllergy_Click(object sender, EventArgs e)
        {
            Patient_KnownAllergies currentControl = new Patient_KnownAllergies();
            patientAllergies.Add(currentControl);
            groupBoxAllergies.Controls.Add(currentControl);

            currentControl.parentForm = this;

            currentControl.Location = new Point(5, 50 + (currentControl.Height) * (patientAllergies.Count - 1));
        }

        private void btnAddEmContact_Click(object sender, EventArgs e)
        {
            Patient_EmergencyContact currentControl = new Patient_EmergencyContact();
            patientEmergencyContacts.Add(currentControl);
            groupBoxEmContact.Controls.Add(currentControl);

            currentControl.parentForm = this;

            currentControl.Location = new Point(5, 50 + (currentControl.Height) * (patientEmergencyContacts.Count - 1));
        }

        private void btnPatientAddPayment_Click(object sender, EventArgs e)
        {
            Patient_Payment currentControl = new Patient_Payment();
            patientPayments.Add(currentControl);
            groupBoxPayment.Controls.Add(currentControl);

            currentControl.parentForm = this;

            currentControl.Location = new Point(5, 50 + (currentControl.Height) * (patientPayments.Count - 1));
        }

        public void removeAndReorderInsurance(Patient_AddInsurance toBeDeleted)
        {
            patientInsurances.Remove(toBeDeleted);
            groupBoxInsurance.Controls.Remove(toBeDeleted);

            for (int i = 0; i < patientInsurances.Count; i++)
            {
                patientInsurances.ElementAt(i).Location = new Point(5, 50 + (patientInsurances.ElementAt(i).Height) * (i));
            }
        }
        public void removeAndReorderAllergies(Patient_KnownAllergies toBeDeleted)
        {
            patientAllergies.Remove(toBeDeleted);
            groupBoxAllergies.Controls.Remove(toBeDeleted);

            for (int i = 0; i < patientAllergies.Count; i++)
            {
                patientAllergies.ElementAt(i).Location = new Point(5, 50 + (patientAllergies.ElementAt(i).Height) * (i));
            }
        }
        public void removeAndReorderPayments(Patient_Payment toBeDeleted)
        {
            patientPayments.Remove(toBeDeleted);
            groupBoxPayment.Controls.Remove(toBeDeleted);

            for (int i = 0; i < patientPayments.Count; i++)
            {
                patientPayments.ElementAt(i).Location = new Point(5, 50 + (patientPayments.ElementAt(i).Height) * (i));
            }
        }

        public void removeAndReorderEmContacts(Patient_EmergencyContact toBeDeleted)
        {
            patientEmergencyContacts.Remove(toBeDeleted);
            groupBoxEmContact.Controls.Remove(toBeDeleted);

            for (int i = 0; i < patientEmergencyContacts.Count; i++)
            {
                patientEmergencyContacts.ElementAt(i).Location = new Point(5, 50 + (patientEmergencyContacts.ElementAt(i).Height) * (i));
            }
        }
    }
}
