using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRule
{
    public class EmployeeRules : IEmployeeRules
    {
        readonly IEmployeeDal _employeetDal;

        public EmployeeRules(IEmployeeDal employeetDal)
        {
            _employeetDal = employeetDal;
        }

        public IResult CheckIfPhoneNumberExist(string phoneNumber)
        {
            var result = _employeetDal.GetAll(h => h.PhoneNumber == phoneNumber).Any();
            if (result)
            {
                return new ErrorResult(Messages.PhoneNumberAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
