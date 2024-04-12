using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

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
            if (patientSSN.Length != 9)
            {
                return null;
            }

            try
            {
                string query = "SELECT * FROM Patient WHERE Ssn = " + patientSSN;

                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Patient(reader["Ssn"].ToString(), reader["Dob"].ToString(), char.Parse(reader["Sex"].ToString()), reader["First_Name"].ToString(), char.Parse(reader["Minit"].ToString()), reader["Last_Name"].ToString(), reader["Primary_Doctor_ID"].ToString(), reader["Phone_Number"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }

            return null;
        }

        public static bool UpdatePatient(Patient patient, string Ssn)
        {
            var docID = patient.getPrimaryDoctorIDForUpdate();

            try
            {
                string query = "UPDATE Patient SET Dob = '" + patient.getDOBForUpdate() + "', Sex = '" + patient.getSex() + "', First_Name = '" + patient.getFirstName() + "', Minit = '" + patient.getMiddleInit() + "', Last_Name = '" + patient.getLastName() + "', Primary_Doctor_ID = " + docID + ", Phone_Number = " + patient.getPhoneNumber() + " WHERE Ssn = " + Ssn + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                //UPDATE FAILED
                return false;
            }

            return UpdatePatientAddress();
        }

        private static bool UpdatePatientAddress()
        {




            return true;
        }

        public static string? GetDoctorID(string doctorName)
        {
            List<string> doctorsNameParts = doctorName.Split(" ").ToList();
            string query;

            if (doctorsNameParts.Count == 2)
            {
                query = "SELECT ID_Number FROM Staff WHERE Staff_First_Name = '" + doctorsNameParts[0] + "' AND Staff_Last_Name = '" + doctorsNameParts[1] + "';";
            }
            else
            {
                query = "SELECT ID_Number FROM Staff WHERE Staff_First_Name = '" + doctorsNameParts[0] + "' AND Staff_Last_Name = '" + doctorsNameParts[2] + "' AND Staff_Middle_Init = '" + doctorsNameParts[1] + "';";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader["ID_Number"].ToString();
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

        public static Boolean addPatient(string fullPatient)
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
        {
            try
            {
                string query = "INSERT INTO Patient(ssn, dob, sex, First_Name, Minit, Last_Name, " +
                    "Primary_Doctor_ID, Phone_Number) VALUES (" + fullPatient + ");";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                return false; //QUERY FAILED
            }
            return true;
        }

        public static Boolean addAllergy(String fullAllergy)
        {
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
            {
                try
                {
                    string query = "INSERT INTO Allergies(pati_ssn, Allergy_Name) VALUES (" + fullAllergy + ");";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false; //QUERY FAILED
                }
                return true;
            } 
        }
        public static Boolean addPayment(String fullPayment)
        {
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
            {
                try
                {
                    string query = "INSERT INTO Payment_Card(Patients_Ssn, Name_On_Card, Card_Type, Card_Number, Ccv, Expiration_Date) VALUES (" + fullPayment + ");";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false; //QUERY FAILED
                }
                return true;
            }
        }
        public static Boolean addInsurance(String fullInsurance)
        {
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
            {
                try
                {
                    string query = "INSERT INTO Insurance(P_Ssn, Insurance_Name, Policy_Number, Group_Number, Policy_Holder_Name) VALUES (" + fullInsurance + ");";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false; //QUERY FAILED
                }
                return true;
            }
        }
        public static Boolean addEmContact(String fullEmContact)
        {
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
            {
                try
                {
                    string query = "INSERT INTO Emergency_Contact(Pa_Ssn, Contact_Name, Phone_Number, Relation_to_Patient) VALUES (" + fullEmContact + ");";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false; //QUERY FAILED
                }
                return true;
            }
        }
        public static Boolean addAddress(String fullAddress)
        {
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
            {
                try
                {
                    string query = "INSERT INTO Address(Ssn, Line_1, Line_2, City, State, Zip) VALUES (" + fullAddress + ");";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false; //QUERY FAILED
                }
                return true;
            }
        }

        public static DataTable? ViewUnprocessedFinancialReports()
        {
       
            try
            {
                string query = "SELECT * FROM Financial_Report WHERE Processing_Date = NULL";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;


            }
            catch (MySqlException ex)
            {
                return null; //QUERY FAILED
            }
        }
        public static DataTable? GetMedication(string patientSSN)
        {
            try
            {
                string query = "SELECT * FROM Prescription WHERE GivenSsn = " + patientSSN;
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
                return null;
            }

        }

        public static DataTable? ViewAppointments( DateTime appointmentTime)
        {
            try
            {
                  

                String query = "SELECT * FROM Appointment WHERE Date_Time >" + appointmentTime.Year + "-" + appointmentTime.Month + "-" + appointmentTime.Day + " 00:00:00 AND Date_Time <" + appointmentTime.Year + "-" + appointmentTime.Month + "-" + appointmentTime.Day + " 23:59:59";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;


            }
            catch (MySqlException ex)
            {
                return null; //QUERY FAILED
            }

        }

    }

}
