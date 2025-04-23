using Domin.Common;

using HealthDomain.Entities;
using HeathData;
using HeathData.Repositories;
using HealthDomain;

namespace MainAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (HealthManagementAppDbContext context = new HealthManagementAppDbContext())
            {
                var clinicianRep = new ClinicianRepository(context);
                var addressRep = new AddressRepository(context);
                // تأكد من تمرير معلمة من نوع Clinician بدلاً من Address
                

                var address = new Address
                {
                    City = "City",
                    StreetNumber = "123",
                    BuildingName = "Building A",
                    Country = "country"
                };

                var Clinician = new Clinician
                {
                    FirstName = "Ahmad",
                    LastName = "Abohmaid",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Gender = Gender.Male,
                    Specializing = Specialization.Psychiatry,
                    WorkShift = WorkingShift.EveningShift,
                    Addresses = new List<Address> { address }
                };
                clinicianRep.Add(Clinician);

                // إضافة الطبيب مع العنوان

            }
            using (HealthManagementAppDbContext context = new HealthManagementAppDbContext())
            {
                var patientRep = new PatientRepository(context);
                var appointmentRep = new AppointmentRepository(context);

                var billingRep = new BillingRepository(context);

                var appointment = new Appointment
                {
                    Data = DateTime.Now.AddDays(2),
                    Status = Status.Awaiting
                };

                var address = new Address
                {
                    Country = "CountryName",
                    City = "City",
                    StreetNumber = "123",
                    BuildingName = "Building A",

                };
                var billing = new Billing
                {
                    Amount = 150, // Example amount
                    Date = DateTime.Now,
                    Method = Method.Card,

                    Status = BillingStatus.Paid

                };

                var patient = new Patient
                {
                    FirstName = "Ahmad",
                    LastName = "Abohmaid",

                    DateOfBirth = new DateTime(1990, 1, 1),
                    Gender = Gender.Male,
                    Phone = "11-333-455",
                    Appointments = new List<Appointment> { appointment },
                    Address = address,
                    Billings = new List<Billing> { billing }

                };

                patientRep.Add(patient);
            }



        }

        private static void GetPatient()
        {
            using (HealthManagementAppDbContext context = new HealthManagementAppDbContext())
            {
             var patients =context.Patients.ToList();
                foreach (var patient in patients)
                {
                    
                    Console.WriteLine($"Patient: {patient.LastName}");  
                }
            }

        }
    }
}

