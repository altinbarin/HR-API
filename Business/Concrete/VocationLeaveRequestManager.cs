﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VocationLeaveRequestManager : IVocationLeaveRequestService
    {
        readonly IVocationRequestDal _vocationRequestDal;

        public VocationLeaveRequestManager(IVocationRequestDal vocationLeaveRequestDal)
        {
            _vocationRequestDal = vocationLeaveRequestDal;
        }

        [ValidationAspect(typeof(VocationLeaveRequestAddDtoValidator))]
        public IResult AddVocationRequest(VocationLeaveRequestAddDto dto, int employeeId)
        {
            var result = _vocationRequestDal.AddVocationRequest(dto, employeeId);

            if(result.Success)
            {
                return new SuccessResult(Messages.VocationLeaveRequestAdded);
            }

            return new ErrorResult(Messages.VocationLeaveRequestNotAdded);
        }

        public IDataResult<List<VocationLeaveRequestDto>> GetAllVocationRequests()
        {
            var vocationRequests = _vocationRequestDal.GetAllVocationRequests();

            if (vocationRequests.Count > 0)
            {
                return new SuccessDataResult<List<VocationLeaveRequestDto>>(vocationRequests);
            }
            return new ErrorDataResult<List<VocationLeaveRequestDto>>(Messages.VocationLeaveRequestNotFound);

        }

        public IDataResult<List<VocationLeaveRequestAddDto>> GetVocationAddForm()
        {
            var result = _vocationRequestDal.GetVocationAddForm();
            if (result.Success)
            {
                   return new SuccessDataResult<List<VocationLeaveRequestAddDto>>(result.Data);
            }
            return new ErrorDataResult<List<VocationLeaveRequestAddDto>>(Messages.VocationLeaveRequestNotFound);
        }

        public IResult UpdateApprovalStatusByName(VocationLeaveRequestUpdateDto dto)
        {
            var result = _vocationRequestDal.UpdateApprovalStatusByName(dto);
            if (result.Success)
            {
                return new SuccessResult(Messages.VocationLeaveRequestUpdated);
            }
            return new ErrorResult(Messages.VocationLeaveRequestNotUpdated);
        }
    }
}