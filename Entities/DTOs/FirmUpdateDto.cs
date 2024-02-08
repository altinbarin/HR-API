using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FirmUpdateDto:IDto
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
