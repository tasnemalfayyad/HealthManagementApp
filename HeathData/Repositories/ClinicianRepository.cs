using Application.Common;
using HealthDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathData.Repositories
{
    public class ClinicianRepository : Repository<Clinician>
    {
        public ClinicianRepository(DbContext context) : base(context)
        {
        }
     
    }
}
