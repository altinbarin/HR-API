using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISpendingRequestService
    {
        public IDataResult<List<SpendingRequestDto>>GetAllSpendingRequests();

        public IResult UpdateApprovalStatusByName(SpendingRequestUpdateDto dto);

        public IResult AddSpendingRequest(SpendingRequestAddDto dto, int employeeId);

        IDataResult<List<SpendingRequestDto>> GetSpendingRequestsByEmployeeId(int employeeId);

    }
}
