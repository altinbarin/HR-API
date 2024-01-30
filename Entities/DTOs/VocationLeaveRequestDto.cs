using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class VocationLeaveRequestDto:IDto
    {
        public int Id { get; set; }
        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; set; }

        public DateTime? ResponseDate { get; set; }

        public int? EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }

        public string VocationLeaveTypeName { get; set; }

        public string RequestApprovalStatusName { get; set; }
    }
}
