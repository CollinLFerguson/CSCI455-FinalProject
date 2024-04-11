using MySql.Data.MySqlClient;
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
    public partial class ViewUnprocessedFinancialReports : Form
    {
        //private static MySqlConnection? connection = null;

        //private string server = "sql5.freesqldatabase.com";
        //private string username = "sql5679201";
        //private string password = "kDArXyz1aB";
        //private string databaseName = "sql5679201";

        private Database database = new Database();
        public ViewUnprocessedFinancialReports()
        {
            InitializeComponent();

            
            //connection = new MySqlConnection();
            //connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
            //connection.Open();

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewUnprocessedFinancialReports_Load(object sender, EventArgs e)
        {


            database.ViewUnprocessedFinancialReports(dataGridView1);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
