using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, HrDbContext>, IEmployeeDal
    {
        public Employee GetSummary(int employeeId)
        {
            using (HrDbContext context = new HrDbContext())
            {
                var summary = context.Employees.Where(h => h.Id == employeeId)
                     .Select(h => new Employee
                     {
                         FirstName = h.FirstName,
                         LastName = h.LastName,
                         ImageData = h.ImageData,
                         PhoneNumber = h.PhoneNumber,
                         Address = h.Address,
                         Profession = h.Profession,
                         Department = h.Department,
                     }).FirstOrDefault();

                return summary;

            }
        }

        public List<OperationClaim> GetClaims(Employee employee)
        {
            using (var context = new HrDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.EmployeeId == employee.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();


            }
        }

    }
}
