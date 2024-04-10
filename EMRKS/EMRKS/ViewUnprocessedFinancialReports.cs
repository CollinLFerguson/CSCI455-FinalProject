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
        private static MySqlConnection? connection = null;

        private string server = "sql5.freesqldatabase.com";
        private string username = "sql5679201";
        private string password = "kDArXyz1aB";
        private string databaseName = "sql5679201";


        public ViewUnprocessedFinancialReports()
        {
            InitializeComponent();
            connection = new MySqlConnection();
            connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
            connection.Open();

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewUnprocessedFinancialReports_Load(object sender, EventArgs e)
        {

            try
            {
                string query = "SELECT * FROM Financial_Report WHERE Processing_Date = NULL";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridView1.DataSource = dtbl;


            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }




        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
