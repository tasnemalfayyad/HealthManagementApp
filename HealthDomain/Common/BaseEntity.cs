using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthDomain.Common
{
    public class BaseEntity
    {
        public int Id { get; }
        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}
