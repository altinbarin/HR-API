using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IVocationLeaveRequestService
    {
        public IDataResult<List<VocationLeaveRequestDto>> GetAllVocationRequests();



        public IResult AddVocationRequest(VocationLeaveRequestAddDto dto, int employeeId);

        public IDataResult<List<VocationLeaveRequestAddDto>> GetVocationAddForm();

        public IResult UpdateApprovalStatusByName(VocationLeaveRequestUpdateDto dto);

        public IDataResult<List<VocationLeaveRequestDto>> GetVocationRequestsByEmployeeId(int employeeId);
    }





}
