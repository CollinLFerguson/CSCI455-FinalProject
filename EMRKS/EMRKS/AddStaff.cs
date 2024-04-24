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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (!sqlStaffCanSerealize())
            { 
                MessageBox.Show("The staff member can not be added. Verify all necessary items are present."); 
                return; 
            }

            String sqlStatement = sqlStaffSerealize();

            if (!Database.addStaff(sqlStatement))
            {
                MessageBox.Show("The staff member can not be added. Verify all necessary items are present.");
                return;
            }

            if (sqlAddressCanSerialize())
            {
                sqlStatement = "'" + txtSSN.Text + "'," + sqlAddressSerealize();

                if (Database.addAddress(sqlStatement) == false) //Adds the patient to the database.
                {
                    MessageBox.Show("The staff member can not be added. Verify all necessary items are present."); 
                    return; //create a popup here.
                }
            }

            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }

        private String sqlStaffSerealize()
        {
            if (comboStaffType.Text == "Doctor")
            {
                return "'" + txtSSN.Text + "'," +
                    "'" + txtPin.Text + "'," +
                    "'" + txtFName.Text + "'," +
                    "'" + txtLName.Text + "'," +
                    "'" + comboStaffType.Text[0] + "'," +
                    "'" + dtpHireDate.Text + "'," +
                    "'" + txtDocYearsPracticing.Text + "'," +
                    "'" + txtDocSpeciality.Text + "'," +
                    "'" + txtMInit.Text + "'";
            }
            else
            {
                return "'" + txtSSN.Text + "'," +
                    "'" + txtPin.Text + "'," +
                    "'" + txtFName.Text + "'," +
                    "'" + txtLName.Text + "'," +
                    "'" + comboStaffType.Text[0] + "'," +
                    "'" + dtpHireDate.Text + "'," +
                    "NULL," +
                    "NULL," +
                    "'" + txtMInit.Text + "'";
            }

        }

        private Boolean sqlStaffCanSerealize()
        {
            if (txtSSN.TextLength != 0 && txtPin.TextLength != 0 && dtpHireDate.Text.Length != 0
                && txtLName.TextLength != 0 && txtFName.TextLength != 0 && comboStaffType.Text.Length != 0)
            {
                if (comboStaffType.Text == "Doctor" && txtDocSpeciality.TextLength != 0
                    && txtDocYearsPracticing.TextLength != 0)
                {
                    return true;
                }
                else if (comboStaffType.Text != "Doctor")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private Boolean sqlAddressCanSerialize()
        {
            if (txtAddressLn1.TextLength != 0 && txtCity.TextLength != 0 &&
               comboState.Text.Length != 0 && txtZip.TextLength != 0)
            { return true; }
            else
            {
                return false;
            }
        }
        private String sqlAddressSerealize()
        {
            if (txtAddressLn2.TextLength != 0)
            {
                return "'" + txtAddressLn1.Text + "'," +
                        "'" + txtAddressLn2.Text + "'," +
                        "'" + txtCity.Text + "'," +
                        "'" + comboState.Text + "'," +
                        "'" + txtZip.Text + "'";
            }
            else
            {
                return "'" + txtAddressLn1.Text + "'," +
                        "NULL," +
                        "'" + txtCity.Text + "'," +
                        "'" + comboState.Text + "'," +
                        "'" + txtZip.Text + "'";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboStaffType.Text == "Doctor")
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.MdiParent != null) { ((MainForm)this.MdiParent).destroyCurrentPage(); } //Returns back to landing page
        }
    }
}
