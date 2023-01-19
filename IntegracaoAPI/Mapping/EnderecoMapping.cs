using AutoMapper;
using Domain.Dto;
using Domain.Models;

namespace API.Mapping
{
    public class EnderecoMapping: Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();

        }
    }
}
