using Core;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfVocationRequestDal : EfEntityRepositoryBase<VocationLeaveRequest, HrDbContext>, IVocationRequestDal
    {
        public IResult AddVocationRequest(VocationLeaveRequestAddDto dto, int employeeId)
        {
            using (HrDbContext context = new HrDbContext())
            {
                var vocationLeaveTypeId = context.VocationLeaveTypes.Where(x => x.Name == dto.VocationLeaveTypeName).Select(x => x.Id).FirstOrDefault();

                var vocationRequest = from vocationLeaveRequest in context.VocationLeaveRequests
                                      join vocationLeaveType in context.VocationLeaveTypes
                                      on vocationLeaveRequest.VocationLeaveTypeId equals vocationLeaveType.Id
                                      join requestApprovalStatus in context.RequestApprovalStatuses on vocationLeaveRequest.RequestApprovalStatusId equals requestApprovalStatus.Id
                                      join employee in context.Employees on vocationLeaveRequest.EmployeeId equals employee.Id
                                      select new VocationLeaveRequest
                                      {
                                          EmployeeId = employeeId,
                                          VocationLeaveTypeId = vocationLeaveTypeId,
                                          RequestApprovalStatusId = requestApprovalStatus.Id,
                                          StartingDate = dto.StartingDate,
                                          EndingDate = dto.StartingDate.AddDays(vocationLeaveType.Day),

                                      };

                var request = vocationRequest.FirstOrDefault();
                if (request == null)
                {
                    return new ErrorResult();
                }
                var result = context.Add(request);
                context.SaveChanges();
                return new SuccessResult();
            }
        }

        public List<VocationLeaveRequestDto> GetAllVocationRequests()
        {
            using (HrDbContext context = new HrDbContext())
            {
                var vocationRequests = from vocationLeaveRequest in context.VocationLeaveRequests
                                       join vocationLeaveType in context.VocationLeaveTypes on vocationLeaveRequest.VocationLeaveTypeId equals vocationLeaveType.Id
                                       join requestApprovalStatus in context.RequestApprovalStatuses on vocationLeaveRequest.RequestApprovalStatusId equals requestApprovalStatus.Id
                                       join employee in context.Employees on vocationLeaveRequest.EmployeeId equals employee.Id
                                       select new VocationLeaveRequestDto
                                       {
                                           Id = vocationLeaveRequest.Id,
                                           EmployeeId = employee.Id,
                                           EmployeeName = employee.FirstName,
                                           EmployeeSurname = employee.LastName,
                                           VocationLeaveTypeName = vocationLeaveType.Name,
                                           RequestApprovalStatusName = requestApprovalStatus.Name,
                                           StartingDate = vocationLeaveRequest.StartingDate,
                                           EndingDate = vocationLeaveRequest.EndingDate,
                                           ResponseDate = vocationLeaveRequest.ResponseDate
                                       };

                return vocationRequests.ToList();
            }
        }

        //public List<VocationLeaveRequestDto> GetVocationRequestsByEmployee(int employeeId)
        //{
        //    using (HrDbContext context = new HrDbContext())
        //    {
        //        var vocationRequests = from vocationLeaveRequest in context.VocationLeaveRequests
        //                               join vocationLeaveType in context.VocationLeaveTypes on vocationLeaveRequest.VocationLeaveTypeId equals vocationLeaveType.Id
        //                               join requestApprovalStatus in context.RequestApprovalStatuses on vocationLeaveRequest.RequestApprovalStatusId equals requestApprovalStatus.Id
        //                               join employee in context.Employees on vocationLeaveRequest.EmployeeId equals employee.Id
        //                               select new VocationLeaveRequestDto
        //                               {
        //                                   Id = vocationLeaveRequest.Id,
        //                                   EmployeeId = employeeId,
        //                                   EmployeeName = employee.FirstName,
        //                                   EmployeeSurname = employee.LastName,
        //                                   VocationLeaveTypeName = vocationLeaveType.Name,
        //                                   RequestApprovalStatusName = requestApprovalStatus.Name,
        //                                   StartingDate = vocationLeaveRequest.StartingDate,
        //                                   EndingDate = vocationLeaveRequest.EndingDate,
        //                                   ResponseDate = vocationLeaveRequest.ResponseDate
        //                               };


        //        var employesVocationRequests = vocationRequests.Where(x => x.EmployeeId == employeeId);
        //        return employesVocationRequests.ToList();
        //    }
        //}


        public IDataResult<List<VocationLeaveRequestAddDto>> GetVocationAddForm()
        {
            using (HrDbContext context = new HrDbContext())
            {
                var result = from vocationLeaveType in context.VocationLeaveTypes
                             select new VocationLeaveRequestAddDto
                             {
                                 VocationLeaveTypeName = vocationLeaveType.Name,
                                 Day = vocationLeaveType.Day
                             };

                var resultList = result.ToList();

                return new SuccessDataResult<List<VocationLeaveRequestAddDto>>(resultList);
            }
        }

       

        public IResult UpdateApprovalStatusByName(VocationLeaveRequestUpdateDto dto)
        {
            using (HrDbContext context = new HrDbContext())
            {
                var request = context.VocationLeaveRequests.Where(x => x.Id == dto.Id).FirstOrDefault();

                if (request != null)
                {

                    request.RequestApprovalStatusId = context.RequestApprovalStatuses.Where(x => x.Name == dto.RequestApprovalStatusName).Select(x => x.Id).FirstOrDefault();
                    request.ResponseDate = DateTime.Now;
                    context.SaveChanges();

                    return new SuccessResult();
                }
                return new ErrorResult();
            }
        }
    }
}
