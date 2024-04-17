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
    public partial class AddMedicationSideEffectscs : UserControl
    {
        public addMedicationForm parentForm;

        public AddMedicationSideEffectscs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((addMedicationForm)this.parentForm).removeAndReorderIngredients(this);
        }

        public String sqlSerialize()
        {
            return "'" + txtIngredient.Text + "'";
        }
        public bool sqlCanSerealize()
        {
            return txtIngredient.TextLength > 0;
        
        }
    }
}