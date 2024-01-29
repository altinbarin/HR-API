using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AdvanceRequestAddDto:IDto
    {
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
