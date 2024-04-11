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
    public partial class Patient_KnownAllergies : UserControl
    {
        public Form parentForm;

        public Patient_KnownAllergies()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((AddPatient)this.parentForm).removeAndReorderAllergies(this);
        }
    }
}
