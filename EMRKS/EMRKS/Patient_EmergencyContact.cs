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
        public Patient_EmergencyContact()
        {
            InitializeComponent();
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
            ((AddPatient)this.parentForm).removeAndReorderEmContacts(this);
        }
    }
}
