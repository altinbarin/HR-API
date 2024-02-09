using AutoMapper;
using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        private IHttpContextAccessor _httpContextAccessor;
        private IMapper _mapper;

        public EmployeeController(IEmployeeService employeeService, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _employeeService = employeeService;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        [HttpGet("profilim")]
        public IActionResult Profilim()
        {
            
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x=>x.Type == ClaimTypes.Email).Value;
            
            
            var employee = _employeeService.GetProfile(employeeMail);
            return Ok(employee);
        }

        [HttpGet("employees")]
        public IActionResult GetEmployees()
        {
            var employees = _employeeService.GetAll();
            var employeesDto = _mapper.Map<List<EmployeesDto>>(employees);

            return Ok(employeesDto);
        }

        [HttpPost("updateemployeestatus")]
        public IActionResult UpdateEmployeeStatus(EmployeeStatusUpdateDto employeeStatusUpdateDto)
        {
            var result = _employeeService.UpdateEmployeeStatus(employeeStatusUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }



        [HttpGet("summary")]
        public IActionResult GetSummary()
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;
            var employee = _employeeService.GetByMail(employeeMail);

            var employeeSummary = _employeeService.GetSummary(employee.Id);
            return Ok(employeeSummary);
        }



        [HttpPut("update")]
        public IActionResult Update([FromBody] EmployeeUpdateDto updateDto)
        {

            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;

            var employee = _employeeService.GetByMail(employeeMail);

            //kontrol edilecek
            employee.Address = updateDto.Address;
            employee.PhoneNumber = updateDto.PhoneNumber;
            employee.ImageData = updateDto.ImageData;

            var result = _employeeService.Update(employee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
