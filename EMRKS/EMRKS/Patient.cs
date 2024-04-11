using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    public class Patient
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

        public Patient(string SSN, string DOB, char sex, string firstName, char middleInit, string lastName, string primaryDoctorID, string phoneNumber) { 
            this.SSN = SSN;
            this.DOB = DateTime.Parse(DOB);
            DateTime now = DateTime.Today;
            this.age = now.Year - this.DOB.Year;
            if (this.DOB > now.AddYears(-age)) age--;

            this.sex = sex;
            this.firstName = firstName;
            this.middleInit = middleInit;
            this.lastName = lastName;
            this.primaryDoctorID = primaryDoctorID;
            this.phoneNumber = phoneNumber;
        }

        public string getSsn() {  return SSN; }
        public string getDOB() { return DOB.ToString().Substring(0, 10); }
        public string getAge() { return age.ToString(); }   
        public string getSex() { return sex.ToString(); }
        public string getFirstName() { return firstName; }
        public string getMiddleInit() { return middleInit.ToString(); }
        public string getLastName() { return lastName; }
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
        public string getPhoneNumber() { return phoneNumber; }
        public Address? getAddress() { return Database.GetAddress(SSN); }
    } 
}
