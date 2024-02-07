using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class SpendingRequest : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int EmployeeId { get; set; }
        public int? RequestApprovalStatusId { get; set; } = 1;
        public DateTime? RequestDate { get; set; } = DateTime.Now;
        public DateTime? ResponseDate { get; set; }
        public byte[]? Folder { get; set; }
        public string? FolderName { get; set; }
        public bool Status { get; set; } = true;


    }
}
