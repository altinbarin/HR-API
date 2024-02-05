using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IVocationRequestDal: IEntityRepository<VocationLeaveRequest>
    {
       List<VocationLeaveRequestDto> GetAllVocationRequests();

        IResult AddVocationRequest(VocationLeaveRequestAddDto dto, int employeeId);

        public IDataResult<List<VocationLeaveRequestAddDto>> GetVocationAddForm();

        public IResult UpdateApprovalStatusByName(VocationLeaveRequestUpdateDto dto);

        //public List<VocationLeaveRequestDto> GetVocationRequestsByEmployee(int employeeId);
    }
}
