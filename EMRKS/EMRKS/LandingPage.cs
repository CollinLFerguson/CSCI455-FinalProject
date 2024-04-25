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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainForm.staffType == "D" || MainForm.staffType == "N")
            {
                MessageBox.Show("Invalid permissions. Only administrators can add patients.");
                return;
            }

            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadAddPatient(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MainForm.staffType == "D" || MainForm.staffType == "N")
            {
                MessageBox.Show("Invalid permissions. Only administrators can add staff.");
                return;
            }

            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadAddStaff(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadFindPatient(); }
        }

        private void button5_Click(object sender, EventArgs e) // the click functions don't correspond to the correct buttons
        {
            if (MainForm.staffType == "D" || MainForm.staffType == "N")
            {
                MessageBox.Show("Invalid permissions. Only administrators can view unprocessed reports.");
                return;
            }

            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadViewUnprocessedFinancialReports(); }
        }
        private void button6_Click(object sender, EventArgs e) // the click functions don't correspond to the correct buttons
        {
            if (MainForm.staffType == "D" || MainForm.staffType == "N")
            {
                MessageBox.Show("Invalid permissions. Only administrators can view appointments.");
                return;
            }

            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadViewAppointments(); }
        }

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            if (MainForm.staffType == "D" || MainForm.staffType == "N")
            {
                MessageBox.Show("Only administrators can add medications.");
                return;
            }

            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadAddMedicationForm(); }
        }

        private void viewPatientButton_Click(object sender, EventArgs e)
        {
            if (MainForm.staffType == "D")
            {

                // open viewPatientDoctor
                if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadviewPatientDoctor(); }
            }
            else if (MainForm.staffType == "A")
            {
                // open viewPatientAdmin
                if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadviewPatientAdmin(); }
            }
            else
            {
                MessageBox.Show("Only administrators and doctors can view patients.");
                return;
            }
        }

        private void viewMedButton_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).loadviewMedications(); }
        }
    }
}
