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
    public partial class AddMedication : UserControl
    {
        private string? currSSN;

        public AddMedication()
        {
            InitializeComponent();
        }

        public AddMedication(string currentSsn)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
        }

        private void Medications_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.ViewMedication();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
