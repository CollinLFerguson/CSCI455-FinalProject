using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    internal class Database
    {
        private static MySqlConnection? connection = null;

        private string server = "sql5.freesqldatabase.com";
        private string username = "sql5679201";
        private string password = "kDArXyz1aB";
        private string databaseName = "sql5679201";

        public Database() { 
            connection = new MySqlConnection();
            connection.ConnectionString = "server=" + server + ";uid=" + username + ";pwd=" + password + ";database=" + databaseName;
            connection.Open();
        }

        public static Patient? GetPatient(string patientSSN)
        {
            try
            {
                string query = "SELECT * FROM Patient WHERE Ssn = " + patientSSN;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Patient(reader["Ssn"].ToString(), reader["Dob"].ToString(), Int32.Parse(reader["Age"].ToString()), char.Parse(reader["Sex"].ToString()), reader["First_Name"].ToString(), char.Parse(reader["Minit"].ToString()), reader["Last_Name"].ToString(), reader["Primary_Doctor_ID"].ToString(), reader["Phone_Number"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }

            return null;
        }

        public static Staff? GetStaff(string staffID)
        {
            try
            {
                string query = "SELECT * FROM Staff WHERE ID_Number = " + staffID;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Staff(reader["ID_Number"].ToString(), reader["Ssn"].ToString(), reader["Pin"].ToString(), reader["Staff_First_Name"].ToString(), reader["Staff_Last_Name"].ToString(), reader["Staff_Type"].ToString(), reader["Hire_Date"].ToString(), reader["Years_Practicing"].ToString(), reader["Specialty"].ToString(), reader["Staff_Middle_Init"].ToString());
                    }
                }


            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }

            return null;
        }

        public static Address? GetAddress(string SSN)
        {
            try
            {
                string query = "SELECT * FROM Address WHERE Ssn = " + SSN;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Address(reader["Ssn"].ToString(), reader["Line_1"].ToString(), reader["Line_2"].ToString(), reader["City"].ToString(), reader["State"].ToString(), reader["Zip"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }

            return null;
        }

    }
}
