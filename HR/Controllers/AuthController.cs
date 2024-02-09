using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IEmployeeService _employeeService;
        private IHttpContextAccessor _httpContextAccessor;
        private IClaimService _claimService;

        public AuthController(IAuthService authService, IEmployeeService employeeService, IHttpContextAccessor httpContextAccessor, IClaimService claimService)
        {
            _authService = authService;
            _employeeService = employeeService;
            _httpContextAccessor = httpContextAccessor;
            _claimService = claimService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.EmailForRegister);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto);

            

            //var result = _authService.CreateAccessToken(registerResult.Data);
            if (registerResult.Success)
            {
                return Ok(registerResult.Data);
            }

            return BadRequest(registerResult.Message);
        }


        [HttpPost("forgotpassword")]
        public ActionResult ForgotPassword(string email)
        {
            var userExists = _authService.UserNotExists(email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var result = _authService.ChangePassword(email);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("changepassword")]
        public ActionResult ChangePassword(string newPassword, string claim)
        {
            var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;

            var result = _authService.SetPassword(employeeMail, newPassword);
            var result2 = _claimService.ChangeClaim(employeeMail, claim);

            if (result.Success && result2.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        //[HttpPost("changeclaim")]
        //public ActionResult ChangeClaim(string claim)
        //{
        //    var employeeMail = _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == ClaimTypes.Email).Value;
        //    var result = _claimService.ChangeClaim(employeeMail, claim);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }
        //    return BadRequest(result.Message);
        //}

    }
}
