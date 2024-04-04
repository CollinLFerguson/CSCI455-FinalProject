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
            //IF PATIENT FOUND HIDE PANEL AND DISPLAY PATIENT INFO
            //ELSE SHOW PATIENT NOT FOUND

            patientSearchPanel.Visible = false;
            patientInfoPanel.Visible = true;
            patientOptionsPanel.Visible = true;
            goodPanel.Visible = true;
        }

        private void onEditPatientPersonalInfo(object sender, EventArgs e)
        {
            Database.Test();
        }
    }
}
