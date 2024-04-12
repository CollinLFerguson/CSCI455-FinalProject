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
            string appointmentTime = dtpDOB.Text;
            appointmentTime = String.Concat(appointmentTime, " 00:00:00");

            DateTime myDate = Convert.ToDateTime(appointmentTime);   //("yyyy-MM-dd HH:mm:ss");

            dataGridView1.DataSource = Database.ViewAppointments(myDate.Date);
        }
    }
}
