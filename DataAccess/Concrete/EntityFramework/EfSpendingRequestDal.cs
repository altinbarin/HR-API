using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSpendingRequestDal : EfEntityRepositoryBase<SpendingRequest, HrDbContext>, ISpendingRequestDal
    {
        public IResult AddSpendingRequest(SpendingRequestAddDto dto, int employeeId)
        {
            using (HrDbContext context = new HrDbContext())
            {
                var spendingRequest = new SpendingRequest
                {
                    EmployeeId = employeeId,
                    Name = dto.Name,
                    Price = dto.Price,
                    Currency = dto.Currency,
                    RequestApprovalStatusId = context.RequestApprovalStatuses.Where(x => x.Name == "Pending").Select(x => x.Id).FirstOrDefault(),
                    Folder = dto.Folder
                };

                var result = context.Add(spendingRequest);
                context.SaveChanges();
                return new SuccessResult();
            }
        }


        public List<SpendingRequestDto> GetAllSpendingRequests()
        {
            using (HrDbContext context = new HrDbContext())
            {
                var spendingRequestDto = from spendingRequests in context.SpendingRequests
                                         join employees in context.Employees on spendingRequests.EmployeeId equals employees.Id
                                         join requestApprovalStatus in context.RequestApprovalStatuses on spendingRequests.RequestApprovalStatusId equals requestApprovalStatus.Id
                                         select new
                                         SpendingRequestDto
                                         {
                                             Id = spendingRequests.Id,
                                             Name = spendingRequests.Name,
                                             Price = spendingRequests.Price,
                                             Currency = spendingRequests.Currency,
                                             EmployeeId = spendingRequests.EmployeeId,
                                             EmployeeName = employees.FirstName,
                                             EmployeeSurname = employees.LastName,
                                             RequestApprovalStatusName = requestApprovalStatus.Name,
                                             RequestDate = spendingRequests.RequestDate,
                                             ResponseDate = spendingRequests.ResponseDate,
                                             Folder = spendingRequests.Folder
                                         };

                return spendingRequestDto.ToList();

            }
        }

        public IResult UpdateApprovalStatusByName(SpendingRequestUpdateDto dto)
        {
            using (HrDbContext context = new HrDbContext())
            {
                var request = context.SpendingRequests.Where(x => x.Id == dto.Id).FirstOrDefault();

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
