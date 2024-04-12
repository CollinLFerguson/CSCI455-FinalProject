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
        public String sqlSerialize()
        {
            return "'" + txtCardName.Text + "'," +
                "'" + txtCardType.Text + "'," +
                "'" + txtCardNumber.Text + "'," +
                "'" + txtCcv.Text + "'," +
                "'" + dtpExp.Text + "'";
        }
        public Boolean sqlCanSerialize()
        {
            if (txtCardName.TextLength!=0 && txtCardType.TextLength != 0
                && txtCardNumber.TextLength != 0 && txtCcv.TextLength != 0
                && dtpExp.Text!="") { return true; } else return false;        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ((AddPatient)this.parentForm).removeAndReorderPayments(this);
        }
    }
}
