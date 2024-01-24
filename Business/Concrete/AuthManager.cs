using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Helpers;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IEmployeeService _employeeService;
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;

        public AuthManager(ITokenHelper tokenHelper, IEmployeeService employeeService, IMapper mapper)
        {
            _tokenHelper = tokenHelper;
            _employeeService = employeeService;
            _mapper = mapper;
        }


        [SecuredOperation("admin")]
        public IDataResult<Employee> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            string password;
            bool isEmailSent = EmailSender.SendPasswordCodeEmail(userForRegisterDto.EmailForRegister, out password);
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var employee = _mapper.Map<Employee>(userForRegisterDto);
            employee.TitleId = 1;
            employee.PasswordHash = passwordHash;
            employee.PasswordSalt = passwordSalt;

            if (isEmailSent)
            {
                _employeeService.Add(employee);

                return new SuccessDataResult<Employee>(employee, Messages.UserRegistered);
            }

            return new ErrorDataResult<Employee>(Messages.EmailNotSent);
        }

        public IDataResult<Employee> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _employeeService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<Employee>(Messages.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Employee>(Messages.PasswordError);
            }

            return new SuccessDataResult<Employee>(userToCheck, Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {

            if (_employeeService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(Employee employee)
        {
            var claims = _employeeService.GetClaims(employee);
            var accessToken = _tokenHelper.CreateToken(employee, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
