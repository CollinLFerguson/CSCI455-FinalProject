using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Collections;
using static System.Windows.Forms.LinkLabel;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Xml.Linq;

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
                        return new Patient(reader["Ssn"].ToString(), 
                            reader["Dob"].ToString(), 
                            char.Parse(reader["Sex"].ToString()), 
                            reader["First_Name"].ToString(), 
                            char.Parse(reader["Minit"].ToString()), 
                            reader["Last_Name"].ToString(), 
                            reader["Primary_Doctor_ID"].ToString(), 
                            reader["Phone_Number"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
            }
            catch(Exception e) //Stops weird crashing? Should fix later
            { 
            
            }

            return null;
        }

        public static bool UpdatePatient(Patient patient, Address address, string Ssn, List<EmergencyContact> contacts, List<EmergencyContact> contactsToRemove, bool noAdd)
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

            if (contacts.Count > 0)
            {
                foreach(EmergencyContact contact in contacts)
                {
                    string name = contact.name;
                    string phone = contact.phone;
                    string relation = contact.relationship;

                    try
                    {
                        //only insert if it doesnt already exist
                        string query = "INSERT INTO Emergency_Contact (Pa_Ssn, Contact_name, Phone_Number, Relation_to_Patient) VALUES ('" + Ssn + "', '" + name + "', '" + phone + "', '" + relation + "');";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        //UPDATE FAILED

                        return false;
                    }
                }
            }
            else
            {
                if (!noAdd)
                {
                    try
                    {
                        string query = "DELETE FROM Emergency_Contact WHERE Pa_Ssn = '" + Ssn + "';";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        //UPDATE FAILED
                        return false;
                    }
                }
       
            }

            if (contactsToRemove.Count > 0)
            {
                foreach (EmergencyContact contact in contactsToRemove)
                {
                    string name = contact.name;
                    string phone = contact.phone;
                    string relation = contact.relationship;

                    try
                    {
                        string query = "DELETE FROM Emergency_Contact WHERE (Pa_Ssn = '" + Ssn + "' AND Contact_Name = '" + name + "' AND Phone_Number = '" + phone + "' AND Relation_to_Patient = '" + relation + "');"; 
                        Debug.WriteLine(query);
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        //UPDATE FAILED
                        MessageBox.Show("4");

                        return false;
                    }
                }
            }

            return UpdatePatientAddress(address, Ssn);
        }

        private static bool UpdatePatientAddress(Address address, string Ssn)
        {
            string query;

            var addressCheck = GetAddress(Ssn);

            if (addressCheck != null)
            {
                //If address already exists
                if (address.getLine2() != "")
                {
                    query = "UPDATE Address SET Line_1 = '" + address.getLine1() + "', Line_2 = '" + address.getLine2() + "', City = '" + address.getCity() + "', State = '" + address.getState() + "', Zip = '" + address.getZip() + "' WHERE Ssn = " + Ssn + ";";
                }
                else
                {
                    query = "UPDATE Address SET Line_1 = '" + address.getLine1() + "', Line_2 = NULL, City = '" + address.getCity() + "', State = '" + address.getState() + "', Zip = '" + address.getZip() + "' WHERE Ssn = " + Ssn + ";";
                }
            }
            else
            {
                if (address.getLine2() != "")
                {
                    query = "INSERT INTO Address(Ssn, Line_1, Line_2, City, State, Zip) VALUES ('" + Ssn + "', '" + address.getLine1() + "', '" + address.getLine2() + "', '" + address.getCity() + "', '" + address.getState() + "', '" + address.getZip() + "')";
                }
                else
                {
                    query = "INSERT INTO Address(Ssn, Line_1, Line_2, City, State, Zip) VALUES ('" + Ssn + "', '" + address.getLine1() + "', NULL, '" + address.getCity() + "', '" + address.getState() + "', '" + address.getZip() + "')";
                }
            }
            
            Debug.WriteLine(query);

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                //UPDATE FAILED
                return false;
            }

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

        public static List<EmergencyContact>? GetContacts(string patientSsn)
        {
            List<EmergencyContact> contacts = new List<EmergencyContact>();

            try
            {
                string query = "SELECT * FROM Emergency_Contact WHERE Pa_Ssn = " + patientSsn;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contacts.Add(new EmergencyContact(reader["Contact_name"].ToString(), reader["Phone_Number"].ToString(), reader["Relation_to_Patient"].ToString()));
                    }
                }

                return contacts;
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
                return null;
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
                return null;
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

        public static Boolean addPrescription(String newPrescription)
        {
            // Adds new prescription to the database
            // true if it was added successfully
            // false if not

            try
            {
                string query = "INSERT INTO PRESCRIPTION((Prescription_ID, Prescribing_Doctor_ID, Patien_Ssn, Medication_ID, Medication_Quantity, Date_Prescribed, Date_Expired) VALUES (" + newPrescription + ");";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                return false;
            }
            return true;
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

        public static Boolean addStaff(String fullStaff)
        {
            /// Adds the sent patient details to the database.
            /// Returns TRUE if the entry was added successfully
            /// Returns FALSE if the entry could not be added.
            {
                try
                {
                    string query = "INSERT INTO Staff(Ssn, Pin, Staff_First_Name, Staff_Last_Name, Staff_Type, Hire_Date, Years_Practicing, Specialty, Staff_Middle_Init) VALUES (" + fullStaff + ");";
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

        public static Boolean addMedication(string fullMedication)
        /// Adds the sent medication details to the database.
        /// Returns TRUE if the entry was added successfully
        /// Returns FALSE if the entry could not be added.
        {
            try
            {
                string query = "INSERT INTO Medication(Medication_ID, Name, Price, Side_Effects) VALUES (" + fullMedication + ");";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                return false; //QUERY FAILED
            }
            return true;
        }
        public static Boolean addMedicationIngredients(string fullIngredients)
        /// Adds the sent medication details to the database.
        /// Returns TRUE if the entry was added successfully
        /// Returns FALSE if the entry could not be added.
        {
            try
            {
                string query = "INSERT INTO Ingredients(Med_ID, Ingredient_Name) VALUES (" + fullIngredients + ");";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                return false; //QUERY FAILED
            }
            return true;
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

        public static DataTable? ViewMedication()
        {
            // list of all possible prescriptions
            try
            {
                string query = "SELECT Medication_ID, Name, Side_Effects, Price FROM Medication;";

                //Debug.WriteLine(query);

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        public static DataTable? GetAllergies(string patientSSN)
        {
            try
            {
                string query = "SELECT Allergy_Name FROM Allergies WHERE Pati_Ssn = \"" + patientSSN + "\"";

                //Debug.WriteLine(query);

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        public static DataTable? GetPatientsDoctor(string staffID)
        {
            try
            {
                string query =
                    "SELECT * FROM Patient WHERE Primary_Doctor_ID = \"" + staffID + "\"";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
        public static DataTable? GetPatientsAdmin()
        {
            try
            {
                string query =
                    "SELECT * FROM Patient";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
        public static DataTable? viewMedications()
        {
            try
            {
                string query =
                    "SELECT * FROM Medication";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        public static DataTable? GetMedication(string patientSSN)
        {
            try
            {
                string query = 
                    "SELECT Prescription_ID, " +
                        "CONCAT(Staff_First_Name, \' \', Staff_Last_name) AS Prescribing_Doctor, " +
                        "Medicat_ID AS Medication_ID, " +
                        "Name AS Medication_Name, " +
                        "Medication_Quantity, " +
                        "Side_Effects, " +
                        "Date_Prescribed, " +
                        "Date_Expired " +
                    "FROM Prescription " +
                    "LEFT JOIN Staff ON Prescription.Prescribing_Doctor_ID = Staff.ID_Number " +
                    "LEFT JOIN Medication ON Prescription.Medicat_ID = Medication.Medication_ID " +
                    "WHERE Patien_Ssn = " + patientSSN;

                //Debug.WriteLine(query);

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }
        public static Boolean CheckAllergy(string patientSSN, string medicationID)
        {
            // checking to see if patient has an allergy to a medication.
            // true = yes the patient is allergic, false = not allergic.
            try
            {
                string query1 =
                    "SELECT Pati_Ssn, Allergy_Name\n" +
                    "FROM Allergies\n" +
                    "LEFT JOIN Medication ON Allergies.Allergy_Name = Medication.Name\n" +
                    "WHERE Medication.Medication_ID = " + medicationID + " AND Allergies.Pati_Ssn = " + patientSSN;

                string query2 =
                    "SELECT Pati_Ssn, Allergy_Name\n" +
                    "FROM Allergies\n" +
                    "LEFT JOIN Ingredients ON Allergies.Allergy_Name = Ingredients.Ingredient_Name\n" +
                    "WHERE Ingredients.Med_ID = " + medicationID + " AND Allergies.Pati_Ssn = " + patientSSN;

                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);

                cmd1.Parameters.AddWithValue("@medicationID", medicationID);
                cmd1.Parameters.AddWithValue("@patientSSN", patientSSN);

                cmd2.Parameters.AddWithValue("@medicationID", medicationID);
                cmd2.Parameters.AddWithValue("@patientSSN", patientSSN);

                using (MySqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
                using (MySqlDataReader reader = cmd2.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                // if error happens, assume patient is allergic
                return true;
            }
            return false;
        }

        public static Boolean AddMedication(string fullAddMedication)
        {
            {
                try
                {
                    string query = "INSERT INTO Medication (Medication_ID, Side_Effects, Name, Price) VALUES (" + fullAddMedication + ")";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }
        public static Boolean AddPrescription(string fullAddMedication)
        {
            {
                try
                {
                    string query = "INSERT INTO Prescription (Prescribing_Doctor_ID, Patien_Ssn, Medicat_ID, Medication_Quantity, Date_Prescribed, Date_Expired) VALUES (" + fullAddMedication + ")";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
        }

        public static DataTable? ViewAppointments( DateTime appointmentTime)
        {
            try
            {
                String query = "SELECT * FROM Appointment WHERE Status = 'A' AND Date_Time BETWEEN '" + appointmentTime.Year + "-" + appointmentTime.Month + "-" + appointmentTime.Day + " 00:00:01' AND '" + appointmentTime.Year + "-" + appointmentTime.Month + "-" + appointmentTime.Day + " 23:59:59'";


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
        public static DataTable? ViewPatientAppointments(string patientSSN)
        {
            try
            {
                string query = "SELECT * FROM Appointment WHERE The_Patients_Ssn = '" + patientSSN + "'";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }
        public static Boolean AddPatientAppointment(string patientSSN, char status, string Notes, DateTime Date_Time)
        {
            try
            {
                
                string query = "INSERT INTO Appointment (The_Patients_Ssn, Status, Notes, Date_Time) VALUES ('" + patientSSN + "','" + status + "','" + Notes + "','" + Date_Time.Year + "-" + Date_Time.Month + "-" + Date_Time.Day + " " + Date_Time.Hour + ":" + Date_Time.Minute + ":" + Date_Time.Second +"')";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return true;

            }
            catch (MySqlException ex)
            {
                return false;
            }

        }
        public static Boolean EditPatientAppointmentStatus(string patientSSN, int appointmentID, char status)
        {
            try
            {
                string query = "UPDATE Appointment SET Status = '" + status + "' WHERE Appointment_ID = " + appointmentID;
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                return true;

            }
            catch (MySqlException ex)
            {
                return false;
            }

        }
        public static DataTable? ViewPatientFinancials(string patientSSN)
        {
            try
            {
                string query = "SELECT * FROM Financial_Report WHERE Pat_Ssn = '" + patientSSN + "'";

                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, connection);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }
            catch (MySqlException ex)
            {
                return null;
            }

        }
        public static string? ValidateUser(string ID, string pin)
        {
            try
            {
                string query = "SELECT * FROM Staff WHERE ID_Number = " + ID + " AND Pin = " + pin;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader["Staff_Type"].ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                //QUERY FAILED
                return null;
            }


            return null;
        }

    }

}
