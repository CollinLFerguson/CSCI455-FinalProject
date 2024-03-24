using System.Windows.Forms;

namespace EMRKS
{
    public partial class MainForm : Form
    {
        LandingPage landingPage;
        NoForm noFormPage;
        AddPatient addPatientPage;
        

        public MainForm()
        {
            InitializeComponent();
            landingPage = new LandingPage();
            landingPage.MdiParent = this;

            noFormPage = new NoForm();
            noFormPage.MdiParent = this;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            loginForm.Show();
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
        }

        public void loadLanding()
        {
            LandingPage landingPage = new LandingPage();
            landingPage.MdiParent = this;
            
            noFormPage.Show();
            landingPage.Show();

        }
        public void loadAddPatient(){
            if(addPatientPage == null) {
                addPatientPage = new AddPatient();
                addPatientPage.MdiParent = this;
            }
            addPatientPage.Show();
        }

        public void destroyPages(){
            //** Destroys all pages except for the landingPage and noFormPage.
            //   This function should be called whenever one of the side menu buttons are hit.
            if(addPatientPage != null) { addPatientPage.Close();}
        
        
        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}