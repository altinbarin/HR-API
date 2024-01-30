using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VocationLeaveRequestController : ControllerBase
    {
        private readonly IVocationLeaveRequestService _vocationLeaveRequestService;
        private readonly IAuthService _authService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmployeeService _employeeService;

        public VocationLeaveRequestController(IVocationLeaveRequestService vocationLeavRequestService, IAuthService authService, IHttpContextAccessor httpContextAccessor, IEmployeeService employeeService)
        {
            _vocationLeaveRequestService = vocationLeavRequestService;
            _authService = authService;
            _httpContextAccessor = httpContextAccessor;
            _employeeService = employeeService;
        }


        [HttpGet("vocationrequests")]
        public IActionResult GetVocationRequests()
        {
            var result = _vocationLeaveRequestService.GetAllVocationRequests();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateapprovalstatus")]
        public IActionResult UpdateApprovalStatus(VocationLeaveRequestUpdateDto dto)
        {
            
            var result = _vocationLeaveRequestService.UpdateApprovalStatusByName(dto);
            
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("vocationrequestform")]
        public IActionResult GetVocationRequestForm()
        {
            var result = _vocationLeaveRequestService.GetVocationAddForm();
            if (result.Success)
            {
               return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpPost("createvocationrequests")]
        public IActionResult CreateVocationRequest(VocationLeaveRequestAddDto dto)
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;
            var employee = _employeeService.GetByMail(employeeMail);
            var employeeId = employee.Id;

            var result = _vocationLeaveRequestService.AddVocationRequest(dto, employeeId);

            if (result.Success)
            {
                   return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("vocationrequestsbyemployee")]
        public IActionResult GetVocationRequestsByEmployee()
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;
            var employee = _employeeService.GetByMail(employeeMail);
            var employeeId = employee.Id;

            var result = _vocationLeaveRequestService.GetVocationRequestsByEmployeeId(employeeId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
