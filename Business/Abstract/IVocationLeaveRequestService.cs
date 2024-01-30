using Core;
using Core.Entities;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
