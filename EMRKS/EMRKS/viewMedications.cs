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
    public partial class viewMedications : Form
    {
        public viewMedications()
        {
            InitializeComponent();
        }

        private void viewMedications_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.ViewMedication();
        }
    }
}
