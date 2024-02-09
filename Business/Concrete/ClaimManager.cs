using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ClaimManager : IClaimService
    {
        private IUserOperationClaimDal _userOperationClaimDal;
        private IEmployeeService _employeeService;
        private IOperationClaimDal _operationClaimDal;


        public ClaimManager(IUserOperationClaimDal claimDal, IEmployeeService employeeService, IOperationClaimDal operationClaimDal)
        {
            _userOperationClaimDal = claimDal;
            _employeeService = employeeService;
            _operationClaimDal = operationClaimDal;
        }

        public IResult ChangeClaim(string email, string claim)
        {
            var user = _employeeService.GetByMail(email);

            if (user == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }

           var userOperationClaim = _userOperationClaimDal.Get(_claimDal => _claimDal.EmployeeId == user.Id);

            var userOperationClaimId = _operationClaimDal.Get(_operationClaimDal => _operationClaimDal.Name == "user").Id;

            var emptyOperationClaim = _operationClaimDal.Get(_operationClaimDal => _operationClaimDal.Name == "empty").Id;

            if(userOperationClaim.OperationClaimId == emptyOperationClaim)
            {
                userOperationClaim.OperationClaimId = userOperationClaimId;
                _userOperationClaimDal.Update(userOperationClaim);
                return new SuccessResult(Messages.SuccessfulLogin);
            }
                return new SuccessResult(Messages.SuccessfulLogin);


           
        }
    }
}
