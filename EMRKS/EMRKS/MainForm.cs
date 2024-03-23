using System.Windows.Forms;

namespace EMRKS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        public void loadLanding()
        {
            LandingPage landingPage = new LandingPage();
            landingPage.MdiParent = this;
            landingPage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}