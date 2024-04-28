using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMRKS
{
    public partial class PatientEditor : UserControl
    {
        public PatientEditor()
        {
            InitializeComponent();

            panel2.AutoScroll = false;
            panel2.HorizontalScroll.Enabled = false;
            panel2.HorizontalScroll.Visible = false;
            panel2.HorizontalScroll.Maximum = 0;
            panel2.AutoScroll = true;
        }

        Patient patient;
        Address address;

        string errorMessage;

        string Ssn;

        List<EmergencyContact> contacts = new List<EmergencyContact>();
        List<EmergencyContact> contactsToRemove = new List<EmergencyContact>();

        bool contactsAdded = false;


        int numberOfContacts;

        public void FillInformation(List<string> patientInformation, List<string> contactInformation)
        {
            Ssn = patientInformation[0]; //Save Ssn incase they chagne it on update so we can still find who we want to update


            textBox1.Text = patientInformation[0];
            textBox2.Text = patientInformation[1];
            textBox3.Text = patientInformation[2];
            textBox4.Text = patientInformation[3];
            textBox5.Text = patientInformation[4];
            textBox6.Text = patientInformation[5];
            textBox7.Text = patientInformation[6];
            textBox8.Text = patientInformation[7];

            if (patientInformation.Count > 8)
            {
                textBox9.Text = patientInformation[8]; //Address could be null.           

                if (patientInformation[9] != "NULL")
                {
                    textBox10.Text = patientInformation[9];
                }

                textBox11.Text = patientInformation[10];
                textBox12.Text = patientInformation[11];
                textBox13.Text = patientInformation[12];
            }

            if (contactInformation.Count != 0)
            {
                for (int i = 0; i < contactInformation.Count - 1; i += 3)
                {
                    EmergencyContact contact = new EmergencyContact(contactInformation[i], contactInformation[i + 1], contactInformation[i + 2]);
                    contacts.Add(contact);
                    numberOfContacts++;
                    Patient_EmergencyContact eContact = new Patient_EmergencyContact(this, contactInformation[i], contactInformation[i + 1], contactInformation[i + 2]);
                    eContact.Location = new Point(5, 132 * (numberOfContacts - 1));
                    panel2.Controls.Add(eContact);
                }
            }
            else
            {
                //no contacts
            }


        }

        private void GrabNewInformation()
        {
            patient = new Patient(textBox1.Text, textBox6.Text, char.Parse(textBox5.Text), textBox2.Text, char.Parse(textBox3.Text), textBox4.Text, textBox8.Text, textBox7.Text);
            address = new Address(textBox1.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);

            contacts.Clear();

            foreach (Control control in panel2.Controls)
            {
                //go through each control creating objects to send to database
                string name = (control as Patient_EmergencyContact).GetName();
                string phone = (control as Patient_EmergencyContact).GetPhone();
                string relation = (control as Patient_EmergencyContact).GetRelation();
                bool nameModify = (control as Patient_EmergencyContact).nameModified;
                bool phoneModified = (control as Patient_EmergencyContact).phoneModified;
                bool relationModified = (control as Patient_EmergencyContact).relationModified;


                if (name != "" && phone != "" && relation != "")
                {
                    EmergencyContact contact = new EmergencyContact(name, phone, relation, nameModify, phoneModified, relationModified);
                    contacts.Add(contact);
                }
            }
        }

        private void onSaveInfo(object sender, EventArgs e)
        {
            GrabNewInformation();

            if (!CheckInformationValid())
            {
                MessageBox.Show(errorMessage);
                return;
            }

            bool noAdd = false;

            if (!contactsAdded)
            {
                contacts.Clear();
                noAdd = true;
            }

            //check all fields valid
            if (!Database.UpdatePatient(patient, address, Ssn, contacts, contactsToRemove, noAdd))
            {
                MessageBox.Show("UPDATE FAILED SOMETHING WENT WRONG");
            }
            else
            {
                MessageBox.Show("UPDATE SUCCESS");
            }
        }

        private void onAddContact(object sender, EventArgs e)
        {
            numberOfContacts++;
            Patient_EmergencyContact contact = new Patient_EmergencyContact(this);
            contact.Location = new Point(5, 132 * (numberOfContacts - 1));
            panel2.Controls.Add(contact);
            contactsAdded = true;
        }

        public void removeControl(UserControl userControl, string name, string phone, string relation)
        {
            contactsToRemove.Add(new EmergencyContact(name, phone, relation));

            panel2.Controls.Remove(userControl);
            numberOfContacts--;

            //rearrange all contacts
            int i = 0;
            foreach(Control control in panel2.Controls)
            {
                control.Location = new Point(5, 132 * i);
                i++;
            }
        }

        private bool CheckInformationValid()
        {
            string firstName = patient.getFirstName();
            string lastName = patient.getLastName();
            string minit = patient.getMiddleInit();
            string sex = patient.getSex();
            string DOB = patient.getDOB();
            bool dobFail = patient.dateFailed;
            string phoneNumber = patient.getPhoneNumber();
            string pcmID = patient.getPrimaryDoctorIDForUpdate();
            string addyLine1 = address.getLine1();
            string addyLine2 = address.getLine2();
            string city = address.getCity();
            string state = address.getState();
            string zip = address.getZip();

            if (firstName.Length > 20)
            {
                errorMessage = "First name too long.  Must be under 20 characters.";

                return false;
            }

            if (lastName.Length > 20)
            {
                errorMessage = "Last name too long.  Must be under 20 characters.";

                return false;
            }

            if (minit.Length > 1)
            {
                errorMessage = "Middle initial too long.  Must be 1 character.";

                return false;
            }

            string sexTest = sex.ToLower();

            if (sexTest == "m" || sexTest == "f")
            {

            }
            else
            {
                errorMessage = "Invalid sex.  Must be M or F";

                return false;
            }

            if (dobFail)
            {
                errorMessage = "Invalid date.  Must be of form YYYY/MM/DD";

                return false;
            }

            if (phoneNumber.Length != 10)
            {
                errorMessage = "Invalid phone.  Must be 10 digit US Phone number of form 77723255555";

                return false;
            }

            if (pcmID == null)
            {
                errorMessage = "Could not find PCM with name " + patient.getPrimaryDoctor();

                return false;
            }

            if (addyLine1.Length > 100)
            {
                errorMessage = "Address line 1 must be under 101 characters.";

                return false;
            }

            if (addyLine2 != null && addyLine2.Length > 100)
            {
                errorMessage = "Address line 2 must be under 101 characters.";

                return false;
            }

            if (city.Length > 100)
            {
                errorMessage = "City must be under 101 characters.";

                return false;
            }

            if (state.Length > 2)
            {
                errorMessage = "State must be your states 2 letter abreviation.";

                return false;
            }

            if (zip.Length > 10)
            {
                errorMessage = "Zip code must be under 10 characters.";

                return false;
            }

            return true;
        }
    }
}
