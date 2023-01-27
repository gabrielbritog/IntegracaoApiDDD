using AutoMapper;
using Domain.Dto;
using Domain.Models;

namespace Service.Mapping
{
    public class BancoMapping: Profile
    {
        public BancoMapping()
        {
            CreateMap<BancoResponse, BancoModel>().ReverseMap();

        }
    }
}
