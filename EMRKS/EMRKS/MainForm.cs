namespace EMRKS
{
    public partial class MainForm : Form
    {
        LoginForm loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Lets get that A!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            loginForm.Close();
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

        }
    }
}
