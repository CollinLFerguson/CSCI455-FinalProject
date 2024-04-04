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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Validate the info will go cleanly into the DB
            //SQL add commands.


            //If the add is successful, return to landing.
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
