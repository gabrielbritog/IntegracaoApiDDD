using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EnderecoModel
    {
        [JsonProperty(PropertyName = "cep")]
        public string? Cep;

        [JsonProperty(PropertyName = "state")]
        public string? Estado;

        [JsonProperty(PropertyName = "city")]
        public string? Cidade;

        [JsonProperty(PropertyName = "neighborhood")]
        public string? Regiao;

        [JsonProperty(PropertyName = "street")]
        public string? Rua;

        [JsonProperty(PropertyName = "service")]
        public string? Servico;
    }
}
