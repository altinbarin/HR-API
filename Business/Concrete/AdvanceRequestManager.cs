using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdvanceRequestManager : IAdvanceRequestService
    {
        readonly IAdvanceRequestDal _advanceRequestDal;
        readonly IEmployeeService _employeeService;

        public AdvanceRequestManager(IAdvanceRequestDal advanceRequestDal, IEmployeeService employeeService)
        {
            _advanceRequestDal = advanceRequestDal;
            _employeeService = employeeService;
        }


        [ValidationAspect(typeof(AdvanceRequestAddDtoValidator))]
        public IResult AddAdvanceRequest(AdvanceRequestAddDto dto, int employeeId)
        {
            var employee = _employeeService.GetById(employeeId);

            if (dto.Price>(employee.Salary*3))
            {
                return new ErrorResult(Messages.PriceCanNotBeMoreThanSalarysThirdTimes);
            }

            var result = _advanceRequestDal.AddAdvanceRequest(dto, employeeId);

            if (result.Success)
            {
                return new SuccessResult(Messages.AdvanceRequestAdded);
            }
            return new ErrorResult(Messages.AdvanceRequestNotAdded);
        }

        public IDataResult<List<AdvanceRequestDto>> GetAllAdvanceRequests()
        {
            var result = _advanceRequestDal.GetAllAdvanceRequests();
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<AdvanceRequestDto>>(result);
            }
            return new ErrorDataResult<List<AdvanceRequestDto>>(Messages.AdvanceRequestNotFound);
        }

        public IResult UpdateApprovalStatusByName(AdvanceRequestUpdateDto dto)
        {
            var result = _advanceRequestDal.UpdateApprovalStatusByName(dto);

            if (result.Success)
            {
                return new SuccessResult(Messages.AdvanceRequestUpdated);
            }
            return new ErrorResult(Messages.AdvanceRequestNotUpdated);
        }
    }
}
