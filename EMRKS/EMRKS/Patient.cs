using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    public class Patient //TEMPORARY, return to internal
    {
        private string SSN;
        private DateTime DOB;
        private int age;
        private char sex;
        private string firstName;
        private char middleInit;
        private string lastName;
        private string primaryDoctorID;
        private string phoneNumber;
        public bool dateFailed = false;
        public Patient(string SSN, string DOB, char sex, string firstName, char middleInit, string lastName, string primaryDoctorID, string phoneNumber) { 
            this.SSN = SSN;

            try
            {
                this.DOB = DateTime.Parse(DOB);
                DateTime now = DateTime.Today;
                this.age = now.Year - this.DOB.Year;
                if (this.DOB > now.AddYears(-age)) age--;
            }
            catch (Exception ex)
            {
                this.DOB = DateTime.Today;
                 dateFailed = true;
            }

            this.sex = sex;
            this.firstName = firstName;
            this.middleInit = middleInit;
            this.lastName = lastName;
            this.primaryDoctorID = primaryDoctorID;
            this.phoneNumber = phoneNumber;
        }

        public string getSsn() {  return SSN; }
        public string getDOB() { return DOB.ToString().Substring(0, 8); }
        public string getAge() { return age.ToString(); }   
        public string getSex() { return sex.ToString(); }
        public string getFirstName() { return firstName; }
        public string getMiddleInit() { return middleInit.ToString(); }
        public string getLastName() { return lastName; }

        public string? getPrimaryDoctorIDForUpdate()
        {
            //Set to for update becuase primaryDoctorID will just be name here TODO fix in future
            var ID = Database.GetDoctorID(this.primaryDoctorID);

            if (ID != null)
            {
                return ID.ToString();
            }

            return null;
        }
        public string? getPrimaryDoctor()
        {
            var PCM = Database.GetStaff(primaryDoctorID);

            if (PCM != null)
            {
                return PCM.getFullName();
            }
            else
            {
                return primaryDoctorID;
            }
        }

        public string getDOBForUpdate()
        {
            string year, month, day;
            year = DOB.Year.ToString();
            month = DOB.Month.ToString();
            day = DOB.Day.ToString();


            return year + "/" +  month + "/" + day;
        }

        public string getPhoneNumber() { return phoneNumber; }
        public Address? getAddress() { return Database.GetAddress(SSN); }
    } 
}
