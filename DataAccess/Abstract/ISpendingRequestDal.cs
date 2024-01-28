using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISpendingRequestDal: IEntityRepository<SpendingRequest>
    {
        List<SpendingRequestDto> GetAllSpendingRequests();

        IResult UpdateApprovalStatusByName(SpendingRequestUpdateDto dto);

        IResult AddSpendingRequest(SpendingRequestAddDto dto, int employeeId);
    }
}
