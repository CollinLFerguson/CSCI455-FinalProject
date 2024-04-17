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
    public partial class addMedicationForm : Form
    {
        List<AddMedicationSideEffectscs> medicationIngredients = new List<AddMedicationSideEffectscs>();

        public addMedicationForm()
        {
            InitializeComponent();
        }

        private void btnMedicationSideEffect_Click(object sender, EventArgs e)
        {
            AddMedicationSideEffectscs currentControl = new AddMedicationSideEffectscs();
            medicationIngredients.Add(currentControl);
            groupBoxIngredients.Controls.Add(currentControl);

            currentControl.parentForm = this;

            currentControl.Location = new Point(5, 50 + (currentControl.Height) * (medicationIngredients.Count - 1));
        }
        public void removeAndReorderIngredients(AddMedicationSideEffectscs toBeDeleted)
        {
            medicationIngredients.Remove(toBeDeleted);
            groupBoxIngredients.Controls.Remove(toBeDeleted);

            for (int i = 0; i < medicationIngredients.Count; i++)
            {
                medicationIngredients.ElementAt(i).Location = new Point(5, 50 + (medicationIngredients.ElementAt(i).Height) * (i));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            //Code to add a new medication.



            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }
    }
}
