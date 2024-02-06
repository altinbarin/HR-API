using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RequestApprovalStatusManager:IRequestApprovalStatusService
    {
       readonly IRequestApprovalStatusDal _requestApprovalStatusDal;
        

        public RequestApprovalStatusManager(IRequestApprovalStatusDal requestApprovalStatusDal)
        {
            _requestApprovalStatusDal = requestApprovalStatusDal;
        }

        public IDataResult<List<RequestApprovalStatus>> GetAll()
        {
            var result = _requestApprovalStatusDal.GetAll();
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<RequestApprovalStatus>>(result);
            }
            return new ErrorDataResult<List<RequestApprovalStatus>>("Approval status not found");
        }
    }
}
