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

namespace EMRKS
{
    public partial class AddMedication : UserControl
    {
        private string? currSSN;
        private string? staffID;
        private string? medID;
        private string? quantity;
        private DateTime expirationDate;
        private DateTime todayDate;
        private string? fullInsert;

        public AddMedication()
        {
            InitializeComponent();
        }

        public AddMedication(string currentSsn, string staffID)
        {
            InitializeComponent();
            this.currSSN = currentSsn;
            this.staffID = staffID;
        }

        private void Medications_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.ViewMedication();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cancel
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // continue
            this.medID = textBox1.Text;
            this.quantity = textBox2.Text;
            this.expirationDate = dateTimePicker1.Value;
            this.todayDate = DateTime.Now;

            // Date_Time.Year + "-" + Date_Time.Month + "-" + Date_Time.Day
            // Prescribing_Doctor_ID, Patien_Ssn, Medicat_ID, Medication_Quantity, Date_Prescribed, Date_Expired

            this.fullInsert =
                "'" + this.staffID + "'," +
                "'" + this.currSSN + "'," +
                "'" + this.medID + "'," +
                "'" + this.quantity + "'," +
                "'" + this.todayDate.Year +
                "-" + this.todayDate.Month +
                "-" + this.todayDate.Day + "'," +
                "'" + this.expirationDate.Year +
                "-" + this.expirationDate.Month +
                "-" + this.expirationDate.Day + "'";

            //Debug.WriteLine(medID);
            //Debug.WriteLine(quantity);
            //Debug.WriteLine(expirationDate);
            //Debug.WriteLine(todayDate);
            //Debug.WriteLine(currSSN);

            if (medID.Length == 0 )
            {
                MessageBox.Show("You need to enter in the Medication ID to continue.");
                return;
            }
            //else if (Database.CheckAllergy())
            //{
            //    MessageBox.Show("This patient has an allergy to this medication.");
            //    return;
            //}
            else if (Database.AddPrescription(fullInsert))
            {
                this.Dispose();
                Medication_Manager.dgv1.Update();
                Medication_Manager.dgv1.Refresh();
                Medication_Manager.dgv2.Update();
                Medication_Manager.dgv2.Refresh();

                Medication_Manager.dgv1.DataSource = Database.GetMedication(currSSN);
                Medication_Manager.dgv2.DataSource = Database.GetAllergies(currSSN);
            }
            else
            {
                MessageBox.Show("Error");
                return;
            }
        }
    }
}
