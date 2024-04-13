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
        public Medication_Manager(string currentSsn)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
        }
        public Medication_Manager()
        {
            InitializeComponent();
        }

        private void Medication_Manager_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine(currSSN);
            dataGridView1.DataSource = Database.GetMedication(currSSN);
            dataGridView2.DataSource = Database.GetAllergies(currSSN);
        }
    }
}
