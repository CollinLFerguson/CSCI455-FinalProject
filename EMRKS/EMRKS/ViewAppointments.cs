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
            //Database database = new Database();
            //int year;
            //int month;
            //int day;

            //String sqlStatement = "SELECT * FROM Appointent WHERE Date_Time >" + year + "-" + month + "-" + day + " 00:00:00 AND Date_Time <" + year + "-" + month + "-" + day + " 23:59:59";

        }
    }
}
