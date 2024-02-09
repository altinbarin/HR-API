using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        public IDataResult<Employee> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<Employee> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Employee employee);

        IDataResult<ForgotPasswordDto> ChangePassword(string email);
        public IResult UserNotExists(string email);

        IResult SetPassword (string email, string password);
    }
}
