using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientLIst
{
    internal class Appointmnet
    {
        public Queue <Patient> waitingPatient = new Queue <Patient> ();

        public void addPatientToList(Patient p)
        {
            waitingPatient.Enqueue (p);
        }

        public Queue <Patient> getAllWaitingPatients()
        {
            return waitingPatient;
        }

        public Patient seeDoctor()
        {
            return waitingPatient.Dequeue();
        }
    }
}
