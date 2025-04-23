using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Common
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; } = "example@example.com"; // قيمة افتراضية للبريد الإلكتروني
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
    }
}