﻿using System;
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
    public partial class viewPatientsAdmin : Form
    {
        public viewPatientsAdmin()
        {
            InitializeComponent();
        }

        private void viewPatientsAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.GetPatientsAdmin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }
    }
}
