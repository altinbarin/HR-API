using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var employees = _employeeService.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetSummary(int id)
        {
            var employeeSummary = _employeeService.GetSummary(id);
            return Ok(employeeSummary);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] EmployeeUpdateDto updateDto)
        {

            var employee = _employeeService.GetById(id);

            if (employee == null)
                return NotFound();

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
