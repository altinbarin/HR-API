using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceRequestController : ControllerBase
    {
        private readonly IAdvanceRequestService _advanceRequestService;
        private readonly IAuthService _authService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmployeeService _employeeService;

        public AdvanceRequestController(IAdvanceRequestService advanceRequestService, IAuthService authService, IHttpContextAccessor httpContextAccessor, IEmployeeService employeeService)
        {
            _advanceRequestService = advanceRequestService;
            _authService = authService;
            _httpContextAccessor = httpContextAccessor;
            _employeeService = employeeService;
        }

        [HttpGet("advancerequests")]
        public IActionResult GetAdvanceRequests()
        {
            var result = _advanceRequestService.GetAllAdvanceRequests();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateapprovalstatus")]
        public IActionResult UpdateApprovalStatus(AdvanceRequestUpdateDto dto)
        {
            var result = _advanceRequestService.UpdateApprovalStatusByName(dto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("createadvancerequestform")]
        public IActionResult GetAdvanceRequestForm(AdvanceRequestAddDto dto)
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;

            var employee = _employeeService.GetByMail(employeeMail);
            var employeeId = employee.Id;

            var result = _advanceRequestService.AddAdvanceRequest(dto, employeeId);

            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
