using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private IFirmService _firmService;

        public FirmController(IFirmService firmService)
        {
            _firmService = firmService;
        }


        [HttpGet("firms")]
        public IActionResult GetFirms()
        
        {
            var firms = _firmService.GetAll();
            return Ok(firms);
        }



        [HttpPost("addfirm")]
        public IActionResult AddFirm(FirmAddDto dto)
        {
            var result = _firmService.AddFirm(dto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
