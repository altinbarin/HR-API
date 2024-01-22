using Core;

namespace Entities.DTOs
{
    public class HeadOfDepartmentSummaryDto : IDto
    {
        public string Firstname { get; set; }
        public string? Middlename { get; set; }
        public string Lastname { get; set; }

        public byte[]? ImageData { get; set; }

        public string Company { get; set; }

        public string Position { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

    }
}
