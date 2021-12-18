using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsAppointmentDemo
{
    class Patient
    {
        public string name { get; set; }
        public string address { get; set; }
        public bool isMale { get; set; }    

        public Patient(string name, string address, bool isMale)
        {
            this.name = name;
            this.address = address;
            this.isMale = isMale;
        }

        public override string ToString()
        {
            return name;
        }


    }
}
