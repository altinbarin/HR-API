using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        private IEmployeeService _employeeService;

        public AuthController(IAuthService authService, IEmployeeService employeeService)
        {
            _authService = authService;
            _employeeService = employeeService;
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
    }
}
