using AutoMapper;
using Domain.Dto;
using Domain.Models;

namespace Service.Mapping
{
    public class EnderecoMapping: Profile
    {
        public EnderecoMapping()
        {
            CreateMap<EnderecoResponse, EnderecoModel>().ReverseMap();

        }
    }
}
