using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.Helpers;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IEmployeeService _employeeService;
        private ITokenHelper _tokenHelper;
        private IMapper _mapper;
        private IEmployeeDal _employeeDal;

        public AuthManager(ITokenHelper tokenHelper, IEmployeeService employeeService, IMapper mapper, IEmployeeDal employeeDal)
        {
            _tokenHelper = tokenHelper;
            _employeeService = employeeService;
            _mapper = mapper;
            _employeeDal = employeeDal;
        }


        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(UserForRegisterDtoValidator))]
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
               
                var userOperationClaim = new UserOperationClaim
                {
                    EmployeeId = employee.Id,
                    OperationClaimId = 4
                };
                _employeeDal.AddUserOperationClaim(userOperationClaim);
               

                return new SuccessDataResult<Employee>(employee, Messages.UserRegistered);
            }

            return new ErrorDataResult<Employee>(Messages.EmailNotSent);
        }


        [ValidationAspect(typeof(UserForLoginDtoValidator))]
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

        public IResult UserNotExists(string email)
        {

            if (_employeeService.GetByMail(email) == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(Employee employee)
        {
            var claims = _employeeService.GetClaims(employee);
            var accessToken = _tokenHelper.CreateToken(employee, claims);


            //sadece ilk claim gönderiliyor. 
            accessToken.Claim = claims[0].Name;

            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public IDataResult<ForgotPasswordDto> ChangePassword(string email)
        {

            var user = _employeeService.GetByMail(email);
            if (user is null)
            {
                return new ErrorDataResult<ForgotPasswordDto>(Messages.UserNotFound);
            }
            byte[] passwordHash, passwordSalt;
            string password;
            bool isEmailSent = EmailSender.SendPasswordCodeEmail(email, out password);
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            if (isEmailSent)
            {
                _employeeDal.Update(user);

                return new SuccessDataResult<ForgotPasswordDto>(Messages.PasswordChanged);
            }

            return new ErrorDataResult<ForgotPasswordDto>(Messages.EmailNotSent);
        }

        public IResult SetPassword(string email, string password)
        {
            var user = _employeeService.GetByMail(email);
            if (user is null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _employeeDal.Update(user);
            return new SuccessResult(Messages.PasswordChanged);
        }
    }
}
