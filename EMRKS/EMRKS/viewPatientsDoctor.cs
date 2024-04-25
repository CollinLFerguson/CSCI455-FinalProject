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
    public partial class viewPatientsDoctor : Form
    {
        string? staffID;

        public viewPatientsDoctor()
        {
            InitializeComponent();
        }

        public viewPatientsDoctor(string staffID)
        {
            this.staffID = staffID;
            InitializeComponent();
        }

        private void loadviewPatientDoctor(string staffID)
        {
            dataGridView1.DataSource = Database.GetPatientsDoctor(staffID);
        }
    }
}
