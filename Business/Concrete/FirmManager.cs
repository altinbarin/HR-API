using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Business.Concrete
{
    public class FirmManager : IFirmService
    {
        readonly IFirmDal _firmDal;
        readonly IMapper _mapper;

        public FirmManager(IFirmDal firmDal, IMapper mapper)
        {
            _firmDal = firmDal;
            _mapper = mapper;
        }


        [ValidationAspect(typeof(FirmAddDtoValidator))]
        public IResult AddFirm(FirmAddDto dto)
        {
            var firm = _mapper.Map<Firm>(dto);
            if(firm == null)
            {
                return new ErrorResult(Messages.FirmCanNotAdded);
            }
            _firmDal.Add(firm);

            return new SuccessResult(Messages.FirmAdded);
        }

        public IDataResult<List<Firm>> GetAll()
        {
            var result = _firmDal.GetAll();
            if(result.Count == 0)
            {
                return new ErrorDataResult<List<Firm>>(result, "Firmalar bulunamadı.");
            }
            result.Sort((x, y) => x.Name.CompareTo(y.Name));
            return new SuccessDataResult<List<Firm>>(result);
        }

        public IResult UpdateFirm(FirmUpdateDto dto)
        {
            var result = _firmDal.Get(f => f.Id == dto.Id);
            if(result == null)
            {
                return new ErrorResult(Messages.FirmCanNotUpdated);
            }
            result.IsActive = dto.IsActive;
            _firmDal.Update(result);
            return new SuccessResult(Messages.FirmUpdated);
        }
    }
}
