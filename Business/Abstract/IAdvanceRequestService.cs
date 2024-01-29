using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdvanceRequestService
    {
        public IDataResult<List<AdvanceRequestDto>> GetAllAdvanceRequests();

        public IResult UpdateApprovalStatusByName(AdvanceRequestUpdateDto dto);

        public IResult AddAdvanceRequest(AdvanceRequestAddDto dto, int employeeId);
    }
}
