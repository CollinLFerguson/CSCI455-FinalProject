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
    public partial class Financial_Manager : UserControl
    {
        private string? currSSN;
        public Financial_Manager()
        {
            InitializeComponent();
        }
        public Financial_Manager(string currentSsn)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
        }
        private void Financial_Manager_Load(object sender, EventArgs e)
        {
            // this will populate the datagridview for the scheduled appoinments for a specific patient

            dataGridView1.DataSource = Database.ViewPatientFinancials(currSSN);

        }


    }
}
