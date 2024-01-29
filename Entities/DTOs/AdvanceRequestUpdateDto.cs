using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AdvanceRequestUpdateDto:IDto
    {
        public int Id { get; set; }

        public string RequestApprovalStatusName { get; set; }
    }
}
