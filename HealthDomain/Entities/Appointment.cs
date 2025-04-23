using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDomain.Entities
{
    public enum Status
    {
        Canceled,
        Done,
        Awaiting
    }
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Status Status { get; set; }

        public int ClinicianId { get; set; }
       public Clinician Clinician { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime Data { get; set; }
    }

}

