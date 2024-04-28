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
    public partial class Patient_EmergencyContact : UserControl
    {
        public Form parentForm;

        public string name;
        public string phone;
        public string relation;
        public bool nameModified;
        public bool phoneModified;
        public bool relationModified;

        //for use inside patient editor
        UserControl parent;

        public Patient_EmergencyContact()
        {
            InitializeComponent();
        }

        public Patient_EmergencyContact(UserControl parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public Patient_EmergencyContact(UserControl parent, string name, string phone, string relation)
        {
            InitializeComponent();
            this.parent = parent;

            txtContactName.Text = name;
            txtContactPhone.Text = phone;
            txtContactRelationship.Text = relation;
        }

        public string GetName()
        {
            return txtContactName.Text;
        }

        public string GetPhone()
        {
            return txtContactPhone.Text;
        }

        public string GetRelation()
        {
            return txtContactRelationship.Text;
        }

        public String[] getInfo()
        {
            return [];

        }
        public String sqlSerialize()
        {
            return "'" + txtContactName.Text + "'," +
                "'" + txtContactPhone.Text + "'," +
                "'" + txtContactRelationship.Text + "'"; ;
        }
        public Boolean sqlCanSerialize()
        {
            if (txtContactName.TextLength != 0 && txtContactPhone.TextLength != 0
                && txtContactRelationship.TextLength != 0) { return true; }
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //for when using inside patient editor
            if (parent != null)
            {
                (parent as PatientEditor).removeControl(this);
                return;
            }

            ((AddPatient)this.parentForm).removeAndReorderEmContacts(this);
        }

        private void onTextChangedName(object sender, EventArgs e)
        {
            nameModified = true;
        }

        private void onPhoneModified(object sender, EventArgs e)
        {
            phoneModified = true;
        }

        private void onRelationModified(object sender, EventArgs e)
        {
            relationModified = true;
        }
    }
}
