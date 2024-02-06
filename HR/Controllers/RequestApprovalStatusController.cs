using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestApprovalStatusController : ControllerBase
    {
        private IRequestApprovalStatusService _requestApprovalStatusService;

        public RequestApprovalStatusController(IRequestApprovalStatusService requestApprovalStatusService)
        {
            _requestApprovalStatusService = requestApprovalStatusService;
        }

        [HttpGet("getstatus")]
        public IActionResult GetRequestApprovalStatus()
        {
            var result = _requestApprovalStatusService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
