using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmployeeProfileDto: IDto
    {
        public string TurkishIdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string? SecondLastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public DateTime? DateOfDismissal { get; set; }

        public string BirthLocation { get; set; }

        public string Company { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Profession { get; set; }
        public decimal Salary { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
