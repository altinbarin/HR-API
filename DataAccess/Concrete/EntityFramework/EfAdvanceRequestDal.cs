using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdvanceRequestDal : EfEntityRepositoryBase<AdvanceRequest, HrDbContext>, IAdvanceRequestDal
    {
        public IResult AddAdvanceRequest(AdvanceRequestAddDto dto, int employeeId)
        {
            using (HrDbContext context = new HrDbContext())
            { 
                var advanceRequest = new AdvanceRequest
                {
                    EmployeeId = employeeId,
                    Description = dto.Description,
                    Price = dto.Price,
                    Currency = dto.Currency,
                    RequestApprovalStatusId = context.RequestApprovalStatuses.Where(x => x.Name == "Pending").Select(x => x.Id).FirstOrDefault(),
                    Type = dto.Type,
                };

                var result = context.Add(advanceRequest);
                context.SaveChanges();
                return new SuccessResult();
            }
        }

        public List<AdvanceRequestDto> GetAllAdvanceRequests()
        {
            using (HrDbContext context = new HrDbContext())
            {
                var advanceRequestDto = from advanceRequest in context.AdvanceRequests
                                        join employees in context.Employees on advanceRequest.EmployeeId equals employees.Id
                                        join requestApprovalStatus in context.RequestApprovalStatuses on advanceRequest.RequestApprovalStatusId equals requestApprovalStatus.Id
                                        select new AdvanceRequestDto
                                        {
                                            Id = advanceRequest.Id,
                                            Currency = advanceRequest.Currency,
                                            EmployeeName = employees.FirstName,
                                            EmployeeSurname = employees.LastName,
                                            Description = advanceRequest.Description,
                                            Price = advanceRequest.Price,
                                            RequestApprovalStatusName = requestApprovalStatus.Name,
                                            RequestDate = advanceRequest.RequestDate
                                        };

                return advanceRequestDto.ToList();
            }
        }

        public IResult UpdateApprovalStatusByName(AdvanceRequestUpdateDto dto)
        {
            using (HrDbContext context = new HrDbContext())
            {
                var advanceRequest = context.AdvanceRequests.Where(x => x.Id == dto.Id).FirstOrDefault();

                if (advanceRequest != null)
                {
                    advanceRequest.RequestApprovalStatusId = context.RequestApprovalStatuses.Where(x => x.Name == dto.RequestApprovalStatusName).Select(x => x.Id).FirstOrDefault();
                    advanceRequest.ResponseDate = DateTime.Now;
                    context.SaveChanges();
                    return new SuccessResult();
                }
                return new ErrorResult();

            }
        }
    }
}
