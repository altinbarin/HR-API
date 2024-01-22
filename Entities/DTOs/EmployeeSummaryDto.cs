using Core;

namespace Entities.DTOs
{
    public class EmployeeSummaryDto :IDto
    {
        public byte[]? ImageData { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string? Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Profession { get; set; }

        public string Department { get; set; }

    }
}
