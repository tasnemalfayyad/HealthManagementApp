using Domin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDomain.Entities
{
    public enum Specialization
    {
        Cardiology,
        Dermatology,
        Neurology,
        Pediatrics,
        Orthopedics,
        Ophthalmology,
        Psychiatry,
        Surgery,
        Other
    }
    public enum WorkingShift
    {
        DayShift,
        NightShift,
        EveningShift
    }
    public class Clinician : Person
    {
       
        public Specialization Specializing { get; set; }
        public WorkingShift WorkShift { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public List<Patient> Patients { get; set; } = new List<Patient>();
       
        public List<Address> Addresses { get; set; }= new List<Address>();
    }
}
