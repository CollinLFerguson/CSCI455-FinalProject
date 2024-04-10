using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    internal class Staff
    {
        private string IDNumber;
        private string Ssn;
        private string pin;
        private string firstName;
        private string middleInitial;
        private string lastName;
        private string staffType;
        private string? yearsPracticing;
        private string? specialty;

        public Staff(string IDNumber, string SSN, string Pin, string firstName, string Lastname, string staffType, string hireDate, string? yearsPracticing, string? specialty, string middleInit) { 
            this.IDNumber = IDNumber;
            this.Ssn = SSN;
            this.pin = Pin;
            this.firstName = firstName;
            this.lastName = Lastname;
            this.staffType = staffType;
            this.yearsPracticing = yearsPracticing;
            this.specialty = specialty;
        }

        public string getFullName() { return firstName + " " + middleInitial + " " + lastName; }
    }
}
