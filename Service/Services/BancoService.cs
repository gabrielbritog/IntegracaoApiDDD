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
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiProxy _brasilApi;
        public BancoService(IMapper mapper, IBrasilApiProxy brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<BancoResponse> BuscarBanco(string cod)
        {
            var banco = await _brasilApi.BuscarBanco(cod);
            var result = _mapper.Map<BancoResponse>(banco);           
            return result;
        }
    }
}
