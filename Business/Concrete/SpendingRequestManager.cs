using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Business.Concrete
{
    public class SpendingRequestManager : ISpendingRequestService
    {
        readonly ISpendingRequestDal _spendingRequestDal;

        public SpendingRequestManager(ISpendingRequestDal spendingRequestDal)
        {
            _spendingRequestDal = spendingRequestDal;
        }

        [ValidationAspect(typeof(SpendingRequestAddDtoValidator))]
        public IResult AddSpendingRequest(SpendingRequestAddDto dto, int employeeId)
        {
            var result = _spendingRequestDal.AddSpendingRequest(dto, employeeId);

            if (result.Success)
            {
                return new SuccessResult(Messages.SpendingRequestAdded);
            }
            return new ErrorResult(Messages.SpendingRequestNotAdded);
        }

        public IDataResult<List<SpendingRequestDto>> GetAllSpendingRequests()
        {
            var result = _spendingRequestDal.GetAllSpendingRequests();
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<SpendingRequestDto>>(result);
            }
            return new ErrorDataResult<List<SpendingRequestDto>>(Messages.SpendingRequestNotFound);
        }

        

        public IResult UpdateApprovalStatusByName(SpendingRequestUpdateDto dto)
        {
            var result = _spendingRequestDal.UpdateApprovalStatusByName(dto);
            if (result.Success)
            {
                return new SuccessResult(Messages.SpendingRequestUpdated);
            }
            return new ErrorResult(Messages.SpendingRequestNotUpdated);
        }
    }
}
