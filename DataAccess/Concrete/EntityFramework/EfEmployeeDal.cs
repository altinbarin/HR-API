using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public Employee GetEmployee(Func<Employee, bool> filter)
        {
            using (var context = new HrDbContext())
            {
                var employee = context.Employees.Where(filter)
                    .Select(h => new Employee
                    {
                        FirstName = h.FirstName,
                        TurkishIdentificationNumber = h.TurkishIdentificationNumber,
                        MiddleName = h.MiddleName,
                        LastName = h.LastName,
                        Email = h.Email,
                        SecondLastname = h.SecondLastname,
                        DateOfBirth = h.DateOfBirth,
                        DateOfEmployment = h.DateOfEmployment,
                        DateOfDismissal = h.DateOfDismissal,
                        BirthLocation = h.BirthLocation,
                        Company = h.Company,
                        Position = h.Position,
                        City = h.City,
                        Salary = h.Salary,
                        ImageData = h.ImageData,
                        PhoneNumber = h.PhoneNumber,
                        Address = h.Address,
                        Profession = h.Profession,
                        Department = h.Department,
                        Status = h.Status,
                    }).FirstOrDefault();


                return employee;
            }
        }

        public void AddUserOperationClaim(UserOperationClaim userOperationClaim)
        {
            using (var context = new HrDbContext())
            { 
                context.UserOperationClaims.Add(userOperationClaim);
                context.SaveChanges();
            }
        }
    }
}
