using Core.Entities.Concrete;
using Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Employee employee, List<OperationClaim> operationClaims);
    }
}
