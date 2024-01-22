using Core;

namespace Entities.DTOs
{
    public class HeadOfDepartmentUpdateDto : IDto
    {
        public string PhoneNumber { get; set; }
        public byte[]? ImageData { get; set; }
        public string Address { get; set; }
    }
}
