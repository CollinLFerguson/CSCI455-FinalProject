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
            //IF AUTHORIZED DO THE EXECUTE THE BELOW CODE
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
