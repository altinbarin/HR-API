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


        [SecuredOperation("admin")]
        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll(h => h.Status);
        }

        public Employee GetById(int employeeId)
        {
            return _employeeDal.Get(h => h.Id == employeeId);
        }

        public EmployeeSummaryDto GetSummary(int employeeId)
        {
            var employee = _employeeDal.GetSummary(employeeId);
            var employeeSummaryDto = _mapper.Map<EmployeeSummaryDto>(employee);

            return employeeSummaryDto;
        }

        [ValidationAspect(typeof(EmployeeValidator))]
        [SecuredOperation("admin")]
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
            return _employeeDal.GetClaims(employee);
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public Employee GetByMail(string email)
        {

            return _employeeDal.Get(u => u.Email == email);
        }
    }
}
