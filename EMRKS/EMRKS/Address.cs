using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    internal class Address
    {
        private string Ssn;
        private string Line1;
        private string? Line2;
        private string City;
        private string State;
        private string Zip;

        public Address(string Ssn, string Line1, string? Line2, string city, string state, string zip) 
        {
            this.Ssn = Ssn;
            this.Line1 = Line1;
            this.Line2 = Line2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        public string getLine1() { return Line1; }
        public string? getLine2() { return Line2; }
        public string getCity() {  return City; }
        public string getState() { return State; }
        public string getZip() { return Zip; }
    }
}
