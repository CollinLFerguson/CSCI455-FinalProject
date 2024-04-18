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
using MySql.Data.MySqlClient;

namespace EMRKS
{
    public partial class Medication_Manager : UserControl
    {
        private string? currSSN;
        private string? staffID;
        public static DataGridView dgv1 = new DataGridView();
        public static DataGridView dgv2 = new DataGridView();

        public Medication_Manager()
        {
            InitializeComponent();
            addMedication1.Hide();
        }

        public Medication_Manager(string currentSsn, string staffID)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
            this.staffID = staffID;
            addMedication1.Hide();
        }

        private void Medication_Manager_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine(currSSN);
            dgv1 = dataGridView1;
            dgv2 = dataGridView2;
            dgv1.DataSource = Database.GetMedication(currSSN);
            dgv2.DataSource = Database.GetAllergies(currSSN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add Medication Button
            AddMedication addMedication1 = new AddMedication(currSSN, staffID);
            addMedication1.Parent = this;
            addMedication1.Location = new Point(0, 0);
            addMedication1.BringToFront();
            addMedication1.Show();
        }
    }
}
