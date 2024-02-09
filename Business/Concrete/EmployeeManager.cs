using AutoMapper;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.BusinessRule;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Mappings;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        readonly IMapper _mapper;
        readonly IEmployeeDal _employeeDal;
        readonly IEmployeeRules _employeeRules;

        public EmployeeManager(IMapper mapper, IEmployeeDal employeeDal, IEmployeeRules employeeRules)
        {
            _mapper = mapper;
            _employeeDal = employeeDal;
            _employeeRules = employeeRules;
        }


        //[SecuredOperation("admin")]
        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll(h => h.Status);
        }

        public Employee GetById(int employeeId)
        {
            var employee = _employeeDal.GetEmployee(h => h.Id == employeeId);
            return employee;
        }

        public EmployeeSummaryDto GetSummary(int employeeId)
        {
            var employee = _employeeDal.GetSummary(employeeId);
            var employeeSummaryDto = _mapper.Map<EmployeeSummaryDto>(employee);

            return employeeSummaryDto;
        }

        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(EmployeeValidator))]
        public IResult Update(Employee employee)
        {
            IResult result = BusinessRules.Run(_employeeRules.CheckIfPhoneNumberExist(employee.PhoneNumber));
            if (result != null)
            {
                return result;
            }

            _employeeDal.Update(employee);

            return new SuccessResult(Messages.EmployeeUpdated);
        }

        public List<OperationClaim> GetClaims(Employee employee)
        {
            var claims = _employeeDal.GetClaims(employee);
            return claims;
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public Employee GetByMail(string email)
        {
            var employee = _employeeDal.Get(u => u.Email == email);
            return employee;
        }

        public EmployeeProfileDto GetProfile(string employeeMail)
        {
            var employee = _employeeDal.GetEmployee(h => h.Email == employeeMail);
            var employeeProfileDto = _mapper.Map<EmployeeProfileDto>(employee);
            return employeeProfileDto;
        }

        public IResult UpdateEmployeeStatus(EmployeeStatusUpdateDto employeeStatusUpdateDto)
        {
            var employee = _employeeDal.Get(e => e.Id == employeeStatusUpdateDto.Id);

            if (employee == null)
            {
                return new ErrorResult(Messages.EmployeeUpdated);
            }
            employee.Status = employeeStatusUpdateDto.Status;
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EmployeeUpdated);
        }
    }
}
