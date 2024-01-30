using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpendingRequestController : ControllerBase
    {

        private readonly ISpendingRequestService _spendingRequestService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmployeeService   _employeeService;

        public SpendingRequestController(ISpendingRequestService spendingRequestService, IHttpContextAccessor httpContextAccessor, IEmployeeService employeeService)
        {
            _spendingRequestService = spendingRequestService;
            _httpContextAccessor = httpContextAccessor;
            _employeeService = employeeService;
        }

        [HttpGet("spendingrequests")]
        public IActionResult GetSpendingRequests()
        {
            var result = _spendingRequestService.GetAllSpendingRequests();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpPut("updateapprovalstatus")]
        public IActionResult UpdateApprovalStatus(SpendingRequestUpdateDto dto)
        {
            var result = _spendingRequestService.UpdateApprovalStatusByName(dto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("createspendingrequestform")]
        public IActionResult GetSpendingRequestForm(SpendingRequestAddDto dto)
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;

            var employee = _employeeService.GetByMail(employeeMail);
            var employeeId = employee.Id;

            var result = _spendingRequestService.AddSpendingRequest(dto, employeeId);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("getspendingrequestformbyemployee")]
        public IActionResult GetSpendingRequestByEmployee()
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;
            var employee = _employeeService.GetByMail(employeeMail);
            var employeeId = employee.Id;

            var result = _spendingRequestService.GetSpendingRequestsByEmployeeId(employeeId);
            if (result.Success)
            {
                   return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


    }
}
