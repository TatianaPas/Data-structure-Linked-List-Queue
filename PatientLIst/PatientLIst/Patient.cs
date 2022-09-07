using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientLIst
{
    internal class Patient
    {
        public string  Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public Patient(string name, string address, string gender)
        {
            Name = name;
            Address = address;
            Gender = gender;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
