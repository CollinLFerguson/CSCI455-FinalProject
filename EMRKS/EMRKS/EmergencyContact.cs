using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRKS
{
    internal class EmergencyContact
    {
        public string name;
        public string phone;
        public string relationship;

        public EmergencyContact(string name, string phone, string relationship)
        {
            this.name = name;
            this.phone = phone;
            this.relationship = relationship;
        }
    }
}
