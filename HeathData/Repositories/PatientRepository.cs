using Application.Common;
using HealthDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HeathData.Repositories
{
    public class PatientRepository : Repository<Patient>
    {
        public PatientRepository(DbContext context) : base(context)
        {
        }

       

        public Patient GetPatientById(int id)
        {
            return _entities.Find(id);
        }
    }
}