using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientsAppointmentDemo
{
    class Appointment
    {
       private Queue<Patient> waitingpatients = new Queue<Patient>();

        public Queue<Patient> getAllWaitingPatient()
        {
            return waitingpatients;
        }

        public void addPatient(Patient p)
        {
            waitingpatients.Enqueue(p);
        }

        public Patient seeDoctor()
        {
            return waitingpatients.Dequeue();
        }

    }
}
