using AutoMapper;
using Domain.Dto;
using Domain.Interfaces.Proxy;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiProxy _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilApiProxy brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<EnderecoResponse> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
            var result = _mapper.Map<EnderecoResponse>(endereco);
            return result;
        }
    }
}
