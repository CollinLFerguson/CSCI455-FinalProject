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
        public Medication_Manager()
        {
            InitializeComponent();
            addMedication1.Hide();
        }
        public Medication_Manager(string currentSsn)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
            addMedication1.Hide();
        }

        private void Medication_Manager_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine(currSSN);
            dataGridView1.DataSource = Database.GetMedication(currSSN);
            dataGridView2.DataSource = Database.GetAllergies(currSSN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add Medication Button
            AddMedication addMedication1 = new AddMedication(currSSN);
            addMedication1.Parent = this;
            addMedication1.Location = new Point(0, 0);
            addMedication1.BringToFront();
            addMedication1.Show();
        }
    }
}
