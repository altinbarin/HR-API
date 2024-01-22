using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRule
{
    public interface IEmployeeRules
    {
        public IResult CheckIfPhoneNumberExist(string phoneNumber);
    }
}
