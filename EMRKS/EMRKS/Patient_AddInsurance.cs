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
    public partial class Patient_AddInsurance : UserControl
    {
        public Form parentForm;

        public Patient_AddInsurance()
        {
            InitializeComponent();
        }
        public String sqlSerialize()
        {

            if (txtGroupNumber.TextLength == 0)
            {
                return "'" + txtProvider.Text + "'," +
                "'" + txtPolicyNumber.Text + "'," +
                "NULL," +
                "'" + txtNameOnInsurance.Text + "'";
            }
            else
            {
                return "'" + txtProvider.Text + "'," +
                "'" + txtPolicyNumber.Text + "'," +
                "'" + txtGroupNumber.Text + "'," +
                "'" + txtNameOnInsurance.Text + "'";
            }
        }
        public Boolean sqlCanSerialize()
        {
            if (txtProvider.TextLength != 0 && txtPolicyNumber.TextLength != 0 && txtNameOnInsurance.TextLength != 0)
            { return true; }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((AddPatient)this.parentForm).removeAndReorderInsurance(this);

        }

        private void Patient_AddInsurance_Load(object sender, EventArgs e)
        {

        }
    }
}
