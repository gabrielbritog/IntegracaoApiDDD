using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Dto
{
    public class EnderecoResponse
    {
        public string? Cep;
        public string? Estado;
        public string? Cidade;
        public string? Regiao;
        public string? Rua;
        [JsonIgnore]
        public string? Servico;
    }
}
