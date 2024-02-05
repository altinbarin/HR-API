using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal: IEntityRepository<Employee>
    {
        Employee GetSummary(int employeeId);

        List<OperationClaim> GetClaims(Employee employee);

        Employee GetEmployee(Func<Employee, bool> filter);

        void AddUserOperationClaim(UserOperationClaim userOperationClaim);

    }
}
