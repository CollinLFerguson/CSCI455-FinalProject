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
        public bool nameModified = false;
        public bool phoneModified = false;
        public bool relationshipModified = false;

        public EmergencyContact(string name, string phone, string relationship, bool nameModified, bool phoneModified, bool relationshipModified)
        {
            this.name = name;
            this.phone = phone;
            this.relationship = relationship;
            this.nameModified = nameModified;
            this.phoneModified = phoneModified;
            this.relationshipModified = relationshipModified;
        }
    }
}
