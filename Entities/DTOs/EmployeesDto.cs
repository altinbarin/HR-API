using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmployeesDto:IDto
    {
        public int Id { get; set; }

        public string TurkishIdentificationNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public bool Status { get; set; } = true;
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? DateOfDismissal { get; set; }
        public string Company { get; set; }

        public string Position { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public byte[]? ImageData { get; set; }

    }
}
