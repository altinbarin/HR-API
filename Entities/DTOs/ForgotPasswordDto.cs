﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ForgotPasswordDto : IDto
    {
        public string Email { get; set; }
    }
}
