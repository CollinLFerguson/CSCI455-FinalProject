using System.Windows.Forms;

namespace EMRKS
{
    public partial class MainForm : Form
    {
        LandingPage landingPage;
        NoForm noFormPage;
        Form? currentPage; //is expected to be null at some points, holds the currently loaded page.
        Database DB = new Database();

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
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        public void loadLanding()
        {
            LandingPage landingPage = new LandingPage();
            landingPage.MdiParent = this;
            
            noFormPage.Show();
            landingPage.Show();

        }
        public void loadAddPatient(){
            if (currentPage != null){ destroyCurrentPage();} //If a page other than NoForm exists, destroy it so it can be replaced.
            Form addPatientPage = new AddPatient(); //Creates the new form
            addPatientPage.MdiParent = this; //Sets the parent to MainForm, so it can be called in the future
            currentPage = addPatientPage; //Sets the currentPage to the recently created form so it can be called later if needed.

            addPatientPage.Show();
            noFormPage.Hide();
        }

        public void loadAddStaff(){
            if (currentPage != null) { destroyCurrentPage(); }
            Form addStaffPage = new AddStaff();
            addStaffPage.MdiParent = this;
            currentPage = addStaffPage;

            addStaffPage.Show();
            noFormPage.Hide();       
        }

        public void loadFindPatient()
        {
            if (currentPage != null) { destroyCurrentPage(); }
            Form findPatientPage = new FindPatient();
            findPatientPage.MdiParent = this;
            currentPage = findPatientPage;

            findPatientPage.Show();
            noFormPage.Hide();
        }
        public void loadViewUnprocessedFinancialReports()
        {
            if (currentPage != null) { destroyCurrentPage(); } 
            Form ViewUnprocessedFincancialReportsPage = new ViewUnprocessedFinancialReports(); 
            ViewUnprocessedFincancialReportsPage.MdiParent = this; 
            currentPage = ViewUnprocessedFincancialReportsPage;

            ViewUnprocessedFincancialReportsPage.Show();
            noFormPage.Hide();
        }

        public void loadViewAppointments()
        {
            if (currentPage != null) { destroyCurrentPage(); }
            Form ViewAppointmentsPage = new ViewAppointments();
            ViewAppointmentsPage.MdiParent = this;
            currentPage = ViewAppointmentsPage;

            ViewAppointmentsPage.Show();
            noFormPage.Hide();
        }

        public void destroyCurrentPage(){
            //** Destroys the currently loaded page.
            //   This function should be called whenever one of the side menu buttons are hit.
            if(currentPage != null){
                currentPage.Close();
                currentPage = null;
            }
            noFormPage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}