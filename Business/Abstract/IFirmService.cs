using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IFirmService
    {
        public IDataResult<List<Firm>> GetAll();

        public IResult AddFirm(FirmAddDto dto);

        public IResult UpdateFirm(FirmUpdateDto dto);
    }
}
