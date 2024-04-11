using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Patient patient = FindPatient.getPatient();

        public Medication_Manager()
        {
            InitializeComponent();
        }

        private void Medication_Manager_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = Database.GetMedication(patient.getSsn());
            }
        }
    }
}
