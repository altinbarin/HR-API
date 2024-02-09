using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmployeeStatusUpdateDto:IDto
    {
        public int Id { get; set; }
        public bool Status { get; set; }
    }
}
