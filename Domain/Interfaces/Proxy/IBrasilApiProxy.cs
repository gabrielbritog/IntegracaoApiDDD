using Domain.Dto;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Proxy
{
    public interface IBrasilApiProxy
    {
        Task<EnderecoModel> BuscarEnderecoPorCep(string cep);
        Task<List<BancoModel>> BuscarTodosBancos();
        Task<BancoModel> BuscarBanco(string codigoBanco);
    }
}
