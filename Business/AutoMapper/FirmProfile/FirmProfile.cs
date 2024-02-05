using AutoMapper;
using Core.Entities.Concrete;
using Entities.DTOs;

namespace Business.AutoMapper.FirmProfile
{
    public class FirmProfile:Profile
    {
        public FirmProfile()
        {
            CreateMap<Firm, FirmAddDto>().ReverseMap();
           
        }
    }
}
