using Domain.Dto;
using Domain.Interfaces.Proxy;
using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.Proxy
{
    public class BrasilApiProxy : IBrasilApiProxy
    {
        public async Task<EnderecoModel> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            using (var client = new HttpClient())
            {           
                try
                {
                    var responseBrasilApi = await client.SendAsync(request);//Pegando dados da API
                    var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<EnderecoModel>(contentResp) ?? new EnderecoModel();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
                
            }
        }

        public Task<List<BancoModel>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
        public Task<BancoModel> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

    }
}
