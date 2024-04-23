using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMRKS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void onLogin(object sender, EventArgs e)
        {
            if (this.MdiParent == null) { this.Close(); return;} //Prevents the rare case where a login form was created without a parent.

            string user = txtUsername.Text;
            string pin = txtPin.Text;

            if (user.Length == 0 && pin.Length == 0)
            {
                this.Hide();
                ((MainForm)this.MdiParent).loadLanding(user, "S");
                this.Close();

                return;
            }

            string? staffType = Database.ValidateUser(user, pin);

            if (staffType != null)
            {
                this.Hide();
                ((MainForm)this.MdiParent).loadLanding(user, staffType);
                this.Close();
            }
            else
            {
                MessageBox.Show("INVALID ID OR PIN");
            }
        }
    }
}
