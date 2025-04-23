using Domin.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDomain.Entities
{
 
    public class Patient:Person
    {
        public Address Address;

        public string Phone { get; set; }
          
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    
        public List<Billing> Billings { get; set; }= new List<Billing>();   
        public List<Clinician> Clinicians { get; set;} = new List<Clinician>();

        public List<Address> Addresss { get; set; } =new List<Address>();
    }
}
