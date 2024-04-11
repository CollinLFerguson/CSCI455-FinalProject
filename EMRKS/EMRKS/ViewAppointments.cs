using Microsoft.VisualBasic;
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
    public partial class ViewAppointments : Form
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnPopData_Click(object sender, EventArgs e)
        {
            string appointmentTime;
            appointmentTime = dtpDOB.Text;

            // need to remove / from appointment timme and replace with -

            DateTime myDate = DateTime.ParseExact(appointmentTime + " 00:00:00,531", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            dataGridView1.DataSource = Database.ViewAppointments(myDate.Date);
        }
    }
}
