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
    public partial class Patient_Payment : UserControl
    {
        public Form parentForm;
        public Patient_Payment()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((AddPatient)this.parentForm).removeAndReorderPayments(this);
        }
    }
}
