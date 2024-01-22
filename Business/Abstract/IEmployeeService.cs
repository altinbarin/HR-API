using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        public IResult Update(Employee employee);

        Employee GetById(int employeeId);

        EmployeeSummaryDto GetSummary(int employeeId);


        List<OperationClaim> GetClaims(Employee employee);
        void Add(Employee employee);
        Employee GetByMail(string email);
    }
}
