﻿using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IAdvanceRequestDal: IEntityRepository<AdvanceRequest>
    {
        List<AdvanceRequestDto> GetAllAdvanceRequests();

        IResult UpdateApprovalStatusByName(AdvanceRequestUpdateDto dto);

        IResult AddAdvanceRequest(AdvanceRequestAddDto dto, int employeeId);
    }
}