using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    internal class Patient
    {
        private string SSN;
        private DateOnly DOB;
        private int age;
        private char sex;
        private string firstName;
        private char middleInit;
        private string lastName;
        private string primaryDoctorID;
        private string phoneNumber;

        public Patient(string SSN, DateOnly DOB, int age, char sex, string firstName, char middleInit, string lastName, string primaryDoctorID, string phoneNumber) { 
            this.SSN = SSN;
            this.DOB = DOB;
            this.age = age;
            this.sex = sex;
            this.firstName = firstName;
            this.middleInit = middleInit;
            this.lastName = lastName;
            this.primaryDoctorID = primaryDoctorID;
            this.phoneNumber = phoneNumber;
        }
    }
}
