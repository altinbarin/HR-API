using Core;

namespace Entities.DTOs
{
    public class EmployeeUpdateDto : IDto
    {
        public byte[]? ImageData { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

    }
}
