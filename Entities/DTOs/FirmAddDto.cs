using Core;

namespace Entities.DTOs
{
    public class FirmAddDto:IDto
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public string MersisNo { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public byte[]? Logo { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public int EmployeeCount { get; set; }

        public DateTime DateOfFoundation { get; set; }
        public DateTime ConctractStartDate { get; set; }
        public DateTime ConctractEndDate { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
