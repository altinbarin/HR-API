using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AdvanceRequestDto:IDto
    {
        public int Id { get; set; }

        public DateTime? RequestDate { get; set; }

        public DateTime? ResponseDate { get; set; }


        public string RequestApprovalStatusName { get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }

        public decimal Price { get; set; }

        public string Currency { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public bool Status { get; set; }


    }
}
