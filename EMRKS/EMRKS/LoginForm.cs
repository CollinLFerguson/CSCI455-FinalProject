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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void onLogin(object sender, EventArgs e)
        {
            if (this.MdiParent == null) { this.Close(); return;} //Prevents the rare case where a login form was created without a parent.



            //validateUser(txtUsername.text, txtPin.text);
                      
            
            //IF AUTHORIZED DO THE EXECUTE THE BELOW CODE
            
            this.Hide();
            ((MainForm)this.MdiParent).loadLanding();
            this.Close();


        }
    }
}
