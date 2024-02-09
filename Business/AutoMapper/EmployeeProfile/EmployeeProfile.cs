using AutoMapper;
using Business.BusinessRule;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper.EmployeeProfile
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeSummaryDto>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDto>().ReverseMap();
            CreateMap<EmployeeRules, IEmployeeRules>().ReverseMap();
            CreateMap<Employee, UserForLoginDto>().ReverseMap();
            CreateMap<Employee, UserForRegisterDto>().ReverseMap();
            CreateMap<Employee, EmployeeProfileDto>().ReverseMap();
            CreateMap<Employee, ForgotPasswordDto>().ReverseMap();
            //CreateMap<Firm, FirmAddDto>().ReverseMap();
            CreateMap<Employee, EmployeesDto>().ReverseMap();
        }
    }
}
